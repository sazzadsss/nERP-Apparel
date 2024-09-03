<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeftOver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLeftOver))
        Me.LeftOverDataSet = New KSoft_Apparel.LeftOverDataSet
        Me.LeftOverBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LeftOverTableAdapter = New KSoft_Apparel.LeftOverDataSetTableAdapters.LeftOverTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.LeftOverDataSetTableAdapters.TableAdapterManager
        Me.LeftOverBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.LeftOverBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.LeftOverGridControl = New DevExpress.XtraGrid.GridControl
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colLeftOverId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colOrderId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colFabricColorId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colLeftOverCategory = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.colLeftOverFor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.colLeftOverQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colUnassortedQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colRunOverQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.OrderFabricColorDataSet = New KSoft_Apparel.OrderFabricColorDataSet
        Me.OrderFabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderFabricColorTableAdapter = New KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet
        Me.Label5 = New System.Windows.Forms.Label
        Me.FabricColorComboBox = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.OrderNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsPrint = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUserId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsMultiPart = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.OrderReconcilationGridControl = New DevExpress.XtraGrid.GridControl
        Me.OrderReconcilationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderReconcilationDataSet = New KSoft_Apparel.OrderReconcilationDataSet
        Me.OrderReconcilationTableAdapter = New KSoft_Apparel.OrderReconcilationDataSetTableAdapters.OrderReconcilationTableAdapter
        Me.TableAdapterManager1 = New KSoft_Apparel.OrderReconcilationDataSetTableAdapters.TableAdapterManager
        Me.BandedGridView2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colProgramNo1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colStyleName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colFabricColorName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colTotalOrderQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colBookingQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colConsumption = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colFabricReceived = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colActualCuttingQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPrintEmbSend = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPrintEmbReceive = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colQCPassQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colInputQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colOutputQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPolyQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colShippmentQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colKnittingProb = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colDyeingProb = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCuttingProb = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPrintProb = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colSewingReject = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colFinishingReject = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colUnassorted = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.gridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.GridBand8 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.GridBand9 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.GridBand10 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        CType(Me.LeftOverDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftOverBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftOverBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LeftOverBindingNavigator.SuspendLayout()
        CType(Me.LeftOverGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.OrderReconcilationGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderReconcilationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderReconcilationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LeftOverDataSet
        '
        Me.LeftOverDataSet.DataSetName = "LeftOverDataSet"
        Me.LeftOverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LeftOverBindingSource
        '
        Me.LeftOverBindingSource.DataMember = "LeftOver"
        Me.LeftOverBindingSource.DataSource = Me.LeftOverDataSet
        '
        'LeftOverTableAdapter
        '
        Me.LeftOverTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LeftOverTableAdapter = Me.LeftOverTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.LeftOverDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LeftOverBindingNavigator
        '
        Me.LeftOverBindingNavigator.AddNewItem = Nothing
        Me.LeftOverBindingNavigator.BindingSource = Me.LeftOverBindingSource
        Me.LeftOverBindingNavigator.CountItem = Nothing
        Me.LeftOverBindingNavigator.DeleteItem = Nothing
        Me.LeftOverBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeftOverBindingNavigatorSaveItem})
        Me.LeftOverBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LeftOverBindingNavigator.MoveFirstItem = Nothing
        Me.LeftOverBindingNavigator.MoveLastItem = Nothing
        Me.LeftOverBindingNavigator.MoveNextItem = Nothing
        Me.LeftOverBindingNavigator.MovePreviousItem = Nothing
        Me.LeftOverBindingNavigator.Name = "LeftOverBindingNavigator"
        Me.LeftOverBindingNavigator.PositionItem = Nothing
        Me.LeftOverBindingNavigator.Size = New System.Drawing.Size(917, 25)
        Me.LeftOverBindingNavigator.TabIndex = 0
        Me.LeftOverBindingNavigator.Text = "BindingNavigator1"
        '
        'LeftOverBindingNavigatorSaveItem
        '
        Me.LeftOverBindingNavigatorSaveItem.Image = CType(resources.GetObject("LeftOverBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LeftOverBindingNavigatorSaveItem.Name = "LeftOverBindingNavigatorSaveItem"
        Me.LeftOverBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.LeftOverBindingNavigatorSaveItem.Text = "Save Data"
        '
        'LeftOverGridControl
        '
        Me.LeftOverGridControl.DataSource = Me.LeftOverBindingSource
        Me.LeftOverGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LeftOverGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.LeftOverGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.LeftOverGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.LeftOverGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.LeftOverGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.LeftOverGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.LeftOverGridControl.Location = New System.Drawing.Point(0, 0)
        Me.LeftOverGridControl.MainView = Me.BandedGridView1
        Me.LeftOverGridControl.Name = "LeftOverGridControl"
        Me.LeftOverGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2})
        Me.LeftOverGridControl.Size = New System.Drawing.Size(917, 149)
        Me.LeftOverGridControl.TabIndex = 1
        Me.LeftOverGridControl.UseEmbeddedNavigator = True
        Me.LeftOverGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1})
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.GridBand2})
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colLeftOverId, Me.colOrderId, Me.colFabricColorId, Me.colUnassortedQuantity, Me.colRunOverQuantity, Me.colLeftOverFor, Me.colLeftOverCategory, Me.colLeftOverQuantity})
        Me.BandedGridView1.GridControl = Me.LeftOverGridControl
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Cause of Left Over"
        Me.GridBand1.Columns.Add(Me.colLeftOverId)
        Me.GridBand1.Columns.Add(Me.colOrderId)
        Me.GridBand1.Columns.Add(Me.colFabricColorId)
        Me.GridBand1.Columns.Add(Me.colLeftOverCategory)
        Me.GridBand1.Columns.Add(Me.colLeftOverFor)
        Me.GridBand1.Columns.Add(Me.colLeftOverQuantity)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 390
        '
        'colLeftOverId
        '
        Me.colLeftOverId.FieldName = "LeftOverId"
        Me.colLeftOverId.Name = "colLeftOverId"
        Me.colLeftOverId.OptionsColumn.ReadOnly = True
        '
        'colOrderId
        '
        Me.colOrderId.FieldName = "OrderId"
        Me.colOrderId.Name = "colOrderId"
        '
        'colFabricColorId
        '
        Me.colFabricColorId.FieldName = "FabricColorId"
        Me.colFabricColorId.Name = "colFabricColorId"
        '
        'colLeftOverCategory
        '
        Me.colLeftOverCategory.ColumnEdit = Me.RepositoryItemComboBox2
        Me.colLeftOverCategory.FieldName = "LeftOverCategory"
        Me.colLeftOverCategory.Name = "colLeftOverCategory"
        Me.colLeftOverCategory.Visible = True
        Me.colLeftOverCategory.Width = 129
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Items.AddRange(New Object() {"Knitting", "Fabrics", "Print", "Sewing", "Finishing"})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'colLeftOverFor
        '
        Me.colLeftOverFor.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colLeftOverFor.FieldName = "LeftOverFor"
        Me.colLeftOverFor.Name = "colLeftOverFor"
        Me.colLeftOverFor.Visible = True
        Me.colLeftOverFor.Width = 129
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"", "Knitting Fault [Knitting]", "Shade [Fabrics]", "Spot [Fabrics]", "Fabric reject [Fabrics]", "Others [Others]", "Shade [Print]", "Reject [Print]", "Cutter [Sewing]", "Reject [Sewing]", "Spot [Finishing]", "Shade [Finishing]", "Measurement [Finishing]", "Without Accessories [Finishing]", "Reject [Finishing]", "Others [Finishing]"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'colLeftOverQuantity
        '
        Me.colLeftOverQuantity.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colLeftOverQuantity.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colLeftOverQuantity.AppearanceCell.Options.UseBackColor = True
        Me.colLeftOverQuantity.FieldName = "LeftOverQuantity"
        Me.colLeftOverQuantity.Name = "colLeftOverQuantity"
        Me.colLeftOverQuantity.Visible = True
        Me.colLeftOverQuantity.Width = 132
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "OK QTY"
        Me.GridBand2.Columns.Add(Me.colUnassortedQuantity)
        Me.GridBand2.Columns.Add(Me.colRunOverQuantity)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 266
        '
        'colUnassortedQuantity
        '
        Me.colUnassortedQuantity.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colUnassortedQuantity.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colUnassortedQuantity.AppearanceCell.Options.UseBackColor = True
        Me.colUnassortedQuantity.FieldName = "UnassortedQuantity"
        Me.colUnassortedQuantity.Name = "colUnassortedQuantity"
        Me.colUnassortedQuantity.Visible = True
        Me.colUnassortedQuantity.Width = 137
        '
        'colRunOverQuantity
        '
        Me.colRunOverQuantity.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colRunOverQuantity.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colRunOverQuantity.AppearanceCell.Options.UseBackColor = True
        Me.colRunOverQuantity.FieldName = "RunOverQuantity"
        Me.colRunOverQuantity.Name = "colRunOverQuantity"
        Me.colRunOverQuantity.Visible = True
        Me.colRunOverQuantity.Width = 129
        '
        'OrderFabricColorDataSet
        '
        Me.OrderFabricColorDataSet.DataSetName = "OrderFabricColorDataSet"
        Me.OrderFabricColorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderFabricColorBindingSource
        '
        Me.OrderFabricColorBindingSource.DataMember = "OrderFabricColor"
        Me.OrderFabricColorBindingSource.DataSource = Me.OrderFabricColorDataSet
        '
        'OrderFabricColorTableAdapter
        '
        Me.OrderFabricColorTableAdapter.ClearBeforeFill = True
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'OrderLookupBindingSource
        '
        Me.OrderLookupBindingSource.DataMember = "OrderLookup"
        Me.OrderLookupBindingSource.DataSource = Me.OrderLookupDataSet
        '
        'OrderLookupDataSet
        '
        Me.OrderLookupDataSet.DataSetName = "OrderLookupDataSet"
        Me.OrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(446, 7)
        Me.Label5.Margin = New System.Windows.Forms.Padding(10, 9, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Color"
        '
        'FabricColorComboBox
        '
        Me.FabricColorComboBox.DataSource = Me.OrderFabricColorBindingSource
        Me.FabricColorComboBox.DisplayMember = "FabricColorName"
        Me.FabricColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FabricColorComboBox.FormattingEnabled = True
        Me.FabricColorComboBox.Location = New System.Drawing.Point(485, 3)
        Me.FabricColorComboBox.Margin = New System.Windows.Forms.Padding(5, 5, 3, 3)
        Me.FabricColorComboBox.Name = "FabricColorComboBox"
        Me.FabricColorComboBox.Size = New System.Drawing.Size(173, 21)
        Me.FabricColorComboBox.TabIndex = 18
        Me.FabricColorComboBox.ValueMember = "FabricColorId"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(229, 6)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Program No"
        '
        'OrderNoGridLookUpEdit
        '
        Me.OrderNoGridLookUpEdit.Location = New System.Drawing.Point(298, 3)
        Me.OrderNoGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.OrderNoGridLookUpEdit.Name = "OrderNoGridLookUpEdit"
        Me.OrderNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderNoGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.OrderNoGridLookUpEdit.Properties.DisplayMember = "ProgramNo"
        Me.OrderNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.OrderNoGridLookUpEdit.Properties.NullText = ""
        Me.OrderNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.OrderNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderNoGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.OrderNoGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.OrderNoGridLookUpEdit.Size = New System.Drawing.Size(135, 20)
        Me.OrderNoGridLookUpEdit.TabIndex = 17
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colProgramNo, Me.colIsPrint, Me.colUserId, Me.colIsMultiPart})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "OrderId"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 0
        '
        'colIsPrint
        '
        Me.colIsPrint.FieldName = "IsPrint"
        Me.colIsPrint.Name = "colIsPrint"
        Me.colIsPrint.Visible = True
        Me.colIsPrint.VisibleIndex = 1
        '
        'colUserId
        '
        Me.colUserId.FieldName = "UserId"
        Me.colUserId.Name = "colUserId"
        '
        'colIsMultiPart
        '
        Me.colIsMultiPart.FieldName = "IsMultiPart"
        Me.colIsMultiPart.Name = "colIsMultiPart"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.LeftOverGridControl)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.OrderReconcilationGridControl)
        Me.SplitContainer1.Size = New System.Drawing.Size(917, 332)
        Me.SplitContainer1.SplitterDistance = 149
        Me.SplitContainer1.TabIndex = 20
        '
        'OrderReconcilationGridControl
        '
        Me.OrderReconcilationGridControl.DataSource = Me.OrderReconcilationBindingSource
        Me.OrderReconcilationGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderReconcilationGridControl.Location = New System.Drawing.Point(0, 0)
        Me.OrderReconcilationGridControl.MainView = Me.BandedGridView2
        Me.OrderReconcilationGridControl.Name = "OrderReconcilationGridControl"
        Me.OrderReconcilationGridControl.Size = New System.Drawing.Size(917, 179)
        Me.OrderReconcilationGridControl.TabIndex = 0
        Me.OrderReconcilationGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView2})
        '
        'OrderReconcilationBindingSource
        '
        Me.OrderReconcilationBindingSource.DataMember = "OrderReconcilation"
        Me.OrderReconcilationBindingSource.DataSource = Me.OrderReconcilationDataSet
        '
        'OrderReconcilationDataSet
        '
        Me.OrderReconcilationDataSet.DataSetName = "OrderReconcilationDataSet"
        Me.OrderReconcilationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderReconcilationTableAdapter
        '
        Me.OrderReconcilationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = KSoft_Apparel.OrderReconcilationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BandedGridView2
        '
        Me.BandedGridView2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.BandedGridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridView2.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BandedGridView2.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand3, Me.gridBand7, Me.gridBand6, Me.gridBand5, Me.GridBand4, Me.GridBand8, Me.GridBand9, Me.GridBand10})
        Me.BandedGridView2.ColumnPanelRowHeight = 40
        Me.BandedGridView2.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colProgramNo1, Me.colStyleName, Me.colFabricColorName, Me.colTotalOrderQuantity, Me.colBookingQuantity, Me.colConsumption, Me.colFabricReceived, Me.colActualCuttingQuantity, Me.colPrintEmbSend, Me.colPrintEmbReceive, Me.colQCPassQuantity, Me.colInputQuantity, Me.colOutputQuantity, Me.colPolyQuantity, Me.colShippmentQuantity, Me.colKnittingProb, Me.colDyeingProb, Me.colCuttingProb, Me.colPrintProb, Me.colSewingReject, Me.colFinishingReject, Me.colUnassorted})
        Me.BandedGridView2.GridControl = Me.OrderReconcilationGridControl
        Me.BandedGridView2.Name = "BandedGridView2"
        Me.BandedGridView2.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView2.OptionsView.ShowGroupPanel = False
        '
        'GridBand3
        '
        Me.GridBand3.Caption = "Order Information"
        Me.GridBand3.Columns.Add(Me.colProgramNo1)
        Me.GridBand3.Columns.Add(Me.colStyleName)
        Me.GridBand3.Columns.Add(Me.colFabricColorName)
        Me.GridBand3.Columns.Add(Me.colTotalOrderQuantity)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 300
        '
        'colProgramNo1
        '
        Me.colProgramNo1.FieldName = "ProgramNo"
        Me.colProgramNo1.Name = "colProgramNo1"
        Me.colProgramNo1.Visible = True
        '
        'colStyleName
        '
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.Visible = True
        '
        'colFabricColorName
        '
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        Me.colFabricColorName.Visible = True
        '
        'colTotalOrderQuantity
        '
        Me.colTotalOrderQuantity.FieldName = "TotalOrderQuantity"
        Me.colTotalOrderQuantity.Name = "colTotalOrderQuantity"
        Me.colTotalOrderQuantity.Visible = True
        '
        'colBookingQuantity
        '
        Me.colBookingQuantity.FieldName = "BookingQuantity"
        Me.colBookingQuantity.Name = "colBookingQuantity"
        Me.colBookingQuantity.OptionsColumn.ReadOnly = True
        Me.colBookingQuantity.Visible = True
        '
        'colConsumption
        '
        Me.colConsumption.FieldName = "Consumption"
        Me.colConsumption.Name = "colConsumption"
        Me.colConsumption.OptionsColumn.ReadOnly = True
        Me.colConsumption.Visible = True
        Me.colConsumption.Width = 87
        '
        'colFabricReceived
        '
        Me.colFabricReceived.FieldName = "FabricReceived"
        Me.colFabricReceived.Name = "colFabricReceived"
        Me.colFabricReceived.OptionsColumn.ReadOnly = True
        Me.colFabricReceived.Visible = True
        '
        'colActualCuttingQuantity
        '
        Me.colActualCuttingQuantity.FieldName = "ActualCuttingQuantity"
        Me.colActualCuttingQuantity.Name = "colActualCuttingQuantity"
        Me.colActualCuttingQuantity.OptionsColumn.ReadOnly = True
        Me.colActualCuttingQuantity.Visible = True
        '
        'colPrintEmbSend
        '
        Me.colPrintEmbSend.FieldName = "PrintEmbSend"
        Me.colPrintEmbSend.Name = "colPrintEmbSend"
        Me.colPrintEmbSend.OptionsColumn.ReadOnly = True
        Me.colPrintEmbSend.Visible = True
        '
        'colPrintEmbReceive
        '
        Me.colPrintEmbReceive.FieldName = "PrintEmbReceive"
        Me.colPrintEmbReceive.Name = "colPrintEmbReceive"
        Me.colPrintEmbReceive.OptionsColumn.ReadOnly = True
        Me.colPrintEmbReceive.Visible = True
        '
        'colQCPassQuantity
        '
        Me.colQCPassQuantity.FieldName = "QCPassQuantity"
        Me.colQCPassQuantity.Name = "colQCPassQuantity"
        Me.colQCPassQuantity.OptionsColumn.ReadOnly = True
        Me.colQCPassQuantity.Visible = True
        '
        'colInputQuantity
        '
        Me.colInputQuantity.FieldName = "InputQuantity"
        Me.colInputQuantity.Name = "colInputQuantity"
        Me.colInputQuantity.OptionsColumn.ReadOnly = True
        Me.colInputQuantity.Visible = True
        '
        'colOutputQuantity
        '
        Me.colOutputQuantity.FieldName = "OutputQuantity"
        Me.colOutputQuantity.Name = "colOutputQuantity"
        Me.colOutputQuantity.OptionsColumn.ReadOnly = True
        Me.colOutputQuantity.Visible = True
        '
        'colPolyQuantity
        '
        Me.colPolyQuantity.FieldName = "PolyQuantity"
        Me.colPolyQuantity.Name = "colPolyQuantity"
        Me.colPolyQuantity.OptionsColumn.ReadOnly = True
        Me.colPolyQuantity.Visible = True
        '
        'colShippmentQuantity
        '
        Me.colShippmentQuantity.FieldName = "ShippmentQuantity"
        Me.colShippmentQuantity.Name = "colShippmentQuantity"
        Me.colShippmentQuantity.OptionsColumn.ReadOnly = True
        Me.colShippmentQuantity.Visible = True
        '
        'colKnittingProb
        '
        Me.colKnittingProb.FieldName = "KnittingProb"
        Me.colKnittingProb.Name = "colKnittingProb"
        Me.colKnittingProb.OptionsColumn.ReadOnly = True
        Me.colKnittingProb.Visible = True
        '
        'colDyeingProb
        '
        Me.colDyeingProb.FieldName = "DyeingProb"
        Me.colDyeingProb.Name = "colDyeingProb"
        Me.colDyeingProb.OptionsColumn.ReadOnly = True
        Me.colDyeingProb.Visible = True
        '
        'colCuttingProb
        '
        Me.colCuttingProb.FieldName = "CuttingProb"
        Me.colCuttingProb.Name = "colCuttingProb"
        Me.colCuttingProb.OptionsColumn.ReadOnly = True
        Me.colCuttingProb.Visible = True
        '
        'colPrintProb
        '
        Me.colPrintProb.FieldName = "PrintProb"
        Me.colPrintProb.Name = "colPrintProb"
        Me.colPrintProb.OptionsColumn.ReadOnly = True
        Me.colPrintProb.Visible = True
        '
        'colSewingReject
        '
        Me.colSewingReject.FieldName = "SewingReject"
        Me.colSewingReject.Name = "colSewingReject"
        Me.colSewingReject.OptionsColumn.ReadOnly = True
        Me.colSewingReject.Visible = True
        Me.colSewingReject.Width = 125
        '
        'colFinishingReject
        '
        Me.colFinishingReject.FieldName = "FinishingReject"
        Me.colFinishingReject.Name = "colFinishingReject"
        Me.colFinishingReject.OptionsColumn.ReadOnly = True
        Me.colFinishingReject.Visible = True
        '
        'colUnassorted
        '
        Me.colUnassorted.FieldName = "Unassorted"
        Me.colUnassorted.Name = "colUnassorted"
        Me.colUnassorted.OptionsColumn.ReadOnly = True
        Me.colUnassorted.Visible = True
        '
        'gridBand7
        '
        Me.gridBand7.Caption = "Fabric Information"
        Me.gridBand7.Columns.Add(Me.colBookingQuantity)
        Me.gridBand7.Columns.Add(Me.colConsumption)
        Me.gridBand7.Columns.Add(Me.colFabricReceived)
        Me.gridBand7.Name = "gridBand7"
        Me.gridBand7.Width = 237
        '
        'gridBand6
        '
        Me.gridBand6.Caption = "Cutting Information"
        Me.gridBand6.Columns.Add(Me.colActualCuttingQuantity)
        Me.gridBand6.Columns.Add(Me.colPrintEmbSend)
        Me.gridBand6.Columns.Add(Me.colPrintEmbReceive)
        Me.gridBand6.Columns.Add(Me.colQCPassQuantity)
        Me.gridBand6.Columns.Add(Me.colInputQuantity)
        Me.gridBand6.Columns.Add(Me.colOutputQuantity)
        Me.gridBand6.Name = "gridBand6"
        Me.gridBand6.Width = 450
        '
        'gridBand5
        '
        Me.gridBand5.Caption = "Shipment Information"
        Me.gridBand5.Columns.Add(Me.colPolyQuantity)
        Me.gridBand5.Columns.Add(Me.colShippmentQuantity)
        Me.gridBand5.Name = "gridBand5"
        Me.gridBand5.Width = 150
        '
        'GridBand4
        '
        Me.GridBand4.Caption = "Cut Panel Reject"
        Me.GridBand4.Columns.Add(Me.colKnittingProb)
        Me.GridBand4.Columns.Add(Me.colDyeingProb)
        Me.GridBand4.Columns.Add(Me.colCuttingProb)
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.Width = 225
        '
        'GridBand8
        '
        Me.GridBand8.Caption = "Print"
        Me.GridBand8.Columns.Add(Me.colPrintProb)
        Me.GridBand8.Name = "GridBand8"
        Me.GridBand8.Width = 75
        '
        'GridBand9
        '
        Me.GridBand9.Caption = "Sewing Reject"
        Me.GridBand9.Columns.Add(Me.colSewingReject)
        Me.GridBand9.Name = "GridBand9"
        Me.GridBand9.Width = 125
        '
        'GridBand10
        '
        Me.GridBand10.Caption = "Finishing Reject"
        Me.GridBand10.Columns.Add(Me.colFinishingReject)
        Me.GridBand10.Columns.Add(Me.colUnassorted)
        Me.GridBand10.Name = "GridBand10"
        Me.GridBand10.Width = 150
        '
        'frmLeftOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 360)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FabricColorComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.OrderNoGridLookUpEdit)
        Me.Controls.Add(Me.LeftOverBindingNavigator)
        Me.Name = "frmLeftOver"
        Me.Text = "Left Over"
        CType(Me.LeftOverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftOverBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftOverBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LeftOverBindingNavigator.ResumeLayout(False)
        Me.LeftOverBindingNavigator.PerformLayout()
        CType(Me.LeftOverGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.OrderReconcilationGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderReconcilationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderReconcilationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LeftOverDataSet As KSoft_Apparel.LeftOverDataSet
    Friend WithEvents LeftOverBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LeftOverTableAdapter As KSoft_Apparel.LeftOverDataSetTableAdapters.LeftOverTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.LeftOverDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LeftOverBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents LeftOverBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents LeftOverGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents OrderFabricColorDataSet As KSoft_Apparel.OrderFabricColorDataSet
    Friend WithEvents OrderFabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderFabricColorTableAdapter As KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FabricColorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OrderNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsMultiPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colLeftOverId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFabricColorId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colUnassortedQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRunOverQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLeftOverFor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLeftOverCategory As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLeftOverQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents OrderReconcilationDataSet As KSoft_Apparel.OrderReconcilationDataSet
    Friend WithEvents OrderReconcilationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderReconcilationTableAdapter As KSoft_Apparel.OrderReconcilationDataSetTableAdapters.OrderReconcilationTableAdapter
    Friend WithEvents TableAdapterManager1 As KSoft_Apparel.OrderReconcilationDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrderReconcilationGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents BandedGridView2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colProgramNo1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalOrderQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBookingQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colConsumption As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFabricReceived As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colActualCuttingQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrintEmbSend As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrintEmbReceive As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colQCPassQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colInputQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colOutputQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPolyQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colShippmentQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colKnittingProb As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDyeingProb As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCuttingProb As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrintProb As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSewingReject As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFinishingReject As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colUnassorted As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand7 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand8 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand9 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand10 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
