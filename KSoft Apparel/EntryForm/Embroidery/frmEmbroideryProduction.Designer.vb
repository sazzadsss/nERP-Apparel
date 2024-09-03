<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmbroideryProduction
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
        Me.ShiftGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.EmbMCGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.EmbOrderDetailsAllGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.EmbOrderDetailsLookupAllBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmbOrderDetailsLookupDataSet = New KSoft_Apparel.EmbOrderDetailsLookupDataSet()
        Me.EmbProductionDataSet = New KSoft_Apparel.EmbProductionDataSet()
        Me.EmbProductionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmbProductionTableAdapter = New KSoft_Apparel.EmbProductionDataSetTableAdapters.EmbProductionTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.EmbProductionDataSetTableAdapters.TableAdapterManager()
        Me.EmbProdSizewiseInputTableAdapter = New KSoft_Apparel.EmbProductionDataSetTableAdapters.EmbProdSizewiseInputTableAdapter()
        Me.EmbSizewiseHourlyProductionTableAdapter = New KSoft_Apparel.EmbProductionDataSetTableAdapters.EmbSizewiseHourlyProductionTableAdapter()
        Me.EmbProductionGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEmbProductionId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmbProductionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShiftId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Shift2GridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.ShiftBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShiftDataSet = New KSoft_Apparel.ShiftDataSet()
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMCNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EmbMC2GridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.EmbMachineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmbMachineDataSet = New KSoft_Apparel.EmbMachineDataSet()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEmbOrderDetailsId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colThreadColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDStitch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBass = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalStitch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCheckedQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRejectQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOperatorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmbOrderDetailsId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColorAndPartGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colReceiveQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChallanNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.Shift2GridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.ShiftTableAdapter = New KSoft_Apparel.ShiftDataSetTableAdapters.ShiftTableAdapter()
        Me.EmbOrderNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.EmbOrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmbOrderLookupDataSet = New KSoft_Apparel.EmbOrderLookupDataSet()
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.EmbOrderLookupTableAdapter = New KSoft_Apparel.EmbOrderLookupDataSetTableAdapters.EmbOrderLookupTableAdapter()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.EmbOrderDetailsGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.EmbOrderDetailsLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.EmbOrderDetailsLookupTableAdapter = New KSoft_Apparel.EmbOrderDetailsLookupDataSetTableAdapters.EmbOrderDetailsLookupTableAdapter()
        Me.EmbOrderDetailsLookupAllTableAdapter = New KSoft_Apparel.EmbOrderDetailsLookupDataSetTableAdapters.EmbOrderDetailsLookupAllTableAdapter()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.colName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EmbMachineTableAdapter = New KSoft_Apparel.EmbMachineDataSetTableAdapters.EmbMachineTableAdapter()
        Me.colMachineName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EmbSizewiseHourlyProductionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmbSizewiseHourlyProductionGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colH1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colH2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colH3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colH4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colH5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colH6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colH7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colH8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colH9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colH10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colH11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colH12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.HTGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSizeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.SizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizeDataSet = New KSoft_Apparel.SizeDataSet()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSizeCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.EmbProdSizewiseInputGridControl = New DevExpress.XtraGrid.GridControl()
        Me.EmbProdSizewiseInputBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmbProdSizewiseInputBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSizeId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SizeLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colInputQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.GetSizeLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.SizeTableAdapter = New KSoft_Apparel.SizeDataSetTableAdapters.SizeTableAdapter()
        Me.GetDataButton = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ChallanNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.CuttingDeliveryChallanLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuttingDeliveryChallanLookupDataSet = New KSoft_Apparel.CuttingDeliveryChallanLookupDataSet()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChallanDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CuttingDeliveryChallanLookupTableAdapter = New KSoft_Apparel.CuttingDeliveryChallanLookupDataSetTableAdapters.CuttingDeliveryChallanLookupTableAdapter()
        Me.ShwButton = New System.Windows.Forms.Button()
        Me.FilterButton = New System.Windows.Forms.Button()
        Me.colMachineName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName3 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.ShiftGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbMCGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbOrderDetailsAllGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbOrderDetailsLookupAllBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbOrderDetailsLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbProductionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbProductionGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shift2GridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShiftBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShiftDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbMC2GridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbMachineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbMachineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorAndPartGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shift2GridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbOrderNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbOrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbOrderDetailsGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbOrderDetailsLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbSizewiseHourlyProductionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbSizewiseHourlyProductionGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.EmbProdSizewiseInputGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbProdSizewiseInputBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbProdSizewiseInputBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShiftGridLookUpEdit
        '
        Me.ShiftGridLookUpEdit.AutoHeight = False
        Me.ShiftGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ShiftGridLookUpEdit.DisplayMember = "Name"
        Me.ShiftGridLookUpEdit.Name = "ShiftGridLookUpEdit"
        Me.ShiftGridLookUpEdit.NullText = ""
        Me.ShiftGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ShiftGridLookUpEdit.ValueMember = "ShiftId"
        '
        'EmbMCGridLookUpEdit
        '
        Me.EmbMCGridLookUpEdit.AutoHeight = False
        Me.EmbMCGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmbMCGridLookUpEdit.DisplayMember = "MachineName"
        Me.EmbMCGridLookUpEdit.Name = "EmbMCGridLookUpEdit"
        Me.EmbMCGridLookUpEdit.NullText = ""
        Me.EmbMCGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.EmbMCGridLookUpEdit.ValueMember = "EmbMCId"
        '
        'EmbOrderDetailsAllGridLookUpEdit
        '
        Me.EmbOrderDetailsAllGridLookUpEdit.AutoHeight = False
        Me.EmbOrderDetailsAllGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmbOrderDetailsAllGridLookUpEdit.DataSource = Me.EmbOrderDetailsLookupAllBindingSource
        Me.EmbOrderDetailsAllGridLookUpEdit.DisplayMember = "Details"
        Me.EmbOrderDetailsAllGridLookUpEdit.Name = "EmbOrderDetailsAllGridLookUpEdit"
        Me.EmbOrderDetailsAllGridLookUpEdit.ValueMember = "EmbOrderDetailsId"
        '
        'EmbOrderDetailsLookupAllBindingSource
        '
        Me.EmbOrderDetailsLookupAllBindingSource.DataMember = "EmbOrderDetailsLookupAll"
        Me.EmbOrderDetailsLookupAllBindingSource.DataSource = Me.EmbOrderDetailsLookupDataSet
        '
        'EmbOrderDetailsLookupDataSet
        '
        Me.EmbOrderDetailsLookupDataSet.DataSetName = "EmbOrderDetailsLookupDataSet"
        Me.EmbOrderDetailsLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmbProductionDataSet
        '
        Me.EmbProductionDataSet.DataSetName = "EmbProductionDataSet"
        Me.EmbProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmbProductionBindingSource
        '
        Me.EmbProductionBindingSource.DataMember = "EmbProduction"
        Me.EmbProductionBindingSource.DataSource = Me.EmbProductionDataSet
        '
        'EmbProductionTableAdapter
        '
        Me.EmbProductionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmbProdSizewiseInputTableAdapter = Me.EmbProdSizewiseInputTableAdapter
        Me.TableAdapterManager.EmbProductionTableAdapter = Me.EmbProductionTableAdapter
        Me.TableAdapterManager.EmbSizewiseHourlyProductionTableAdapter = Me.EmbSizewiseHourlyProductionTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.EmbProductionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmbProdSizewiseInputTableAdapter
        '
        Me.EmbProdSizewiseInputTableAdapter.ClearBeforeFill = True
        '
        'EmbSizewiseHourlyProductionTableAdapter
        '
        Me.EmbSizewiseHourlyProductionTableAdapter.ClearBeforeFill = True
        '
        'EmbProductionGridControl
        '
        Me.EmbProductionGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmbProductionGridControl.DataSource = Me.EmbProductionBindingSource
        Me.EmbProductionGridControl.Location = New System.Drawing.Point(0, 0)
        Me.EmbProductionGridControl.MainView = Me.GridView1
        Me.EmbProductionGridControl.Name = "EmbProductionGridControl"
        Me.EmbProductionGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ColorAndPartGridLookUpEdit, Me.EmbMC2GridLookUpEdit, Me.Shift2GridLookUpEdit2})
        Me.EmbProductionGridControl.Size = New System.Drawing.Size(1314, 344)
        Me.EmbProductionGridControl.TabIndex = 1
        Me.EmbProductionGridControl.UseEmbeddedNavigator = True
        Me.EmbProductionGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEmbProductionId, Me.colEmbProductionDate, Me.colShiftId, Me.colMCNo, Me.colEmbOrderDetailsId, Me.colThreadColor, Me.colDStitch, Me.colBass, Me.colTotalStitch, Me.colCheckedQuantity, Me.colRejectQuantity, Me.colOperatorName, Me.colRemarks, Me.colEmbOrderDetailsId1, Me.colReceiveQuantity, Me.colDeliveryQty, Me.colChallanNo})
        Me.GridView1.GridControl = Me.EmbProductionGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.EnableMasterViewMode = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colEmbProductionId
        '
        Me.colEmbProductionId.AppearanceHeader.Options.UseTextOptions = True
        Me.colEmbProductionId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmbProductionId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEmbProductionId.FieldName = "EmbProductionId"
        Me.colEmbProductionId.Name = "colEmbProductionId"
        Me.colEmbProductionId.OptionsColumn.ReadOnly = True
        Me.colEmbProductionId.Width = 129
        '
        'colEmbProductionDate
        '
        Me.colEmbProductionDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colEmbProductionDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmbProductionDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEmbProductionDate.FieldName = "EmbProductionDate"
        Me.colEmbProductionDate.Name = "colEmbProductionDate"
        Me.colEmbProductionDate.OptionsColumn.AllowEdit = False
        Me.colEmbProductionDate.OptionsColumn.ReadOnly = True
        Me.colEmbProductionDate.Visible = True
        Me.colEmbProductionDate.VisibleIndex = 0
        Me.colEmbProductionDate.Width = 102
        '
        'colShiftId
        '
        Me.colShiftId.AppearanceHeader.Options.UseTextOptions = True
        Me.colShiftId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colShiftId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colShiftId.Caption = "Shift"
        Me.colShiftId.ColumnEdit = Me.Shift2GridLookUpEdit2
        Me.colShiftId.FieldName = "ShiftId"
        Me.colShiftId.Name = "colShiftId"
        Me.colShiftId.OptionsColumn.AllowEdit = False
        Me.colShiftId.OptionsColumn.ReadOnly = True
        Me.colShiftId.Visible = True
        Me.colShiftId.VisibleIndex = 1
        Me.colShiftId.Width = 50
        '
        'Shift2GridLookUpEdit2
        '
        Me.Shift2GridLookUpEdit2.AutoHeight = False
        Me.Shift2GridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Shift2GridLookUpEdit2.DataSource = Me.ShiftBindingSource
        Me.Shift2GridLookUpEdit2.DisplayMember = "Name"
        Me.Shift2GridLookUpEdit2.Name = "Shift2GridLookUpEdit2"
        Me.Shift2GridLookUpEdit2.NullText = ""
        Me.Shift2GridLookUpEdit2.PopupView = Me.GridView10
        Me.Shift2GridLookUpEdit2.ValueMember = "ShiftId"
        '
        'ShiftBindingSource
        '
        Me.ShiftBindingSource.DataMember = "Shift"
        Me.ShiftBindingSource.DataSource = Me.ShiftDataSet
        '
        'ShiftDataSet
        '
        Me.ShiftDataSet.DataSetName = "ShiftDataSet"
        Me.ShiftDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView10
        '
        Me.GridView10.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colName3})
        Me.GridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView10.OptionsView.ShowGroupPanel = False
        '
        'colMCNo
        '
        Me.colMCNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colMCNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMCNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMCNo.Caption = "MC No"
        Me.colMCNo.ColumnEdit = Me.EmbMC2GridLookUpEdit
        Me.colMCNo.FieldName = "EmbMachineId"
        Me.colMCNo.Name = "colMCNo"
        Me.colMCNo.Visible = True
        Me.colMCNo.VisibleIndex = 2
        Me.colMCNo.Width = 84
        '
        'EmbMC2GridLookUpEdit
        '
        Me.EmbMC2GridLookUpEdit.AutoHeight = False
        Me.EmbMC2GridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmbMC2GridLookUpEdit.DataSource = Me.EmbMachineBindingSource
        Me.EmbMC2GridLookUpEdit.DisplayMember = "MachineName"
        Me.EmbMC2GridLookUpEdit.Name = "EmbMC2GridLookUpEdit"
        Me.EmbMC2GridLookUpEdit.NullText = ""
        Me.EmbMC2GridLookUpEdit.PopupView = Me.GridView5
        Me.EmbMC2GridLookUpEdit.ValueMember = "EmbMCId"
        '
        'EmbMachineBindingSource
        '
        Me.EmbMachineBindingSource.DataMember = "EmbMachine"
        Me.EmbMachineBindingSource.DataSource = Me.EmbMachineDataSet
        '
        'EmbMachineDataSet
        '
        Me.EmbMachineDataSet.DataSetName = "EmbMachineDataSet"
        Me.EmbMachineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMachineName1})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colEmbOrderDetailsId
        '
        Me.colEmbOrderDetailsId.AppearanceHeader.Options.UseTextOptions = True
        Me.colEmbOrderDetailsId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmbOrderDetailsId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEmbOrderDetailsId.FieldName = "EmbOrderDetailsId"
        Me.colEmbOrderDetailsId.Name = "colEmbOrderDetailsId"
        Me.colEmbOrderDetailsId.Width = 136
        '
        'colThreadColor
        '
        Me.colThreadColor.AppearanceHeader.Options.UseTextOptions = True
        Me.colThreadColor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colThreadColor.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colThreadColor.FieldName = "ThreadColor"
        Me.colThreadColor.Name = "colThreadColor"
        Me.colThreadColor.Visible = True
        Me.colThreadColor.VisibleIndex = 4
        Me.colThreadColor.Width = 67
        '
        'colDStitch
        '
        Me.colDStitch.AppearanceHeader.Options.UseTextOptions = True
        Me.colDStitch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDStitch.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDStitch.FieldName = "DStitch"
        Me.colDStitch.Name = "colDStitch"
        Me.colDStitch.Visible = True
        Me.colDStitch.VisibleIndex = 5
        Me.colDStitch.Width = 43
        '
        'colBass
        '
        Me.colBass.AppearanceHeader.Options.UseTextOptions = True
        Me.colBass.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBass.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBass.FieldName = "Bass"
        Me.colBass.Name = "colBass"
        Me.colBass.Visible = True
        Me.colBass.VisibleIndex = 6
        Me.colBass.Width = 42
        '
        'colTotalStitch
        '
        Me.colTotalStitch.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalStitch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalStitch.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalStitch.FieldName = "TotalStitch"
        Me.colTotalStitch.Name = "colTotalStitch"
        Me.colTotalStitch.Visible = True
        Me.colTotalStitch.VisibleIndex = 7
        Me.colTotalStitch.Width = 39
        '
        'colCheckedQuantity
        '
        Me.colCheckedQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colCheckedQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCheckedQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCheckedQuantity.FieldName = "CheckedQuantity"
        Me.colCheckedQuantity.Name = "colCheckedQuantity"
        Me.colCheckedQuantity.OptionsColumn.ReadOnly = True
        Me.colCheckedQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CheckedQuantity", "{0:0.##}")})
        Me.colCheckedQuantity.Visible = True
        Me.colCheckedQuantity.VisibleIndex = 10
        Me.colCheckedQuantity.Width = 64
        '
        'colRejectQuantity
        '
        Me.colRejectQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colRejectQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRejectQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRejectQuantity.FieldName = "RejectQuantity"
        Me.colRejectQuantity.Name = "colRejectQuantity"
        Me.colRejectQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RejectQuantity", "{0:0.##}")})
        Me.colRejectQuantity.Visible = True
        Me.colRejectQuantity.VisibleIndex = 11
        Me.colRejectQuantity.Width = 66
        '
        'colOperatorName
        '
        Me.colOperatorName.AppearanceHeader.Options.UseTextOptions = True
        Me.colOperatorName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOperatorName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOperatorName.Caption = "Operator"
        Me.colOperatorName.FieldName = "OperatorName"
        Me.colOperatorName.Name = "colOperatorName"
        Me.colOperatorName.Visible = True
        Me.colOperatorName.VisibleIndex = 13
        Me.colOperatorName.Width = 85
        '
        'colRemarks
        '
        Me.colRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.colRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRemarks.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 14
        Me.colRemarks.Width = 169
        '
        'colEmbOrderDetailsId1
        '
        Me.colEmbOrderDetailsId1.AppearanceHeader.Options.UseTextOptions = True
        Me.colEmbOrderDetailsId1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmbOrderDetailsId1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEmbOrderDetailsId1.Caption = "Color And Part"
        Me.colEmbOrderDetailsId1.ColumnEdit = Me.ColorAndPartGridLookUpEdit
        Me.colEmbOrderDetailsId1.FieldName = "EmbOrderDetailsId"
        Me.colEmbOrderDetailsId1.Name = "colEmbOrderDetailsId1"
        Me.colEmbOrderDetailsId1.OptionsColumn.AllowEdit = False
        Me.colEmbOrderDetailsId1.OptionsColumn.ReadOnly = True
        Me.colEmbOrderDetailsId1.Visible = True
        Me.colEmbOrderDetailsId1.VisibleIndex = 3
        Me.colEmbOrderDetailsId1.Width = 177
        '
        'ColorAndPartGridLookUpEdit
        '
        Me.ColorAndPartGridLookUpEdit.AutoHeight = False
        Me.ColorAndPartGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ColorAndPartGridLookUpEdit.DataSource = Me.EmbOrderDetailsLookupAllBindingSource
        Me.ColorAndPartGridLookUpEdit.DisplayMember = "Details"
        Me.ColorAndPartGridLookUpEdit.Name = "ColorAndPartGridLookUpEdit"
        Me.ColorAndPartGridLookUpEdit.PopupView = Me.GridView4
        Me.ColorAndPartGridLookUpEdit.ValueMember = "EmbOrderDetailsId"
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colReceiveQuantity
        '
        Me.colReceiveQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colReceiveQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colReceiveQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colReceiveQuantity.FieldName = "ReceiveQuantity"
        Me.colReceiveQuantity.Name = "colReceiveQuantity"
        Me.colReceiveQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ReceiveQuantity", "{0:0.##}")})
        Me.colReceiveQuantity.Visible = True
        Me.colReceiveQuantity.VisibleIndex = 9
        Me.colReceiveQuantity.Width = 50
        '
        'colDeliveryQty
        '
        Me.colDeliveryQty.FieldName = "DeliveryQty"
        Me.colDeliveryQty.Name = "colDeliveryQty"
        Me.colDeliveryQty.OptionsColumn.ReadOnly = True
        Me.colDeliveryQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DeliveryQty", "{0:0.##}")})
        Me.colDeliveryQty.Visible = True
        Me.colDeliveryQty.VisibleIndex = 12
        Me.colDeliveryQty.Width = 72
        '
        'colChallanNo
        '
        Me.colChallanNo.FieldName = "ChallanNo"
        Me.colChallanNo.Name = "colChallanNo"
        Me.colChallanNo.OptionsColumn.ReadOnly = True
        Me.colChallanNo.Visible = True
        Me.colChallanNo.VisibleIndex = 8
        Me.colChallanNo.Width = 65
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.EmbProductionGridControl
        Me.GridView2.Name = "GridView2"
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(118, 15)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(150, 20)
        Me.DateEdit1.TabIndex = 2
        '
        'Shift2GridLookUpEdit
        '
        Me.Shift2GridLookUpEdit.Location = New System.Drawing.Point(355, 16)
        Me.Shift2GridLookUpEdit.Name = "Shift2GridLookUpEdit"
        Me.Shift2GridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Shift2GridLookUpEdit.Properties.DataSource = Me.ShiftBindingSource
        Me.Shift2GridLookUpEdit.Properties.DisplayMember = "Name"
        Me.Shift2GridLookUpEdit.Properties.NullText = ""
        Me.Shift2GridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.Shift2GridLookUpEdit.Properties.ValueMember = "ShiftId"
        Me.Shift2GridLookUpEdit.Size = New System.Drawing.Size(75, 20)
        Me.Shift2GridLookUpEdit.TabIndex = 3
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colName})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colName
        '
        Me.colName.Caption = "Shift"
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Production Date:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(323, 18)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Shift:"
        '
        'ShiftTableAdapter
        '
        Me.ShiftTableAdapter.ClearBeforeFill = True
        '
        'EmbOrderNoGridLookUpEdit
        '
        Me.EmbOrderNoGridLookUpEdit.Location = New System.Drawing.Point(602, 16)
        Me.EmbOrderNoGridLookUpEdit.Name = "EmbOrderNoGridLookUpEdit"
        Me.EmbOrderNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmbOrderNoGridLookUpEdit.Properties.DataSource = Me.EmbOrderLookupBindingSource
        Me.EmbOrderNoGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.EmbOrderNoGridLookUpEdit.Properties.NullText = ""
        Me.EmbOrderNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.EmbOrderNoGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit2View
        Me.EmbOrderNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.EmbOrderNoGridLookUpEdit.Properties.ValueMember = "EmbOrderId"
        Me.EmbOrderNoGridLookUpEdit.Size = New System.Drawing.Size(550, 20)
        Me.EmbOrderNoGridLookUpEdit.TabIndex = 6
        '
        'EmbOrderLookupBindingSource
        '
        Me.EmbOrderLookupBindingSource.DataMember = "EmbOrderLookup"
        Me.EmbOrderLookupBindingSource.DataSource = Me.EmbOrderLookupDataSet
        '
        'EmbOrderLookupDataSet
        '
        Me.EmbOrderLookupDataSet.DataSetName = "EmbOrderLookupDataSet"
        Me.EmbOrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit2View
        '
        Me.GridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails})
        Me.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View.Name = "GridLookUpEdit2View"
        Me.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(435, 19)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(160, 13)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Work Order::Program::Style No.:"
        '
        'EmbOrderLookupTableAdapter
        '
        Me.EmbOrderLookupTableAdapter.ClearBeforeFill = True
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(529, 48)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Color :: Part :"
        '
        'EmbOrderDetailsGridLookUpEdit
        '
        Me.EmbOrderDetailsGridLookUpEdit.Location = New System.Drawing.Point(602, 42)
        Me.EmbOrderDetailsGridLookUpEdit.Name = "EmbOrderDetailsGridLookUpEdit"
        Me.EmbOrderDetailsGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmbOrderDetailsGridLookUpEdit.Properties.DataSource = Me.EmbOrderDetailsLookupBindingSource
        Me.EmbOrderDetailsGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.EmbOrderDetailsGridLookUpEdit.Properties.NullText = ""
        Me.EmbOrderDetailsGridLookUpEdit.Properties.PopupView = Me.GridView3
        Me.EmbOrderDetailsGridLookUpEdit.Properties.ValueMember = "EmbOrderDetailsId"
        Me.EmbOrderDetailsGridLookUpEdit.Size = New System.Drawing.Size(550, 20)
        Me.EmbOrderDetailsGridLookUpEdit.TabIndex = 9
        '
        'EmbOrderDetailsLookupBindingSource
        '
        Me.EmbOrderDetailsLookupBindingSource.DataMember = "EmbOrderDetailsLookup"
        Me.EmbOrderDetailsLookupBindingSource.DataSource = Me.EmbOrderDetailsLookupDataSet
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails1})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colDetails1
        '
        Me.colDetails1.FieldName = "Details"
        Me.colDetails1.Name = "colDetails1"
        Me.colDetails1.Visible = True
        Me.colDetails1.VisibleIndex = 0
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(1198, 13)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(56, 49)
        Me.AddButton.TabIndex = 10
        Me.AddButton.Text = "&Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'EmbOrderDetailsLookupTableAdapter
        '
        Me.EmbOrderDetailsLookupTableAdapter.ClearBeforeFill = True
        '
        'EmbOrderDetailsLookupAllTableAdapter
        '
        Me.EmbOrderDetailsLookupAllTableAdapter.ClearBeforeFill = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(1260, 13)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(53, 49)
        Me.SaveButton.TabIndex = 10
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'colName1
        '
        Me.colName1.FieldName = "Name"
        Me.colName1.Name = "colName1"
        Me.colName1.Visible = True
        Me.colName1.VisibleIndex = 0
        '
        'EmbMachineTableAdapter
        '
        Me.EmbMachineTableAdapter.ClearBeforeFill = True
        '
        'colMachineName
        '
        Me.colMachineName.FieldName = "MachineName"
        Me.colMachineName.Name = "colMachineName"
        Me.colMachineName.Visible = True
        Me.colMachineName.VisibleIndex = 0
        '
        'colName2
        '
        Me.colName2.FieldName = "Name"
        Me.colName2.Name = "colName2"
        Me.colName2.Visible = True
        Me.colName2.VisibleIndex = 0
        '
        'EmbSizewiseHourlyProductionBindingSource
        '
        Me.EmbSizewiseHourlyProductionBindingSource.DataMember = "EmbProduction_EmbSizewiseHourlyProduction"
        Me.EmbSizewiseHourlyProductionBindingSource.DataSource = Me.EmbProductionBindingSource
        '
        'EmbSizewiseHourlyProductionGridControl
        '
        Me.EmbSizewiseHourlyProductionGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmbSizewiseHourlyProductionGridControl.DataSource = Me.EmbSizewiseHourlyProductionBindingSource
        Me.EmbSizewiseHourlyProductionGridControl.Location = New System.Drawing.Point(3, 28)
        Me.EmbSizewiseHourlyProductionGridControl.MainView = Me.GridView6
        Me.EmbSizewiseHourlyProductionGridControl.Name = "EmbSizewiseHourlyProductionGridControl"
        Me.EmbSizewiseHourlyProductionGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1})
        Me.EmbSizewiseHourlyProductionGridControl.Size = New System.Drawing.Size(973, 187)
        Me.EmbSizewiseHourlyProductionGridControl.TabIndex = 11
        Me.EmbSizewiseHourlyProductionGridControl.UseEmbeddedNavigator = True
        Me.EmbSizewiseHourlyProductionGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6})
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colH1, Me.colH2, Me.colH3, Me.colH4, Me.colH5, Me.colH6, Me.colH7, Me.colH8, Me.colH9, Me.colH10, Me.colH11, Me.colH12, Me.HTGridColumn, Me.colRemarks1, Me.colSizeId})
        Me.GridView6.GridControl = Me.EmbSizewiseHourlyProductionGridControl
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsView.ShowFooter = True
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colH1
        '
        Me.colH1.AppearanceHeader.Options.UseTextOptions = True
        Me.colH1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colH1.FieldName = "H1"
        Me.colH1.Name = "colH1"
        Me.colH1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H1", "{0:0.##}")})
        Me.colH1.Visible = True
        Me.colH1.VisibleIndex = 1
        '
        'colH2
        '
        Me.colH2.AppearanceHeader.Options.UseTextOptions = True
        Me.colH2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colH2.FieldName = "H2"
        Me.colH2.Name = "colH2"
        Me.colH2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H2", "{0:0.##}")})
        Me.colH2.Visible = True
        Me.colH2.VisibleIndex = 2
        '
        'colH3
        '
        Me.colH3.AppearanceHeader.Options.UseTextOptions = True
        Me.colH3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colH3.FieldName = "H3"
        Me.colH3.Name = "colH3"
        Me.colH3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H3", "{0:0.##}")})
        Me.colH3.Visible = True
        Me.colH3.VisibleIndex = 3
        '
        'colH4
        '
        Me.colH4.AppearanceHeader.Options.UseTextOptions = True
        Me.colH4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colH4.FieldName = "H4"
        Me.colH4.Name = "colH4"
        Me.colH4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H4", "{0:0.##}")})
        Me.colH4.Visible = True
        Me.colH4.VisibleIndex = 4
        '
        'colH5
        '
        Me.colH5.AppearanceHeader.Options.UseTextOptions = True
        Me.colH5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colH5.FieldName = "H5"
        Me.colH5.Name = "colH5"
        Me.colH5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H5", "{0:0.##}")})
        Me.colH5.Visible = True
        Me.colH5.VisibleIndex = 5
        '
        'colH6
        '
        Me.colH6.AppearanceHeader.Options.UseTextOptions = True
        Me.colH6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colH6.FieldName = "H6"
        Me.colH6.Name = "colH6"
        Me.colH6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H6", "{0:0.##}")})
        Me.colH6.Visible = True
        Me.colH6.VisibleIndex = 6
        '
        'colH7
        '
        Me.colH7.AppearanceHeader.Options.UseTextOptions = True
        Me.colH7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colH7.FieldName = "H7"
        Me.colH7.Name = "colH7"
        Me.colH7.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H7", "{0:0.##}")})
        Me.colH7.Visible = True
        Me.colH7.VisibleIndex = 7
        '
        'colH8
        '
        Me.colH8.AppearanceHeader.Options.UseTextOptions = True
        Me.colH8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colH8.FieldName = "H8"
        Me.colH8.Name = "colH8"
        Me.colH8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H8", "{0:0.##}")})
        Me.colH8.Visible = True
        Me.colH8.VisibleIndex = 8
        '
        'colH9
        '
        Me.colH9.AppearanceHeader.Options.UseTextOptions = True
        Me.colH9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colH9.FieldName = "H9"
        Me.colH9.Name = "colH9"
        Me.colH9.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H9", "{0:0.##}")})
        Me.colH9.Visible = True
        Me.colH9.VisibleIndex = 9
        '
        'colH10
        '
        Me.colH10.AppearanceHeader.Options.UseTextOptions = True
        Me.colH10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colH10.FieldName = "H10"
        Me.colH10.Name = "colH10"
        Me.colH10.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H10", "{0:0.##}")})
        Me.colH10.Visible = True
        Me.colH10.VisibleIndex = 10
        '
        'colH11
        '
        Me.colH11.AppearanceHeader.Options.UseTextOptions = True
        Me.colH11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colH11.FieldName = "H11"
        Me.colH11.Name = "colH11"
        Me.colH11.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H11", "{0:0.##}")})
        Me.colH11.Visible = True
        Me.colH11.VisibleIndex = 11
        '
        'colH12
        '
        Me.colH12.AppearanceHeader.Options.UseTextOptions = True
        Me.colH12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colH12.FieldName = "H12"
        Me.colH12.Name = "colH12"
        Me.colH12.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H12", "{0:0.##}")})
        Me.colH12.Visible = True
        Me.colH12.VisibleIndex = 12
        '
        'HTGridColumn
        '
        Me.HTGridColumn.AppearanceCell.Options.UseTextOptions = True
        Me.HTGridColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.HTGridColumn.AppearanceHeader.Options.UseTextOptions = True
        Me.HTGridColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.HTGridColumn.Caption = "HT"
        Me.HTGridColumn.CustomizationCaption = "HT"
        Me.HTGridColumn.FieldName = "HT"
        Me.HTGridColumn.Name = "HTGridColumn"
        Me.HTGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HT", "{0:0.##}")})
        Me.HTGridColumn.Visible = True
        Me.HTGridColumn.VisibleIndex = 13
        '
        'colRemarks1
        '
        Me.colRemarks1.FieldName = "Remarks"
        Me.colRemarks1.Name = "colRemarks1"
        Me.colRemarks1.Visible = True
        Me.colRemarks1.VisibleIndex = 14
        '
        'colSizeId
        '
        Me.colSizeId.Caption = "Size"
        Me.colSizeId.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colSizeId.FieldName = "SizeId"
        Me.colSizeId.Name = "colSizeId"
        Me.colSizeId.Visible = True
        Me.colSizeId.VisibleIndex = 0
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.SizeBindingSource
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "SizeCode"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = ""
        Me.RepositoryItemGridLookUpEdit1.PopupView = Me.GridView7
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "SizeId"
        '
        'SizeBindingSource
        '
        Me.SizeBindingSource.DataMember = "Size"
        Me.SizeBindingSource.DataSource = Me.SizeDataSet
        '
        'SizeDataSet
        '
        Me.SizeDataSet.DataSetName = "SizeDataSet"
        Me.SizeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSizeCode})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colSizeCode
        '
        Me.colSizeCode.FieldName = "SizeCode"
        Me.colSizeCode.Name = "colSizeCode"
        Me.colSizeCode.Visible = True
        Me.colSizeCode.VisibleIndex = 0
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(2, 81)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.EmbProductionGridControl)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.EmbProdSizewiseInputGridControl)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LinkLabel2)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GetSizeLinkLabel)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.EmbSizewiseHourlyProductionGridControl)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1314, 561)
        Me.SplitContainerControl1.SplitterPosition = 212
        Me.SplitContainerControl1.TabIndex = 12
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'EmbProdSizewiseInputGridControl
        '
        Me.EmbProdSizewiseInputGridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmbProdSizewiseInputGridControl.DataSource = Me.EmbProdSizewiseInputBindingSource1
        Me.EmbProdSizewiseInputGridControl.Location = New System.Drawing.Point(991, 28)
        Me.EmbProdSizewiseInputGridControl.MainView = Me.GridView9
        Me.EmbProdSizewiseInputGridControl.Name = "EmbProdSizewiseInputGridControl"
        Me.EmbProdSizewiseInputGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SizeLookupGridLookUpEdit})
        Me.EmbProdSizewiseInputGridControl.Size = New System.Drawing.Size(312, 184)
        Me.EmbProdSizewiseInputGridControl.TabIndex = 77
        Me.EmbProdSizewiseInputGridControl.UseEmbeddedNavigator = True
        Me.EmbProdSizewiseInputGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView9})
        '
        'EmbProdSizewiseInputBindingSource1
        '
        Me.EmbProdSizewiseInputBindingSource1.DataMember = "FK_EmbProdSizewiseInput_EmbProduction"
        Me.EmbProdSizewiseInputBindingSource1.DataSource = Me.EmbProdSizewiseInputBindingSource
        '
        'EmbProdSizewiseInputBindingSource
        '
        Me.EmbProdSizewiseInputBindingSource.DataSource = Me.EmbProductionBindingSource
        '
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSizeId1, Me.colInputQuantity})
        Me.GridView9.GridControl = Me.EmbProdSizewiseInputGridControl
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsView.ShowFooter = True
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'colSizeId1
        '
        Me.colSizeId1.Caption = "Size"
        Me.colSizeId1.ColumnEdit = Me.SizeLookupGridLookUpEdit
        Me.colSizeId1.FieldName = "SizeId"
        Me.colSizeId1.Name = "colSizeId1"
        Me.colSizeId1.Visible = True
        Me.colSizeId1.VisibleIndex = 0
        '
        'SizeLookupGridLookUpEdit
        '
        Me.SizeLookupGridLookUpEdit.AutoHeight = False
        Me.SizeLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SizeLookupGridLookUpEdit.DataSource = Me.SizeBindingSource
        Me.SizeLookupGridLookUpEdit.DisplayMember = "SizeCode"
        Me.SizeLookupGridLookUpEdit.Name = "SizeLookupGridLookUpEdit"
        Me.SizeLookupGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit2View
        Me.SizeLookupGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SizeLookupGridLookUpEdit.ValueMember = "SizeId"
        '
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colInputQuantity
        '
        Me.colInputQuantity.FieldName = "InputQuantity"
        Me.colInputQuantity.Name = "colInputQuantity"
        Me.colInputQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "InputQuantity", "{0:0.##}")})
        Me.colInputQuantity.Visible = True
        Me.colInputQuantity.VisibleIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(991, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 23)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "&Refresh [Input Show]"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(101, 6)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(58, 13)
        Me.LinkLabel2.TabIndex = 76
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Summerize"
        '
        'GetSizeLinkLabel
        '
        Me.GetSizeLinkLabel.AutoSize = True
        Me.GetSizeLinkLabel.Location = New System.Drawing.Point(7, 6)
        Me.GetSizeLinkLabel.Name = "GetSizeLinkLabel"
        Me.GetSizeLinkLabel.Size = New System.Drawing.Size(65, 13)
        Me.GetSizeLinkLabel.TabIndex = 31
        Me.GetSizeLinkLabel.TabStop = True
        Me.GetSizeLinkLabel.Text = "Get Size List"
        '
        'SizeTableAdapter
        '
        Me.SizeTableAdapter.ClearBeforeFill = True
        '
        'GetDataButton
        '
        Me.GetDataButton.Location = New System.Drawing.Point(274, 48)
        Me.GetDataButton.Name = "GetDataButton"
        Me.GetDataButton.Size = New System.Drawing.Size(82, 23)
        Me.GetDataButton.TabIndex = 75
        Me.GetDataButton.Text = "&Get Data"
        Me.GetDataButton.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 13)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "Cutting Challan No  :"
        '
        'ChallanNoGridLookUpEdit
        '
        Me.ChallanNoGridLookUpEdit.Location = New System.Drawing.Point(118, 50)
        Me.ChallanNoGridLookUpEdit.Name = "ChallanNoGridLookUpEdit"
        Me.ChallanNoGridLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.ChallanNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanNoGridLookUpEdit.Properties.DataSource = Me.CuttingDeliveryChallanLookupBindingSource
        Me.ChallanNoGridLookUpEdit.Properties.DisplayMember = "ChallanNo"
        Me.ChallanNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ChallanNoGridLookUpEdit.Properties.NullText = ""
        Me.ChallanNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ChallanNoGridLookUpEdit.Properties.PopupView = Me.GridView8
        Me.ChallanNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ChallanNoGridLookUpEdit.Properties.ValueMember = "ChallanNo"
        Me.ChallanNoGridLookUpEdit.Size = New System.Drawing.Size(150, 20)
        Me.ChallanNoGridLookUpEdit.TabIndex = 76
        '
        'CuttingDeliveryChallanLookupBindingSource
        '
        Me.CuttingDeliveryChallanLookupBindingSource.DataMember = "CuttingDeliveryChallanLookup"
        Me.CuttingDeliveryChallanLookupBindingSource.DataSource = Me.CuttingDeliveryChallanLookupDataSet
        '
        'CuttingDeliveryChallanLookupDataSet
        '
        Me.CuttingDeliveryChallanLookupDataSet.DataSetName = "CuttingDeliveryChallanLookupDataSet"
        Me.CuttingDeliveryChallanLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colChallanDate})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "ChallanNo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'colChallanDate
        '
        Me.colChallanDate.FieldName = "ChallanDate"
        Me.colChallanDate.Name = "colChallanDate"
        Me.colChallanDate.Visible = True
        Me.colChallanDate.VisibleIndex = 1
        '
        'CuttingDeliveryChallanLookupTableAdapter
        '
        Me.CuttingDeliveryChallanLookupTableAdapter.ClearBeforeFill = True
        '
        'ShwButton
        '
        Me.ShwButton.Location = New System.Drawing.Point(274, 13)
        Me.ShwButton.Name = "ShwButton"
        Me.ShwButton.Size = New System.Drawing.Size(43, 23)
        Me.ShwButton.TabIndex = 10
        Me.ShwButton.Text = "&Filter"
        Me.ShwButton.UseVisualStyleBackColor = True
        '
        'FilterButton
        '
        Me.FilterButton.Location = New System.Drawing.Point(1155, 13)
        Me.FilterButton.Name = "FilterButton"
        Me.FilterButton.Size = New System.Drawing.Size(37, 50)
        Me.FilterButton.TabIndex = 78
        Me.FilterButton.Text = "&Filter"
        Me.FilterButton.UseVisualStyleBackColor = True
        '
        'colMachineName1
        '
        Me.colMachineName1.FieldName = "MachineName"
        Me.colMachineName1.Name = "colMachineName1"
        Me.colMachineName1.Visible = True
        Me.colMachineName1.VisibleIndex = 0
        '
        'colName3
        '
        Me.colName3.FieldName = "Name"
        Me.colName3.Name = "colName3"
        Me.colName3.Visible = True
        Me.colName3.VisibleIndex = 0
        '
        'frmEmbroideryProduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 642)
        Me.Controls.Add(Me.FilterButton)
        Me.Controls.Add(Me.GetDataButton)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ChallanNoGridLookUpEdit)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.ShwButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.EmbOrderDetailsGridLookUpEdit)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.EmbOrderNoGridLookUpEdit)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.Shift2GridLookUpEdit)
        Me.Controls.Add(Me.DateEdit1)
        Me.Name = "frmEmbroideryProduction"
        Me.Text = "Embroidery Production"
        CType(Me.ShiftGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbMCGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbOrderDetailsAllGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbOrderDetailsLookupAllBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbOrderDetailsLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbProductionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbProductionGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shift2GridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShiftBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShiftDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbMC2GridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbMachineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbMachineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorAndPartGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shift2GridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbOrderNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbOrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbOrderDetailsGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbOrderDetailsLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbSizewiseHourlyProductionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbSizewiseHourlyProductionGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.EmbProdSizewiseInputGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbProdSizewiseInputBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbProdSizewiseInputBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EmbProductionDataSet As KSoft_Apparel.EmbProductionDataSet
    Friend WithEvents EmbProductionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmbProductionTableAdapter As KSoft_Apparel.EmbProductionDataSetTableAdapters.EmbProductionTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.EmbProductionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmbProductionGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEmbProductionId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmbProductionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShiftId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMCNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmbOrderDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colThreadColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDStitch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalStitch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCheckedQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRejectQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOperatorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Shift2GridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ShiftDataSet As KSoft_Apparel.ShiftDataSet
    Friend WithEvents ShiftBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ShiftTableAdapter As KSoft_Apparel.ShiftDataSetTableAdapters.ShiftTableAdapter
    Friend WithEvents colEmbOrderDetailsId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmbOrderNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EmbOrderLookupDataSet As KSoft_Apparel.EmbOrderLookupDataSet
    Friend WithEvents EmbOrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmbOrderLookupTableAdapter As KSoft_Apparel.EmbOrderLookupDataSetTableAdapters.EmbOrderLookupTableAdapter
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EmbOrderDetailsGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents EmbOrderDetailsLookupDataSet As KSoft_Apparel.EmbOrderDetailsLookupDataSet
    Friend WithEvents EmbOrderDetailsLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmbOrderDetailsLookupTableAdapter As KSoft_Apparel.EmbOrderDetailsLookupDataSetTableAdapters.EmbOrderDetailsLookupTableAdapter
    Friend WithEvents EmbOrderDetailsLookupAllBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmbOrderDetailsLookupAllTableAdapter As KSoft_Apparel.EmbOrderDetailsLookupDataSetTableAdapters.EmbOrderDetailsLookupAllTableAdapter
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmbMachineDataSet As KSoft_Apparel.EmbMachineDataSet
    Friend WithEvents EmbMachineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmbMachineTableAdapter As KSoft_Apparel.EmbMachineDataSetTableAdapters.EmbMachineTableAdapter
    Friend WithEvents colMachineName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiveQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChallanNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmbSizewiseHourlyProductionBindingSource As BindingSource
    Friend WithEvents EmbSizewiseHourlyProductionTableAdapter As EmbProductionDataSetTableAdapters.EmbSizewiseHourlyProductionTableAdapter
    Friend WithEvents EmbSizewiseHourlyProductionGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GetSizeLinkLabel As LinkLabel
    Friend WithEvents colH1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colH2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colH3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colH4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colH5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colH6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colH7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colH8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colH9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colH10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colH11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colH12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSizeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSizeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SizeDataSet As SizeDataSet
    Friend WithEvents SizeBindingSource As BindingSource
    Friend WithEvents SizeTableAdapter As SizeDataSetTableAdapters.SizeTableAdapter
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents HTGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GetDataButton As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents ChallanNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChallanDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CuttingDeliveryChallanLookupDataSet As CuttingDeliveryChallanLookupDataSet
    Friend WithEvents CuttingDeliveryChallanLookupBindingSource As BindingSource
    Friend WithEvents CuttingDeliveryChallanLookupTableAdapter As CuttingDeliveryChallanLookupDataSetTableAdapters.CuttingDeliveryChallanLookupTableAdapter
    Friend WithEvents ShwButton As Button
    Friend WithEvents EmbProdSizewiseInputBindingSource As BindingSource
    Friend WithEvents EmbProdSizewiseInputTableAdapter As EmbProductionDataSetTableAdapters.EmbProdSizewiseInputTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents EmbProdSizewiseInputBindingSource1 As BindingSource
    Friend WithEvents EmbProdSizewiseInputGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSizeId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SizeLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colInputQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FilterButton As Button
    Friend WithEvents ShiftGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents EmbMCGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents EmbOrderDetailsAllGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents ColorAndPartGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Shift2GridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents EmbMC2GridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colName3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachineName1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
