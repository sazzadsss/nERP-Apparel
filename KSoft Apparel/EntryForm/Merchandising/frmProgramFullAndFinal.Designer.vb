<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgramFullAndFinal
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
        Dim StyleIdLabel As System.Windows.Forms.Label
        Dim ProgramNoLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim OrderReceiveDateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProgramFullAndFinal))
        Me.ProgramFullAndFinalDataSet = New KSoft_Apparel.ProgramFullAndFinalDataSet()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderTableAdapter = New KSoft_Apparel.ProgramFullAndFinalDataSetTableAdapters.OrderTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.ProgramFullAndFinalDataSetTableAdapters.TableAdapterManager()
        Me.OrderDetailsTableAdapter = New KSoft_Apparel.ProgramFullAndFinalDataSetTableAdapters.OrderDetailsTableAdapter()
        Me.OrderBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.OrderBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.StyleIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.StyleIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.StyleLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleLookupDataSet = New KSoft_Apparel.StyleLookupDataSet()
        Me.IsCompleteCheckBox = New System.Windows.Forms.CheckBox()
        Me.IsAccBOMCompleteCheckBox = New System.Windows.Forms.CheckBox()
        Me.IsFabricBOMCompleteCheckBox = New System.Windows.Forms.CheckBox()
        Me.DiscontinueCheckBox = New System.Windows.Forms.CheckBox()
        Me.OrderDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricColorId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FabricColorGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.FabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricColorDataSet = New KSoft_Apparel.FabricColorDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsClose = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscontinue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCasuseOfDiscontinue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipmentQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsCuttingComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsSewingComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsFinishingComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInspectionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInspectionStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscountOrClaimAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClosedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ClosedOnDateEdit = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colHoldOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsHold = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCancelledOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProgramNoTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.StyleLookupTableAdapter = New KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleLookupTableAdapter()
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FabricColorTableAdapter = New KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter()
        Me.IsRunningCheckBox = New System.Windows.Forms.CheckBox()
        Me.FullCompleteDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.VGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.OrderAndProductionDateStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderAndProductionStatusDataSet = New KSoft_Apparel.OrderAndProductionStatusDataSet()
        Me.OrderInfocategory = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowBuyerName = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowProgramNo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowStyleName = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowOrderReceiveDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFirstEx = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowLastEx = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.BookingInfocategory = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowFabricBookingDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowYarnBookingDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowYarnRequisitionDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowAccessoriesBookingDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.SampleInfocategory = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowSampleSendDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCommentsReceiveDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.FabProdInfocategory = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowKnittingProductioinStartDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKnittingProductionEndDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDyeingProductionStartDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDyeingProductionEndDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.GMTProdInfocategory = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowCuttingStartDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCuttingEndDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSewingStartDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSewingEndDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFinishingStartDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFinishingEndDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFullCompleteDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowProgramFullCancelledOn = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.OrderAndProductionDateStatusTableAdapter = New KSoft_Apparel.OrderAndProductionStatusDataSetTableAdapters.OrderAndProductionDateStatusTableAdapter()
        Me.TableAdapterManager1 = New KSoft_Apparel.OrderAndProductionStatusDataSetTableAdapters.TableAdapterManager()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.OrderReceiveDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.CancelledOnDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.HoldOnDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.HoldCheckBox = New System.Windows.Forms.CheckBox()
        StyleIdLabel = New System.Windows.Forms.Label()
        ProgramNoLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        OrderReceiveDateLabel = New System.Windows.Forms.Label()
        CType(Me.ProgramFullAndFinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OrderBindingNavigator.SuspendLayout()
        CType(Me.StyleIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClosedOnDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClosedOnDateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FullCompleteDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FullCompleteDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderAndProductionDateStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderAndProductionStatusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderReceiveDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderReceiveDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancelledOnDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancelledOnDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoldOnDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoldOnDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleIdLabel
        '
        StyleIdLabel.AutoSize = True
        StyleIdLabel.Location = New System.Drawing.Point(17, 71)
        StyleIdLabel.Name = "StyleIdLabel"
        StyleIdLabel.Size = New System.Drawing.Size(33, 13)
        StyleIdLabel.TabIndex = 4
        StyleIdLabel.Text = "Style:"
        '
        'ProgramNoLabel
        '
        ProgramNoLabel.AutoSize = True
        ProgramNoLabel.Location = New System.Drawing.Point(17, 45)
        ProgramNoLabel.Name = "ProgramNoLabel"
        ProgramNoLabel.Size = New System.Drawing.Size(66, 13)
        ProgramNoLabel.TabIndex = 2
        ProgramNoLabel.Text = "Program No:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(17, 101)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(52, 13)
        Label2.TabIndex = 4
        Label2.Text = "Remarks:"
        '
        'OrderReceiveDateLabel
        '
        OrderReceiveDateLabel.AutoSize = True
        OrderReceiveDateLabel.Location = New System.Drawing.Point(374, 67)
        OrderReceiveDateLabel.Name = "OrderReceiveDateLabel"
        OrderReceiveDateLabel.Size = New System.Drawing.Size(105, 13)
        OrderReceiveDateLabel.TabIndex = 42
        OrderReceiveDateLabel.Text = "Order Receive Date:"
        '
        'ProgramFullAndFinalDataSet
        '
        Me.ProgramFullAndFinalDataSet.DataSetName = "ProgramFullAndFinalDataSet"
        Me.ProgramFullAndFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "Order"
        Me.OrderBindingSource.DataSource = Me.ProgramFullAndFinalDataSet
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.OrderDetailsTableAdapter = Me.OrderDetailsTableAdapter
        Me.TableAdapterManager.OrderTableAdapter = Me.OrderTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.ProgramFullAndFinalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OrderDetailsTableAdapter
        '
        Me.OrderDetailsTableAdapter.ClearBeforeFill = True
        '
        'OrderBindingNavigator
        '
        Me.OrderBindingNavigator.AddNewItem = Nothing
        Me.OrderBindingNavigator.BindingSource = Me.OrderBindingSource
        Me.OrderBindingNavigator.CountItem = Nothing
        Me.OrderBindingNavigator.DeleteItem = Nothing
        Me.OrderBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderBindingNavigatorSaveItem})
        Me.OrderBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OrderBindingNavigator.MoveFirstItem = Nothing
        Me.OrderBindingNavigator.MoveLastItem = Nothing
        Me.OrderBindingNavigator.MoveNextItem = Nothing
        Me.OrderBindingNavigator.MovePreviousItem = Nothing
        Me.OrderBindingNavigator.Name = "OrderBindingNavigator"
        Me.OrderBindingNavigator.PositionItem = Nothing
        Me.OrderBindingNavigator.Size = New System.Drawing.Size(1219, 25)
        Me.OrderBindingNavigator.TabIndex = 0
        Me.OrderBindingNavigator.Text = "BindingNavigator1"
        '
        'OrderBindingNavigatorSaveItem
        '
        Me.OrderBindingNavigatorSaveItem.Image = CType(resources.GetObject("OrderBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OrderBindingNavigatorSaveItem.Name = "OrderBindingNavigatorSaveItem"
        Me.OrderBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.OrderBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StyleIdGridLookUpEditView
        '
        Me.StyleIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.StyleIdGridLookUpEditView.Name = "StyleIdGridLookUpEditView"
        Me.StyleIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.StyleIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'StyleIdGridLookUpEdit
        '
        Me.StyleIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "StyleId", True))
        Me.StyleIdGridLookUpEdit.Location = New System.Drawing.Point(89, 68)
        Me.StyleIdGridLookUpEdit.Name = "StyleIdGridLookUpEdit"
        Me.StyleIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StyleIdGridLookUpEdit.Properties.DataSource = Me.StyleLookupBindingSource
        Me.StyleIdGridLookUpEdit.Properties.DisplayMember = "StyleName"
        Me.StyleIdGridLookUpEdit.Properties.NullText = ""
        Me.StyleIdGridLookUpEdit.Properties.PopupView = Me.StyleIdGridLookUpEditView
        Me.StyleIdGridLookUpEdit.Properties.ValueMember = "StyleId"
        Me.StyleIdGridLookUpEdit.Size = New System.Drawing.Size(139, 20)
        Me.StyleIdGridLookUpEdit.TabIndex = 5
        '
        'StyleLookupBindingSource
        '
        Me.StyleLookupBindingSource.DataMember = "StyleLookup"
        Me.StyleLookupBindingSource.DataSource = Me.StyleLookupDataSet
        '
        'StyleLookupDataSet
        '
        Me.StyleLookupDataSet.DataSetName = "StyleLookupDataSet"
        Me.StyleLookupDataSet.EnforceConstraints = False
        Me.StyleLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IsCompleteCheckBox
        '
        Me.IsCompleteCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.OrderBindingSource, "IsComplete", True))
        Me.IsCompleteCheckBox.Location = New System.Drawing.Point(595, 60)
        Me.IsCompleteCheckBox.Name = "IsCompleteCheckBox"
        Me.IsCompleteCheckBox.Size = New System.Drawing.Size(126, 24)
        Me.IsCompleteCheckBox.TabIndex = 9
        Me.IsCompleteCheckBox.Text = "Full Complete:"
        Me.IsCompleteCheckBox.UseVisualStyleBackColor = True
        '
        'IsAccBOMCompleteCheckBox
        '
        Me.IsAccBOMCompleteCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.OrderBindingSource, "IsAccBOMComplete", True))
        Me.IsAccBOMCompleteCheckBox.Location = New System.Drawing.Point(246, 38)
        Me.IsAccBOMCompleteCheckBox.Name = "IsAccBOMCompleteCheckBox"
        Me.IsAccBOMCompleteCheckBox.Size = New System.Drawing.Size(128, 24)
        Me.IsAccBOMCompleteCheckBox.TabIndex = 11
        Me.IsAccBOMCompleteCheckBox.Text = "Acc BOM Complete"
        Me.IsAccBOMCompleteCheckBox.UseVisualStyleBackColor = True
        '
        'IsFabricBOMCompleteCheckBox
        '
        Me.IsFabricBOMCompleteCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.OrderBindingSource, "IsFabricBOMComplete", True))
        Me.IsFabricBOMCompleteCheckBox.Location = New System.Drawing.Point(246, 62)
        Me.IsFabricBOMCompleteCheckBox.Name = "IsFabricBOMCompleteCheckBox"
        Me.IsFabricBOMCompleteCheckBox.Size = New System.Drawing.Size(128, 24)
        Me.IsFabricBOMCompleteCheckBox.TabIndex = 13
        Me.IsFabricBOMCompleteCheckBox.Text = "Fab BOM Complete"
        Me.IsFabricBOMCompleteCheckBox.UseVisualStyleBackColor = True
        '
        'DiscontinueCheckBox
        '
        Me.DiscontinueCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.OrderBindingSource, "Discontinue", True))
        Me.DiscontinueCheckBox.Location = New System.Drawing.Point(595, 32)
        Me.DiscontinueCheckBox.Name = "DiscontinueCheckBox"
        Me.DiscontinueCheckBox.Size = New System.Drawing.Size(147, 24)
        Me.DiscontinueCheckBox.TabIndex = 15
        Me.DiscontinueCheckBox.Text = "Full Discontinue/Cancel:"
        Me.DiscontinueCheckBox.UseVisualStyleBackColor = True
        '
        'OrderDetailsBindingSource
        '
        Me.OrderDetailsBindingSource.DataMember = "FK_OrderDetails_Order"
        Me.OrderDetailsBindingSource.DataSource = Me.OrderBindingSource
        '
        'OrderDetailsGridControl
        '
        Me.OrderDetailsGridControl.DataSource = Me.OrderDetailsBindingSource
        Me.OrderDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderDetailsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.OrderDetailsGridControl.MainView = Me.GridView1
        Me.OrderDetailsGridControl.Name = "OrderDetailsGridControl"
        Me.OrderDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.FabricColorGridLookUpEdit, Me.ClosedOnDateEdit})
        Me.OrderDetailsGridControl.Size = New System.Drawing.Size(848, 378)
        Me.OrderDetailsGridControl.TabIndex = 16
        Me.OrderDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPO, Me.colFabricColorId, Me.colEX, Me.colIsClose, Me.colDiscontinue, Me.colCasuseOfDiscontinue, Me.colOrderQuantity, Me.colShipmentQuantity, Me.colBalance, Me.colIsCuttingComplete, Me.colIsSewingComplete, Me.colIsFinishingComplete, Me.colInspectionDate, Me.colInspectionStatus, Me.colDiscountOrClaimAmount, Me.colClosedOn, Me.colHoldOn, Me.colIsHold, Me.colCancelledOn, Me.colRemarks})
        Me.GridView1.GridControl = Me.OrderDetailsGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colPO
        '
        Me.colPO.AppearanceCell.Options.UseTextOptions = True
        Me.colPO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPO.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPO.FieldName = "PO"
        Me.colPO.Name = "colPO"
        Me.colPO.OptionsColumn.AllowEdit = False
        Me.colPO.Visible = True
        Me.colPO.VisibleIndex = 0
        Me.colPO.Width = 110
        '
        'colFabricColorId
        '
        Me.colFabricColorId.AppearanceCell.Options.UseTextOptions = True
        Me.colFabricColorId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFabricColorId.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFabricColorId.Caption = "Fabric Color"
        Me.colFabricColorId.ColumnEdit = Me.FabricColorGridLookUpEdit
        Me.colFabricColorId.FieldName = "FabricColorId"
        Me.colFabricColorId.Name = "colFabricColorId"
        Me.colFabricColorId.OptionsColumn.AllowEdit = False
        Me.colFabricColorId.Visible = True
        Me.colFabricColorId.VisibleIndex = 1
        Me.colFabricColorId.Width = 146
        '
        'FabricColorGridLookUpEdit
        '
        Me.FabricColorGridLookUpEdit.AutoHeight = False
        Me.FabricColorGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FabricColorGridLookUpEdit.DataSource = Me.FabricColorBindingSource
        Me.FabricColorGridLookUpEdit.DisplayMember = "FabricColorName"
        Me.FabricColorGridLookUpEdit.Name = "FabricColorGridLookUpEdit"
        Me.FabricColorGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.FabricColorGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.FabricColorGridLookUpEdit.ValueMember = "FabricColorId"
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
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colEX
        '
        Me.colEX.AppearanceCell.Options.UseTextOptions = True
        Me.colEX.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEX.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEX.FieldName = "EX"
        Me.colEX.Name = "colEX"
        Me.colEX.OptionsColumn.AllowEdit = False
        Me.colEX.Visible = True
        Me.colEX.VisibleIndex = 2
        '
        'colIsClose
        '
        Me.colIsClose.AppearanceCell.Options.UseTextOptions = True
        Me.colIsClose.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsClose.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsClose.Caption = "PO Complete"
        Me.colIsClose.FieldName = "IsClose"
        Me.colIsClose.Name = "colIsClose"
        Me.colIsClose.Visible = True
        Me.colIsClose.VisibleIndex = 14
        '
        'colDiscontinue
        '
        Me.colDiscontinue.AppearanceCell.Options.UseTextOptions = True
        Me.colDiscontinue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDiscontinue.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDiscontinue.Caption = "Cancel"
        Me.colDiscontinue.FieldName = "Discontinue"
        Me.colDiscontinue.Name = "colDiscontinue"
        Me.colDiscontinue.Visible = True
        Me.colDiscontinue.VisibleIndex = 5
        '
        'colCasuseOfDiscontinue
        '
        Me.colCasuseOfDiscontinue.AppearanceCell.Options.UseTextOptions = True
        Me.colCasuseOfDiscontinue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCasuseOfDiscontinue.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCasuseOfDiscontinue.Caption = "Cause of Cancel"
        Me.colCasuseOfDiscontinue.FieldName = "CasuseOfDiscontinue"
        Me.colCasuseOfDiscontinue.Name = "colCasuseOfDiscontinue"
        Me.colCasuseOfDiscontinue.Visible = True
        Me.colCasuseOfDiscontinue.VisibleIndex = 7
        Me.colCasuseOfDiscontinue.Width = 146
        '
        'colOrderQuantity
        '
        Me.colOrderQuantity.AppearanceCell.Options.UseTextOptions = True
        Me.colOrderQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrderQuantity.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOrderQuantity.FieldName = "OrderQuantity"
        Me.colOrderQuantity.Name = "colOrderQuantity"
        Me.colOrderQuantity.OptionsColumn.AllowEdit = False
        Me.colOrderQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OrderQuantity", "{0:0.##}")})
        Me.colOrderQuantity.Visible = True
        Me.colOrderQuantity.VisibleIndex = 8
        Me.colOrderQuantity.Width = 65
        '
        'colShipmentQuantity
        '
        Me.colShipmentQuantity.AppearanceCell.Options.UseTextOptions = True
        Me.colShipmentQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colShipmentQuantity.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colShipmentQuantity.FieldName = "ShipmentQuantity"
        Me.colShipmentQuantity.Name = "colShipmentQuantity"
        Me.colShipmentQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ShipmentQuantity", "{0:0.##}")})
        Me.colShipmentQuantity.Visible = True
        Me.colShipmentQuantity.VisibleIndex = 9
        Me.colShipmentQuantity.Width = 73
        '
        'colBalance
        '
        Me.colBalance.AppearanceCell.Options.UseTextOptions = True
        Me.colBalance.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBalance.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBalance.FieldName = "Balance"
        Me.colBalance.Name = "colBalance"
        Me.colBalance.OptionsColumn.ReadOnly = True
        Me.colBalance.Visible = True
        Me.colBalance.VisibleIndex = 10
        Me.colBalance.Width = 58
        '
        'colIsCuttingComplete
        '
        Me.colIsCuttingComplete.AppearanceCell.Options.UseTextOptions = True
        Me.colIsCuttingComplete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsCuttingComplete.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsCuttingComplete.FieldName = "IsCuttingComplete"
        Me.colIsCuttingComplete.Name = "colIsCuttingComplete"
        Me.colIsCuttingComplete.Visible = True
        Me.colIsCuttingComplete.VisibleIndex = 11
        Me.colIsCuttingComplete.Width = 65
        '
        'colIsSewingComplete
        '
        Me.colIsSewingComplete.AppearanceCell.Options.UseTextOptions = True
        Me.colIsSewingComplete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsSewingComplete.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsSewingComplete.FieldName = "IsSewingComplete"
        Me.colIsSewingComplete.Name = "colIsSewingComplete"
        Me.colIsSewingComplete.Visible = True
        Me.colIsSewingComplete.VisibleIndex = 12
        Me.colIsSewingComplete.Width = 67
        '
        'colIsFinishingComplete
        '
        Me.colIsFinishingComplete.AppearanceCell.Options.UseTextOptions = True
        Me.colIsFinishingComplete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsFinishingComplete.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsFinishingComplete.FieldName = "IsFinishingComplete"
        Me.colIsFinishingComplete.Name = "colIsFinishingComplete"
        Me.colIsFinishingComplete.Visible = True
        Me.colIsFinishingComplete.VisibleIndex = 13
        Me.colIsFinishingComplete.Width = 69
        '
        'colInspectionDate
        '
        Me.colInspectionDate.AppearanceCell.Options.UseTextOptions = True
        Me.colInspectionDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInspectionDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInspectionDate.FieldName = "InspectionDate"
        Me.colInspectionDate.Name = "colInspectionDate"
        Me.colInspectionDate.Visible = True
        Me.colInspectionDate.VisibleIndex = 16
        '
        'colInspectionStatus
        '
        Me.colInspectionStatus.AppearanceCell.Options.UseTextOptions = True
        Me.colInspectionStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInspectionStatus.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInspectionStatus.FieldName = "InspectionStatus"
        Me.colInspectionStatus.Name = "colInspectionStatus"
        Me.colInspectionStatus.Visible = True
        Me.colInspectionStatus.VisibleIndex = 17
        '
        'colDiscountOrClaimAmount
        '
        Me.colDiscountOrClaimAmount.AppearanceCell.Options.UseTextOptions = True
        Me.colDiscountOrClaimAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDiscountOrClaimAmount.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDiscountOrClaimAmount.FieldName = "DiscountOrClaimAmount"
        Me.colDiscountOrClaimAmount.Name = "colDiscountOrClaimAmount"
        Me.colDiscountOrClaimAmount.Visible = True
        Me.colDiscountOrClaimAmount.VisibleIndex = 18
        '
        'colClosedOn
        '
        Me.colClosedOn.AppearanceCell.Options.UseTextOptions = True
        Me.colClosedOn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClosedOn.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colClosedOn.Caption = "PO Completed On"
        Me.colClosedOn.ColumnEdit = Me.ClosedOnDateEdit
        Me.colClosedOn.FieldName = "ClosedOn"
        Me.colClosedOn.Name = "colClosedOn"
        Me.colClosedOn.OptionsColumn.AllowEdit = False
        Me.colClosedOn.OptionsColumn.ReadOnly = True
        Me.colClosedOn.Visible = True
        Me.colClosedOn.VisibleIndex = 15
        Me.colClosedOn.Width = 76
        '
        'ClosedOnDateEdit
        '
        Me.ClosedOnDateEdit.AutoHeight = False
        Me.ClosedOnDateEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ClosedOnDateEdit.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ClosedOnDateEdit.Name = "ClosedOnDateEdit"
        '
        'colHoldOn
        '
        Me.colHoldOn.AppearanceCell.Options.UseTextOptions = True
        Me.colHoldOn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHoldOn.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colHoldOn.Caption = "Hold On"
        Me.colHoldOn.FieldName = "HoldOn"
        Me.colHoldOn.Name = "colHoldOn"
        Me.colHoldOn.Visible = True
        Me.colHoldOn.VisibleIndex = 4
        '
        'colIsHold
        '
        Me.colIsHold.AppearanceCell.Options.UseTextOptions = True
        Me.colIsHold.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsHold.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsHold.Caption = "Is Hold"
        Me.colIsHold.FieldName = "IsHold"
        Me.colIsHold.Name = "colIsHold"
        Me.colIsHold.Visible = True
        Me.colIsHold.VisibleIndex = 3
        '
        'colCancelledOn
        '
        Me.colCancelledOn.AppearanceCell.Options.UseTextOptions = True
        Me.colCancelledOn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCancelledOn.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCancelledOn.FieldName = "CancelledOn"
        Me.colCancelledOn.Name = "colCancelledOn"
        Me.colCancelledOn.Visible = True
        Me.colCancelledOn.VisibleIndex = 6
        '

        'colRemarks
        '
        Me.colRemarks.AppearanceCell.Options.UseTextOptions = True
        Me.colRemarks.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRemarks.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 19
        '

        'OrderLookupGridLookUpEdit
        '
        Me.OrderLookupGridLookUpEdit.EditValue = "[Select your Program]"
        Me.OrderLookupGridLookUpEdit.Location = New System.Drawing.Point(228, 5)
        Me.OrderLookupGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.OrderLookupGridLookUpEdit.Name = "OrderLookupGridLookUpEdit"
        Me.OrderLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderLookupGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.OrderLookupGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.OrderLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.OrderLookupGridLookUpEdit.Properties.NullText = "Select your Program"
        Me.OrderLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.OrderLookupGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.OrderLookupGridLookUpEdit.Properties.Tag = "NR"
        Me.OrderLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderLookupGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.OrderLookupGridLookUpEdit.Size = New System.Drawing.Size(251, 20)
        Me.OrderLookupGridLookUpEdit.TabIndex = 37
        Me.OrderLookupGridLookUpEdit.Tag = "NR"
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
        'ProgramNoTextBox
        '
        Me.ProgramNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "ProgramNo", True))
        Me.ProgramNoTextBox.Location = New System.Drawing.Point(89, 42)
        Me.ProgramNoTextBox.Name = "ProgramNoTextBox"
        Me.ProgramNoTextBox.Size = New System.Drawing.Size(139, 20)
        Me.ProgramNoTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(157, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Program No :"
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(485, 4)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 39
        Me.ShowButton.Text = "Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'StyleLookupTableAdapter
        '
        Me.StyleLookupTableAdapter.ClearBeforeFill = True
        '
        'colStyleName
        '
        Me.colStyleName.Caption = "Style No"
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 0
        '
        'FabricColorTableAdapter
        '
        Me.FabricColorTableAdapter.ClearBeforeFill = True
        '
        'IsRunningCheckBox
        '
        Me.IsRunningCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.OrderBindingSource, "IsRunning", True))
        Me.IsRunningCheckBox.Location = New System.Drawing.Point(485, 38)
        Me.IsRunningCheckBox.Name = "IsRunningCheckBox"
        Me.IsRunningCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.IsRunningCheckBox.TabIndex = 40
        Me.IsRunningCheckBox.Text = "Running"
        Me.IsRunningCheckBox.UseVisualStyleBackColor = True
        '
        'FullCompleteDateEdit
        '
        Me.FullCompleteDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "FullCompleteDate", True))
        Me.FullCompleteDateEdit.EditValue = Nothing
        Me.FullCompleteDateEdit.Location = New System.Drawing.Point(748, 65)
        Me.FullCompleteDateEdit.Name = "FullCompleteDateEdit"
        Me.FullCompleteDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FullCompleteDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FullCompleteDateEdit.Properties.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.FullCompleteDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.FullCompleteDateEdit.Properties.ReadOnly = True
        Me.FullCompleteDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.FullCompleteDateEdit.TabIndex = 41
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 131)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.OrderDetailsGridControl)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.VGridControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1215, 378)
        Me.SplitContainer1.SplitterDistance = 848
        Me.SplitContainer1.TabIndex = 42
        '
        'VGridControl1
        '
        Me.VGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VGridControl1.Appearance.Category.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VGridControl1.Appearance.Category.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.VGridControl1.Appearance.Category.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VGridControl1.Appearance.Category.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VGridControl1.Appearance.Category.Options.UseBackColor = True
        Me.VGridControl1.Appearance.Category.Options.UseBorderColor = True
        Me.VGridControl1.Appearance.Category.Options.UseFont = True
        Me.VGridControl1.Appearance.Category.Options.UseForeColor = True
        Me.VGridControl1.Appearance.CategoryExpandButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.VGridControl1.Appearance.CategoryExpandButton.Options.UseBackColor = True
        Me.VGridControl1.Appearance.DisabledRecordValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.VGridControl1.Appearance.DisabledRecordValue.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.VGridControl1.Appearance.DisabledRecordValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VGridControl1.Appearance.DisabledRecordValue.Options.UseBackColor = True
        Me.VGridControl1.Appearance.DisabledRecordValue.Options.UseBorderColor = True
        Me.VGridControl1.Appearance.DisabledRecordValue.Options.UseForeColor = True
        Me.VGridControl1.Appearance.DisabledRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VGridControl1.Appearance.DisabledRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VGridControl1.Appearance.DisabledRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VGridControl1.Appearance.DisabledRow.Options.UseBackColor = True
        Me.VGridControl1.Appearance.DisabledRow.Options.UseBorderColor = True
        Me.VGridControl1.Appearance.DisabledRow.Options.UseForeColor = True
        Me.VGridControl1.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.VGridControl1.Appearance.Empty.ForeColor = System.Drawing.Color.Black
        Me.VGridControl1.Appearance.Empty.Options.UseBackColor = True
        Me.VGridControl1.Appearance.Empty.Options.UseForeColor = True
        Me.VGridControl1.Appearance.ExpandButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VGridControl1.Appearance.ExpandButton.ForeColor = System.Drawing.Color.White
        Me.VGridControl1.Appearance.ExpandButton.Options.UseBackColor = True
        Me.VGridControl1.Appearance.ExpandButton.Options.UseForeColor = True
        Me.VGridControl1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.VGridControl1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VGridControl1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VGridControl1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.VGridControl1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.VGridControl1.Appearance.HorzLine.Options.UseBackColor = True
        Me.VGridControl1.Appearance.ReadOnlyRecordValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VGridControl1.Appearance.ReadOnlyRecordValue.BackColor2 = System.Drawing.Color.White
        Me.VGridControl1.Appearance.ReadOnlyRecordValue.Options.UseBackColor = True
        Me.VGridControl1.Appearance.RecordValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.VGridControl1.Appearance.RecordValue.ForeColor = System.Drawing.Color.Black
        Me.VGridControl1.Appearance.RecordValue.Options.UseBackColor = True
        Me.VGridControl1.Appearance.RecordValue.Options.UseForeColor = True
        Me.VGridControl1.Appearance.RowHeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.VGridControl1.Appearance.RowHeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VGridControl1.Appearance.RowHeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VGridControl1.Appearance.RowHeaderPanel.Options.UseBackColor = True
        Me.VGridControl1.Appearance.RowHeaderPanel.Options.UseBorderColor = True
        Me.VGridControl1.Appearance.RowHeaderPanel.Options.UseForeColor = True
        Me.VGridControl1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.VGridControl1.Appearance.VertLine.Options.UseBackColor = True
        Me.VGridControl1.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.VGridControl1.DataSource = Me.OrderAndProductionDateStatusBindingSource
        Me.VGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.VGridControl1.Name = "VGridControl1"
        Me.VGridControl1.RowHeaderWidth = 202
        Me.VGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.OrderInfocategory, Me.BookingInfocategory, Me.SampleInfocategory, Me.FabProdInfocategory, Me.GMTProdInfocategory})
        Me.VGridControl1.Size = New System.Drawing.Size(363, 378)
        Me.VGridControl1.TabIndex = 1
        '
        'OrderAndProductionDateStatusBindingSource
        '
        Me.OrderAndProductionDateStatusBindingSource.DataMember = "OrderAndProductionDateStatus"
        Me.OrderAndProductionDateStatusBindingSource.DataSource = Me.OrderAndProductionStatusDataSet
        '
        'OrderAndProductionStatusDataSet
        '
        Me.OrderAndProductionStatusDataSet.DataSetName = "OrderAndProductionStatusDataSet"
        Me.OrderAndProductionStatusDataSet.EnforceConstraints = False
        Me.OrderAndProductionStatusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderInfocategory
        '
        Me.OrderInfocategory.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowBuyerName, Me.rowProgramNo, Me.rowStyleName, Me.rowOrderReceiveDate, Me.rowFirstEx, Me.rowLastEx})
        Me.OrderInfocategory.Name = "OrderInfocategory"
        Me.OrderInfocategory.Properties.Caption = "Order Info"
        '
        'rowBuyerName
        '
        Me.rowBuyerName.Name = "rowBuyerName"
        Me.rowBuyerName.Properties.Caption = "Buyer"
        Me.rowBuyerName.Properties.FieldName = "BuyerName"
        '
        'rowProgramNo
        '
        Me.rowProgramNo.Name = "rowProgramNo"
        Me.rowProgramNo.Properties.Caption = "Program No"
        Me.rowProgramNo.Properties.FieldName = "ProgramNo"
        '
        'rowStyleName
        '
        Me.rowStyleName.Name = "rowStyleName"
        Me.rowStyleName.Properties.Caption = "Style"
        Me.rowStyleName.Properties.FieldName = "StyleName"
        '
        'rowOrderReceiveDate
        '
        Me.rowOrderReceiveDate.Name = "rowOrderReceiveDate"
        Me.rowOrderReceiveDate.Properties.Caption = "Order Receive Date"
        Me.rowOrderReceiveDate.Properties.FieldName = "OrderReceiveDate"
        '
        'rowFirstEx
        '
        Me.rowFirstEx.Name = "rowFirstEx"
        Me.rowFirstEx.Properties.Caption = "First Shipment Date"
        Me.rowFirstEx.Properties.FieldName = "FirstEx"
        '
        'rowLastEx
        '
        Me.rowLastEx.Name = "rowLastEx"
        Me.rowLastEx.Properties.Caption = "Last Shipment Date"
        Me.rowLastEx.Properties.FieldName = "LastEx"
        '
        'BookingInfocategory
        '
        Me.BookingInfocategory.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowFabricBookingDate, Me.rowYarnBookingDate, Me.rowYarnRequisitionDate, Me.rowAccessoriesBookingDate})
        Me.BookingInfocategory.Name = "BookingInfocategory"
        Me.BookingInfocategory.Properties.Caption = "Booking Info"
        '
        'rowFabricBookingDate
        '
        Me.rowFabricBookingDate.Name = "rowFabricBookingDate"
        Me.rowFabricBookingDate.Properties.Caption = "Fabric Booking Date"
        Me.rowFabricBookingDate.Properties.FieldName = "FabricBookingDate"
        '
        'rowYarnBookingDate
        '
        Me.rowYarnBookingDate.Appearance.ForeColor = System.Drawing.Color.White
        Me.rowYarnBookingDate.Name = "rowYarnBookingDate"
        Me.rowYarnBookingDate.Properties.Caption = "Yarn Booking Date"
        Me.rowYarnBookingDate.Properties.FieldName = "YarnBookingDate"
        Me.rowYarnBookingDate.Properties.ReadOnly = False
        '
        'rowYarnRequisitionDate
        '
        Me.rowYarnRequisitionDate.Height = 18
        Me.rowYarnRequisitionDate.Name = "rowYarnRequisitionDate"
        Me.rowYarnRequisitionDate.Properties.Caption = "Yarn Requisition Date"
        Me.rowYarnRequisitionDate.Properties.FieldName = "YarnRequisitionDate"
        '
        'rowAccessoriesBookingDate
        '
        Me.rowAccessoriesBookingDate.Name = "rowAccessoriesBookingDate"
        Me.rowAccessoriesBookingDate.Properties.Caption = "Accessories Booking Date"
        Me.rowAccessoriesBookingDate.Properties.FieldName = "AccessoriesBookingDate"
        '
        'SampleInfocategory
        '
        Me.SampleInfocategory.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowSampleSendDate, Me.rowCommentsReceiveDate})
        Me.SampleInfocategory.Name = "SampleInfocategory"
        Me.SampleInfocategory.Properties.Caption = "Sample Info"
        '
        'rowSampleSendDate
        '
        Me.rowSampleSendDate.Name = "rowSampleSendDate"
        Me.rowSampleSendDate.Properties.Caption = "P.P Sample Send Date"
        Me.rowSampleSendDate.Properties.FieldName = "SampleSendDate"
        '
        'rowCommentsReceiveDate
        '
        Me.rowCommentsReceiveDate.Name = "rowCommentsReceiveDate"
        Me.rowCommentsReceiveDate.Properties.Caption = "P.P Comments Receive Date"
        Me.rowCommentsReceiveDate.Properties.FieldName = "CommentsReceiveDate"
        '
        'FabProdInfocategory
        '
        Me.FabProdInfocategory.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowKnittingProductioinStartDate, Me.rowKnittingProductionEndDate, Me.rowDyeingProductionStartDate, Me.rowDyeingProductionEndDate})
        Me.FabProdInfocategory.Name = "FabProdInfocategory"
        Me.FabProdInfocategory.Properties.Caption = "Fabric Production Info"
        '
        'rowKnittingProductioinStartDate
        '
        Me.rowKnittingProductioinStartDate.Name = "rowKnittingProductioinStartDate"
        Me.rowKnittingProductioinStartDate.Properties.Caption = "Knitting Productioin Start Date"
        Me.rowKnittingProductioinStartDate.Properties.FieldName = "KnittingProductioinStartDate"
        Me.rowKnittingProductioinStartDate.Properties.ReadOnly = False
        '
        'rowKnittingProductionEndDate
        '
        Me.rowKnittingProductionEndDate.Name = "rowKnittingProductionEndDate"
        Me.rowKnittingProductionEndDate.Properties.Caption = "Knitting Production End Date"
        Me.rowKnittingProductionEndDate.Properties.FieldName = "KnittingProductionEndDate"
        Me.rowKnittingProductionEndDate.Properties.ReadOnly = False
        '
        'rowDyeingProductionStartDate
        '
        Me.rowDyeingProductionStartDate.Name = "rowDyeingProductionStartDate"
        Me.rowDyeingProductionStartDate.Properties.Caption = "Dyeing Production Start Date"
        Me.rowDyeingProductionStartDate.Properties.FieldName = "DyeingProductionStartDate"
        Me.rowDyeingProductionStartDate.Properties.ReadOnly = False
        '
        'rowDyeingProductionEndDate
        '
        Me.rowDyeingProductionEndDate.Name = "rowDyeingProductionEndDate"
        Me.rowDyeingProductionEndDate.Properties.Caption = "Dyeing Production End Date"
        Me.rowDyeingProductionEndDate.Properties.FieldName = "DyeingProductionEndDate"
        Me.rowDyeingProductionEndDate.Properties.ReadOnly = False
        '
        'GMTProdInfocategory
        '
        Me.GMTProdInfocategory.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowCuttingStartDate, Me.rowCuttingEndDate, Me.rowSewingStartDate, Me.rowSewingEndDate, Me.rowFinishingStartDate, Me.rowFinishingEndDate, Me.rowFullCompleteDate, Me.rowProgramFullCancelledOn})
        Me.GMTProdInfocategory.Name = "GMTProdInfocategory"
        Me.GMTProdInfocategory.Properties.Caption = "Garments Production Info"
        '
        'rowCuttingStartDate
        '
        Me.rowCuttingStartDate.Name = "rowCuttingStartDate"
        Me.rowCuttingStartDate.Properties.Caption = "Fabric Cutting Start Date"
        Me.rowCuttingStartDate.Properties.FieldName = "CuttingStartDate"
        '
        'rowCuttingEndDate
        '
        Me.rowCuttingEndDate.Name = "rowCuttingEndDate"
        Me.rowCuttingEndDate.Properties.Caption = "Fabric Cutting End Date"
        Me.rowCuttingEndDate.Properties.FieldName = "CuttingEndDate"
        '
        'rowSewingStartDate
        '
        Me.rowSewingStartDate.Name = "rowSewingStartDate"
        Me.rowSewingStartDate.Properties.Caption = "Sewing Production Start Date"
        Me.rowSewingStartDate.Properties.FieldName = "SewingStartDate"
        '
        'rowSewingEndDate
        '
        Me.rowSewingEndDate.Height = 18
        Me.rowSewingEndDate.Name = "rowSewingEndDate"
        Me.rowSewingEndDate.Properties.Caption = "Sewing Production End Date"
        Me.rowSewingEndDate.Properties.FieldName = "SewingEndDate"
        '
        'rowFinishingStartDate
        '
        Me.rowFinishingStartDate.Name = "rowFinishingStartDate"
        Me.rowFinishingStartDate.Properties.Caption = "Finishing Production Start Date"
        Me.rowFinishingStartDate.Properties.FieldName = "FinishingStartDate"
        '
        'rowFinishingEndDate
        '
        Me.rowFinishingEndDate.Name = "rowFinishingEndDate"
        Me.rowFinishingEndDate.Properties.Caption = "Finishing Production End Date"
        Me.rowFinishingEndDate.Properties.FieldName = "FinishingEndDate"
        '
        'rowFullCompleteDate
        '
        Me.rowFullCompleteDate.Name = "rowFullCompleteDate"
        Me.rowFullCompleteDate.Properties.Caption = "Full Complete Date"
        Me.rowFullCompleteDate.Properties.FieldName = "FullCompleteDate"
        '
        'rowProgramFullCancelledOn
        '
        Me.rowProgramFullCancelledOn.Name = "rowProgramFullCancelledOn"
        Me.rowProgramFullCancelledOn.Properties.Caption = "Full Cancelled On"
        Me.rowProgramFullCancelledOn.Properties.FieldName = "ProgramFullCancelledOn"
        '
        'OrderAndProductionDateStatusTableAdapter
        '
        Me.OrderAndProductionDateStatusTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.MasterOrderAndProductionStatusPrgTableAdapter = Nothing
        Me.TableAdapterManager1.OrderAndProductionStatusTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = KSoft_Apparel.OrderAndProductionStatusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "OrderRemarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(89, 94)
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(759, 20)
        Me.RemarksTextBox.TabIndex = 3
        '
        'OrderReceiveDateDateEdit
        '
        Me.OrderReceiveDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "OrderReceiveDate", True))
        Me.OrderReceiveDateDateEdit.EditValue = Nothing
        Me.OrderReceiveDateDateEdit.Location = New System.Drawing.Point(485, 64)
        Me.OrderReceiveDateDateEdit.Name = "OrderReceiveDateDateEdit"
        Me.OrderReceiveDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderReceiveDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderReceiveDateDateEdit.Properties.ReadOnly = True
        Me.OrderReceiveDateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.OrderReceiveDateDateEdit.TabIndex = 43
        '
        'CancelledOnDateEdit
        '
        Me.CancelledOnDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "CancelledOn", True))
        Me.CancelledOnDateEdit.EditValue = Nothing
        Me.CancelledOnDateEdit.Location = New System.Drawing.Point(748, 37)
        Me.CancelledOnDateEdit.Name = "CancelledOnDateEdit"
        Me.CancelledOnDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CancelledOnDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CancelledOnDateEdit.Properties.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.CancelledOnDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.CancelledOnDateEdit.Properties.ReadOnly = True
        Me.CancelledOnDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.CancelledOnDateEdit.TabIndex = 41
        '
        'HoldOnDateEdit
        '
        Me.HoldOnDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "HoldOn", True))
        Me.HoldOnDateEdit.EditValue = Nothing
        Me.HoldOnDateEdit.Location = New System.Drawing.Point(748, 8)
        Me.HoldOnDateEdit.Name = "HoldOnDateEdit"
        Me.HoldOnDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.HoldOnDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.HoldOnDateEdit.Properties.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.HoldOnDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.HoldOnDateEdit.Properties.ReadOnly = True
        Me.HoldOnDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.HoldOnDateEdit.TabIndex = 45
        '
        'HoldCheckBox
        '
        Me.HoldCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.OrderBindingSource, "IsHold", True))
        Me.HoldCheckBox.Location = New System.Drawing.Point(595, 6)
        Me.HoldCheckBox.Name = "HoldCheckBox"
        Me.HoldCheckBox.Size = New System.Drawing.Size(147, 24)
        Me.HoldCheckBox.TabIndex = 46
        Me.HoldCheckBox.Text = "Full Hold:"
        Me.HoldCheckBox.UseVisualStyleBackColor = True
        '
        'frmProgramFullAndFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 511)
        Me.Controls.Add(Me.HoldCheckBox)
        Me.Controls.Add(Me.HoldOnDateEdit)
        Me.Controls.Add(OrderReceiveDateLabel)
        Me.Controls.Add(Me.OrderReceiveDateDateEdit)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.CancelledOnDateEdit)
        Me.Controls.Add(Me.FullCompleteDateEdit)
        Me.Controls.Add(Me.IsRunningCheckBox)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OrderLookupGridLookUpEdit)
        Me.Controls.Add(Me.DiscontinueCheckBox)
        Me.Controls.Add(Me.IsFabricBOMCompleteCheckBox)
        Me.Controls.Add(Me.IsAccBOMCompleteCheckBox)
        Me.Controls.Add(Me.IsCompleteCheckBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(StyleIdLabel)
        Me.Controls.Add(Me.StyleIdGridLookUpEdit)
        Me.Controls.Add(ProgramNoLabel)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Controls.Add(Me.ProgramNoTextBox)
        Me.Controls.Add(Me.OrderBindingNavigator)
        Me.Name = "frmProgramFullAndFinal"
        Me.Text = "Program Full And Final"
        CType(Me.ProgramFullAndFinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OrderBindingNavigator.ResumeLayout(False)
        Me.OrderBindingNavigator.PerformLayout()
        CType(Me.StyleIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClosedOnDateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClosedOnDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FullCompleteDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FullCompleteDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderAndProductionDateStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderAndProductionStatusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderReceiveDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderReceiveDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancelledOnDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancelledOnDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoldOnDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoldOnDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgramFullAndFinalDataSet As KSoft_Apparel.ProgramFullAndFinalDataSet
    Friend WithEvents OrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderTableAdapter As KSoft_Apparel.ProgramFullAndFinalDataSetTableAdapters.OrderTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.ProgramFullAndFinalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrderBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents OrderBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents StyleIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents StyleIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents IsCompleteCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IsAccBOMCompleteCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IsFabricBOMCompleteCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DiscontinueCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents OrderDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderDetailsTableAdapter As KSoft_Apparel.ProgramFullAndFinalDataSetTableAdapters.OrderDetailsTableAdapter
    Friend WithEvents OrderDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsClose As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscontinue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCasuseOfDiscontinue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipmentQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsCuttingComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsSewingComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsFinishingComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProgramNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents StyleLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleLookupDataSet As KSoft_Apparel.StyleLookupDataSet
    Friend WithEvents StyleLookupTableAdapter As KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleLookupTableAdapter
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FabricColorGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FabricColorDataSet As KSoft_Apparel.FabricColorDataSet
    Friend WithEvents FabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricColorTableAdapter As KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsRunningCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FullCompleteDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents VGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents OrderInfocategory As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowBuyerName As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowProgramNo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowStyleName As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowOrderReceiveDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFirstEx As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowLastEx As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents BookingInfocategory As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowFabricBookingDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowYarnBookingDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowYarnRequisitionDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowAccessoriesBookingDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents SampleInfocategory As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowSampleSendDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCommentsReceiveDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents FabProdInfocategory As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowKnittingProductioinStartDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKnittingProductionEndDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDyeingProductionStartDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDyeingProductionEndDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents GMTProdInfocategory As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowCuttingStartDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCuttingEndDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSewingStartDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSewingEndDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFinishingStartDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFinishingEndDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFullCompleteDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents OrderAndProductionDateStatusTableAdapter As OrderAndProductionStatusDataSetTableAdapters.OrderAndProductionDateStatusTableAdapter
    Friend WithEvents OrderAndProductionDateStatusBindingSource As BindingSource
    Friend WithEvents OrderAndProductionStatusDataSet As OrderAndProductionStatusDataSet
    Friend WithEvents TableAdapterManager1 As OrderAndProductionStatusDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RemarksTextBox As TextBox
    Friend WithEvents OrderReceiveDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colInspectionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInspectionStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscountOrClaimAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CancelledOnDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colClosedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ClosedOnDateEdit As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents rowProgramFullCancelledOn As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents HoldOnDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents HoldCheckBox As CheckBox
    Friend WithEvents colHoldOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsHold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCancelledOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    'Friend WithEvents OrderTableAdapter As KSoft_Apparel.ProgramFullAndFinalDataSetTableAdapters.OrderTableAdapter
End Class
