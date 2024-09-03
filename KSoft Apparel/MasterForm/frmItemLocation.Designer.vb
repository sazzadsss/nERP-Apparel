<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemLocation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemLocation))
        Me.ItemLocationDataSet = New KSoft_Apparel.ItemLocationDataSet
        Me.ItemLocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemLocationTableAdapter = New KSoft_Apparel.ItemLocationDataSetTableAdapters.ItemLocationTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.ItemLocationDataSetTableAdapters.TableAdapterManager
        Me.ItemLocationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.ItemLocationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ItemLocationDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ItemLocationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemLocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemLocationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ItemLocationBindingNavigator.SuspendLayout()
        CType(Me.ItemLocationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemLocationDataSet
        '
        Me.ItemLocationDataSet.DataSetName = "ItemLocationDataSet"
        Me.ItemLocationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemLocationBindingSource
        '
        Me.ItemLocationBindingSource.DataMember = "ItemLocation"
        Me.ItemLocationBindingSource.DataSource = Me.ItemLocationDataSet
        '
        'ItemLocationTableAdapter
        '
        Me.ItemLocationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ItemLocationTableAdapter = Me.ItemLocationTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.ItemLocationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ItemLocationBindingNavigator
        '
        Me.ItemLocationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ItemLocationBindingNavigator.BindingSource = Me.ItemLocationBindingSource
        Me.ItemLocationBindingNavigator.CountItem = Nothing
        Me.ItemLocationBindingNavigator.DeleteItem = Nothing
        Me.ItemLocationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.ItemLocationBindingNavigatorSaveItem})
        Me.ItemLocationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ItemLocationBindingNavigator.MoveFirstItem = Nothing
        Me.ItemLocationBindingNavigator.MoveLastItem = Nothing
        Me.ItemLocationBindingNavigator.MoveNextItem = Nothing
        Me.ItemLocationBindingNavigator.MovePreviousItem = Nothing
        Me.ItemLocationBindingNavigator.Name = "ItemLocationBindingNavigator"
        Me.ItemLocationBindingNavigator.PositionItem = Nothing
        Me.ItemLocationBindingNavigator.Size = New System.Drawing.Size(493, 25)
        Me.ItemLocationBindingNavigator.TabIndex = 0
        Me.ItemLocationBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'ItemLocationBindingNavigatorSaveItem
        '
        Me.ItemLocationBindingNavigatorSaveItem.Image = CType(resources.GetObject("ItemLocationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ItemLocationBindingNavigatorSaveItem.Name = "ItemLocationBindingNavigatorSaveItem"
        Me.ItemLocationBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.ItemLocationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ItemLocationDataGridView
        '
        Me.ItemLocationDataGridView.AllowUserToAddRows = False
        Me.ItemLocationDataGridView.AutoGenerateColumns = False
        Me.ItemLocationDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ItemLocationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemLocationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ItemLocationDataGridView.DataSource = Me.ItemLocationBindingSource
        Me.ItemLocationDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemLocationDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.ItemLocationDataGridView.Name = "ItemLocationDataGridView"
        Me.ItemLocationDataGridView.Size = New System.Drawing.Size(493, 315)
        Me.ItemLocationDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "StepA"
        Me.DataGridViewTextBoxColumn2.HeaderText = "StepA"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "StepB"
        Me.DataGridViewTextBoxColumn3.HeaderText = "StepB"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "StepC"
        Me.DataGridViewTextBoxColumn4.HeaderText = "StepC"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'frmItemLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 340)
        Me.Controls.Add(Me.ItemLocationDataGridView)
        Me.Controls.Add(Me.ItemLocationBindingNavigator)
        Me.Name = "frmItemLocation"
        Me.Text = "Item Location"
        CType(Me.ItemLocationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemLocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemLocationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ItemLocationBindingNavigator.ResumeLayout(False)
        Me.ItemLocationBindingNavigator.PerformLayout()
        CType(Me.ItemLocationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ItemLocationDataSet As KSoft_Apparel.ItemLocationDataSet
    Friend WithEvents ItemLocationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemLocationTableAdapter As KSoft_Apparel.ItemLocationDataSetTableAdapters.ItemLocationTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.ItemLocationDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemLocationBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ItemLocationBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ItemLocationDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
