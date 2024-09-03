<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStyleCapture_Fabric
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
        Me.components = New System.ComponentModel.Container
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.StyleCaptureFabricDataSet = New KSoft_Apparel.StyleCaptureFabricDataSet
        Me.StyleCapture_FabricBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleCapture_FabricTableAdapter = New KSoft_Apparel.StyleCaptureFabricDataSetTableAdapters.StyleCapture_FabricTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.StyleCaptureFabricDataSetTableAdapters.TableAdapterManager
        Me.StyleCapture_FinishingTableAdapter = New KSoft_Apparel.StyleCaptureFabricDataSetTableAdapters.StyleCapture_FinishingTableAdapter
        Me.StyleCapture_YarnTableAdapter = New KSoft_Apparel.StyleCaptureFabricDataSetTableAdapters.StyleCapture_YarnTableAdapter
        Me.StyleCapture_FabricGridControl = New DevExpress.XtraGrid.GridControl
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.colIsYarnAllocated = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colGarmentsPartId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GarmentsPartLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GarmentsPartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GarmentsPartDataSet = New KSoft_Apparel.GarmentsPartDataSet
        Me.colKnittingTypeId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.FabricTypeLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.KnittingTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KnittingTypeDataSet = New KSoft_Apparel.KnittingTypeDataSet
        Me.colCompositionId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.CompositionLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.CompositionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompositionDataSet = New KSoft_Apparel.CompositionDataSet
        Me.colDia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colDiaType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.colDUnit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.colGSMId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GSMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSMDataSet = New KSoft_Apparel.GSMDataSet
        Me.colFUnitId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDataSet = New KSoft_Apparel.UnitDataSet
        Me.colConsumption = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.colMarkerLengthInch = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colMarkerLengthYrds = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colMarkerWidth = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colLengthAllowance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colWidthAllowance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colGarmentsQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colWastagePercentage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colDyeingTypeId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.DyeingTypeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.DyeingTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DyeingTypeDataSet = New KSoft_Apparel.DyeingTypeDataSet
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDyeingTypeId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDyeingType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsAOP = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colAOPDescription = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colSPNote = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colSPNoteDetails = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colIsYDS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colYDSDescription = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.StyleCapture_YarnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleCapture_YarnGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colStyleCapture_YarnId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStyleCapture_FabricId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.YarnListGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListLookupDataSet = New KSoft_Apparel.ItemListLookupDataSet
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colItemId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUsagesPercentage = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colWastagePercentage1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colYdsColor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colYdsPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsYd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.KnittingTypeTableAdapter = New KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter
        Me.CompositionTableAdapter = New KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter
        Me.GarmentsPartTableAdapter = New KSoft_Apparel.GarmentsPartDataSetTableAdapters.GarmentsPartTableAdapter
        Me.ItemListTableAdapter = New KSoft_Apparel.ItemListLookupDataSetTableAdapters.ItemListTableAdapter
        Me.GSMTableAdapter = New KSoft_Apparel.GSMDataSetTableAdapters.GSMTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.StyleLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.StyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleLookupDataSet = New KSoft_Apparel.StyleLookupDataSet
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.StyleTableAdapter = New KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleTableAdapter
        Me.UnitTableAdapter = New KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter
        Me.StyleController1 = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.NewButton = New System.Windows.Forms.Button
        Me.DeleteButton = New System.Windows.Forms.Button
        Me.SaveButton = New System.Windows.Forms.Button
        Me.RefreshButton = New System.Windows.Forms.Button
        Me.FabricFinishingTypeDataSet = New KSoft_Apparel.FabricFinishingTypeDataSet
        Me.FabricFinishingTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricFinishingTypeTableAdapter = New KSoft_Apparel.FabricFinishingTypeDataSetTableAdapters.FabricFinishingTypeTableAdapter
        Me.TableAdapterManager1 = New KSoft_Apparel.FabricFinishingTypeDataSetTableAdapters.TableAdapterManager
        Me.DyeingTypeTableAdapter = New KSoft_Apparel.DyeingTypeDataSetTableAdapters.DyeingTypeTableAdapter
        Me.StyleCapture_FinishingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleCapture_FinishingGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colStyleCapture_FinishingId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStyleCapture_FabricId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFinishingTypeId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FinishingTypeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFinishingType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrice1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricFinishingTypeId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPricePerKg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.colKgPerUnit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        CType(Me.StyleCaptureFabricDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleCapture_FabricBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleCapture_FabricGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsPartLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsPartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsPartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricTypeLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DyeingTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DyeingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DyeingTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleCapture_YarnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleCapture_YarnGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnListGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.FabricFinishingTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricFinishingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleCapture_FinishingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleCapture_FinishingGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishingTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleCaptureFabricDataSet
        '
        Me.StyleCaptureFabricDataSet.DataSetName = "StyleCaptureFabricDataSet"
        Me.StyleCaptureFabricDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StyleCapture_FabricBindingSource
        '
        Me.StyleCapture_FabricBindingSource.DataMember = "StyleCapture_Fabric"
        Me.StyleCapture_FabricBindingSource.DataSource = Me.StyleCaptureFabricDataSet
        '
        'StyleCapture_FabricTableAdapter
        '
        Me.StyleCapture_FabricTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StyleCapture_FabricTableAdapter = Me.StyleCapture_FabricTableAdapter
        Me.TableAdapterManager.StyleCapture_FinishingTableAdapter = Me.StyleCapture_FinishingTableAdapter
        Me.TableAdapterManager.StyleCapture_YarnTableAdapter = Me.StyleCapture_YarnTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.StyleCaptureFabricDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StyleCapture_FinishingTableAdapter
        '
        Me.StyleCapture_FinishingTableAdapter.ClearBeforeFill = True
        '
        'StyleCapture_YarnTableAdapter
        '
        Me.StyleCapture_YarnTableAdapter.ClearBeforeFill = True
        '
        'StyleCapture_FabricGridControl
        '
        Me.StyleCapture_FabricGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StyleCapture_FabricGridControl.DataSource = Me.StyleCapture_FabricBindingSource
        GridLevelNode1.RelationName = "Yarn Details"
        Me.StyleCapture_FabricGridControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.StyleCapture_FabricGridControl.Location = New System.Drawing.Point(0, 36)
        Me.StyleCapture_FabricGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.StyleCapture_FabricGridControl.MainView = Me.BandedGridView1
        Me.StyleCapture_FabricGridControl.Name = "StyleCapture_FabricGridControl"
        Me.StyleCapture_FabricGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.FabricTypeLookUpEdit, Me.CompositionLookUpEdit, Me.GarmentsPartLookUpEdit, Me.RepositoryItemComboBox1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemComboBox2, Me.RepositoryItemLookUpEdit3, Me.DyeingTypeGridLookUpEdit, Me.RepositoryItemCalcEdit1})
        Me.StyleCapture_FabricGridControl.Size = New System.Drawing.Size(1366, 330)
        Me.StyleCapture_FabricGridControl.TabIndex = 1
        Me.StyleCapture_FabricGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1})
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.gridBand3, Me.GridBand2, Me.GridBand4})
        Me.BandedGridView1.ColumnPanelRowHeight = 40
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colKnittingTypeId, Me.colCompositionId, Me.colDia, Me.colDiaType, Me.colDUnit, Me.colGSMId, Me.colWastagePercentage, Me.colGarmentsPartId, Me.colConsumption, Me.colFUnitId, Me.colGarmentsQuantity, Me.colIsAOP, Me.colIsYDS, Me.colSPNote, Me.colSPNoteDetails, Me.colYDSDescription, Me.colAOPDescription, Me.colIsYarnAllocated, Me.colDyeingTypeId, Me.colLengthAllowance, Me.colMarkerLengthInch, Me.colMarkerLengthYrds, Me.colMarkerWidth, Me.colWidthAllowance, Me.colKgPerUnit})
        Me.BandedGridView1.CustomizationFormBounds = New System.Drawing.Rectangle(978, 371, 222, 357)
        Me.BandedGridView1.GridControl = Me.StyleCapture_FabricGridControl
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView1.OptionsView.ShowDetailButtons = False
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'colIsYarnAllocated
        '
        Me.colIsYarnAllocated.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colIsYarnAllocated.AppearanceCell.Options.UseBackColor = True
        Me.colIsYarnAllocated.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsYarnAllocated.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsYarnAllocated.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsYarnAllocated.Caption = "Yarn Allocated"
        Me.colIsYarnAllocated.FieldName = "IsYarnAllocated"
        Me.colIsYarnAllocated.Name = "colIsYarnAllocated"
        Me.colIsYarnAllocated.Visible = True
        Me.colIsYarnAllocated.Width = 65
        '
        'colGarmentsPartId
        '
        Me.colGarmentsPartId.AppearanceHeader.Options.UseTextOptions = True
        Me.colGarmentsPartId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGarmentsPartId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGarmentsPartId.Caption = "Part"
        Me.colGarmentsPartId.ColumnEdit = Me.GarmentsPartLookUpEdit
        Me.colGarmentsPartId.FieldName = "GarmentsPartId"
        Me.colGarmentsPartId.Name = "colGarmentsPartId"
        Me.colGarmentsPartId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colGarmentsPartId.Visible = True
        Me.colGarmentsPartId.Width = 88
        '
        'GarmentsPartLookUpEdit
        '
        Me.GarmentsPartLookUpEdit.AutoHeight = False
        Me.GarmentsPartLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GarmentsPartLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GarmentsPartId", "Garments Part Id", 105, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.GarmentsPartLookUpEdit.DataSource = Me.GarmentsPartBindingSource
        Me.GarmentsPartLookUpEdit.DisplayMember = "Name"
        Me.GarmentsPartLookUpEdit.Name = "GarmentsPartLookUpEdit"
        Me.GarmentsPartLookUpEdit.NullText = ""
        Me.GarmentsPartLookUpEdit.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.GarmentsPartLookUpEdit.ValueMember = "GarmentsPartId"
        '
        'GarmentsPartBindingSource
        '
        Me.GarmentsPartBindingSource.DataMember = "GarmentsPart"
        Me.GarmentsPartBindingSource.DataSource = Me.GarmentsPartDataSet
        '
        'GarmentsPartDataSet
        '
        Me.GarmentsPartDataSet.DataSetName = "GarmentsPartDataSet"
        Me.GarmentsPartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colKnittingTypeId
        '
        Me.colKnittingTypeId.AppearanceHeader.Options.UseTextOptions = True
        Me.colKnittingTypeId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colKnittingTypeId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colKnittingTypeId.Caption = "Fabric Type"
        Me.colKnittingTypeId.ColumnEdit = Me.FabricTypeLookUpEdit
        Me.colKnittingTypeId.FieldName = "KnittingTypeId"
        Me.colKnittingTypeId.Name = "colKnittingTypeId"
        Me.colKnittingTypeId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colKnittingTypeId.Visible = True
        Me.colKnittingTypeId.Width = 115
        '
        'FabricTypeLookUpEdit
        '
        Me.FabricTypeLookUpEdit.AutoHeight = False
        Me.FabricTypeLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FabricTypeLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KnittingTypeId", "Knitting Type Id", 99, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KnittingTypeCode", "Knitting Type Code", 101, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KnittingType", "Knitting Type", 73, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.FabricTypeLookUpEdit.DataSource = Me.KnittingTypeBindingSource
        Me.FabricTypeLookUpEdit.DisplayMember = "KnittingType"
        Me.FabricTypeLookUpEdit.Name = "FabricTypeLookUpEdit"
        Me.FabricTypeLookUpEdit.NullText = ""
        Me.FabricTypeLookUpEdit.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.FabricTypeLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.FabricTypeLookUpEdit.ValueMember = "KnittingTypeId"
        '
        'KnittingTypeBindingSource
        '
        Me.KnittingTypeBindingSource.DataMember = "KnittingType"
        Me.KnittingTypeBindingSource.DataSource = Me.KnittingTypeDataSet
        '
        'KnittingTypeDataSet
        '
        Me.KnittingTypeDataSet.DataSetName = "KnittingTypeDataSet"
        Me.KnittingTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colCompositionId
        '
        Me.colCompositionId.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompositionId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompositionId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCompositionId.Caption = "Composition"
        Me.colCompositionId.ColumnEdit = Me.CompositionLookUpEdit
        Me.colCompositionId.FieldName = "CompositionId"
        Me.colCompositionId.Name = "colCompositionId"
        Me.colCompositionId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCompositionId.Visible = True
        Me.colCompositionId.Width = 113
        '
        'CompositionLookUpEdit
        '
        Me.CompositionLookUpEdit.AutoHeight = False
        Me.CompositionLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompositionLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompositionId", "Composition Id", 94, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Composition", "Composition", 68, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CompositionLookUpEdit.DataSource = Me.CompositionBindingSource
        Me.CompositionLookUpEdit.DisplayMember = "Composition"
        Me.CompositionLookUpEdit.Name = "CompositionLookUpEdit"
        Me.CompositionLookUpEdit.NullText = ""
        Me.CompositionLookUpEdit.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.CompositionLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CompositionLookUpEdit.ValueMember = "CompositionId"
        '
        'CompositionBindingSource
        '
        Me.CompositionBindingSource.DataMember = "Composition"
        Me.CompositionBindingSource.DataSource = Me.CompositionDataSet
        '
        'CompositionDataSet
        '
        Me.CompositionDataSet.DataSetName = "CompositionDataSet"
        Me.CompositionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colDia
        '
        Me.colDia.AppearanceHeader.Options.UseTextOptions = True
        Me.colDia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDia.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDia.FieldName = "Dia"
        Me.colDia.Name = "colDia"
        Me.colDia.Visible = True
        Me.colDia.Width = 46
        '
        'colDiaType
        '
        Me.colDiaType.AppearanceHeader.Options.UseTextOptions = True
        Me.colDiaType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDiaType.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDiaType.ColumnEdit = Me.RepositoryItemComboBox2
        Me.colDiaType.FieldName = "DiaType"
        Me.colDiaType.Name = "colDiaType"
        Me.colDiaType.Visible = True
        Me.colDiaType.Width = 67
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Items.AddRange(New Object() {"", "Open", "Tube"})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'colDUnit
        '
        Me.colDUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.colDUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDUnit.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDUnit.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colDUnit.FieldName = "DUnit"
        Me.colDUnit.Name = "colDUnit"
        Me.colDUnit.Visible = True
        Me.colDUnit.Width = 54
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"IN", "CM"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'colGSMId
        '
        Me.colGSMId.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSMId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSMId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSMId.Caption = "GSM"
        Me.colGSMId.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colGSMId.FieldName = "GSMId"
        Me.colGSMId.Name = "colGSMId"
        Me.colGSMId.Visible = True
        Me.colGSMId.Width = 50
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GSMId", "GSMId", 54, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GSM", "GSM", 31, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GSMCode", "GSM Code", 59, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.GSMBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "GSM"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.RepositoryItemLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit2.ValueMember = "GSMId"
        '
        'GSMBindingSource
        '
        Me.GSMBindingSource.DataMember = "GSM"
        Me.GSMBindingSource.DataSource = Me.GSMDataSet
        '
        'GSMDataSet
        '
        Me.GSMDataSet.DataSetName = "GSMDataSet"
        Me.GSMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colFUnitId
        '
        Me.colFUnitId.AppearanceHeader.Options.UseTextOptions = True
        Me.colFUnitId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFUnitId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFUnitId.Caption = "Con Unit"
        Me.colFUnitId.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.colFUnitId.FieldName = "FUnitId"
        Me.colFUnitId.Name = "colFUnitId"
        Me.colFUnitId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colFUnitId.Visible = True
        Me.colFUnitId.Width = 56
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitId", "Unit Id", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitCode", "Unit Code", 57, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitName", "Unit Name", 59, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit3.DataSource = Me.UnitBindingSource
        Me.RepositoryItemLookUpEdit3.DisplayMember = "UnitCode"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit3.ValueMember = "UnitId"
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
        'colConsumption
        '
        Me.colConsumption.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colConsumption.AppearanceCell.Options.UseBackColor = True
        Me.colConsumption.AppearanceHeader.Options.UseTextOptions = True
        Me.colConsumption.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colConsumption.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colConsumption.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.colConsumption.FieldName = "Consumption"
        Me.colConsumption.Name = "colConsumption"
        Me.colConsumption.Visible = True
        Me.colConsumption.Width = 87
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.DisplayFormat.FormatString = "n2"
        Me.RepositoryItemCalcEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemCalcEdit1.EditFormat.FormatString = "n2"
        Me.RepositoryItemCalcEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'colMarkerLengthInch
        '
        Me.colMarkerLengthInch.AppearanceHeader.Options.UseTextOptions = True
        Me.colMarkerLengthInch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMarkerLengthInch.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMarkerLengthInch.Caption = "Marker Length Yrds"
        Me.colMarkerLengthInch.FieldName = "MarkerLengthInch"
        Me.colMarkerLengthInch.Name = "colMarkerLengthInch"
        Me.colMarkerLengthInch.Visible = True
        Me.colMarkerLengthInch.Width = 84
        '
        'colMarkerLengthYrds
        '
        Me.colMarkerLengthYrds.AppearanceHeader.Options.UseTextOptions = True
        Me.colMarkerLengthYrds.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMarkerLengthYrds.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMarkerLengthYrds.Caption = "Marker Length Inch"
        Me.colMarkerLengthYrds.FieldName = "MarkerLengthYrds"
        Me.colMarkerLengthYrds.Name = "colMarkerLengthYrds"
        Me.colMarkerLengthYrds.Visible = True
        Me.colMarkerLengthYrds.Width = 82
        '
        'colMarkerWidth
        '
        Me.colMarkerWidth.AppearanceHeader.Options.UseTextOptions = True
        Me.colMarkerWidth.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMarkerWidth.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMarkerWidth.FieldName = "MarkerWidth"
        Me.colMarkerWidth.Name = "colMarkerWidth"
        Me.colMarkerWidth.Visible = True
        Me.colMarkerWidth.Width = 57
        '
        'colLengthAllowance
        '
        Me.colLengthAllowance.AppearanceHeader.Options.UseTextOptions = True
        Me.colLengthAllowance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLengthAllowance.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLengthAllowance.FieldName = "LengthAllowance"
        Me.colLengthAllowance.Name = "colLengthAllowance"
        Me.colLengthAllowance.Visible = True
        '
        'colWidthAllowance
        '
        Me.colWidthAllowance.AppearanceHeader.Options.UseTextOptions = True
        Me.colWidthAllowance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWidthAllowance.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colWidthAllowance.FieldName = "WidthAllowance"
        Me.colWidthAllowance.Name = "colWidthAllowance"
        Me.colWidthAllowance.Visible = True
        '
        'colGarmentsQuantity
        '
        Me.colGarmentsQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colGarmentsQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGarmentsQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGarmentsQuantity.FieldName = "GarmentsQuantity"
        Me.colGarmentsQuantity.Name = "colGarmentsQuantity"
        Me.colGarmentsQuantity.Visible = True
        Me.colGarmentsQuantity.Width = 70
        '
        'colWastagePercentage
        '
        Me.colWastagePercentage.AppearanceHeader.Options.UseTextOptions = True
        Me.colWastagePercentage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWastagePercentage.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colWastagePercentage.Caption = "W%"
        Me.colWastagePercentage.FieldName = "WastagePercentage"
        Me.colWastagePercentage.Name = "colWastagePercentage"
        Me.colWastagePercentage.Visible = True
        Me.colWastagePercentage.Width = 43
        '
        'colDyeingTypeId
        '
        Me.colDyeingTypeId.AppearanceHeader.Options.UseTextOptions = True
        Me.colDyeingTypeId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDyeingTypeId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDyeingTypeId.Caption = "Dyeing Type"
        Me.colDyeingTypeId.ColumnEdit = Me.DyeingTypeGridLookUpEdit
        Me.colDyeingTypeId.FieldName = "DyeingTypeId"
        Me.colDyeingTypeId.Name = "colDyeingTypeId"
        Me.colDyeingTypeId.Visible = True
        Me.colDyeingTypeId.Width = 77
        '
        'DyeingTypeGridLookUpEdit
        '
        Me.DyeingTypeGridLookUpEdit.AutoHeight = False
        Me.DyeingTypeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DyeingTypeGridLookUpEdit.DataSource = Me.DyeingTypeBindingSource
        Me.DyeingTypeGridLookUpEdit.DisplayMember = "DyeingType"
        Me.DyeingTypeGridLookUpEdit.Name = "DyeingTypeGridLookUpEdit"
        Me.DyeingTypeGridLookUpEdit.NullText = ""
        Me.DyeingTypeGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DyeingTypeGridLookUpEdit.ValueMember = "DyeingTypeId"
        Me.DyeingTypeGridLookUpEdit.View = Me.GridView5
        '
        'DyeingTypeBindingSource
        '
        Me.DyeingTypeBindingSource.DataMember = "DyeingType"
        Me.DyeingTypeBindingSource.DataSource = Me.DyeingTypeDataSet
        '
        'DyeingTypeDataSet
        '
        Me.DyeingTypeDataSet.DataSetName = "DyeingTypeDataSet"
        Me.DyeingTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDyeingTypeId1, Me.colDyeingType})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colDyeingTypeId1
        '
        Me.colDyeingTypeId1.FieldName = "DyeingTypeId"
        Me.colDyeingTypeId1.Name = "colDyeingTypeId1"
        Me.colDyeingTypeId1.OptionsColumn.ReadOnly = True
        '
        'colDyeingType
        '
        Me.colDyeingType.FieldName = "DyeingType"
        Me.colDyeingType.Name = "colDyeingType"
        Me.colDyeingType.Visible = True
        Me.colDyeingType.VisibleIndex = 0
        '
        'colIsAOP
        '
        Me.colIsAOP.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsAOP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsAOP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsAOP.FieldName = "IsAOP"
        Me.colIsAOP.Name = "colIsAOP"
        Me.colIsAOP.Visible = True
        '
        'colAOPDescription
        '
        Me.colAOPDescription.AppearanceHeader.Options.UseTextOptions = True
        Me.colAOPDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAOPDescription.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAOPDescription.FieldName = "AOPDescription"
        Me.colAOPDescription.Name = "colAOPDescription"
        Me.colAOPDescription.Visible = True
        Me.colAOPDescription.Width = 98
        '
        'colSPNote
        '
        Me.colSPNote.AppearanceHeader.Options.UseTextOptions = True
        Me.colSPNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSPNote.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSPNote.FieldName = "SPNote"
        Me.colSPNote.Name = "colSPNote"
        Me.colSPNote.Visible = True
        '
        'colSPNoteDetails
        '
        Me.colSPNoteDetails.AppearanceHeader.Options.UseTextOptions = True
        Me.colSPNoteDetails.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSPNoteDetails.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSPNoteDetails.FieldName = "SPNoteDetails"
        Me.colSPNoteDetails.Name = "colSPNoteDetails"
        Me.colSPNoteDetails.Visible = True
        Me.colSPNoteDetails.Width = 111
        '
        'colIsYDS
        '
        Me.colIsYDS.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsYDS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsYDS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsYDS.FieldName = "IsYDS"
        Me.colIsYDS.Name = "colIsYDS"
        Me.colIsYDS.Visible = True
        Me.colIsYDS.Width = 71
        '
        'colYDSDescription
        '
        Me.colYDSDescription.AppearanceHeader.Options.UseTextOptions = True
        Me.colYDSDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYDSDescription.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colYDSDescription.FieldName = "YDSDescription"
        Me.colYDSDescription.Name = "colYDSDescription"
        Me.colYDSDescription.Visible = True
        Me.colYDSDescription.Width = 95
        '
        'StyleCapture_YarnBindingSource
        '
        Me.StyleCapture_YarnBindingSource.DataMember = "StyleCapture_Fabric_StyleCapture_Yarn"
        Me.StyleCapture_YarnBindingSource.DataSource = Me.StyleCapture_FabricBindingSource
        '
        'StyleCapture_YarnGridControl
        '
        Me.StyleCapture_YarnGridControl.DataSource = Me.StyleCapture_YarnBindingSource
        Me.StyleCapture_YarnGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StyleCapture_YarnGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.StyleCapture_YarnGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.StyleCapture_YarnGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.StyleCapture_YarnGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.StyleCapture_YarnGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.StyleCapture_YarnGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.StyleCapture_YarnGridControl.Location = New System.Drawing.Point(0, 0)
        Me.StyleCapture_YarnGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.StyleCapture_YarnGridControl.MainView = Me.GridView2
        Me.StyleCapture_YarnGridControl.Name = "StyleCapture_YarnGridControl"
        Me.StyleCapture_YarnGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.YarnListGridLookUpEdit})
        Me.StyleCapture_YarnGridControl.Size = New System.Drawing.Size(1014, 373)
        Me.StyleCapture_YarnGridControl.TabIndex = 2
        Me.StyleCapture_YarnGridControl.UseEmbeddedNavigator = True
        Me.StyleCapture_YarnGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.ColumnPanelRowHeight = 30
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStyleCapture_YarnId, Me.colStyleCapture_FabricId, Me.colItemId, Me.colUsagesPercentage, Me.colWastagePercentage1, Me.colPrice, Me.colYdsColor, Me.colYdsPrice, Me.colIsYd})
        Me.GridView2.GridControl = Me.StyleCapture_YarnGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colStyleCapture_YarnId
        '
        Me.colStyleCapture_YarnId.AppearanceHeader.Options.UseTextOptions = True
        Me.colStyleCapture_YarnId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStyleCapture_YarnId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStyleCapture_YarnId.FieldName = "StyleCapture_YarnId"
        Me.colStyleCapture_YarnId.Name = "colStyleCapture_YarnId"
        Me.colStyleCapture_YarnId.Width = 144
        '
        'colStyleCapture_FabricId
        '
        Me.colStyleCapture_FabricId.AppearanceHeader.Options.UseTextOptions = True
        Me.colStyleCapture_FabricId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStyleCapture_FabricId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStyleCapture_FabricId.FieldName = "StyleCapture_FabricId"
        Me.colStyleCapture_FabricId.Name = "colStyleCapture_FabricId"
        Me.colStyleCapture_FabricId.Width = 122
        '
        'colItemId
        '
        Me.colItemId.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colItemId.Caption = "Yarn"
        Me.colItemId.ColumnEdit = Me.YarnListGridLookUpEdit
        Me.colItemId.FieldName = "ItemId"
        Me.colItemId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colItemId.Name = "colItemId"
        Me.colItemId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colItemId.Visible = True
        Me.colItemId.VisibleIndex = 0
        Me.colItemId.Width = 438
        '
        'YarnListGridLookUpEdit
        '
        Me.YarnListGridLookUpEdit.AutoHeight = False
        Me.YarnListGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.YarnListGridLookUpEdit.DataSource = Me.ItemListBindingSource
        Me.YarnListGridLookUpEdit.DisplayMember = "ItemName"
        Me.YarnListGridLookUpEdit.Name = "YarnListGridLookUpEdit"
        Me.YarnListGridLookUpEdit.NullText = ""
        Me.YarnListGridLookUpEdit.ValueMember = "ItemId"
        Me.YarnListGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
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
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId1, Me.colItemName, Me.colDepartmentId})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colItemId1
        '
        Me.colItemId1.FieldName = "ItemId"
        Me.colItemId1.Name = "colItemId1"
        Me.colItemId1.OptionsColumn.ReadOnly = True
        '
        'colItemName
        '
        Me.colItemName.FieldName = "ItemName"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.Visible = True
        Me.colItemName.VisibleIndex = 0
        '
        'colDepartmentId
        '
        Me.colDepartmentId.FieldName = "DepartmentId"
        Me.colDepartmentId.Name = "colDepartmentId"
        '
        'colUsagesPercentage
        '
        Me.colUsagesPercentage.AppearanceHeader.Options.UseTextOptions = True
        Me.colUsagesPercentage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUsagesPercentage.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUsagesPercentage.Caption = "Usages%"
        Me.colUsagesPercentage.FieldName = "UsagesPercentage"
        Me.colUsagesPercentage.Name = "colUsagesPercentage"
        Me.colUsagesPercentage.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colUsagesPercentage.Visible = True
        Me.colUsagesPercentage.VisibleIndex = 1
        Me.colUsagesPercentage.Width = 86
        '
        'colWastagePercentage1
        '
        Me.colWastagePercentage1.AppearanceHeader.Options.UseTextOptions = True
        Me.colWastagePercentage1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWastagePercentage1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colWastagePercentage1.Caption = "W%"
        Me.colWastagePercentage1.FieldName = "WastagePercentage"
        Me.colWastagePercentage1.Name = "colWastagePercentage1"
        Me.colWastagePercentage1.Visible = True
        Me.colWastagePercentage1.VisibleIndex = 2
        '
        'colPrice
        '
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 3
        Me.colPrice.Width = 49
        '
        'colYdsColor
        '
        Me.colYdsColor.FieldName = "YdsColor"
        Me.colYdsColor.Name = "colYdsColor"
        Me.colYdsColor.Visible = True
        Me.colYdsColor.VisibleIndex = 5
        Me.colYdsColor.Width = 140
        '
        'colYdsPrice
        '
        Me.colYdsPrice.FieldName = "YdsPrice"
        Me.colYdsPrice.Name = "colYdsPrice"
        Me.colYdsPrice.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colYdsPrice.Visible = True
        Me.colYdsPrice.VisibleIndex = 6
        Me.colYdsPrice.Width = 155
        '
        'colIsYd
        '
        Me.colIsYd.FieldName = "IsYd"
        Me.colIsYd.Name = "colIsYd"
        Me.colIsYd.Visible = True
        Me.colIsYd.VisibleIndex = 4
        Me.colIsYd.Width = 53
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemId", "Item Id", 58, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Item Name", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentId", "Department Id", 80, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.ItemListBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "ItemName"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "ItemId"
        '
        'KnittingTypeTableAdapter
        '
        Me.KnittingTypeTableAdapter.ClearBeforeFill = True
        '
        'CompositionTableAdapter
        '
        Me.CompositionTableAdapter.ClearBeforeFill = True
        '
        'GarmentsPartTableAdapter
        '
        Me.GarmentsPartTableAdapter.ClearBeforeFill = True
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'GSMTableAdapter
        '
        Me.GSMTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(322, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 14)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Style No"
        '
        'StyleLookupGridLookUpEdit
        '
        Me.StyleLookupGridLookUpEdit.Location = New System.Drawing.Point(379, 7)
        Me.StyleLookupGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.StyleLookupGridLookUpEdit.Name = "StyleLookupGridLookUpEdit"
        Me.StyleLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StyleLookupGridLookUpEdit.Properties.DataSource = Me.StyleBindingSource
        Me.StyleLookupGridLookUpEdit.Properties.DisplayMember = "StyleName"
        Me.StyleLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.StyleLookupGridLookUpEdit.Properties.LookAndFeel.SkinName = "Lilian"
        Me.StyleLookupGridLookUpEdit.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.StyleLookupGridLookUpEdit.Properties.NullText = ""
        Me.StyleLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.StyleLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.StyleLookupGridLookUpEdit.Properties.ValueMember = "StyleId"
        Me.StyleLookupGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.StyleLookupGridLookUpEdit.Size = New System.Drawing.Size(193, 20)
        Me.StyleLookupGridLookUpEdit.TabIndex = 42
        '
        'StyleBindingSource
        '
        Me.StyleBindingSource.DataMember = "Style"
        Me.StyleBindingSource.DataSource = Me.StyleLookupDataSet
        '
        'StyleLookupDataSet
        '
        Me.StyleLookupDataSet.DataSetName = "StyleLookupDataSet"
        Me.StyleLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colStyleName})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "StyleId"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'colStyleName
        '
        Me.colStyleName.Caption = "Style No"
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 0
        '
        'StyleTableAdapter
        '
        Me.StyleTableAdapter.ClearBeforeFill = True
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'StyleController1
        '
        Me.StyleController1.LookAndFeel.SkinName = "Money Twins"
        Me.StyleController1.LookAndFeel.UseDefaultLookAndFeel = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.NewButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.SaveButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.RefreshButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.StyleLookupGridLookUpEdit)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1366, 36)
        Me.FlowLayoutPanel1.TabIndex = 45
        Me.FlowLayoutPanel1.Tag = "NR"
        '
        'NewButton
        '
        Me.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewButton.Location = New System.Drawing.Point(3, 3)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(82, 27)
        Me.NewButton.TabIndex = 4
        Me.NewButton.Tag = "NR"
        Me.NewButton.Text = "&New"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.Location = New System.Drawing.Point(91, 3)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(63, 27)
        Me.DeleteButton.TabIndex = 6
        Me.DeleteButton.Tag = "NR"
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Location = New System.Drawing.Point(160, 3)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 27)
        Me.SaveButton.TabIndex = 35
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshButton.Location = New System.Drawing.Point(241, 3)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 27)
        Me.RefreshButton.TabIndex = 35
        Me.RefreshButton.Text = "&Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'FabricFinishingTypeDataSet
        '
        Me.FabricFinishingTypeDataSet.DataSetName = "FabricFinishingTypeDataSet"
        Me.FabricFinishingTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FabricFinishingTypeBindingSource
        '
        Me.FabricFinishingTypeBindingSource.DataMember = "FabricFinishingType"
        Me.FabricFinishingTypeBindingSource.DataSource = Me.FabricFinishingTypeDataSet
        '
        'FabricFinishingTypeTableAdapter
        '
        Me.FabricFinishingTypeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.FabricFinishingTypeTableAdapter = Me.FabricFinishingTypeTableAdapter
        Me.TableAdapterManager1.UpdateOrder = KSoft_Apparel.FabricFinishingTypeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DyeingTypeTableAdapter
        '
        Me.DyeingTypeTableAdapter.ClearBeforeFill = True
        '
        'StyleCapture_FinishingBindingSource
        '
        Me.StyleCapture_FinishingBindingSource.DataMember = "StyleCapture_Fabric_StyleCapture_Finishing"
        Me.StyleCapture_FinishingBindingSource.DataSource = Me.StyleCapture_FabricBindingSource
        '
        'StyleCapture_FinishingGridControl
        '
        Me.StyleCapture_FinishingGridControl.DataSource = Me.StyleCapture_FinishingBindingSource
        Me.StyleCapture_FinishingGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StyleCapture_FinishingGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.StyleCapture_FinishingGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.StyleCapture_FinishingGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.StyleCapture_FinishingGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.StyleCapture_FinishingGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.StyleCapture_FinishingGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.StyleCapture_FinishingGridControl.Location = New System.Drawing.Point(0, 0)
        Me.StyleCapture_FinishingGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.StyleCapture_FinishingGridControl.MainView = Me.GridView3
        Me.StyleCapture_FinishingGridControl.Name = "StyleCapture_FinishingGridControl"
        Me.StyleCapture_FinishingGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.FinishingTypeGridLookUpEdit})
        Me.StyleCapture_FinishingGridControl.Size = New System.Drawing.Size(348, 373)
        Me.StyleCapture_FinishingGridControl.TabIndex = 45
        Me.StyleCapture_FinishingGridControl.UseEmbeddedNavigator = True
        Me.StyleCapture_FinishingGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStyleCapture_FinishingId, Me.colStyleCapture_FabricId1, Me.colFinishingTypeId, Me.colPricePerKg, Me.colRemarks})
        Me.GridView3.GridControl = Me.StyleCapture_FinishingGridControl
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colStyleCapture_FinishingId
        '
        Me.colStyleCapture_FinishingId.FieldName = "StyleCapture_FinishingId"
        Me.colStyleCapture_FinishingId.Name = "colStyleCapture_FinishingId"
        Me.colStyleCapture_FinishingId.OptionsColumn.ReadOnly = True
        '
        'colStyleCapture_FabricId1
        '
        Me.colStyleCapture_FabricId1.FieldName = "StyleCapture_FabricId"
        Me.colStyleCapture_FabricId1.Name = "colStyleCapture_FabricId1"
        '
        'colFinishingTypeId
        '
        Me.colFinishingTypeId.Caption = "Finishing Type"
        Me.colFinishingTypeId.ColumnEdit = Me.FinishingTypeGridLookUpEdit
        Me.colFinishingTypeId.FieldName = "FinishingTypeId"
        Me.colFinishingTypeId.Name = "colFinishingTypeId"
        Me.colFinishingTypeId.Visible = True
        Me.colFinishingTypeId.VisibleIndex = 0
        Me.colFinishingTypeId.Width = 137
        '
        'FinishingTypeGridLookUpEdit
        '
        Me.FinishingTypeGridLookUpEdit.AutoHeight = False
        Me.FinishingTypeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FinishingTypeGridLookUpEdit.DataSource = Me.FabricFinishingTypeBindingSource
        Me.FinishingTypeGridLookUpEdit.DisplayMember = "FinishingType"
        Me.FinishingTypeGridLookUpEdit.ImmediatePopup = True
        Me.FinishingTypeGridLookUpEdit.Name = "FinishingTypeGridLookUpEdit"
        Me.FinishingTypeGridLookUpEdit.NullText = ""
        Me.FinishingTypeGridLookUpEdit.ValueMember = "FabricFinishingTypeId"
        Me.FinishingTypeGridLookUpEdit.View = Me.GridView4
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFinishingType, Me.colPrice1, Me.colFabricFinishingTypeId})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colFinishingType
        '
        Me.colFinishingType.FieldName = "FinishingType"
        Me.colFinishingType.Name = "colFinishingType"
        Me.colFinishingType.Visible = True
        Me.colFinishingType.VisibleIndex = 0
        '
        'colPrice1
        '
        Me.colPrice1.FieldName = "Price"
        Me.colPrice1.Name = "colPrice1"
        Me.colPrice1.Visible = True
        Me.colPrice1.VisibleIndex = 1
        '
        'colFabricFinishingTypeId
        '
        Me.colFabricFinishingTypeId.FieldName = "FabricFinishingTypeId"
        Me.colFabricFinishingTypeId.Name = "colFabricFinishingTypeId"
        Me.colFabricFinishingTypeId.OptionsColumn.ReadOnly = True
        '
        'colPricePerKg
        '
        Me.colPricePerKg.FieldName = "PricePerKg"
        Me.colPricePerKg.Name = "colPricePerKg"
        Me.colPricePerKg.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPricePerKg.Visible = True
        Me.colPricePerKg.VisibleIndex = 1
        Me.colPricePerKg.Width = 87
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 2
        Me.colRemarks.Width = 106
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 372)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.StyleCapture_YarnGridControl)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.StyleCapture_FinishingGridControl)
        Me.SplitContainer1.Size = New System.Drawing.Size(1366, 373)
        Me.SplitContainer1.SplitterDistance = 1014
        Me.SplitContainer1.TabIndex = 46
        '
        'colKgPerUnit
        '
        Me.colKgPerUnit.FieldName = "KgPerUnit"
        Me.colKgPerUnit.Name = "colKgPerUnit"
        Me.colKgPerUnit.Visible = True
        Me.colKgPerUnit.Width = 79
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Status"
        Me.GridBand1.Columns.Add(Me.colIsYarnAllocated)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 65
        '
        'gridBand3
        '
        Me.gridBand3.Caption = "Fabric Information"
        Me.gridBand3.Columns.Add(Me.colDyeingTypeId)
        Me.gridBand3.Columns.Add(Me.colGarmentsPartId)
        Me.gridBand3.Columns.Add(Me.colKnittingTypeId)
        Me.gridBand3.Columns.Add(Me.colCompositionId)
        Me.gridBand3.Columns.Add(Me.colDia)
        Me.gridBand3.Columns.Add(Me.colDiaType)
        Me.gridBand3.Columns.Add(Me.colDUnit)
        Me.gridBand3.Columns.Add(Me.colGSMId)
        Me.gridBand3.Columns.Add(Me.colConsumption)
        Me.gridBand3.Columns.Add(Me.colFUnitId)
        Me.gridBand3.Columns.Add(Me.colKgPerUnit)
        Me.gridBand3.Name = "gridBand3"
        Me.gridBand3.Width = 832
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "CAD Information"
        Me.GridBand2.Columns.Add(Me.colMarkerLengthInch)
        Me.GridBand2.Columns.Add(Me.colMarkerLengthYrds)
        Me.GridBand2.Columns.Add(Me.colMarkerWidth)
        Me.GridBand2.Columns.Add(Me.colLengthAllowance)
        Me.GridBand2.Columns.Add(Me.colWidthAllowance)
        Me.GridBand2.Columns.Add(Me.colGarmentsQuantity)
        Me.GridBand2.Columns.Add(Me.colWastagePercentage)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 486
        '
        'GridBand4
        '
        Me.GridBand4.Caption = "Others"
        Me.GridBand4.Columns.Add(Me.colIsAOP)
        Me.GridBand4.Columns.Add(Me.colAOPDescription)
        Me.GridBand4.Columns.Add(Me.colSPNote)
        Me.GridBand4.Columns.Add(Me.colSPNoteDetails)
        Me.GridBand4.Columns.Add(Me.colIsYDS)
        Me.GridBand4.Columns.Add(Me.colYDSDescription)
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.Width = 525
        '
        'frmStyleCapture_Fabric
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1366, 745)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.StyleCapture_FabricGridControl)
        Me.Name = "frmStyleCapture_Fabric"
        Me.Text = "Style Collection [Fabric]"
        CType(Me.StyleCaptureFabricDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleCapture_FabricBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleCapture_FabricGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsPartLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsPartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsPartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricTypeLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DyeingTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DyeingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DyeingTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleCapture_YarnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleCapture_YarnGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnListGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.FabricFinishingTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricFinishingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleCapture_FinishingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleCapture_FinishingGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishingTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StyleCaptureFabricDataSet As KSoft_Apparel.StyleCaptureFabricDataSet
    Friend WithEvents StyleCapture_FabricBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleCapture_FabricTableAdapter As KSoft_Apparel.StyleCaptureFabricDataSetTableAdapters.StyleCapture_FabricTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.StyleCaptureFabricDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StyleCapture_FabricGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents StyleCapture_YarnTableAdapter As KSoft_Apparel.StyleCaptureFabricDataSetTableAdapters.StyleCapture_YarnTableAdapter
    Friend WithEvents StyleCapture_YarnBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleCapture_YarnGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colStyleCapture_YarnId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleCapture_FabricId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsagesPercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWastagePercentage1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FabricTypeLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents KnittingTypeDataSet As KSoft_Apparel.KnittingTypeDataSet
    Friend WithEvents KnittingTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KnittingTypeTableAdapter As KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter
    Friend WithEvents CompositionLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents CompositionDataSet As KSoft_Apparel.CompositionDataSet
    Friend WithEvents CompositionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompositionTableAdapter As KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter
    Friend WithEvents GarmentsPartLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GarmentsPartDataSet As KSoft_Apparel.GarmentsPartDataSet
    Friend WithEvents GarmentsPartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GarmentsPartTableAdapter As KSoft_Apparel.GarmentsPartDataSetTableAdapters.GarmentsPartTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListLookupDataSet As KSoft_Apparel.ItemListLookupDataSet
    Friend WithEvents ItemListTableAdapter As KSoft_Apparel.ItemListLookupDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GSMDataSet As KSoft_Apparel.GSMDataSet
    Friend WithEvents GSMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GSMTableAdapter As KSoft_Apparel.GSMDataSetTableAdapters.GSMTableAdapter
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StyleLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StyleLookupDataSet As KSoft_Apparel.StyleLookupDataSet
    Friend WithEvents StyleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleTableAdapter As KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents UnitDataSet As KSoft_Apparel.UnitDataSet
    Friend WithEvents UnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitTableAdapter As KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents StyleController1 As DevExpress.XtraEditors.StyleController
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYdsColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYdsPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents YarnListGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents colIsYd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FabricFinishingTypeDataSet As KSoft_Apparel.FabricFinishingTypeDataSet
    Friend WithEvents FabricFinishingTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricFinishingTypeTableAdapter As KSoft_Apparel.FabricFinishingTypeDataSetTableAdapters.FabricFinishingTypeTableAdapter
    Friend WithEvents TableAdapterManager1 As KSoft_Apparel.FabricFinishingTypeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StyleCapture_FinishingTableAdapter As KSoft_Apparel.StyleCaptureFabricDataSetTableAdapters.StyleCapture_FinishingTableAdapter
    Friend WithEvents DyeingTypeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DyeingTypeDataSet As KSoft_Apparel.DyeingTypeDataSet
    Friend WithEvents DyeingTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DyeingTypeTableAdapter As KSoft_Apparel.DyeingTypeDataSetTableAdapters.DyeingTypeTableAdapter
    Friend WithEvents colDyeingTypeId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDyeingType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StyleCapture_FinishingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleCapture_FinishingGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colStyleCapture_FinishingId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleCapture_FabricId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinishingTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FinishingTypeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPricePerKg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents colFinishingType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricFinishingTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents colKnittingTypeId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCompositionId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDiaType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDUnit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGSMId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colWastagePercentage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGarmentsPartId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colConsumption As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFUnitId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGarmentsQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIsAOP As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIsYDS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSPNote As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSPNoteDetails As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colYDSDescription As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAOPDescription As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIsYarnAllocated As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDyeingTypeId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLengthAllowance As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMarkerLengthInch As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMarkerLengthYrds As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMarkerWidth As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colWidthAllowance As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents colKgPerUnit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
