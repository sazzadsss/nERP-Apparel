<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinishingDefect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinishingDefect))
        Me.FinishingDefectBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.FinishingDefectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinishingDefectDataSet = New KSoft_Apparel.FinishingDefectDataSet
        Me.FinishingDefectBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.FinishingDefectDataGridView = New System.Windows.Forms.DataGridView
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Apparel.BranchDataSet
        Me.FinishingDefectDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinishingDefectDetailsDataGridView = New System.Windows.Forms.DataGridView
        Me.QCCheckListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QCCheckListDataSet = New KSoft_Apparel.QCCheckListDataSet
        Me.FinishingDefectTableAdapter = New KSoft_Apparel.FinishingDefectDataSetTableAdapters.FinishingDefectTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.FinishingDefectDataSetTableAdapters.TableAdapterManager
        Me.FinishingDefectDetailsTableAdapter = New KSoft_Apparel.FinishingDefectDataSetTableAdapters.FinishingDefectDetailsTableAdapter
        Me.QCCheckListTableAdapter = New KSoft_Apparel.QCCheckListDataSetTableAdapters.QCCheckListTableAdapter
        Me.BranchComboBox = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LoadDefectButton = New System.Windows.Forms.Button
        Me.DefectDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.BranchTableAdapter = New KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
        Me.FinishingDefectDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BranchId = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.HourNo = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QCCheckListId = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.FinishingDefectBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FinishingDefectBindingNavigator.SuspendLayout()
        CType(Me.FinishingDefectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishingDefectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishingDefectDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishingDefectDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishingDefectDetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QCCheckListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QCCheckListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FinishingDefectBindingNavigator
        '
        Me.FinishingDefectBindingNavigator.AddNewItem = Nothing
        Me.FinishingDefectBindingNavigator.BindingSource = Me.FinishingDefectBindingSource
        Me.FinishingDefectBindingNavigator.CountItem = Nothing
        Me.FinishingDefectBindingNavigator.DeleteItem = Nothing
        Me.FinishingDefectBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FinishingDefectBindingNavigatorSaveItem})
        Me.FinishingDefectBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FinishingDefectBindingNavigator.MoveFirstItem = Nothing
        Me.FinishingDefectBindingNavigator.MoveLastItem = Nothing
        Me.FinishingDefectBindingNavigator.MoveNextItem = Nothing
        Me.FinishingDefectBindingNavigator.MovePreviousItem = Nothing
        Me.FinishingDefectBindingNavigator.Name = "FinishingDefectBindingNavigator"
        Me.FinishingDefectBindingNavigator.PositionItem = Nothing
        Me.FinishingDefectBindingNavigator.Size = New System.Drawing.Size(968, 25)
        Me.FinishingDefectBindingNavigator.TabIndex = 0
        Me.FinishingDefectBindingNavigator.Text = "BindingNavigator1"
        '
        'FinishingDefectBindingSource
        '
        Me.FinishingDefectBindingSource.DataMember = "FinishingDefect"
        Me.FinishingDefectBindingSource.DataSource = Me.FinishingDefectDataSet
        '
        'FinishingDefectDataSet
        '
        Me.FinishingDefectDataSet.DataSetName = "FinishingDefectDataSet"
        Me.FinishingDefectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinishingDefectBindingNavigatorSaveItem
        '
        Me.FinishingDefectBindingNavigatorSaveItem.Image = CType(resources.GetObject("FinishingDefectBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FinishingDefectBindingNavigatorSaveItem.Name = "FinishingDefectBindingNavigatorSaveItem"
        Me.FinishingDefectBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.FinishingDefectBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FinishingDefectDataGridView
        '
        Me.FinishingDefectDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FinishingDefectDataGridView.AutoGenerateColumns = False
        Me.FinishingDefectDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.FinishingDefectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FinishingDefectDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FinishingDefectDate, Me.BranchId, Me.HourNo, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3, Me.Remarks})
        Me.FinishingDefectDataGridView.DataSource = Me.FinishingDefectBindingSource
        Me.FinishingDefectDataGridView.Location = New System.Drawing.Point(12, 79)
        Me.FinishingDefectDataGridView.Name = "FinishingDefectDataGridView"
        Me.FinishingDefectDataGridView.Size = New System.Drawing.Size(600, 325)
        Me.FinishingDefectDataGridView.TabIndex = 1
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
        'FinishingDefectDetailsBindingSource
        '
        Me.FinishingDefectDetailsBindingSource.DataMember = "FK_FinishingDefectDetails_FinishingDefect"
        Me.FinishingDefectDetailsBindingSource.DataSource = Me.FinishingDefectBindingSource
        '
        'FinishingDefectDetailsDataGridView
        '
        Me.FinishingDefectDetailsDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FinishingDefectDetailsDataGridView.AutoGenerateColumns = False
        Me.FinishingDefectDetailsDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.FinishingDefectDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FinishingDefectDetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.QCCheckListId, Me.DataGridViewTextBoxColumn8})
        Me.FinishingDefectDetailsDataGridView.DataSource = Me.FinishingDefectDetailsBindingSource
        Me.FinishingDefectDetailsDataGridView.Location = New System.Drawing.Point(631, 79)
        Me.FinishingDefectDetailsDataGridView.Name = "FinishingDefectDetailsDataGridView"
        Me.FinishingDefectDetailsDataGridView.Size = New System.Drawing.Size(320, 325)
        Me.FinishingDefectDetailsDataGridView.TabIndex = 2
        '
        'QCCheckListBindingSource
        '
        Me.QCCheckListBindingSource.DataMember = "QCCheckList"
        Me.QCCheckListBindingSource.DataSource = Me.QCCheckListDataSet
        '
        'QCCheckListDataSet
        '
        Me.QCCheckListDataSet.DataSetName = "QCCheckListDataSet"
        Me.QCCheckListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinishingDefectTableAdapter
        '
        Me.FinishingDefectTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FinishingDefectDetailsTableAdapter = Me.FinishingDefectDetailsTableAdapter
        Me.TableAdapterManager.FinishingDefectTableAdapter = Me.FinishingDefectTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.FinishingDefectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FinishingDefectDetailsTableAdapter
        '
        Me.FinishingDefectDetailsTableAdapter.ClearBeforeFill = True
        '
        'QCCheckListTableAdapter
        '
        Me.QCCheckListTableAdapter.ClearBeforeFill = True
        '
        'BranchComboBox
        '
        Me.BranchComboBox.DataSource = Me.BranchBindingSource
        Me.BranchComboBox.DisplayMember = "BranchCode"
        Me.BranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BranchComboBox.FormattingEnabled = True
        Me.BranchComboBox.Location = New System.Drawing.Point(297, 47)
        Me.BranchComboBox.Name = "BranchComboBox"
        Me.BranchComboBox.Size = New System.Drawing.Size(111, 21)
        Me.BranchComboBox.TabIndex = 4
        Me.BranchComboBox.ValueMember = "BranchId"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Finishing Defect Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(250, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Branch"
        '
        'LoadDefectButton
        '
        Me.LoadDefectButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadDefectButton.Location = New System.Drawing.Point(631, 47)
        Me.LoadDefectButton.Name = "LoadDefectButton"
        Me.LoadDefectButton.Size = New System.Drawing.Size(118, 23)
        Me.LoadDefectButton.TabIndex = 7
        Me.LoadDefectButton.Text = "Load Defect List"
        Me.LoadDefectButton.UseVisualStyleBackColor = True
        '
        'DefectDateTimePicker
        '
        Me.DefectDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.DefectDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DefectDateTimePicker.Location = New System.Drawing.Point(124, 47)
        Me.DefectDateTimePicker.Name = "DefectDateTimePicker"
        Me.DefectDateTimePicker.Size = New System.Drawing.Size(110, 20)
        Me.DefectDateTimePicker.TabIndex = 8
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'FinishingDefectDate
        '
        Me.FinishingDefectDate.DataPropertyName = "FinishingDefectDate"
        Me.FinishingDefectDate.HeaderText = "Finishing Defect Date"
        Me.FinishingDefectDate.Name = "FinishingDefectDate"
        Me.FinishingDefectDate.ReadOnly = True
        '
        'BranchId
        '
        Me.BranchId.DataPropertyName = "BranchId"
        Me.BranchId.DataSource = Me.BranchBindingSource
        Me.BranchId.DisplayMember = "BranchCode"
        Me.BranchId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.BranchId.HeaderText = "Branch"
        Me.BranchId.Name = "BranchId"
        Me.BranchId.ReadOnly = True
        Me.BranchId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BranchId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BranchId.ValueMember = "BranchId"
        '
        'HourNo
        '
        Me.HourNo.DataPropertyName = "HourNo"
        Me.HourNo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.HourNo.HeaderText = "Hour"
        Me.HourNo.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "1", "2", "3", "4", "5", "6", "7"})
        Me.HourNo.Name = "HourNo"
        Me.HourNo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HourNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "OKQty"
        Me.DataGridViewTextBoxColumn4.HeaderText = "OK Qty"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CheckQty"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Check Qty"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Remarks
        '
        Me.Remarks.DataPropertyName = "Remarks"
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        '
        'QCCheckListId
        '
        Me.QCCheckListId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.QCCheckListId.DataPropertyName = "QCCheckListId"
        Me.QCCheckListId.DataSource = Me.QCCheckListBindingSource
        Me.QCCheckListId.DisplayMember = "Name"
        Me.QCCheckListId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.QCCheckListId.HeaderText = "Defect Name"
        Me.QCCheckListId.Name = "QCCheckListId"
        Me.QCCheckListId.ReadOnly = True
        Me.QCCheckListId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.QCCheckListId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.QCCheckListId.ValueMember = "QCCheckListId"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DefectQuantity"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Defect Quantity"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'frmFinishingDefect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 424)
        Me.Controls.Add(Me.DefectDateTimePicker)
        Me.Controls.Add(Me.LoadDefectButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BranchComboBox)
        Me.Controls.Add(Me.FinishingDefectDetailsDataGridView)
        Me.Controls.Add(Me.FinishingDefectDataGridView)
        Me.Controls.Add(Me.FinishingDefectBindingNavigator)
        Me.Name = "frmFinishingDefect"
        Me.Text = "Finishing Defect"
        CType(Me.FinishingDefectBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FinishingDefectBindingNavigator.ResumeLayout(False)
        Me.FinishingDefectBindingNavigator.PerformLayout()
        CType(Me.FinishingDefectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishingDefectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishingDefectDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishingDefectDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishingDefectDetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QCCheckListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QCCheckListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FinishingDefectDataSet As KSoft_Apparel.FinishingDefectDataSet
    Friend WithEvents FinishingDefectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinishingDefectTableAdapter As KSoft_Apparel.FinishingDefectDataSetTableAdapters.FinishingDefectTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.FinishingDefectDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FinishingDefectBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents FinishingDefectBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FinishingDefectDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FinishingDefectDetailsTableAdapter As KSoft_Apparel.FinishingDefectDataSetTableAdapters.FinishingDefectDetailsTableAdapter
    Friend WithEvents FinishingDefectDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinishingDefectDetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents QCCheckListDataSet As KSoft_Apparel.QCCheckListDataSet
    Friend WithEvents QCCheckListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QCCheckListTableAdapter As KSoft_Apparel.QCCheckListDataSetTableAdapters.QCCheckListTableAdapter
    Friend WithEvents BranchComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LoadDefectButton As System.Windows.Forms.Button
    Friend WithEvents DefectDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BranchDataSet As KSoft_Apparel.BranchDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents FinishingDefectDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BranchId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents HourNo As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QCCheckListId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
