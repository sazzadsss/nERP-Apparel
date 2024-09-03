<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFabricBOMInstruction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFabricBOMInstruction))
        Me.FabricBOMInstructionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.FabricBOMInstructionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricBOMInstructionDataSet = New KSoft_Apparel.FabricBOMInstructionDataSet
        Me.FabricBOMInstructionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.FabricBOMInstructionDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FabricBOMInstructionTableAdapter = New KSoft_Apparel.FabricBOMInstructionDataSetTableAdapters.FabricBOMInstructionTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.FabricBOMInstructionDataSetTableAdapters.TableAdapterManager
        CType(Me.FabricBOMInstructionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FabricBOMInstructionBindingNavigator.SuspendLayout()
        CType(Me.FabricBOMInstructionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBOMInstructionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBOMInstructionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FabricBOMInstructionBindingNavigator
        '
        Me.FabricBOMInstructionBindingNavigator.AddNewItem = Nothing
        Me.FabricBOMInstructionBindingNavigator.BindingSource = Me.FabricBOMInstructionBindingSource
        Me.FabricBOMInstructionBindingNavigator.CountItem = Nothing
        Me.FabricBOMInstructionBindingNavigator.DeleteItem = Nothing
        Me.FabricBOMInstructionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FabricBOMInstructionBindingNavigatorSaveItem})
        Me.FabricBOMInstructionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FabricBOMInstructionBindingNavigator.MoveFirstItem = Nothing
        Me.FabricBOMInstructionBindingNavigator.MoveLastItem = Nothing
        Me.FabricBOMInstructionBindingNavigator.MoveNextItem = Nothing
        Me.FabricBOMInstructionBindingNavigator.MovePreviousItem = Nothing
        Me.FabricBOMInstructionBindingNavigator.Name = "FabricBOMInstructionBindingNavigator"
        Me.FabricBOMInstructionBindingNavigator.PositionItem = Nothing
        Me.FabricBOMInstructionBindingNavigator.Size = New System.Drawing.Size(720, 25)
        Me.FabricBOMInstructionBindingNavigator.TabIndex = 0
        Me.FabricBOMInstructionBindingNavigator.Text = "BindingNavigator1"
        '
        'FabricBOMInstructionBindingSource
        '
        Me.FabricBOMInstructionBindingSource.DataMember = "FabricBOMInstruction"
        Me.FabricBOMInstructionBindingSource.DataSource = Me.FabricBOMInstructionDataSet
        '
        'FabricBOMInstructionDataSet
        '
        Me.FabricBOMInstructionDataSet.DataSetName = "FabricBOMInstructionDataSet"
        Me.FabricBOMInstructionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FabricBOMInstructionBindingNavigatorSaveItem
        '
        Me.FabricBOMInstructionBindingNavigatorSaveItem.Image = CType(resources.GetObject("FabricBOMInstructionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FabricBOMInstructionBindingNavigatorSaveItem.Name = "FabricBOMInstructionBindingNavigatorSaveItem"
        Me.FabricBOMInstructionBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.FabricBOMInstructionBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FabricBOMInstructionDataGridView
        '
        Me.FabricBOMInstructionDataGridView.AutoGenerateColumns = False
        Me.FabricBOMInstructionDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.FabricBOMInstructionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FabricBOMInstructionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.FabricBOMInstructionDataGridView.DataSource = Me.FabricBOMInstructionBindingSource
        Me.FabricBOMInstructionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FabricBOMInstructionDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.FabricBOMInstructionDataGridView.Name = "FabricBOMInstructionDataGridView"
        Me.FabricBOMInstructionDataGridView.Size = New System.Drawing.Size(720, 378)
        Me.FabricBOMInstructionDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SLNo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SLNo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'FabricBOMInstructionTableAdapter
        '
        Me.FabricBOMInstructionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FabricBOMInstructionTableAdapter = Me.FabricBOMInstructionTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.FabricBOMInstructionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmFabricBOMInstruction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 403)
        Me.Controls.Add(Me.FabricBOMInstructionDataGridView)
        Me.Controls.Add(Me.FabricBOMInstructionBindingNavigator)
        Me.Name = "frmFabricBOMInstruction"
        Me.Text = "Fabric BOM Instruction"
        CType(Me.FabricBOMInstructionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FabricBOMInstructionBindingNavigator.ResumeLayout(False)
        Me.FabricBOMInstructionBindingNavigator.PerformLayout()
        CType(Me.FabricBOMInstructionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBOMInstructionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBOMInstructionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FabricBOMInstructionDataSet As KSoft_Apparel.FabricBOMInstructionDataSet
    Friend WithEvents FabricBOMInstructionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricBOMInstructionTableAdapter As KSoft_Apparel.FabricBOMInstructionDataSetTableAdapters.FabricBOMInstructionTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.FabricBOMInstructionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FabricBOMInstructionBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents FabricBOMInstructionBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FabricBOMInstructionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
