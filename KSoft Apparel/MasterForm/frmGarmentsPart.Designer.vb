<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGarmentsPart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGarmentsPart))
        Me.GarmentsPartBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.GarmentsPartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GarmentsPartDataSet = New KSoft_Apparel.GarmentsPartDataSet
        Me.GarmentsPartBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.GarmentsPartDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GarmentsPartTableAdapter = New KSoft_Apparel.GarmentsPartDataSetTableAdapters.GarmentsPartTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.GarmentsPartDataSetTableAdapters.TableAdapterManager
        CType(Me.GarmentsPartBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GarmentsPartBindingNavigator.SuspendLayout()
        CType(Me.GarmentsPartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsPartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsPartDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GarmentsPartBindingNavigator
        '
        Me.GarmentsPartBindingNavigator.AddNewItem = Nothing
        Me.GarmentsPartBindingNavigator.BindingSource = Me.GarmentsPartBindingSource
        Me.GarmentsPartBindingNavigator.CountItem = Nothing
        Me.GarmentsPartBindingNavigator.DeleteItem = Nothing
        Me.GarmentsPartBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GarmentsPartBindingNavigatorSaveItem})
        Me.GarmentsPartBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GarmentsPartBindingNavigator.MoveFirstItem = Nothing
        Me.GarmentsPartBindingNavigator.MoveLastItem = Nothing
        Me.GarmentsPartBindingNavigator.MoveNextItem = Nothing
        Me.GarmentsPartBindingNavigator.MovePreviousItem = Nothing
        Me.GarmentsPartBindingNavigator.Name = "GarmentsPartBindingNavigator"
        Me.GarmentsPartBindingNavigator.PositionItem = Nothing
        Me.GarmentsPartBindingNavigator.Size = New System.Drawing.Size(586, 25)
        Me.GarmentsPartBindingNavigator.TabIndex = 0
        Me.GarmentsPartBindingNavigator.Text = "BindingNavigator1"
        '
        'GarmentsPartBindingSource
        '
        Me.GarmentsPartBindingSource.DataMember = "GarmentsPart"
        Me.GarmentsPartBindingSource.DataSource = Me.GarmentsPartDataSet
        '
        'GarmentsPartDataSet
        '
        Me.GarmentsPartDataSet.DataSetName = "GarmentsPartDataSet"
        Me.GarmentsPartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GarmentsPartBindingNavigatorSaveItem
        '
        Me.GarmentsPartBindingNavigatorSaveItem.Image = CType(resources.GetObject("GarmentsPartBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GarmentsPartBindingNavigatorSaveItem.Name = "GarmentsPartBindingNavigatorSaveItem"
        Me.GarmentsPartBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.GarmentsPartBindingNavigatorSaveItem.Text = "Save Data"
        '
        'GarmentsPartDataGridView
        '
        Me.GarmentsPartDataGridView.AutoGenerateColumns = False
        Me.GarmentsPartDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.GarmentsPartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GarmentsPartDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.Category, Me.DataGridViewTextBoxColumn3})
        Me.GarmentsPartDataGridView.DataSource = Me.GarmentsPartBindingSource
        Me.GarmentsPartDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GarmentsPartDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.GarmentsPartDataGridView.Name = "GarmentsPartDataGridView"
        Me.GarmentsPartDataGridView.Size = New System.Drawing.Size(586, 291)
        Me.GarmentsPartDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'Category
        '
        Me.Category.DataPropertyName = "Category"
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'GarmentsPartTableAdapter
        '
        Me.GarmentsPartTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GarmentsPartTableAdapter = Me.GarmentsPartTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.GarmentsPartDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmGarmentsPart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 316)
        Me.Controls.Add(Me.GarmentsPartDataGridView)
        Me.Controls.Add(Me.GarmentsPartBindingNavigator)
        Me.Name = "frmGarmentsPart"
        Me.Text = "Garments Part"
        CType(Me.GarmentsPartBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GarmentsPartBindingNavigator.ResumeLayout(False)
        Me.GarmentsPartBindingNavigator.PerformLayout()
        CType(Me.GarmentsPartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsPartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsPartDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GarmentsPartDataSet As KSoft_Apparel.GarmentsPartDataSet
    Friend WithEvents GarmentsPartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GarmentsPartTableAdapter As KSoft_Apparel.GarmentsPartDataSetTableAdapters.GarmentsPartTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.GarmentsPartDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GarmentsPartBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents GarmentsPartBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GarmentsPartDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
