<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSewingMachine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSewingMachine))
        Me.SewingMachineBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.SewingMachineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingLayoutDataSet = New KSoft_Apparel.SewingLayoutDataSet
        Me.SewingMachineBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.SewingMachineDataGridView = New System.Windows.Forms.DataGridView
        Me.SewingMachineTableAdapter = New KSoft_Apparel.SewingLayoutDataSetTableAdapters.SewingMachineTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.SewingLayoutDataSetTableAdapters.TableAdapterManager
        Me.Discontinue = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SecIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MachineQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LoanFrom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LoanTo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OutOfOrder = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.SewingMachineBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SewingMachineBindingNavigator.SuspendLayout()
        CType(Me.SewingMachineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingLayoutDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingMachineDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SewingMachineBindingNavigator
        '
        Me.SewingMachineBindingNavigator.AddNewItem = Nothing
        Me.SewingMachineBindingNavigator.BindingSource = Me.SewingMachineBindingSource
        Me.SewingMachineBindingNavigator.CountItem = Nothing
        Me.SewingMachineBindingNavigator.DeleteItem = Nothing
        Me.SewingMachineBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SewingMachineBindingNavigatorSaveItem})
        Me.SewingMachineBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SewingMachineBindingNavigator.MoveFirstItem = Nothing
        Me.SewingMachineBindingNavigator.MoveLastItem = Nothing
        Me.SewingMachineBindingNavigator.MoveNextItem = Nothing
        Me.SewingMachineBindingNavigator.MovePreviousItem = Nothing
        Me.SewingMachineBindingNavigator.Name = "SewingMachineBindingNavigator"
        Me.SewingMachineBindingNavigator.PositionItem = Nothing
        Me.SewingMachineBindingNavigator.Size = New System.Drawing.Size(1014, 25)
        Me.SewingMachineBindingNavigator.TabIndex = 0
        Me.SewingMachineBindingNavigator.Text = "BindingNavigator1"
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
        'SewingMachineBindingNavigatorSaveItem
        '
        Me.SewingMachineBindingNavigatorSaveItem.Image = CType(resources.GetObject("SewingMachineBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SewingMachineBindingNavigatorSaveItem.Name = "SewingMachineBindingNavigatorSaveItem"
        Me.SewingMachineBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.SewingMachineBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SewingMachineDataGridView
        '
        Me.SewingMachineDataGridView.AutoGenerateColumns = False
        Me.SewingMachineDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SewingMachineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SewingMachineDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Discontinue, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.SecIN, Me.MachineQuantity, Me.LoanFrom, Me.LoanTo, Me.OutOfOrder, Me.Remarks})
        Me.SewingMachineDataGridView.DataSource = Me.SewingMachineBindingSource
        Me.SewingMachineDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SewingMachineDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.SewingMachineDataGridView.Name = "SewingMachineDataGridView"
        Me.SewingMachineDataGridView.Size = New System.Drawing.Size(1014, 317)
        Me.SewingMachineDataGridView.TabIndex = 1
        '
        'SewingMachineTableAdapter
        '
        Me.SewingMachineTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.SewingProcessTableAdapter = Nothing
        Me.TableAdapterManager.SewingSMVCopyTableAdapter = Nothing
        Me.TableAdapterManager.SewingSMVTableAdapter = Nothing
        Me.TableAdapterManager.SewingTargetAllocationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SewingLayoutDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Discontinue
        '
        Me.Discontinue.DataPropertyName = "Discontinue"
        Me.Discontinue.HeaderText = "Discontinue"
        Me.Discontinue.Name = "Discontinue"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ShortName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Short Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FullName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Full Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'SecIN
        '
        Me.SecIN.DataPropertyName = "SecIN"
        Me.SecIN.HeaderText = "SecIN"
        Me.SecIN.Name = "SecIN"
        '
        'MachineQuantity
        '
        Me.MachineQuantity.DataPropertyName = "MachineQuantity"
        Me.MachineQuantity.HeaderText = "Machine Quantity"
        Me.MachineQuantity.Name = "MachineQuantity"
        '
        'LoanFrom
        '
        Me.LoanFrom.DataPropertyName = "LoanFrom"
        Me.LoanFrom.HeaderText = "LoanFrom"
        Me.LoanFrom.Name = "LoanFrom"
        '
        'LoanTo
        '
        Me.LoanTo.DataPropertyName = "LoanTo"
        Me.LoanTo.HeaderText = "LoanTo"
        Me.LoanTo.Name = "LoanTo"
        '
        'OutOfOrder
        '
        Me.OutOfOrder.DataPropertyName = "OutOfOrder"
        Me.OutOfOrder.HeaderText = "OutOfOrder"
        Me.OutOfOrder.Name = "OutOfOrder"
        '
        'Remarks
        '
        Me.Remarks.DataPropertyName = "Remarks"
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        '
        'frmSewingMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 342)
        Me.Controls.Add(Me.SewingMachineDataGridView)
        Me.Controls.Add(Me.SewingMachineBindingNavigator)
        Me.Name = "frmSewingMachine"
        Me.Text = "Sewing Machine"
        CType(Me.SewingMachineBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SewingMachineBindingNavigator.ResumeLayout(False)
        Me.SewingMachineBindingNavigator.PerformLayout()
        CType(Me.SewingMachineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingLayoutDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingMachineDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SewingLayoutDataSet As KSoft_Apparel.SewingLayoutDataSet
    Friend WithEvents SewingMachineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SewingMachineTableAdapter As KSoft_Apparel.SewingLayoutDataSetTableAdapters.SewingMachineTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.SewingLayoutDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SewingMachineBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents SewingMachineBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SewingMachineDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Discontinue As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SecIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MachineQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoanFrom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoanTo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OutOfOrder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
