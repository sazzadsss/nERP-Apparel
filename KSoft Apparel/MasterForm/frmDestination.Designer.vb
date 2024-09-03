<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDestination
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDestination))
        Me.DestinationDataSet = New KSoft_Apparel.DestinationDataSet
        Me.DestinationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DestinationTableAdapter = New KSoft_Apparel.DestinationDataSetTableAdapters.DestinationTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.DestinationDataSetTableAdapters.TableAdapterManager
        Me.DestinationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.DestinationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.DestinationDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DestinationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DestinationBindingNavigator.SuspendLayout()
        CType(Me.DestinationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DestinationDataSet
        '
        Me.DestinationDataSet.DataSetName = "DestinationDataSet"
        Me.DestinationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DestinationBindingSource
        '
        Me.DestinationBindingSource.DataMember = "Destination"
        Me.DestinationBindingSource.DataSource = Me.DestinationDataSet
        '
        'DestinationTableAdapter
        '
        Me.DestinationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DestinationTableAdapter = Me.DestinationTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.DestinationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DestinationBindingNavigator
        '
        Me.DestinationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DestinationBindingNavigator.BindingSource = Me.DestinationBindingSource
        Me.DestinationBindingNavigator.CountItem = Nothing
        Me.DestinationBindingNavigator.DeleteItem = Nothing
        Me.DestinationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.DestinationBindingNavigatorSaveItem})
        Me.DestinationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DestinationBindingNavigator.MoveFirstItem = Nothing
        Me.DestinationBindingNavigator.MoveLastItem = Nothing
        Me.DestinationBindingNavigator.MoveNextItem = Nothing
        Me.DestinationBindingNavigator.MovePreviousItem = Nothing
        Me.DestinationBindingNavigator.Name = "DestinationBindingNavigator"
        Me.DestinationBindingNavigator.PositionItem = Nothing
        Me.DestinationBindingNavigator.Size = New System.Drawing.Size(476, 25)
        Me.DestinationBindingNavigator.TabIndex = 0
        Me.DestinationBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'DestinationBindingNavigatorSaveItem
        '
        Me.DestinationBindingNavigatorSaveItem.Image = CType(resources.GetObject("DestinationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DestinationBindingNavigatorSaveItem.Name = "DestinationBindingNavigatorSaveItem"
        Me.DestinationBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.DestinationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DestinationDataGridView
        '
        Me.DestinationDataGridView.AutoGenerateColumns = False
        Me.DestinationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DestinationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.DestinationDataGridView.DataSource = Me.DestinationBindingSource
        Me.DestinationDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DestinationDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.DestinationDataGridView.Name = "DestinationDataGridView"
        Me.DestinationDataGridView.Size = New System.Drawing.Size(476, 272)
        Me.DestinationDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DestinationCode"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DestinationCode"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'frmDestination
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 297)
        Me.Controls.Add(Me.DestinationDataGridView)
        Me.Controls.Add(Me.DestinationBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmDestination"
        Me.Text = "Destination"
        CType(Me.DestinationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DestinationBindingNavigator.ResumeLayout(False)
        Me.DestinationBindingNavigator.PerformLayout()
        CType(Me.DestinationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DestinationDataSet As KSoft_Apparel.DestinationDataSet
    Friend WithEvents DestinationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DestinationTableAdapter As KSoft_Apparel.DestinationDataSetTableAdapters.DestinationTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.DestinationDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DestinationBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DestinationBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DestinationDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
