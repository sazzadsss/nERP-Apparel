<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFloorIncharge
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFloorIncharge))
        Me.FloorInchargeDataSet = New KSoft_Apparel.FloorInchargeDataSet
        Me.FloorInchargeListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FloorInchargeListTableAdapter = New KSoft_Apparel.FloorInchargeDataSetTableAdapters.FloorInchargeListTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.FloorInchargeDataSetTableAdapters.TableAdapterManager
        Me.FloorInchargeListBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.FloorInchargeListBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.FloorInchargeListDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.FloorInchargeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FloorInchargeListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FloorInchargeListBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FloorInchargeListBindingNavigator.SuspendLayout()
        CType(Me.FloorInchargeListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FloorInchargeDataSet
        '
        Me.FloorInchargeDataSet.DataSetName = "FloorInchargeDataSet"
        Me.FloorInchargeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FloorInchargeListBindingSource
        '
        Me.FloorInchargeListBindingSource.DataMember = "FloorInchargeList"
        Me.FloorInchargeListBindingSource.DataSource = Me.FloorInchargeDataSet
        '
        'FloorInchargeListTableAdapter
        '
        Me.FloorInchargeListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FloorInchargeListTableAdapter = Me.FloorInchargeListTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.FloorInchargeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FloorInchargeListBindingNavigator
        '
        Me.FloorInchargeListBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FloorInchargeListBindingNavigator.BindingSource = Me.FloorInchargeListBindingSource
        Me.FloorInchargeListBindingNavigator.CountItem = Nothing
        Me.FloorInchargeListBindingNavigator.DeleteItem = Nothing
        Me.FloorInchargeListBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.FloorInchargeListBindingNavigatorSaveItem})
        Me.FloorInchargeListBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FloorInchargeListBindingNavigator.MoveFirstItem = Nothing
        Me.FloorInchargeListBindingNavigator.MoveLastItem = Nothing
        Me.FloorInchargeListBindingNavigator.MoveNextItem = Nothing
        Me.FloorInchargeListBindingNavigator.MovePreviousItem = Nothing
        Me.FloorInchargeListBindingNavigator.Name = "FloorInchargeListBindingNavigator"
        Me.FloorInchargeListBindingNavigator.PositionItem = Nothing
        Me.FloorInchargeListBindingNavigator.Size = New System.Drawing.Size(447, 25)
        Me.FloorInchargeListBindingNavigator.TabIndex = 0
        Me.FloorInchargeListBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'FloorInchargeListBindingNavigatorSaveItem
        '
        Me.FloorInchargeListBindingNavigatorSaveItem.Image = CType(resources.GetObject("FloorInchargeListBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FloorInchargeListBindingNavigatorSaveItem.Name = "FloorInchargeListBindingNavigatorSaveItem"
        Me.FloorInchargeListBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.FloorInchargeListBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FloorInchargeListDataGridView
        '
        Me.FloorInchargeListDataGridView.AutoGenerateColumns = False
        Me.FloorInchargeListDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.FloorInchargeListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FloorInchargeListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.FloorInchargeListDataGridView.DataSource = Me.FloorInchargeListBindingSource
        Me.FloorInchargeListDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.FloorInchargeListDataGridView.Name = "FloorInchargeListDataGridView"
        Me.FloorInchargeListDataGridView.Size = New System.Drawing.Size(447, 304)
        Me.FloorInchargeListDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'frmFloorIncharge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 333)
        Me.Controls.Add(Me.FloorInchargeListDataGridView)
        Me.Controls.Add(Me.FloorInchargeListBindingNavigator)
        Me.Name = "frmFloorIncharge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Floor Incharge"
        CType(Me.FloorInchargeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FloorInchargeListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FloorInchargeListBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FloorInchargeListBindingNavigator.ResumeLayout(False)
        Me.FloorInchargeListBindingNavigator.PerformLayout()
        CType(Me.FloorInchargeListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FloorInchargeDataSet As KSoft_Apparel.FloorInchargeDataSet
    Friend WithEvents FloorInchargeListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FloorInchargeListTableAdapter As KSoft_Apparel.FloorInchargeDataSetTableAdapters.FloorInchargeListTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.FloorInchargeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FloorInchargeListBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FloorInchargeListBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FloorInchargeListDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
