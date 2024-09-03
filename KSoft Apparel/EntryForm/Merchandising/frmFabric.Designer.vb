<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFabric
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFabric))
        Me.FabricDataSet = New KSoft_Apparel.FabricDataSet
        Me.FabricBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricTableAdapter = New KSoft_Apparel.FabricDataSetTableAdapters.FabricTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.FabricDataSetTableAdapters.TableAdapterManager
        Me.FabricBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.FabricBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.FabricDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        CType(Me.FabricDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FabricBindingNavigator.SuspendLayout()
        CType(Me.FabricDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FabricDataSet
        '
        Me.FabricDataSet.DataSetName = "FabricDataSet"
        Me.FabricDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FabricBindingSource
        '
        Me.FabricBindingSource.DataMember = "Fabric"
        Me.FabricBindingSource.DataSource = Me.FabricDataSet
        '
        'FabricTableAdapter
        '
        Me.FabricTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FabricTableAdapter = Me.FabricTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.FabricDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FabricBindingNavigator
        '
        Me.FabricBindingNavigator.AddNewItem = Nothing
        Me.FabricBindingNavigator.BindingSource = Me.FabricBindingSource
        Me.FabricBindingNavigator.CountItem = Nothing
        Me.FabricBindingNavigator.DeleteItem = Nothing
        Me.FabricBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorSeparator2, Me.FabricBindingNavigatorSaveItem})
        Me.FabricBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FabricBindingNavigator.MoveFirstItem = Nothing
        Me.FabricBindingNavigator.MoveLastItem = Nothing
        Me.FabricBindingNavigator.MoveNextItem = Nothing
        Me.FabricBindingNavigator.MovePreviousItem = Nothing
        Me.FabricBindingNavigator.Name = "FabricBindingNavigator"
        Me.FabricBindingNavigator.PositionItem = Nothing
        Me.FabricBindingNavigator.Size = New System.Drawing.Size(552, 25)
        Me.FabricBindingNavigator.TabIndex = 0
        Me.FabricBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'FabricBindingNavigatorSaveItem
        '
        Me.FabricBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FabricBindingNavigatorSaveItem.Image = CType(resources.GetObject("FabricBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FabricBindingNavigatorSaveItem.Name = "FabricBindingNavigatorSaveItem"
        Me.FabricBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FabricBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FabricDataGridView
        '
        Me.FabricDataGridView.AutoGenerateColumns = False
        Me.FabricDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FabricDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn1})
        Me.FabricDataGridView.DataSource = Me.FabricBindingSource
        Me.FabricDataGridView.Location = New System.Drawing.Point(12, 40)
        Me.FabricDataGridView.Name = "FabricDataGridView"
        Me.FabricDataGridView.Size = New System.Drawing.Size(528, 274)
        Me.FabricDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FabricId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "FabricId"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "OrderId"
        Me.DataGridViewTextBoxColumn2.HeaderText = "OrderId"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "GSMId"
        Me.DataGridViewTextBoxColumn3.HeaderText = "GSMId"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "KnittingTypeId"
        Me.DataGridViewTextBoxColumn4.HeaderText = "KnittingTypeId"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "YarnTypeId"
        Me.DataGridViewTextBoxColumn5.HeaderText = "YarnTypeId"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DyeingTypeId"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DyeingTypeId"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "IsAllOverPrint"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "IsAllOverPrint"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'frmFabric
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 326)
        Me.Controls.Add(Me.FabricDataGridView)
        Me.Controls.Add(Me.FabricBindingNavigator)
        Me.Name = "frmFabric"
        Me.Text = "frmFabric"
        CType(Me.FabricDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FabricBindingNavigator.ResumeLayout(False)
        Me.FabricBindingNavigator.PerformLayout()
        CType(Me.FabricDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FabricDataSet As KSoft_Apparel.FabricDataSet
    Friend WithEvents FabricBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricTableAdapter As KSoft_Apparel.FabricDataSetTableAdapters.FabricTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.FabricDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FabricBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FabricBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FabricDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
