<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SewingCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SewingCategory))
        Me.SewingLayoutDataSet = New KSoft_Apparel.SewingLayoutDataSet
        Me.SewingCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingCategoryTableAdapter = New KSoft_Apparel.SewingLayoutDataSetTableAdapters.SewingCategoryTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.SewingLayoutDataSetTableAdapters.TableAdapterManager
        Me.SewingCategoryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.SewingCategoryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.SewingCategoryDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.SewingLayoutDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingCategoryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SewingCategoryBindingNavigator.SuspendLayout()
        CType(Me.SewingCategoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SewingLayoutDataSet
        '
        Me.SewingLayoutDataSet.DataSetName = "SewingLayoutDataSet"
        Me.SewingLayoutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SewingCategoryBindingSource
        '
        Me.SewingCategoryBindingSource.DataMember = "SewingCategory"
        Me.SewingCategoryBindingSource.DataSource = Me.SewingLayoutDataSet
        '
        'SewingCategoryTableAdapter
        '
        Me.SewingCategoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SewingBreakDownCopyTableAdapter = Nothing
        Me.TableAdapterManager.SewingBreakDownTableAdapter = Nothing
        Me.TableAdapterManager.SewingCategoryTableAdapter = Me.SewingCategoryTableAdapter
        Me.TableAdapterManager.SewingLayoutDetailsTableAdapter = Nothing
        Me.TableAdapterManager.SewingLayoutTableAdapter = Nothing
        Me.TableAdapterManager.SewingLearningCurveTableAdapter = Nothing
        Me.TableAdapterManager.SewingMachineLayoutTableAdapter = Nothing
        Me.TableAdapterManager.SewingMachineTableAdapter = Nothing
        Me.TableAdapterManager.SewingProcessTableAdapter = Nothing
        Me.TableAdapterManager.SewingSMVCopyTableAdapter = Nothing
        Me.TableAdapterManager.SewingSMVTableAdapter = Nothing
        Me.TableAdapterManager.SewingTargetAllocationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SewingLayoutDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SewingCategoryBindingNavigator
        '
        Me.SewingCategoryBindingNavigator.AddNewItem = Nothing
        Me.SewingCategoryBindingNavigator.BindingSource = Me.SewingCategoryBindingSource
        Me.SewingCategoryBindingNavigator.CountItem = Nothing
        Me.SewingCategoryBindingNavigator.DeleteItem = Nothing
        Me.SewingCategoryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SewingCategoryBindingNavigatorSaveItem})
        Me.SewingCategoryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SewingCategoryBindingNavigator.MoveFirstItem = Nothing
        Me.SewingCategoryBindingNavigator.MoveLastItem = Nothing
        Me.SewingCategoryBindingNavigator.MoveNextItem = Nothing
        Me.SewingCategoryBindingNavigator.MovePreviousItem = Nothing
        Me.SewingCategoryBindingNavigator.Name = "SewingCategoryBindingNavigator"
        Me.SewingCategoryBindingNavigator.PositionItem = Nothing
        Me.SewingCategoryBindingNavigator.Size = New System.Drawing.Size(493, 25)
        Me.SewingCategoryBindingNavigator.TabIndex = 0
        Me.SewingCategoryBindingNavigator.Text = "BindingNavigator1"
        '
        'SewingCategoryBindingNavigatorSaveItem
        '
        Me.SewingCategoryBindingNavigatorSaveItem.Image = CType(resources.GetObject("SewingCategoryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SewingCategoryBindingNavigatorSaveItem.Name = "SewingCategoryBindingNavigatorSaveItem"
        Me.SewingCategoryBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.SewingCategoryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SewingCategoryDataGridView
        '
        Me.SewingCategoryDataGridView.AutoGenerateColumns = False
        Me.SewingCategoryDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SewingCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SewingCategoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.SewingCategoryDataGridView.DataSource = Me.SewingCategoryBindingSource
        Me.SewingCategoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SewingCategoryDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.SewingCategoryDataGridView.Name = "SewingCategoryDataGridView"
        Me.SewingCategoryDataGridView.Size = New System.Drawing.Size(493, 282)
        Me.SewingCategoryDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CategoryName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Category Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CategoryPercentage"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Category Percentage"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'SewingCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 307)
        Me.Controls.Add(Me.SewingCategoryDataGridView)
        Me.Controls.Add(Me.SewingCategoryBindingNavigator)
        Me.Name = "SewingCategory"
        Me.Text = "Sewing Category"
        CType(Me.SewingLayoutDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingCategoryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SewingCategoryBindingNavigator.ResumeLayout(False)
        Me.SewingCategoryBindingNavigator.PerformLayout()
        CType(Me.SewingCategoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SewingLayoutDataSet As KSoft_Apparel.SewingLayoutDataSet
    Friend WithEvents SewingCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SewingCategoryTableAdapter As KSoft_Apparel.SewingLayoutDataSetTableAdapters.SewingCategoryTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.SewingLayoutDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SewingCategoryBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents SewingCategoryBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SewingCategoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
