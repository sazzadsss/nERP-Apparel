<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailyProductionSummery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDailyProductionSummery))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DailyProductionSummeryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.DailyProductionSummeryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DailyProductionSummeryDataSet = New KSoft_Apparel.DailyProductionSummeryDataSet
        Me.DailyProductionSummeryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.GenerateToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.DailyProductionSummeryDataGridView = New System.Windows.Forms.DataGridView
        Me.BranchId = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Apparel.BranchDataSet
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CuttingReplace = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DailyProductionSummeryTableAdapter = New KSoft_Apparel.DailyProductionSummeryDataSetTableAdapters.DailyProductionSummeryTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.DailyProductionSummeryDataSetTableAdapters.TableAdapterManager
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BranchComboBox = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.BranchTableAdapter = New KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox = New System.Windows.Forms.GroupBox
        CType(Me.DailyProductionSummeryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DailyProductionSummeryBindingNavigator.SuspendLayout()
        CType(Me.DailyProductionSummeryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DailyProductionSummeryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DailyProductionSummeryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'DailyProductionSummeryBindingNavigator
        '
        Me.DailyProductionSummeryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DailyProductionSummeryBindingNavigator.BindingSource = Me.DailyProductionSummeryBindingSource
        Me.DailyProductionSummeryBindingNavigator.CountItem = Nothing
        Me.DailyProductionSummeryBindingNavigator.DeleteItem = Nothing
        Me.DailyProductionSummeryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.DailyProductionSummeryBindingNavigatorSaveItem, Me.GenerateToolStripButton, Me.PrintToolStripButton})
        Me.DailyProductionSummeryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DailyProductionSummeryBindingNavigator.MoveFirstItem = Nothing
        Me.DailyProductionSummeryBindingNavigator.MoveLastItem = Nothing
        Me.DailyProductionSummeryBindingNavigator.MoveNextItem = Nothing
        Me.DailyProductionSummeryBindingNavigator.MovePreviousItem = Nothing
        Me.DailyProductionSummeryBindingNavigator.Name = "DailyProductionSummeryBindingNavigator"
        Me.DailyProductionSummeryBindingNavigator.PositionItem = Nothing
        Me.DailyProductionSummeryBindingNavigator.Size = New System.Drawing.Size(1029, 25)
        Me.DailyProductionSummeryBindingNavigator.TabIndex = 0
        Me.DailyProductionSummeryBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'DailyProductionSummeryBindingSource
        '
        Me.DailyProductionSummeryBindingSource.DataMember = "DailyProductionSummery"
        Me.DailyProductionSummeryBindingSource.DataSource = Me.DailyProductionSummeryDataSet
        '
        'DailyProductionSummeryDataSet
        '
        Me.DailyProductionSummeryDataSet.DataSetName = "DailyProductionSummeryDataSet"
        Me.DailyProductionSummeryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DailyProductionSummeryBindingNavigatorSaveItem
        '
        Me.DailyProductionSummeryBindingNavigatorSaveItem.Image = CType(resources.GetObject("DailyProductionSummeryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DailyProductionSummeryBindingNavigatorSaveItem.Name = "DailyProductionSummeryBindingNavigatorSaveItem"
        Me.DailyProductionSummeryBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.DailyProductionSummeryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'GenerateToolStripButton
        '
        Me.GenerateToolStripButton.Image = CType(resources.GetObject("GenerateToolStripButton.Image"), System.Drawing.Image)
        Me.GenerateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GenerateToolStripButton.Name = "GenerateToolStripButton"
        Me.GenerateToolStripButton.Size = New System.Drawing.Size(74, 22)
        Me.GenerateToolStripButton.Text = "Generate"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(52, 22)
        Me.PrintToolStripButton.Text = "Print"
        '
        'DailyProductionSummeryDataGridView
        '
        Me.DailyProductionSummeryDataGridView.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DailyProductionSummeryDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DailyProductionSummeryDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DailyProductionSummeryDataGridView.AutoGenerateColumns = False
        Me.DailyProductionSummeryDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.DailyProductionSummeryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DailyProductionSummeryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BranchId, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.CuttingReplace, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.Remarks})
        Me.DailyProductionSummeryDataGridView.DataSource = Me.DailyProductionSummeryBindingSource
        Me.DailyProductionSummeryDataGridView.Location = New System.Drawing.Point(12, 97)
        Me.DailyProductionSummeryDataGridView.Name = "DailyProductionSummeryDataGridView"
        Me.DailyProductionSummeryDataGridView.Size = New System.Drawing.Size(1005, 382)
        Me.DailyProductionSummeryDataGridView.TabIndex = 1
        '
        'BranchId
        '
        Me.BranchId.DataPropertyName = "BranchId"
        Me.BranchId.DataSource = Me.BranchBindingSource
        Me.BranchId.DisplayMember = "BranchCode"
        Me.BranchId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.BranchId.Frozen = True
        Me.BranchId.HeaderText = "Branch"
        Me.BranchId.Name = "BranchId"
        Me.BranchId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BranchId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BranchId.ValueMember = "BranchId"
        Me.BranchId.Width = 50
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductionDay"
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Production Day"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProductionDayType"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.Frozen = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn3.Items.AddRange(New Object() {"WO", "HLD", "GD"})
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CuttingTarget"
        Me.DataGridViewTextBoxColumn4.Frozen = True
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cutting Target"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 75
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CuttingQuantity"
        Me.DataGridViewTextBoxColumn5.Frozen = True
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cutting Quantity (QC)"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CuttingReject"
        Me.DataGridViewTextBoxColumn6.Frozen = True
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cutting Reject"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 75
        '
        'CuttingReplace
        '
        Me.CuttingReplace.DataPropertyName = "CuttingReplace"
        Me.CuttingReplace.Frozen = True
        Me.CuttingReplace.HeaderText = "Cutting Replace"
        Me.CuttingReplace.Name = "CuttingReplace"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "SewingTarget"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Sewing Target"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 75
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SewingQuantity"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Sewing Quantity"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 75
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "SewingReject"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Sewing Reject"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 75
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "FinishingTarget"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Finishing Target"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 75
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "FinishingQuantity"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Finishing Quantity"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 75
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "FinishingReject"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Finishing Reject"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 75
        '
        'Remarks
        '
        Me.Remarks.DataPropertyName = "Remarks"
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Width = 200
        '
        'DailyProductionSummeryTableAdapter
        '
        Me.DailyProductionSummeryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DailyProductionSummeryTableAdapter = Me.DailyProductionSummeryTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.DailyProductionSummeryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(68, 16)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(96, 20)
        Me.FromDateTimePicker.TabIndex = 2
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(205, 16)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(92, 20)
        Me.ToDateTimePicker.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "To"
        '
        'BranchComboBox
        '
        Me.BranchComboBox.DataSource = Me.BranchBindingSource
        Me.BranchComboBox.DisplayMember = "BranchCode"
        Me.BranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BranchComboBox.FormattingEnabled = True
        Me.BranchComboBox.Location = New System.Drawing.Point(353, 15)
        Me.BranchComboBox.Name = "BranchComboBox"
        Me.BranchComboBox.Size = New System.Drawing.Size(121, 21)
        Me.BranchComboBox.TabIndex = 6
        Me.BranchComboBox.ValueMember = "BranchId"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(306, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Branch"
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(795, 108)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(118, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'GroupBox
        '
        Me.GroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox.Controls.Add(Me.Label3)
        Me.GroupBox.Controls.Add(Me.BranchComboBox)
        Me.GroupBox.Controls.Add(Me.Label2)
        Me.GroupBox.Controls.Add(Me.Label1)
        Me.GroupBox.Controls.Add(Me.ToDateTimePicker)
        Me.GroupBox.Controls.Add(Me.FromDateTimePicker)
        Me.GroupBox.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(1005, 45)
        Me.GroupBox.TabIndex = 9
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Fitration"
        '
        'frmDailyProductionSummery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 491)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.DailyProductionSummeryDataGridView)
        Me.Controls.Add(Me.DailyProductionSummeryBindingNavigator)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "frmDailyProductionSummery"
        Me.Text = "Daily Production Summery"
        CType(Me.DailyProductionSummeryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DailyProductionSummeryBindingNavigator.ResumeLayout(False)
        Me.DailyProductionSummeryBindingNavigator.PerformLayout()
        CType(Me.DailyProductionSummeryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DailyProductionSummeryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DailyProductionSummeryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DailyProductionSummeryDataSet As KSoft_Apparel.DailyProductionSummeryDataSet
    Friend WithEvents DailyProductionSummeryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DailyProductionSummeryTableAdapter As KSoft_Apparel.DailyProductionSummeryDataSetTableAdapters.DailyProductionSummeryTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.DailyProductionSummeryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DailyProductionSummeryBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DailyProductionSummeryBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DailyProductionSummeryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GenerateToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FromDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BranchComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BranchDataSet As KSoft_Apparel.BranchDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents BranchId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuttingReplace As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
