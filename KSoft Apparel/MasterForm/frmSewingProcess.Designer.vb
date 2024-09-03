<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSewingProcess
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
        Me.SewingProcessDataGridView = New System.Windows.Forms.DataGridView()
        Me.DetailsLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SewingMachineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingLayoutDataSet = New KSoft_Apparel.SewingLayoutDataSet()
        Me.SMV_SEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsManual = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SewingProcessBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProcessNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SewingProcessTableAdapter = New KSoft_Apparel.SewingLayoutDataSetTableAdapters.SewingProcessTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.SewingLayoutDataSetTableAdapters.TableAdapterManager()
        Me.SewingMachineTableAdapter = New KSoft_Apparel.SewingLayoutDataSetTableAdapters.SewingMachineTableAdapter()
        CType(Me.SewingProcessDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingMachineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingLayoutDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingProcessBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SewingProcessDataGridView
        '
        Me.SewingProcessDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SewingProcessDataGridView.AutoGenerateColumns = False
        Me.SewingProcessDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SewingProcessDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SewingProcessDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DetailsLinkColumn, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.SMV_SEC, Me.IsManual, Me.DataGridViewTextBoxColumn4})
        Me.SewingProcessDataGridView.DataSource = Me.SewingProcessBindingSource
        Me.SewingProcessDataGridView.Location = New System.Drawing.Point(0, 38)
        Me.SewingProcessDataGridView.Name = "SewingProcessDataGridView"
        Me.SewingProcessDataGridView.Size = New System.Drawing.Size(720, 319)
        Me.SewingProcessDataGridView.TabIndex = 1
        '
        'DetailsLinkColumn
        '
        Me.DetailsLinkColumn.HeaderText = "Details"
        Me.DetailsLinkColumn.Name = "DetailsLinkColumn"
        Me.DetailsLinkColumn.ReadOnly = True
        Me.DetailsLinkColumn.Text = "Details"
        Me.DetailsLinkColumn.UseColumnTextForLinkValue = True
        Me.DetailsLinkColumn.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProcessName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ProcessName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SewingMachineId"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.SewingMachineBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "ShortName"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.HeaderText = "Machine"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "SewingMachineId"
        '
        'SewingMachineBindingSource
        '
        Me.SewingMachineBindingSource.DataMember = "SewingMachine"
        Me.SewingMachineBindingSource.DataSource = Me.SewingLayoutDataSet
        '
        'SewingLayoutDataSet
        '
        Me.SewingLayoutDataSet.DataSetName = "SewingLayoutDataSet"
        Me.SewingLayoutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SMV_SEC
        '
        Me.SMV_SEC.DataPropertyName = "SMV_SEC"
        Me.SMV_SEC.HeaderText = "SMV SEC"
        Me.SMV_SEC.Name = "SMV_SEC"
        '
        'IsManual
        '
        Me.IsManual.DataPropertyName = "IsManual"
        Me.IsManual.HeaderText = "Manual"
        Me.IsManual.Name = "IsManual"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ProcessType"
        Me.DataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn4.HeaderText = "ProcessType"
        Me.DataGridViewTextBoxColumn4.Items.AddRange(New Object() {"Machine", "Manual"})
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'SewingProcessBindingSource
        '
        Me.SewingProcessBindingSource.DataMember = "SewingProcess"
        Me.SewingProcessBindingSource.DataSource = Me.SewingLayoutDataSet
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(614, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "E&xit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProcessNameTextBox
        '
        Me.ProcessNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProcessNameTextBox.Location = New System.Drawing.Point(256, 12)
        Me.ProcessNameTextBox.Name = "ProcessNameTextBox"
        Me.ProcessNameTextBox.Size = New System.Drawing.Size(454, 20)
        Me.ProcessNameTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search by  Process Name where contains"
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveButton.Location = New System.Drawing.Point(523, 367)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(85, 29)
        Me.SaveButton.TabIndex = 5
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'SewingProcessTableAdapter
        '
        Me.SewingProcessTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SewingBreakDownCopyTableAdapter = Nothing
        Me.TableAdapterManager.SewingBreakDownTableAdapter = Nothing
        Me.TableAdapterManager.SewingCategoryTableAdapter = Nothing
        Me.TableAdapterManager.SewingLayoutDetailsTableAdapter = Nothing
        Me.TableAdapterManager.SewingLayoutTableAdapter = Nothing
        Me.TableAdapterManager.SewingLearningCurveTableAdapter = Nothing
        Me.TableAdapterManager.SewingMachineLayoutTableAdapter = Nothing
        Me.TableAdapterManager.SewingMachineTableAdapter = Me.SewingMachineTableAdapter
        Me.TableAdapterManager.SewingProcessTableAdapter = Me.SewingProcessTableAdapter
        Me.TableAdapterManager.SewingSMVCopyTableAdapter = Nothing
        Me.TableAdapterManager.SewingSMVTableAdapter = Nothing
        Me.TableAdapterManager.SewingTargetAllocationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SewingLayoutDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SewingMachineTableAdapter
        '
        Me.SewingMachineTableAdapter.ClearBeforeFill = True
        '
        'frmSewingProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 408)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProcessNameTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SewingProcessDataGridView)
        Me.Name = "frmSewingProcess"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Sewing Process"
        CType(Me.SewingProcessDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingMachineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingLayoutDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingProcessBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SewingLayoutDataSet As KSoft_Apparel.SewingLayoutDataSet
    Friend WithEvents SewingProcessBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SewingProcessTableAdapter As KSoft_Apparel.SewingLayoutDataSetTableAdapters.SewingProcessTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.SewingLayoutDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SewingMachineTableAdapter As KSoft_Apparel.SewingLayoutDataSetTableAdapters.SewingMachineTableAdapter
    Friend WithEvents SewingProcessDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SewingMachineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProcessNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents DetailsLinkColumn As DataGridViewLinkColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents SMV_SEC As DataGridViewTextBoxColumn
    Friend WithEvents IsManual As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewComboBoxColumn
End Class
