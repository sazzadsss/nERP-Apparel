<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuttingBundleTracking
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
        Dim IssuedBranchIdLabel As System.Windows.Forms.Label
        Dim IssuedLineIdLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCuttingBundleTracking))
        Me.CuttingBundleTrackingDataSet = New KSoft_Apparel.CuttingBundleTrackingDataSet
        Me.CuttingBundleTrackingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuttingBundleTrackingTableAdapter = New KSoft_Apparel.CuttingBundleTrackingDataSetTableAdapters.CuttingBundleTrackingTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.CuttingBundleTrackingDataSetTableAdapters.TableAdapterManager
        Me.CuttingBundleTrackingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.CuttingBundleTrackingBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.CuttingBundleTrackingGridControl = New DevExpress.XtraGrid.GridControl
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colCuttingBundleTrackingDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colBranchId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colLineId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colBundleNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colExcessPanel = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colRemarks = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colFabricRejection = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPrintRejection = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCuttingRejection = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCuttingReplaced = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colMatchingReplaced = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colQCPassed = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colPrintSend = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPrintReceived = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colEmbroiderySend = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colEmbroideryReceived = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colInputQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colIssuedBranchId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.IssuedBranchGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Apparel.BranchDataSet
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colBranchCode1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIssuedLineId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.LineItemGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.LineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LineDataSet = New KSoft_Apparel.LineDataSet
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colLine1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label2 = New System.Windows.Forms.Label
        Me.BundleNoTextBox = New System.Windows.Forms.TextBox
        Me.AddButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.CuttingNoTextBox = New System.Windows.Forms.TextBox
        Me.IssuedLineIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.IssuedLineIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colLine = New DevExpress.XtraGrid.Columns.GridColumn
        Me.IssuedBranchIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.IssuedBranchIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colBranchCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBranchName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CuttingBundleSummeryGridControl = New DevExpress.XtraGrid.GridControl
        Me.CuttingBundleSummeryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuttingBundleSummerDataSet = New KSoft_Apparel.CuttingBundleSummerDataSet
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCuttingProductionNewId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCuttingNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStyleNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBundleNo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricColorId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBatchNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRollWeight = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSizeId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSizeCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCuttingQuantity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCuttingRejection1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricRejection1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrintRejection1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCuttingReplaced1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMatchingReplaced1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrintSend1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrintReceived1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQCPassed1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colInputQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExcessPanel1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEmbroiderySend1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEmbroideryReceived1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ShowByBranchAndDateButton = New System.Windows.Forms.Button
        Me.ShowBundleStatusButton = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.BranchComboBox = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.LineTableAdapter = New KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter
        Me.BranchTableAdapter = New KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
        Me.CuttingBundleSummeryTableAdapter = New KSoft_Apparel.CuttingBundleSummerDataSetTableAdapters.CuttingBundleSummeryTableAdapter
        Me.TableAdapterManager1 = New KSoft_Apparel.CuttingBundleSummerDataSetTableAdapters.TableAdapterManager
        IssuedBranchIdLabel = New System.Windows.Forms.Label
        IssuedLineIdLabel = New System.Windows.Forms.Label
        CType(Me.CuttingBundleTrackingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingBundleTrackingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingBundleTrackingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CuttingBundleTrackingBindingNavigator.SuspendLayout()
        CType(Me.CuttingBundleTrackingGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssuedBranchGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.IssuedLineIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssuedLineIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssuedBranchIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssuedBranchIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingBundleSummeryGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingBundleSummeryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingBundleSummerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IssuedBranchIdLabel
        '
        IssuedBranchIdLabel.AutoSize = True
        IssuedBranchIdLabel.Location = New System.Drawing.Point(29, 14)
        IssuedBranchIdLabel.Name = "IssuedBranchIdLabel"
        IssuedBranchIdLabel.Size = New System.Drawing.Size(140, 13)
        IssuedBranchIdLabel.TabIndex = 6
        IssuedBranchIdLabel.Text = "Issued to  / Receved From :"
        '
        'IssuedLineIdLabel
        '
        IssuedLineIdLabel.AutoSize = True
        IssuedLineIdLabel.Location = New System.Drawing.Point(293, 14)
        IssuedLineIdLabel.Name = "IssuedLineIdLabel"
        IssuedLineIdLabel.Size = New System.Drawing.Size(33, 13)
        IssuedLineIdLabel.TabIndex = 7
        IssuedLineIdLabel.Text = "Line :"
        '
        'CuttingBundleTrackingDataSet
        '
        Me.CuttingBundleTrackingDataSet.DataSetName = "CuttingBundleTrackingDataSet"
        Me.CuttingBundleTrackingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CuttingBundleTrackingBindingSource
        '
        Me.CuttingBundleTrackingBindingSource.DataMember = "CuttingBundleTracking"
        Me.CuttingBundleTrackingBindingSource.DataSource = Me.CuttingBundleTrackingDataSet
        '
        'CuttingBundleTrackingTableAdapter
        '
        Me.CuttingBundleTrackingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CuttingBundleTrackingTableAdapter = Me.CuttingBundleTrackingTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.CuttingBundleTrackingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CuttingBundleTrackingBindingNavigator
        '
        Me.CuttingBundleTrackingBindingNavigator.AddNewItem = Nothing
        Me.CuttingBundleTrackingBindingNavigator.BindingSource = Me.CuttingBundleTrackingBindingSource
        Me.CuttingBundleTrackingBindingNavigator.CountItem = Nothing
        Me.CuttingBundleTrackingBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CuttingBundleTrackingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorDeleteItem, Me.CuttingBundleTrackingBindingNavigatorSaveItem})
        Me.CuttingBundleTrackingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CuttingBundleTrackingBindingNavigator.MoveFirstItem = Nothing
        Me.CuttingBundleTrackingBindingNavigator.MoveLastItem = Nothing
        Me.CuttingBundleTrackingBindingNavigator.MoveNextItem = Nothing
        Me.CuttingBundleTrackingBindingNavigator.MovePreviousItem = Nothing
        Me.CuttingBundleTrackingBindingNavigator.Name = "CuttingBundleTrackingBindingNavigator"
        Me.CuttingBundleTrackingBindingNavigator.PositionItem = Nothing
        Me.CuttingBundleTrackingBindingNavigator.Size = New System.Drawing.Size(1072, 25)
        Me.CuttingBundleTrackingBindingNavigator.TabIndex = 0
        Me.CuttingBundleTrackingBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CuttingBundleTrackingBindingNavigatorSaveItem
        '
        Me.CuttingBundleTrackingBindingNavigatorSaveItem.Image = CType(resources.GetObject("CuttingBundleTrackingBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CuttingBundleTrackingBindingNavigatorSaveItem.Name = "CuttingBundleTrackingBindingNavigatorSaveItem"
        Me.CuttingBundleTrackingBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.CuttingBundleTrackingBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CuttingBundleTrackingGridControl
        '
        Me.CuttingBundleTrackingGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuttingBundleTrackingGridControl.DataSource = Me.CuttingBundleTrackingBindingSource
        Me.CuttingBundleTrackingGridControl.Location = New System.Drawing.Point(0, 42)
        Me.CuttingBundleTrackingGridControl.MainView = Me.BandedGridView1
        Me.CuttingBundleTrackingGridControl.Name = "CuttingBundleTrackingGridControl"
        Me.CuttingBundleTrackingGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.IssuedBranchGridLookUpEdit, Me.LineItemGridLookUpEdit})
        Me.CuttingBundleTrackingGridControl.Size = New System.Drawing.Size(1072, 321)
        Me.CuttingBundleTrackingGridControl.TabIndex = 5
        Me.CuttingBundleTrackingGridControl.UseEmbeddedNavigator = True
        Me.CuttingBundleTrackingGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1, Me.GridView2})
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.BandedGridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.GridBand2, Me.GridBand3, Me.GridBand4, Me.GridBand5, Me.GridBand6})
        Me.BandedGridView1.ColumnPanelRowHeight = 40
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colBranchId, Me.colCuttingBundleTrackingDate, Me.colBundleNo, Me.colQuantity, Me.colCuttingRejection, Me.colFabricRejection, Me.colPrintRejection, Me.colCuttingReplaced, Me.colMatchingReplaced, Me.colPrintSend, Me.colPrintReceived, Me.colQCPassed, Me.colInputQuantity, Me.colExcessPanel, Me.colRemarks, Me.colEmbroiderySend, Me.colEmbroideryReceived, Me.colLineId, Me.colIssuedBranchId, Me.colIssuedLineId})
        Me.BandedGridView1.GridControl = Me.CuttingBundleTrackingGridControl
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView1.OptionsView.ShowAutoFilterRow = True
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Cutting"
        Me.GridBand1.Columns.Add(Me.colCuttingBundleTrackingDate)
        Me.GridBand1.Columns.Add(Me.colBranchId)
        Me.GridBand1.Columns.Add(Me.colLineId)
        Me.GridBand1.Columns.Add(Me.colBundleNo)
        Me.GridBand1.Columns.Add(Me.colQuantity)
        Me.GridBand1.Columns.Add(Me.colExcessPanel)
        Me.GridBand1.Columns.Add(Me.colRemarks)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 440
        '
        'colCuttingBundleTrackingDate
        '
        Me.colCuttingBundleTrackingDate.Caption = "Production Date"
        Me.colCuttingBundleTrackingDate.FieldName = "CuttingBundleTrackingDate"
        Me.colCuttingBundleTrackingDate.Name = "colCuttingBundleTrackingDate"
        Me.colCuttingBundleTrackingDate.Visible = True
        Me.colCuttingBundleTrackingDate.Width = 68
        '
        'colBranchId
        '
        Me.colBranchId.Caption = "Branch"
        Me.colBranchId.FieldName = "BranchId"
        Me.colBranchId.Name = "colBranchId"
        Me.colBranchId.Visible = True
        Me.colBranchId.Width = 78
        '
        'colLineId
        '
        Me.colLineId.Caption = "Line"
        Me.colLineId.FieldName = "LineId"
        Me.colLineId.Name = "colLineId"
        Me.colLineId.Visible = True
        Me.colLineId.Width = 63
        '
        'colBundleNo
        '
        Me.colBundleNo.FieldName = "BundleNo"
        Me.colBundleNo.Name = "colBundleNo"
        Me.colBundleNo.Visible = True
        Me.colBundleNo.Width = 65
        '
        'colQuantity
        '
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Visible = True
        Me.colQuantity.Width = 54
        '
        'colExcessPanel
        '
        Me.colExcessPanel.FieldName = "ExcessPanel"
        Me.colExcessPanel.Name = "colExcessPanel"
        Me.colExcessPanel.Visible = True
        Me.colExcessPanel.Width = 49
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.Width = 63
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "QC"
        Me.GridBand2.Columns.Add(Me.colFabricRejection)
        Me.GridBand2.Columns.Add(Me.colPrintRejection)
        Me.GridBand2.Columns.Add(Me.colCuttingRejection)
        Me.GridBand2.Columns.Add(Me.colCuttingReplaced)
        Me.GridBand2.Columns.Add(Me.colMatchingReplaced)
        Me.GridBand2.Columns.Add(Me.colQCPassed)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 339
        '
        'colFabricRejection
        '
        Me.colFabricRejection.FieldName = "FabricRejection"
        Me.colFabricRejection.Name = "colFabricRejection"
        Me.colFabricRejection.Visible = True
        Me.colFabricRejection.Width = 60
        '
        'colPrintRejection
        '
        Me.colPrintRejection.FieldName = "PrintRejection"
        Me.colPrintRejection.Name = "colPrintRejection"
        Me.colPrintRejection.Visible = True
        Me.colPrintRejection.Width = 53
        '
        'colCuttingRejection
        '
        Me.colCuttingRejection.FieldName = "CuttingRejection"
        Me.colCuttingRejection.Name = "colCuttingRejection"
        Me.colCuttingRejection.Visible = True
        Me.colCuttingRejection.Width = 59
        '
        'colCuttingReplaced
        '
        Me.colCuttingReplaced.FieldName = "CuttingReplaced"
        Me.colCuttingReplaced.Name = "colCuttingReplaced"
        Me.colCuttingReplaced.Visible = True
        Me.colCuttingReplaced.Width = 55
        '
        'colMatchingReplaced
        '
        Me.colMatchingReplaced.FieldName = "MatchingReplaced"
        Me.colMatchingReplaced.Name = "colMatchingReplaced"
        Me.colMatchingReplaced.Visible = True
        Me.colMatchingReplaced.Width = 54
        '
        'colQCPassed
        '
        Me.colQCPassed.FieldName = "QCPassed"
        Me.colQCPassed.Name = "colQCPassed"
        Me.colQCPassed.Visible = True
        Me.colQCPassed.Width = 58
        '
        'GridBand3
        '
        Me.GridBand3.Caption = "Print"
        Me.GridBand3.Columns.Add(Me.colPrintSend)
        Me.GridBand3.Columns.Add(Me.colPrintReceived)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 110
        '
        'colPrintSend
        '
        Me.colPrintSend.FieldName = "PrintSend"
        Me.colPrintSend.Name = "colPrintSend"
        Me.colPrintSend.Visible = True
        Me.colPrintSend.Width = 52
        '
        'colPrintReceived
        '
        Me.colPrintReceived.FieldName = "PrintReceived"
        Me.colPrintReceived.Name = "colPrintReceived"
        Me.colPrintReceived.Visible = True
        Me.colPrintReceived.Width = 58
        '
        'GridBand4
        '
        Me.GridBand4.Caption = "Embroidery"
        Me.GridBand4.Columns.Add(Me.colEmbroiderySend)
        Me.GridBand4.Columns.Add(Me.colEmbroideryReceived)
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.Width = 143
        '
        'colEmbroiderySend
        '
        Me.colEmbroiderySend.FieldName = "EmbroiderySend"
        Me.colEmbroiderySend.Name = "colEmbroiderySend"
        Me.colEmbroiderySend.Visible = True
        Me.colEmbroiderySend.Width = 72
        '
        'colEmbroideryReceived
        '
        Me.colEmbroideryReceived.FieldName = "EmbroideryReceived"
        Me.colEmbroideryReceived.Name = "colEmbroideryReceived"
        Me.colEmbroideryReceived.Visible = True
        Me.colEmbroideryReceived.Width = 71
        '
        'GridBand5
        '
        Me.GridBand5.Caption = "Sewing"
        Me.GridBand5.Columns.Add(Me.colInputQuantity)
        Me.GridBand5.Name = "GridBand5"
        Me.GridBand5.Width = 80
        '
        'colInputQuantity
        '
        Me.colInputQuantity.FieldName = "InputQuantity"
        Me.colInputQuantity.Name = "colInputQuantity"
        Me.colInputQuantity.Visible = True
        Me.colInputQuantity.Width = 80
        '
        'GridBand6
        '
        Me.GridBand6.Caption = "Issued to / Received From"
        Me.GridBand6.Columns.Add(Me.colIssuedBranchId)
        Me.GridBand6.Columns.Add(Me.colIssuedLineId)
        Me.GridBand6.Name = "GridBand6"
        Me.GridBand6.Width = 150
        '
        'colIssuedBranchId
        '
        Me.colIssuedBranchId.Caption = "Branch"
        Me.colIssuedBranchId.ColumnEdit = Me.IssuedBranchGridLookUpEdit
        Me.colIssuedBranchId.FieldName = "IssuedBranchId"
        Me.colIssuedBranchId.Name = "colIssuedBranchId"
        Me.colIssuedBranchId.Visible = True
        '
        'IssuedBranchGridLookUpEdit
        '
        Me.IssuedBranchGridLookUpEdit.AutoHeight = False
        Me.IssuedBranchGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IssuedBranchGridLookUpEdit.DataSource = Me.BranchBindingSource
        Me.IssuedBranchGridLookUpEdit.DisplayMember = "BranchCode"
        Me.IssuedBranchGridLookUpEdit.Name = "IssuedBranchGridLookUpEdit"
        Me.IssuedBranchGridLookUpEdit.NullText = ""
        Me.IssuedBranchGridLookUpEdit.ValueMember = "BranchId"
        Me.IssuedBranchGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
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
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBranchCode1})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colBranchCode1
        '
        Me.colBranchCode1.FieldName = "BranchCode"
        Me.colBranchCode1.Name = "colBranchCode1"
        Me.colBranchCode1.Visible = True
        Me.colBranchCode1.VisibleIndex = 0
        '
        'colIssuedLineId
        '
        Me.colIssuedLineId.Caption = "Issued Line"
        Me.colIssuedLineId.ColumnEdit = Me.LineItemGridLookUpEdit
        Me.colIssuedLineId.FieldName = "IssuedLineId"
        Me.colIssuedLineId.Name = "colIssuedLineId"
        Me.colIssuedLineId.Visible = True
        '
        'LineItemGridLookUpEdit
        '
        Me.LineItemGridLookUpEdit.AutoHeight = False
        Me.LineItemGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LineItemGridLookUpEdit.DataSource = Me.LineBindingSource
        Me.LineItemGridLookUpEdit.DisplayMember = "Line"
        Me.LineItemGridLookUpEdit.Name = "LineItemGridLookUpEdit"
        Me.LineItemGridLookUpEdit.ValueMember = "LineId"
        Me.LineItemGridLookUpEdit.View = Me.GridView3
        '
        'LineBindingSource
        '
        Me.LineBindingSource.DataMember = "Line"
        Me.LineBindingSource.DataSource = Me.LineDataSet
        '
        'LineDataSet
        '
        Me.LineDataSet.DataSetName = "LineDataSet"
        Me.LineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLine1})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colLine1
        '
        Me.colLine1.FieldName = "Line"
        Me.colLine1.Name = "colLine1"
        Me.colLine1.Visible = True
        Me.colLine1.VisibleIndex = 0
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.CuttingBundleTrackingGridControl
        Me.GridView2.Name = "GridView2"
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
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BundleNoTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AddButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CuttingNoTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(IssuedLineIdLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.IssuedLineIdGridLookUpEdit)
        Me.SplitContainer1.Panel1.Controls.Add(IssuedBranchIdLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.IssuedBranchIdGridLookUpEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CuttingBundleTrackingGridControl)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.CuttingBundleSummeryGridControl)
        Me.SplitContainer1.Size = New System.Drawing.Size(1072, 483)
        Me.SplitContainer1.SplitterDistance = 365
        Me.SplitContainer1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(619, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "B"
        '
        'BundleNoTextBox
        '
        Me.BundleNoTextBox.BackColor = System.Drawing.Color.Yellow
        Me.BundleNoTextBox.Location = New System.Drawing.Point(636, 11)
        Me.BundleNoTextBox.Name = "BundleNoTextBox"
        Me.BundleNoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BundleNoTextBox.TabIndex = 3
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(744, 9)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 4
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(455, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Bundle No :"
        '
        'CuttingNoTextBox
        '
        Me.CuttingNoTextBox.BackColor = System.Drawing.Color.Yellow
        Me.CuttingNoTextBox.Location = New System.Drawing.Point(524, 11)
        Me.CuttingNoTextBox.Name = "CuttingNoTextBox"
        Me.CuttingNoTextBox.Size = New System.Drawing.Size(91, 20)
        Me.CuttingNoTextBox.TabIndex = 2
        '
        'IssuedLineIdGridLookUpEdit
        '
        Me.IssuedLineIdGridLookUpEdit.Location = New System.Drawing.Point(332, 11)
        Me.IssuedLineIdGridLookUpEdit.Name = "IssuedLineIdGridLookUpEdit"
        Me.IssuedLineIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IssuedLineIdGridLookUpEdit.Properties.DataSource = Me.LineBindingSource
        Me.IssuedLineIdGridLookUpEdit.Properties.DisplayMember = "Line"
        Me.IssuedLineIdGridLookUpEdit.Properties.NullText = ""
        Me.IssuedLineIdGridLookUpEdit.Properties.ValueMember = "LineId"
        Me.IssuedLineIdGridLookUpEdit.Properties.View = Me.IssuedLineIdGridLookUpEditView
        Me.IssuedLineIdGridLookUpEdit.Size = New System.Drawing.Size(108, 20)
        Me.IssuedLineIdGridLookUpEdit.TabIndex = 1
        '
        'IssuedLineIdGridLookUpEditView
        '
        Me.IssuedLineIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLine})
        Me.IssuedLineIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.IssuedLineIdGridLookUpEditView.Name = "IssuedLineIdGridLookUpEditView"
        Me.IssuedLineIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.IssuedLineIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colLine
        '
        Me.colLine.FieldName = "Line"
        Me.colLine.Name = "colLine"
        Me.colLine.Visible = True
        Me.colLine.VisibleIndex = 0
        '
        'IssuedBranchIdGridLookUpEdit
        '
        Me.IssuedBranchIdGridLookUpEdit.Location = New System.Drawing.Point(175, 12)
        Me.IssuedBranchIdGridLookUpEdit.Name = "IssuedBranchIdGridLookUpEdit"
        Me.IssuedBranchIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IssuedBranchIdGridLookUpEdit.Properties.DataSource = Me.BranchBindingSource
        Me.IssuedBranchIdGridLookUpEdit.Properties.DisplayMember = "BranchCode"
        Me.IssuedBranchIdGridLookUpEdit.Properties.NullText = ""
        Me.IssuedBranchIdGridLookUpEdit.Properties.ValueMember = "BranchId"
        Me.IssuedBranchIdGridLookUpEdit.Properties.View = Me.IssuedBranchIdGridLookUpEditView
        Me.IssuedBranchIdGridLookUpEdit.Size = New System.Drawing.Size(112, 20)
        Me.IssuedBranchIdGridLookUpEdit.TabIndex = 0
        '
        'IssuedBranchIdGridLookUpEditView
        '
        Me.IssuedBranchIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBranchCode, Me.colBranchName})
        Me.IssuedBranchIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.IssuedBranchIdGridLookUpEditView.Name = "IssuedBranchIdGridLookUpEditView"
        Me.IssuedBranchIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.IssuedBranchIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colBranchCode
        '
        Me.colBranchCode.FieldName = "BranchCode"
        Me.colBranchCode.Name = "colBranchCode"
        Me.colBranchCode.Visible = True
        Me.colBranchCode.VisibleIndex = 0
        '
        'colBranchName
        '
        Me.colBranchName.FieldName = "BranchName"
        Me.colBranchName.Name = "colBranchName"
        Me.colBranchName.Visible = True
        Me.colBranchName.VisibleIndex = 1
        '
        'CuttingBundleSummeryGridControl
        '
        Me.CuttingBundleSummeryGridControl.DataSource = Me.CuttingBundleSummeryBindingSource
        Me.CuttingBundleSummeryGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CuttingBundleSummeryGridControl.Location = New System.Drawing.Point(0, 0)
        Me.CuttingBundleSummeryGridControl.MainView = Me.GridView1
        Me.CuttingBundleSummeryGridControl.Name = "CuttingBundleSummeryGridControl"
        Me.CuttingBundleSummeryGridControl.Size = New System.Drawing.Size(1072, 114)
        Me.CuttingBundleSummeryGridControl.TabIndex = 0
        Me.CuttingBundleSummeryGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'CuttingBundleSummeryBindingSource
        '
        Me.CuttingBundleSummeryBindingSource.DataMember = "CuttingBundleSummery"
        Me.CuttingBundleSummeryBindingSource.DataSource = Me.CuttingBundleSummerDataSet
        '
        'CuttingBundleSummerDataSet
        '
        Me.CuttingBundleSummerDataSet.DataSetName = "CuttingBundleSummerDataSet"
        Me.CuttingBundleSummerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCuttingProductionNewId, Me.colCuttingNo, Me.colProgramNo, Me.colBuyerName, Me.colStyleNo, Me.colBundleNo1, Me.colOrderId, Me.colFabricColorId, Me.colFabricColorName, Me.colBatchNo, Me.colRollWeight, Me.colSizeId, Me.colSizeCode, Me.colCuttingQuantity, Me.colCuttingRejection1, Me.colFabricRejection1, Me.colPrintRejection1, Me.colCuttingReplaced1, Me.colMatchingReplaced1, Me.colPrintSend1, Me.colPrintReceived1, Me.colQCPassed1, Me.colInputQuantity1, Me.colExcessPanel1, Me.colEmbroiderySend1, Me.colEmbroideryReceived1})
        Me.GridView1.GridControl = Me.CuttingBundleSummeryGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCuttingProductionNewId
        '
        Me.colCuttingProductionNewId.AppearanceHeader.Options.UseTextOptions = True
        Me.colCuttingProductionNewId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCuttingProductionNewId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCuttingProductionNewId.FieldName = "CuttingProductionNewId"
        Me.colCuttingProductionNewId.Name = "colCuttingProductionNewId"
        Me.colCuttingProductionNewId.Width = 149
        '
        'colCuttingNo
        '
        Me.colCuttingNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCuttingNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCuttingNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCuttingNo.FieldName = "CuttingNo"
        Me.colCuttingNo.Name = "colCuttingNo"
        Me.colCuttingNo.Visible = True
        Me.colCuttingNo.VisibleIndex = 0
        '
        'colProgramNo
        '
        Me.colProgramNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colProgramNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProgramNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 1
        '
        'colBuyerName
        '
        Me.colBuyerName.AppearanceHeader.Options.UseTextOptions = True
        Me.colBuyerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBuyerName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 2
        '
        'colStyleNo
        '
        Me.colStyleNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colStyleNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStyleNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStyleNo.FieldName = "StyleNo"
        Me.colStyleNo.Name = "colStyleNo"
        Me.colStyleNo.Visible = True
        Me.colStyleNo.VisibleIndex = 3
        '
        'colBundleNo1
        '
        Me.colBundleNo1.AppearanceHeader.Options.UseTextOptions = True
        Me.colBundleNo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBundleNo1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBundleNo1.FieldName = "BundleNo"
        Me.colBundleNo1.Name = "colBundleNo1"
        Me.colBundleNo1.Visible = True
        Me.colBundleNo1.VisibleIndex = 4
        '
        'colOrderId
        '
        Me.colOrderId.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrderId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrderId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOrderId.FieldName = "OrderId"
        Me.colOrderId.Name = "colOrderId"
        '
        'colFabricColorId
        '
        Me.colFabricColorId.AppearanceHeader.Options.UseTextOptions = True
        Me.colFabricColorId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFabricColorId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFabricColorId.FieldName = "FabricColorId"
        Me.colFabricColorId.Name = "colFabricColorId"
        '
        'colFabricColorName
        '
        Me.colFabricColorName.AppearanceHeader.Options.UseTextOptions = True
        Me.colFabricColorName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFabricColorName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        Me.colFabricColorName.Visible = True
        Me.colFabricColorName.VisibleIndex = 5
        Me.colFabricColorName.Width = 110
        '
        'colBatchNo
        '
        Me.colBatchNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colBatchNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBatchNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBatchNo.FieldName = "BatchNo"
        Me.colBatchNo.Name = "colBatchNo"
        Me.colBatchNo.Visible = True
        Me.colBatchNo.VisibleIndex = 6
        '
        'colRollWeight
        '
        Me.colRollWeight.AppearanceHeader.Options.UseTextOptions = True
        Me.colRollWeight.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRollWeight.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRollWeight.FieldName = "RollWeight"
        Me.colRollWeight.Name = "colRollWeight"
        Me.colRollWeight.Visible = True
        Me.colRollWeight.VisibleIndex = 7
        '
        'colSizeId
        '
        Me.colSizeId.AppearanceHeader.Options.UseTextOptions = True
        Me.colSizeId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSizeId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSizeId.FieldName = "SizeId"
        Me.colSizeId.Name = "colSizeId"
        '
        'colSizeCode
        '
        Me.colSizeCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colSizeCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSizeCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSizeCode.FieldName = "SizeCode"
        Me.colSizeCode.Name = "colSizeCode"
        Me.colSizeCode.Visible = True
        Me.colSizeCode.VisibleIndex = 8
        '
        'colCuttingQuantity
        '
        Me.colCuttingQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colCuttingQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCuttingQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCuttingQuantity.FieldName = "CuttingQuantity"
        Me.colCuttingQuantity.Name = "colCuttingQuantity"
        Me.colCuttingQuantity.Visible = True
        Me.colCuttingQuantity.VisibleIndex = 9
        '
        'colCuttingRejection1
        '
        Me.colCuttingRejection1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCuttingRejection1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCuttingRejection1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCuttingRejection1.FieldName = "CuttingRejection"
        Me.colCuttingRejection1.Name = "colCuttingRejection1"
        Me.colCuttingRejection1.Visible = True
        Me.colCuttingRejection1.VisibleIndex = 10
        '
        'colFabricRejection1
        '
        Me.colFabricRejection1.AppearanceHeader.Options.UseTextOptions = True
        Me.colFabricRejection1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFabricRejection1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFabricRejection1.FieldName = "FabricRejection"
        Me.colFabricRejection1.Name = "colFabricRejection1"
        Me.colFabricRejection1.Visible = True
        Me.colFabricRejection1.VisibleIndex = 11
        '
        'colPrintRejection1
        '
        Me.colPrintRejection1.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrintRejection1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrintRejection1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPrintRejection1.FieldName = "PrintRejection"
        Me.colPrintRejection1.Name = "colPrintRejection1"
        Me.colPrintRejection1.Visible = True
        Me.colPrintRejection1.VisibleIndex = 12
        '
        'colCuttingReplaced1
        '
        Me.colCuttingReplaced1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCuttingReplaced1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCuttingReplaced1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCuttingReplaced1.FieldName = "CuttingReplaced"
        Me.colCuttingReplaced1.Name = "colCuttingReplaced1"
        Me.colCuttingReplaced1.Visible = True
        Me.colCuttingReplaced1.VisibleIndex = 13
        '
        'colMatchingReplaced1
        '
        Me.colMatchingReplaced1.AppearanceHeader.Options.UseTextOptions = True
        Me.colMatchingReplaced1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMatchingReplaced1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMatchingReplaced1.FieldName = "MatchingReplaced"
        Me.colMatchingReplaced1.Name = "colMatchingReplaced1"
        Me.colMatchingReplaced1.Visible = True
        Me.colMatchingReplaced1.VisibleIndex = 14
        '
        'colPrintSend1
        '
        Me.colPrintSend1.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrintSend1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrintSend1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPrintSend1.FieldName = "PrintSend"
        Me.colPrintSend1.Name = "colPrintSend1"
        Me.colPrintSend1.Visible = True
        Me.colPrintSend1.VisibleIndex = 15
        '
        'colPrintReceived1
        '
        Me.colPrintReceived1.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrintReceived1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrintReceived1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPrintReceived1.FieldName = "PrintReceived"
        Me.colPrintReceived1.Name = "colPrintReceived1"
        Me.colPrintReceived1.Visible = True
        Me.colPrintReceived1.VisibleIndex = 16
        '
        'colQCPassed1
        '
        Me.colQCPassed1.AppearanceHeader.Options.UseTextOptions = True
        Me.colQCPassed1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQCPassed1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colQCPassed1.FieldName = "QCPassed"
        Me.colQCPassed1.Name = "colQCPassed1"
        Me.colQCPassed1.Visible = True
        Me.colQCPassed1.VisibleIndex = 17
        '
        'colInputQuantity1
        '
        Me.colInputQuantity1.AppearanceHeader.Options.UseTextOptions = True
        Me.colInputQuantity1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInputQuantity1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInputQuantity1.FieldName = "InputQuantity"
        Me.colInputQuantity1.Name = "colInputQuantity1"
        Me.colInputQuantity1.Visible = True
        Me.colInputQuantity1.VisibleIndex = 18
        '
        'colExcessPanel1
        '
        Me.colExcessPanel1.AppearanceHeader.Options.UseTextOptions = True
        Me.colExcessPanel1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExcessPanel1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colExcessPanel1.FieldName = "ExcessPanel"
        Me.colExcessPanel1.Name = "colExcessPanel1"
        Me.colExcessPanel1.Visible = True
        Me.colExcessPanel1.VisibleIndex = 19
        '
        'colEmbroiderySend1
        '
        Me.colEmbroiderySend1.AppearanceHeader.Options.UseTextOptions = True
        Me.colEmbroiderySend1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmbroiderySend1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEmbroiderySend1.FieldName = "EmbroiderySend"
        Me.colEmbroiderySend1.Name = "colEmbroiderySend1"
        Me.colEmbroiderySend1.Visible = True
        Me.colEmbroiderySend1.VisibleIndex = 20
        '
        'colEmbroideryReceived1
        '
        Me.colEmbroideryReceived1.AppearanceHeader.Options.UseTextOptions = True
        Me.colEmbroideryReceived1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmbroideryReceived1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEmbroideryReceived1.FieldName = "EmbroideryReceived"
        Me.colEmbroideryReceived1.Name = "colEmbroideryReceived1"
        Me.colEmbroideryReceived1.Visible = True
        Me.colEmbroideryReceived1.VisibleIndex = 21
        '
        'ShowByBranchAndDateButton
        '
        Me.ShowByBranchAndDateButton.Location = New System.Drawing.Point(561, 1)
        Me.ShowByBranchAndDateButton.Name = "ShowByBranchAndDateButton"
        Me.ShowByBranchAndDateButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowByBranchAndDateButton.TabIndex = 3
        Me.ShowByBranchAndDateButton.Text = "Show"
        Me.ShowByBranchAndDateButton.UseVisualStyleBackColor = True
        '
        'ShowBundleStatusButton
        '
        Me.ShowBundleStatusButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowBundleStatusButton.Location = New System.Drawing.Point(947, 2)
        Me.ShowBundleStatusButton.Name = "ShowBundleStatusButton"
        Me.ShowBundleStatusButton.Size = New System.Drawing.Size(121, 23)
        Me.ShowBundleStatusButton.TabIndex = 7
        Me.ShowBundleStatusButton.Text = "&Show Bundle Status"
        Me.ShowBundleStatusButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(190, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Production Date :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(286, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'BranchComboBox
        '
        Me.BranchComboBox.DataSource = Me.BranchBindingSource
        Me.BranchComboBox.DisplayMember = "BranchCode"
        Me.BranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BranchComboBox.FormattingEnabled = True
        Me.BranchComboBox.Location = New System.Drawing.Point(447, 2)
        Me.BranchComboBox.Name = "BranchComboBox"
        Me.BranchComboBox.Size = New System.Drawing.Size(108, 21)
        Me.BranchComboBox.TabIndex = 2
        Me.BranchComboBox.ValueMember = "BranchId"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(400, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Branch"
        '
        'LineTableAdapter
        '
        Me.LineTableAdapter.ClearBeforeFill = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'CuttingBundleSummeryTableAdapter
        '
        Me.CuttingBundleSummeryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = KSoft_Apparel.CuttingBundleSummerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmCuttingBundleTracking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 508)
        Me.Controls.Add(Me.BranchComboBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ShowByBranchAndDateButton)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ShowBundleStatusButton)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.CuttingBundleTrackingBindingNavigator)
        Me.Name = "frmCuttingBundleTracking"
        Me.Text = "Cutting Bundle Information"
        CType(Me.CuttingBundleTrackingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingBundleTrackingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingBundleTrackingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CuttingBundleTrackingBindingNavigator.ResumeLayout(False)
        Me.CuttingBundleTrackingBindingNavigator.PerformLayout()
        CType(Me.CuttingBundleTrackingGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssuedBranchGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.IssuedLineIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssuedLineIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssuedBranchIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssuedBranchIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingBundleSummeryGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingBundleSummeryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingBundleSummerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CuttingBundleTrackingDataSet As KSoft_Apparel.CuttingBundleTrackingDataSet
    Friend WithEvents CuttingBundleTrackingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CuttingBundleTrackingTableAdapter As KSoft_Apparel.CuttingBundleTrackingDataSetTableAdapters.CuttingBundleTrackingTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.CuttingBundleTrackingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CuttingBundleTrackingBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CuttingBundleTrackingBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CuttingBundleTrackingGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents colBranchId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCuttingBundleTrackingDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBundleNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colExcessPanel As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFabricRejection As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrintRejection As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCuttingRejection As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCuttingReplaced As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMatchingReplaced As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colQCPassed As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrintSend As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrintReceived As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colEmbroiderySend As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colEmbroideryReceived As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colInputQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BranchComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents colLineId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents LineDataSet As KSoft_Apparel.LineDataSet
    Friend WithEvents LineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LineTableAdapter As KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter
    Friend WithEvents BranchDataSet As KSoft_Apparel.BranchDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents CuttingBundleSummerDataSet As KSoft_Apparel.CuttingBundleSummerDataSet
    Friend WithEvents CuttingBundleSummeryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CuttingBundleSummeryTableAdapter As KSoft_Apparel.CuttingBundleSummerDataSetTableAdapters.CuttingBundleSummeryTableAdapter
    Friend WithEvents TableAdapterManager1 As KSoft_Apparel.CuttingBundleSummerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CuttingBundleSummeryGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCuttingProductionNewId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCuttingNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBundleNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBatchNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRollWeight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSizeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSizeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCuttingQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCuttingRejection1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricRejection1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintRejection1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCuttingReplaced1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMatchingReplaced1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintSend1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintReceived1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQCPassed1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInputQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExcessPanel1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmbroiderySend1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmbroideryReceived1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShowBundleStatusButton As System.Windows.Forms.Button
    Friend WithEvents ShowByBranchAndDateButton As System.Windows.Forms.Button
    Friend WithEvents IssuedLineIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents IssuedLineIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IssuedBranchIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents IssuedBranchIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBranchCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CuttingNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents BundleNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents colIssuedBranchId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIssuedLineId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents IssuedBranchGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBranchCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LineItemGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colLine1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
