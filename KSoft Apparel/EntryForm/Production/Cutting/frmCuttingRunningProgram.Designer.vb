<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuttingRunningProgram
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCuttingRunningProgram))
        Me.CuttingRunningProgramBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.CuttingRunningProgramBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuttingRunningProgramDataSet = New KSoft_Apparel.CuttingRunningProgramDataSet
        Me.CuttingRunningProgramBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.CuttingRunningProgramDataGridView = New System.Windows.Forms.DataGridView
        Me.BranchId = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Apparel.BranchDataSet
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.FabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricColorDataSet = New KSoft_Apparel.FabricColorDataSet
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
        Me.FabricColorTableAdapter = New KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
        Me.CuttingRunningProgramTableAdapter = New KSoft_Apparel.CuttingRunningProgramDataSetTableAdapters.CuttingRunningProgramTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.CuttingRunningProgramDataSetTableAdapters.TableAdapterManager
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsPrint = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUserId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsMultiPart = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BranchComboBox = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.FabricColorComboBox = New System.Windows.Forms.ComboBox
        Me.OrderFabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderFabricColorDataSet = New KSoft_Apparel.OrderFabricColorDataSet
        Me.BranchTableAdapter = New KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
        Me.OrderFabricColorTableAdapter = New KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
        Me.AddButton = New System.Windows.Forms.Button
        CType(Me.CuttingRunningProgramBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CuttingRunningProgramBindingNavigator.SuspendLayout()
        CType(Me.CuttingRunningProgramBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingRunningProgramDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingRunningProgramDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CuttingRunningProgramBindingNavigator
        '
        Me.CuttingRunningProgramBindingNavigator.AddNewItem = Nothing
        Me.CuttingRunningProgramBindingNavigator.BindingSource = Me.CuttingRunningProgramBindingSource
        Me.CuttingRunningProgramBindingNavigator.CountItem = Nothing
        Me.CuttingRunningProgramBindingNavigator.DeleteItem = Nothing
        Me.CuttingRunningProgramBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuttingRunningProgramBindingNavigatorSaveItem})
        Me.CuttingRunningProgramBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CuttingRunningProgramBindingNavigator.MoveFirstItem = Nothing
        Me.CuttingRunningProgramBindingNavigator.MoveLastItem = Nothing
        Me.CuttingRunningProgramBindingNavigator.MoveNextItem = Nothing
        Me.CuttingRunningProgramBindingNavigator.MovePreviousItem = Nothing
        Me.CuttingRunningProgramBindingNavigator.Name = "CuttingRunningProgramBindingNavigator"
        Me.CuttingRunningProgramBindingNavigator.PositionItem = Nothing
        Me.CuttingRunningProgramBindingNavigator.Size = New System.Drawing.Size(724, 25)
        Me.CuttingRunningProgramBindingNavigator.TabIndex = 0
        Me.CuttingRunningProgramBindingNavigator.Text = "BindingNavigator1"
        '
        'CuttingRunningProgramBindingSource
        '
        Me.CuttingRunningProgramBindingSource.DataMember = "CuttingRunningProgram"
        Me.CuttingRunningProgramBindingSource.DataSource = Me.CuttingRunningProgramDataSet
        '
        'CuttingRunningProgramDataSet
        '
        Me.CuttingRunningProgramDataSet.DataSetName = "CuttingRunningProgramDataSet"
        Me.CuttingRunningProgramDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CuttingRunningProgramBindingNavigatorSaveItem
        '
        Me.CuttingRunningProgramBindingNavigatorSaveItem.Image = CType(resources.GetObject("CuttingRunningProgramBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CuttingRunningProgramBindingNavigatorSaveItem.Name = "CuttingRunningProgramBindingNavigatorSaveItem"
        Me.CuttingRunningProgramBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.CuttingRunningProgramBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CuttingRunningProgramDataGridView
        '
        Me.CuttingRunningProgramDataGridView.AllowUserToAddRows = False
        Me.CuttingRunningProgramDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuttingRunningProgramDataGridView.AutoGenerateColumns = False
        Me.CuttingRunningProgramDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CuttingRunningProgramDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CuttingRunningProgramDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BranchId, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.CuttingRunningProgramDataGridView.DataSource = Me.CuttingRunningProgramBindingSource
        Me.CuttingRunningProgramDataGridView.Location = New System.Drawing.Point(0, 80)
        Me.CuttingRunningProgramDataGridView.Name = "CuttingRunningProgramDataGridView"
        Me.CuttingRunningProgramDataGridView.Size = New System.Drawing.Size(724, 335)
        Me.CuttingRunningProgramDataGridView.TabIndex = 1
        '
        'BranchId
        '
        Me.BranchId.DataPropertyName = "BranchId"
        Me.BranchId.DataSource = Me.BranchBindingSource
        Me.BranchId.DisplayMember = "BranchCode"
        Me.BranchId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.BranchId.HeaderText = "Branch"
        Me.BranchId.Name = "BranchId"
        Me.BranchId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BranchId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BranchId.ValueMember = "BranchId"
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
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "OrderId"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.OrderLookupBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "ProgramNo"
        Me.DataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn2.HeaderText = "Program No"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "OrderId"
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
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FabricColorId"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.FabricColorBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "FabricColorName"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fabric Color"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "FabricColorId"
        Me.DataGridViewTextBoxColumn3.Width = 150
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
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'FabricColorTableAdapter
        '
        Me.FabricColorTableAdapter.ClearBeforeFill = True
        '
        'CuttingRunningProgramTableAdapter
        '
        Me.CuttingRunningProgramTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CuttingRunningProgramTableAdapter = Me.CuttingRunningProgramTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.CuttingRunningProgramDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(181, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Program No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(380, 44)
        Me.Label4.Margin = New System.Windows.Forms.Padding(15, 8, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Color"
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(252, 40)
        Me.ProgramNoGridLookUpEdit.Margin = New System.Windows.Forms.Padding(15, 4, 3, 3)
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.ProgramNoGridLookUpEdit.Properties.DisplayMember = "ProgramNo"
        Me.ProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoGridLookUpEdit.Properties.NullText = ""
        Me.ProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.ProgramNoGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(113, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 17
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderId, Me.colProgramNo, Me.colIsPrint, Me.colUserId, Me.colIsMultiPart})
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
        'colIsMultiPart
        '
        Me.colIsMultiPart.FieldName = "IsMultiPart"
        Me.colIsMultiPart.Name = "colIsMultiPart"
        '
        'BranchComboBox
        '
        Me.BranchComboBox.DataSource = Me.BranchBindingSource
        Me.BranchComboBox.DisplayMember = "BranchCode"
        Me.BranchComboBox.FormattingEnabled = True
        Me.BranchComboBox.Location = New System.Drawing.Point(67, 40)
        Me.BranchComboBox.Name = "BranchComboBox"
        Me.BranchComboBox.Size = New System.Drawing.Size(98, 21)
        Me.BranchComboBox.TabIndex = 14
        Me.BranchComboBox.TabStop = False
        Me.BranchComboBox.ValueMember = "BranchId"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Branch"
        '
        'FabricColorComboBox
        '
        Me.FabricColorComboBox.DataSource = Me.OrderFabricColorBindingSource
        Me.FabricColorComboBox.DisplayMember = "FabricColorName"
        Me.FabricColorComboBox.FormattingEnabled = True
        Me.FabricColorComboBox.Location = New System.Drawing.Point(418, 40)
        Me.FabricColorComboBox.Margin = New System.Windows.Forms.Padding(20, 4, 3, 3)
        Me.FabricColorComboBox.Name = "FabricColorComboBox"
        Me.FabricColorComboBox.Size = New System.Drawing.Size(128, 21)
        Me.FabricColorComboBox.TabIndex = 13
        Me.FabricColorComboBox.ValueMember = "FabricColorId"
        '
        'OrderFabricColorBindingSource
        '
        Me.OrderFabricColorBindingSource.DataMember = "OrderFabricColor"
        Me.OrderFabricColorBindingSource.DataSource = Me.OrderFabricColorDataSet
        '
        'OrderFabricColorDataSet
        '
        Me.OrderFabricColorDataSet.DataSetName = "OrderFabricColorDataSet"
        Me.OrderFabricColorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'OrderFabricColorTableAdapter
        '
        Me.OrderFabricColorTableAdapter.ClearBeforeFill = True
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(552, 39)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(94, 23)
        Me.AddButton.TabIndex = 19
        Me.AddButton.Text = "Add Button"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'frmCuttingRunningProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 417)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.Controls.Add(Me.BranchComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FabricColorComboBox)
        Me.Controls.Add(Me.CuttingRunningProgramDataGridView)
        Me.Controls.Add(Me.CuttingRunningProgramBindingNavigator)
        Me.Name = "frmCuttingRunningProgram"
        Me.Text = "Cutting Running Program"
        CType(Me.CuttingRunningProgramBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CuttingRunningProgramBindingNavigator.ResumeLayout(False)
        Me.CuttingRunningProgramBindingNavigator.PerformLayout()
        CType(Me.CuttingRunningProgramBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingRunningProgramDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingRunningProgramDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CuttingRunningProgramDataSet As KSoft_Apparel.CuttingRunningProgramDataSet
    Friend WithEvents CuttingRunningProgramBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CuttingRunningProgramTableAdapter As KSoft_Apparel.CuttingRunningProgramDataSetTableAdapters.CuttingRunningProgramTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.CuttingRunningProgramDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CuttingRunningProgramBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents CuttingRunningProgramBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CuttingRunningProgramDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents FabricColorDataSet As KSoft_Apparel.FabricColorDataSet
    Friend WithEvents FabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricColorTableAdapter As KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsMultiPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BranchComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FabricColorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BranchDataSet As KSoft_Apparel.BranchDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents OrderFabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderFabricColorDataSet As KSoft_Apparel.OrderFabricColorDataSet
    Friend WithEvents OrderFabricColorTableAdapter As KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents BranchId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
