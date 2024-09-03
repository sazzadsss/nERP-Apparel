<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkingHour
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWorkingHour))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.WorkingHourDataSet = New KSoft_Apparel.WorkingHourDataSet
        Me.WorkingHourBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorkingHourTableAdapter = New KSoft_Apparel.WorkingHourDataSetTableAdapters.WorkingHourTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.WorkingHourDataSetTableAdapters.TableAdapterManager
        Me.WorkingHourBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.WorkingHourBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.WorkingHourDataGridView = New System.Windows.Forms.DataGridView
        Me.ShiftBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShiftDataSet = New KSoft_Apparel.ShiftDataSet
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Apparel.BranchDataSet
        Me.ShiftTableAdapter = New KSoft_Apparel.ShiftDataSetTableAdapters.ShiftTableAdapter
        Me.BranchTableAdapter = New KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
        Me.CompanyDataSet = New KSoft_Apparel.CompanyDataSet
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyTableAdapter = New KSoft_Apparel.CompanyDataSetTableAdapters.CompanyTableAdapter
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.CompanyId = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.WorkingHourDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkingHourBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkingHourBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkingHourBindingNavigator.SuspendLayout()
        CType(Me.WorkingHourDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShiftBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShiftDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WorkingHourDataSet
        '
        Me.WorkingHourDataSet.DataSetName = "WorkingHourDataSet"
        Me.WorkingHourDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WorkingHourBindingSource
        '
        Me.WorkingHourBindingSource.DataMember = "WorkingHour"
        Me.WorkingHourBindingSource.DataSource = Me.WorkingHourDataSet
        '
        'WorkingHourTableAdapter
        '
        Me.WorkingHourTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.WorkingHourDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WorkingHourTableAdapter = Me.WorkingHourTableAdapter
        '
        'WorkingHourBindingNavigator
        '
        Me.WorkingHourBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.WorkingHourBindingNavigator.BindingSource = Me.WorkingHourBindingSource
        Me.WorkingHourBindingNavigator.CountItem = Nothing
        Me.WorkingHourBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.WorkingHourBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.WorkingHourBindingNavigatorSaveItem})
        Me.WorkingHourBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.WorkingHourBindingNavigator.MoveFirstItem = Nothing
        Me.WorkingHourBindingNavigator.MoveLastItem = Nothing
        Me.WorkingHourBindingNavigator.MoveNextItem = Nothing
        Me.WorkingHourBindingNavigator.MovePreviousItem = Nothing
        Me.WorkingHourBindingNavigator.Name = "WorkingHourBindingNavigator"
        Me.WorkingHourBindingNavigator.PositionItem = Nothing
        Me.WorkingHourBindingNavigator.Size = New System.Drawing.Size(694, 25)
        Me.WorkingHourBindingNavigator.TabIndex = 0
        Me.WorkingHourBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'WorkingHourBindingNavigatorSaveItem
        '
        Me.WorkingHourBindingNavigatorSaveItem.Image = CType(resources.GetObject("WorkingHourBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.WorkingHourBindingNavigatorSaveItem.Name = "WorkingHourBindingNavigatorSaveItem"
        Me.WorkingHourBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.WorkingHourBindingNavigatorSaveItem.Text = "Save Data"
        '
        'WorkingHourDataGridView
        '
        Me.WorkingHourDataGridView.AllowUserToAddRows = False
        Me.WorkingHourDataGridView.AutoGenerateColumns = False
        Me.WorkingHourDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.WorkingHourDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WorkingHourDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.CompanyId, Me.DataGridViewTextBoxColumn5})
        Me.WorkingHourDataGridView.DataSource = Me.WorkingHourBindingSource
        Me.WorkingHourDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkingHourDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.WorkingHourDataGridView.Name = "WorkingHourDataGridView"
        Me.WorkingHourDataGridView.Size = New System.Drawing.Size(694, 415)
        Me.WorkingHourDataGridView.TabIndex = 1
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
        'ShiftTableAdapter
        '
        Me.ShiftTableAdapter.ClearBeforeFill = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'CompanyDataSet
        '
        Me.CompanyDataSet.DataSetName = "CompanyDataSet"
        Me.CompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompanyBindingSource
        '
        Me.CompanyBindingSource.DataMember = "Company"
        Me.CompanyBindingSource.DataSource = Me.CompanyDataSet
        '
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "WorkingDate"
        DataGridViewCellStyle1.Format = "dd-MMM-yy"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn2.HeaderText = "Working Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ShiftId"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.ShiftBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "Name"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.HeaderText = "Shift"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "ShiftId"
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "WorkingHour"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Working Hour"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "BrachId"
        Me.DataGridViewTextBoxColumn6.DataSource = Me.BranchBindingSource
        Me.DataGridViewTextBoxColumn6.DisplayMember = "BranchCode"
        Me.DataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn6.HeaderText = "Branch"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn6.ValueMember = "BranchId"
        '
        'CompanyId
        '
        Me.CompanyId.DataPropertyName = "CompanyId"
        Me.CompanyId.DataSource = Me.CompanyBindingSource
        Me.CompanyId.DisplayMember = "CompanyCode"
        Me.CompanyId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.CompanyId.HeaderText = "Company"
        Me.CompanyId.Name = "CompanyId"
        Me.CompanyId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CompanyId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CompanyId.ValueMember = "CompanyId"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 200
        '
        'frmWorkingHour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 440)
        Me.Controls.Add(Me.WorkingHourDataGridView)
        Me.Controls.Add(Me.WorkingHourBindingNavigator)
        Me.Name = "frmWorkingHour"
        Me.Text = "Working Hour"
        CType(Me.WorkingHourDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkingHourBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkingHourBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkingHourBindingNavigator.ResumeLayout(False)
        Me.WorkingHourBindingNavigator.PerformLayout()
        CType(Me.WorkingHourDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShiftBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShiftDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WorkingHourDataSet As KSoft_Apparel.WorkingHourDataSet
    Friend WithEvents WorkingHourBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WorkingHourTableAdapter As KSoft_Apparel.WorkingHourDataSetTableAdapters.WorkingHourTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.WorkingHourDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WorkingHourBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents WorkingHourBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents WorkingHourDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ShiftDataSet As KSoft_Apparel.ShiftDataSet
    Friend WithEvents ShiftBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ShiftTableAdapter As KSoft_Apparel.ShiftDataSetTableAdapters.ShiftTableAdapter
    Friend WithEvents BranchDataSet As KSoft_Apparel.BranchDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents CompanyDataSet As KSoft_Apparel.CompanyDataSet
    Friend WithEvents CompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyTableAdapter As KSoft_Apparel.CompanyDataSetTableAdapters.CompanyTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CompanyId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
