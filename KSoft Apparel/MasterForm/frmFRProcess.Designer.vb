<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFRProcess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFRProcess))
        Me.FRProcessDataSet = New KSoft_Apparel.FRProcessDataSet
        Me.FRProcessBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FRProcessTableAdapter = New KSoft_Apparel.FRProcessDataSetTableAdapters.FRProcessTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.FRProcessDataSetTableAdapters.TableAdapterManager
        Me.FRProcessBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.FRProcessBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.FRProcessDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.FRProcessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FRProcessBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FRProcessBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FRProcessBindingNavigator.SuspendLayout()
        CType(Me.FRProcessDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FRProcessDataSet
        '
        Me.FRProcessDataSet.DataSetName = "FRProcessDataSet"
        Me.FRProcessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FRProcessBindingSource
        '
        Me.FRProcessBindingSource.DataMember = "FRProcess"
        Me.FRProcessBindingSource.DataSource = Me.FRProcessDataSet
        '
        'FRProcessTableAdapter
        '
        Me.FRProcessTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FRProcessTableAdapter = Me.FRProcessTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.FRProcessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FRProcessBindingNavigator
        '
        Me.FRProcessBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FRProcessBindingNavigator.BindingSource = Me.FRProcessBindingSource
        Me.FRProcessBindingNavigator.CountItem = Nothing
        Me.FRProcessBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FRProcessBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FRProcessBindingNavigatorSaveItem})
        Me.FRProcessBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FRProcessBindingNavigator.MoveFirstItem = Nothing
        Me.FRProcessBindingNavigator.MoveLastItem = Nothing
        Me.FRProcessBindingNavigator.MoveNextItem = Nothing
        Me.FRProcessBindingNavigator.MovePreviousItem = Nothing
        Me.FRProcessBindingNavigator.Name = "FRProcessBindingNavigator"
        Me.FRProcessBindingNavigator.PositionItem = Nothing
        Me.FRProcessBindingNavigator.Size = New System.Drawing.Size(508, 25)
        Me.FRProcessBindingNavigator.TabIndex = 0
        Me.FRProcessBindingNavigator.Text = "BindingNavigator1"
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
        'FRProcessBindingNavigatorSaveItem
        '
        Me.FRProcessBindingNavigatorSaveItem.Image = CType(resources.GetObject("FRProcessBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FRProcessBindingNavigatorSaveItem.Name = "FRProcessBindingNavigatorSaveItem"
        Me.FRProcessBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.FRProcessBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FRProcessDataGridView
        '
        Me.FRProcessDataGridView.AutoGenerateColumns = False
        Me.FRProcessDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FRProcessDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.FRProcessDataGridView.DataSource = Me.FRProcessBindingSource
        Me.FRProcessDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FRProcessDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.FRProcessDataGridView.Name = "FRProcessDataGridView"
        Me.FRProcessDataGridView.Size = New System.Drawing.Size(508, 326)
        Me.FRProcessDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FRProcessName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FRProcessName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FRNo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FRNo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'frmFRProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 351)
        Me.Controls.Add(Me.FRProcessDataGridView)
        Me.Controls.Add(Me.FRProcessBindingNavigator)
        Me.Name = "frmFRProcess"
        Me.Text = "frmFRProcess"
        CType(Me.FRProcessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FRProcessBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FRProcessBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FRProcessBindingNavigator.ResumeLayout(False)
        Me.FRProcessBindingNavigator.PerformLayout()
        CType(Me.FRProcessDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FRProcessDataSet As KSoft_Apparel.FRProcessDataSet
    Friend WithEvents FRProcessBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FRProcessTableAdapter As KSoft_Apparel.FRProcessDataSetTableAdapters.FRProcessTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.FRProcessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FRProcessBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FRProcessBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FRProcessDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
