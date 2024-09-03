<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShipmentComents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShipmentComents))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DelayShipmentCommentsDataSet = New KSoft_Apparel.DelayShipmentCommentsDataSet
        Me.DelayShipmentCommentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DelayShipmentCommentsTableAdapter = New KSoft_Apparel.DelayShipmentCommentsDataSetTableAdapters.DelayShipmentCommentsTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.DelayShipmentCommentsDataSetTableAdapters.TableAdapterManager
        Me.DelayShipmentCommentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.DelayShipmentCommentsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.DelayShipmentCommentsDataGridView = New System.Windows.Forms.DataGridView
        Me.OrderPOLookupNewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderPOLookupNewDataSet = New KSoft_Apparel.OrderPOLookupNewDataSet
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsPrint = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUserId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.GridLookUpEdit2 = New DevExpress.XtraEditors.GridLookUpEdit
        Me.OrderP0LookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderPOLookupDataSet = New KSoft_Apparel.OrderPOLookupDataSet
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colOrderDetailsId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramNo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPOandColor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOrderId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricColorId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDestinationCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPOAndColorAndDes = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
        Me.OrderPOTableAdapter = New KSoft_Apparel.OrderPOLookupDataSetTableAdapters.OrderPOTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.OrderPOLookupNewTableAdapter = New KSoft_Apparel.OrderPOLookupNewDataSetTableAdapters.OrderPOLookupNewTableAdapter
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.OrderDetailsId = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DelayShipmentCommentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelayShipmentCommentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelayShipmentCommentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DelayShipmentCommentsBindingNavigator.SuspendLayout()
        CType(Me.DelayShipmentCommentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderPOLookupNewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderPOLookupNewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderP0LookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderPOLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DelayShipmentCommentsDataSet
        '
        Me.DelayShipmentCommentsDataSet.DataSetName = "DelayShipmentCommentsDataSet"
        Me.DelayShipmentCommentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DelayShipmentCommentsBindingSource
        '
        Me.DelayShipmentCommentsBindingSource.DataMember = "DelayShipmentComments"
        Me.DelayShipmentCommentsBindingSource.DataSource = Me.DelayShipmentCommentsDataSet
        '
        'DelayShipmentCommentsTableAdapter
        '
        Me.DelayShipmentCommentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DelayShipmentCommentsTableAdapter = Me.DelayShipmentCommentsTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.DelayShipmentCommentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DelayShipmentCommentsBindingNavigator
        '
        Me.DelayShipmentCommentsBindingNavigator.AddNewItem = Nothing
        Me.DelayShipmentCommentsBindingNavigator.BindingSource = Me.DelayShipmentCommentsBindingSource
        Me.DelayShipmentCommentsBindingNavigator.CountItem = Nothing
        Me.DelayShipmentCommentsBindingNavigator.DeleteItem = Nothing
        Me.DelayShipmentCommentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DelayShipmentCommentsBindingNavigatorSaveItem})
        Me.DelayShipmentCommentsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DelayShipmentCommentsBindingNavigator.MoveFirstItem = Nothing
        Me.DelayShipmentCommentsBindingNavigator.MoveLastItem = Nothing
        Me.DelayShipmentCommentsBindingNavigator.MoveNextItem = Nothing
        Me.DelayShipmentCommentsBindingNavigator.MovePreviousItem = Nothing
        Me.DelayShipmentCommentsBindingNavigator.Name = "DelayShipmentCommentsBindingNavigator"
        Me.DelayShipmentCommentsBindingNavigator.PositionItem = Nothing
        Me.DelayShipmentCommentsBindingNavigator.Size = New System.Drawing.Size(922, 25)
        Me.DelayShipmentCommentsBindingNavigator.TabIndex = 0
        Me.DelayShipmentCommentsBindingNavigator.Text = "BindingNavigator1"
        '
        'DelayShipmentCommentsBindingNavigatorSaveItem
        '
        Me.DelayShipmentCommentsBindingNavigatorSaveItem.Image = CType(resources.GetObject("DelayShipmentCommentsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DelayShipmentCommentsBindingNavigatorSaveItem.Name = "DelayShipmentCommentsBindingNavigatorSaveItem"
        Me.DelayShipmentCommentsBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.DelayShipmentCommentsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DelayShipmentCommentsDataGridView
        '
        Me.DelayShipmentCommentsDataGridView.AllowUserToAddRows = False
        Me.DelayShipmentCommentsDataGridView.AutoGenerateColumns = False
        Me.DelayShipmentCommentsDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.DelayShipmentCommentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DelayShipmentCommentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.OrderDetailsId, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4})
        Me.DelayShipmentCommentsDataGridView.DataSource = Me.DelayShipmentCommentsBindingSource
        Me.DelayShipmentCommentsDataGridView.Location = New System.Drawing.Point(12, 96)
        Me.DelayShipmentCommentsDataGridView.Name = "DelayShipmentCommentsDataGridView"
        Me.DelayShipmentCommentsDataGridView.Size = New System.Drawing.Size(887, 249)
        Me.DelayShipmentCommentsDataGridView.TabIndex = 2
        '
        'OrderPOLookupNewBindingSource
        '
        Me.OrderPOLookupNewBindingSource.DataMember = "OrderPOLookupNew"
        Me.OrderPOLookupNewBindingSource.DataSource = Me.OrderPOLookupNewDataSet
        '
        'OrderPOLookupNewDataSet
        '
        Me.OrderPOLookupNewDataSet.DataSetName = "OrderPOLookupNewDataSet"
        Me.OrderPOLookupNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(93, 21)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.OrderLookupBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "ProgramNo"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = "[Type Program No]"
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "OrderId"
        Me.GridLookUpEdit1.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(133, 20)
        Me.GridLookUpEdit1.TabIndex = 3
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
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderId, Me.colProgramNo, Me.colIsPrint, Me.colUserId})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colOrderId
        '
        Me.colOrderId.FieldName = "OrderId"
        Me.colOrderId.Name = "colOrderId"
        Me.colOrderId.OptionsColumn.ReadOnly = True
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
        '
        'colUserId
        '
        Me.colUserId.FieldName = "UserId"
        Me.colUserId.Name = "colUserId"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Program No"
        '
        'GridLookUpEdit2
        '
        Me.GridLookUpEdit2.Location = New System.Drawing.Point(285, 21)
        Me.GridLookUpEdit2.Name = "GridLookUpEdit2"
        Me.GridLookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit2.Properties.DataSource = Me.OrderP0LookupBindingSource
        Me.GridLookUpEdit2.Properties.DisplayMember = "POandColor"
        Me.GridLookUpEdit2.Properties.ImmediatePopup = True
        Me.GridLookUpEdit2.Properties.NullText = "[Type PO No]"
        Me.GridLookUpEdit2.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit2.Properties.ValueMember = "OrderDetailsId"
        Me.GridLookUpEdit2.Properties.View = Me.GridView1
        Me.GridLookUpEdit2.Size = New System.Drawing.Size(149, 20)
        Me.GridLookUpEdit2.TabIndex = 5
        '
        'OrderP0LookupBindingSource
        '
        Me.OrderP0LookupBindingSource.DataMember = "OrderP0Lookup"
        Me.OrderP0LookupBindingSource.DataSource = Me.OrderPOLookupDataSet
        '
        'OrderPOLookupDataSet
        '
        Me.OrderPOLookupDataSet.DataSetName = "OrderPOLookupDataSet"
        Me.OrderPOLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderDetailsId, Me.colProgramNo1, Me.colFabricColorName, Me.colDetails, Me.colPOandColor, Me.colOrderId1, Me.colFabricColorId, Me.colDestinationCode, Me.colPOAndColorAndDes, Me.colPO})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colOrderDetailsId
        '
        Me.colOrderDetailsId.FieldName = "OrderDetailsId"
        Me.colOrderDetailsId.Name = "colOrderDetailsId"
        Me.colOrderDetailsId.OptionsColumn.ReadOnly = True
        '
        'colProgramNo1
        '
        Me.colProgramNo1.FieldName = "ProgramNo"
        Me.colProgramNo1.Name = "colProgramNo1"
        '
        'colFabricColorName
        '
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.OptionsColumn.ReadOnly = True
        '
        'colPOandColor
        '
        Me.colPOandColor.FieldName = "POandColor"
        Me.colPOandColor.Name = "colPOandColor"
        Me.colPOandColor.OptionsColumn.ReadOnly = True
        Me.colPOandColor.Visible = True
        Me.colPOandColor.VisibleIndex = 0
        '
        'colOrderId1
        '
        Me.colOrderId1.FieldName = "OrderId"
        Me.colOrderId1.Name = "colOrderId1"
        Me.colOrderId1.OptionsColumn.ReadOnly = True
        '
        'colFabricColorId
        '
        Me.colFabricColorId.FieldName = "FabricColorId"
        Me.colFabricColorId.Name = "colFabricColorId"
        Me.colFabricColorId.OptionsColumn.ReadOnly = True
        '
        'colDestinationCode
        '
        Me.colDestinationCode.FieldName = "DestinationCode"
        Me.colDestinationCode.Name = "colDestinationCode"
        Me.colDestinationCode.OptionsColumn.ReadOnly = True
        '
        'colPOAndColorAndDes
        '
        Me.colPOAndColorAndDes.FieldName = "POAndColorAndDes"
        Me.colPOAndColorAndDes.Name = "colPOAndColorAndDes"
        Me.colPOAndColorAndDes.OptionsColumn.ReadOnly = True
        '
        'colPO
        '
        Me.colPO.FieldName = "PO"
        Me.colPO.Name = "colPO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(240, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "PO No"
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'OrderPOTableAdapter
        '
        Me.OrderPOTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GridLookUpEdit2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GridLookUpEdit1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(887, 53)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'OrderPOLookupNewTableAdapter
        '
        Me.OrderPOLookupNewTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "OrderDetailsId"
        Me.DataGridViewTextBoxColumn1.DataSource = Me.OrderPOLookupNewBindingSource
        Me.DataGridViewTextBoxColumn1.DisplayMember = "ProgramNo"
        Me.DataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn1.HeaderText = "Program No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn1.ValueMember = "OrderDetailsId"
        '
        'OrderDetailsId
        '
        Me.OrderDetailsId.DataPropertyName = "OrderDetailsId"
        Me.OrderDetailsId.DataSource = Me.OrderPOLookupNewBindingSource
        Me.OrderDetailsId.DisplayMember = "POAndColor"
        Me.OrderDetailsId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.OrderDetailsId.HeaderText = "PO/Color"
        Me.OrderDetailsId.Name = "OrderDetailsId"
        Me.OrderDetailsId.ReadOnly = True
        Me.OrderDetailsId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OrderDetailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.OrderDetailsId.ValueMember = "OrderDetailsId"
        Me.OrderDetailsId.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FFabReceiveDate"
        DataGridViewCellStyle1.Format = "dd-MMM-yy"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn2.HeaderText = "First Fab Receive Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LFabReceiveDate"
        DataGridViewCellStyle2.Format = "dd-MMM-yy"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last Fab Receive Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Criteria"
        Me.DataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn5.HeaderText = "Criteria"
        Me.DataGridViewTextBoxColumn5.Items.AddRange(New Object() {"Accessories", "Fabrics", "Print", "Buyer Problem", "Others"})
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'frmShipmentComents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 368)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DelayShipmentCommentsDataGridView)
        Me.Controls.Add(Me.DelayShipmentCommentsBindingNavigator)
        Me.Name = "frmShipmentComents"
        Me.Text = "Shipment Coments"
        CType(Me.DelayShipmentCommentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelayShipmentCommentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelayShipmentCommentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DelayShipmentCommentsBindingNavigator.ResumeLayout(False)
        Me.DelayShipmentCommentsBindingNavigator.PerformLayout()
        CType(Me.DelayShipmentCommentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderPOLookupNewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderPOLookupNewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderP0LookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderPOLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DelayShipmentCommentsDataSet As KSoft_Apparel.DelayShipmentCommentsDataSet
    Friend WithEvents DelayShipmentCommentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DelayShipmentCommentsTableAdapter As KSoft_Apparel.DelayShipmentCommentsDataSetTableAdapters.DelayShipmentCommentsTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.DelayShipmentCommentsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DelayShipmentCommentsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents DelayShipmentCommentsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DelayShipmentCommentsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridLookUpEdit2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents OrderPOLookupDataSet As KSoft_Apparel.OrderPOLookupDataSet
    Friend WithEvents OrderP0LookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderPOTableAdapter As KSoft_Apparel.OrderPOLookupDataSetTableAdapters.OrderPOTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OrderPOLookupNewDataSet As KSoft_Apparel.OrderPOLookupNewDataSet
    Friend WithEvents OrderPOLookupNewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderPOLookupNewTableAdapter As KSoft_Apparel.OrderPOLookupNewDataSetTableAdapters.OrderPOLookupNewTableAdapter
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOandColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestinationCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOAndColorAndDes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents OrderDetailsId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
