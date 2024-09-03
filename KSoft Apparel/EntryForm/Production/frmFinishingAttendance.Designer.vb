<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFinishingAttendance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BranchDataSet = New KSoft_Apparel.BranchDataSet()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchTableAdapter = New KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter()
        Me.LineDataSet = New KSoft_Apparel.LineDataSet()
        Me.LineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LineTableAdapter = New KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SewingAttendanceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PresentIronMan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdIronMan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReIronMan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinishingAttendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinishingAttendanceDataSet = New KSoft_Apparel.FinishingAttendanceDataSet()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FinishingAttendanceTableAdapter = New KSoft_Apparel.FinishingAttendanceDataSetTableAdapters.FinishingAttendanceTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.FinishingAttendanceDataSetTableAdapters.TableAdapterManager()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingAttendanceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishingAttendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishingAttendanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BranchDataSet
        '
        Me.BranchDataSet.DataSetName = "BranchDataSet"
        Me.BranchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.BranchDataSet
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'LineDataSet
        '
        Me.LineDataSet.DataSetName = "LineDataSet"
        Me.LineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LineBindingSource
        '
        Me.LineBindingSource.DataMember = "Line"
        Me.LineBindingSource.DataSource = Me.LineDataSet
        '
        'LineTableAdapter
        '
        Me.LineTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Finishing Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(99, 40)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(108, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'SewingAttendanceDataGridView
        '
        Me.SewingAttendanceDataGridView.AllowUserToAddRows = False
        Me.SewingAttendanceDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SewingAttendanceDataGridView.AutoGenerateColumns = False
        Me.SewingAttendanceDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SewingAttendanceDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.SewingAttendanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SewingAttendanceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.BranchId, Me.PresentIronMan, Me.ProdIronMan, Me.ReIronMan, Me.Remarks})
        Me.SewingAttendanceDataGridView.DataSource = Me.FinishingAttendanceBindingSource
        Me.SewingAttendanceDataGridView.Location = New System.Drawing.Point(21, 67)
        Me.SewingAttendanceDataGridView.Name = "SewingAttendanceDataGridView"
        Me.SewingAttendanceDataGridView.Size = New System.Drawing.Size(959, 545)
        Me.SewingAttendanceDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "AttendanceDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Attendance Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 75
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
        Me.BranchId.Width = 75
        '
        'PresentIronMan
        '
        Me.PresentIronMan.DataPropertyName = "PresentIronMan"
        Me.PresentIronMan.HeaderText = "Present Iron Man"
        Me.PresentIronMan.Name = "PresentIronMan"
        '
        'ProdIronMan
        '
        Me.ProdIronMan.DataPropertyName = "ProdIronMan"
        Me.ProdIronMan.HeaderText = "Prod Iron Man"
        Me.ProdIronMan.Name = "ProdIronMan"
        '
        'ReIronMan
        '
        Me.ReIronMan.DataPropertyName = "ReIronMan"
        Me.ReIronMan.HeaderText = "ReIron Man"
        Me.ReIronMan.Name = "ReIronMan"
        '
        'Remarks
        '
        Me.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Remarks.DataPropertyName = "Remarks"
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        '
        'FinishingAttendanceBindingSource
        '
        Me.FinishingAttendanceBindingSource.DataMember = "FinishingAttendance"
        Me.FinishingAttendanceBindingSource.DataSource = Me.FinishingAttendanceDataSet
        '
        'FinishingAttendanceDataSet
        '
        Me.FinishingAttendanceDataSet.DataSetName = "FinishingAttendanceDataSet"
        Me.FinishingAttendanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Location = New System.Drawing.Point(899, 38)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(81, 23)
        Me.SaveButton.TabIndex = 12
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1003, 31)
        Me.FlowLayoutPanel1.TabIndex = 69
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(3, 7)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 7, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Finishing Attendance"
        '
        'FinishingAttendanceTableAdapter
        '
        Me.FinishingAttendanceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FinishingAttendanceTableAdapter = Me.FinishingAttendanceTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.FinishingAttendanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AddButton
        '
        Me.AddButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddButton.Location = New System.Drawing.Point(693, 38)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(87, 23)
        Me.AddButton.TabIndex = 70
        Me.AddButton.Text = "&Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteButton.Location = New System.Drawing.Point(786, 38)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(85, 23)
        Me.DeleteButton.TabIndex = 71
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'frmFinishingAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 624)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.SewingAttendanceDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "frmFinishingAttendance"
        Me.Text = "Finishing Attendance"
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingAttendanceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishingAttendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishingAttendanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BranchDataSet As KSoft_Apparel.BranchDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents LineDataSet As KSoft_Apparel.LineDataSet
    Friend WithEvents LineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LineTableAdapter As KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents FinishingAttendanceDataSet As KSoft_Apparel.FinishingAttendanceDataSet
    Friend WithEvents FinishingAttendanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinishingAttendanceTableAdapter As KSoft_Apparel.FinishingAttendanceDataSetTableAdapters.FinishingAttendanceTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.FinishingAttendanceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SewingAttendanceDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BranchId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PresentIronMan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdIronMan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReIronMan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
