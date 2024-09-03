<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevelopmentType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevelopmentType))
        Me.DevTypeDataSet = New KSoft_Apparel.DevTypeDataSet
        Me.DevTypeMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DevTypeMstTableAdapter = New KSoft_Apparel.DevTypeDataSetTableAdapters.DevTypeMstTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.DevTypeDataSetTableAdapters.TableAdapterManager
        Me.DevTypeMstBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.DevTypeMstBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.DevTypeMstDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DevTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevTypeMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevTypeMstBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DevTypeMstBindingNavigator.SuspendLayout()
        CType(Me.DevTypeMstDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DevTypeDataSet
        '
        Me.DevTypeDataSet.DataSetName = "DevTypeDataSet"
        Me.DevTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DevTypeMstBindingSource
        '
        Me.DevTypeMstBindingSource.DataMember = "DevTypeMst"
        Me.DevTypeMstBindingSource.DataSource = Me.DevTypeDataSet
        '
        'DevTypeMstTableAdapter
        '
        Me.DevTypeMstTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DevTypeMstTableAdapter = Me.DevTypeMstTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.DevTypeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DevTypeMstBindingNavigator
        '
        Me.DevTypeMstBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DevTypeMstBindingNavigator.BindingSource = Me.DevTypeMstBindingSource
        Me.DevTypeMstBindingNavigator.CountItem = Nothing
        Me.DevTypeMstBindingNavigator.DeleteItem = Nothing
        Me.DevTypeMstBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.DevTypeMstBindingNavigatorSaveItem})
        Me.DevTypeMstBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DevTypeMstBindingNavigator.MoveFirstItem = Nothing
        Me.DevTypeMstBindingNavigator.MoveLastItem = Nothing
        Me.DevTypeMstBindingNavigator.MoveNextItem = Nothing
        Me.DevTypeMstBindingNavigator.MovePreviousItem = Nothing
        Me.DevTypeMstBindingNavigator.Name = "DevTypeMstBindingNavigator"
        Me.DevTypeMstBindingNavigator.PositionItem = Nothing
        Me.DevTypeMstBindingNavigator.Size = New System.Drawing.Size(337, 25)
        Me.DevTypeMstBindingNavigator.TabIndex = 0
        Me.DevTypeMstBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'DevTypeMstBindingNavigatorSaveItem
        '
        Me.DevTypeMstBindingNavigatorSaveItem.Image = CType(resources.GetObject("DevTypeMstBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DevTypeMstBindingNavigatorSaveItem.Name = "DevTypeMstBindingNavigatorSaveItem"
        Me.DevTypeMstBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.DevTypeMstBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DevTypeMstDataGridView
        '
        Me.DevTypeMstDataGridView.AllowUserToAddRows = False
        Me.DevTypeMstDataGridView.AutoGenerateColumns = False
        Me.DevTypeMstDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.DevTypeMstDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DevTypeMstDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DevTypeMstDataGridView.DataSource = Me.DevTypeMstBindingSource
        Me.DevTypeMstDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DevTypeMstDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.DevTypeMstDataGridView.Name = "DevTypeMstDataGridView"
        Me.DevTypeMstDataGridView.Size = New System.Drawing.Size(337, 265)
        Me.DevTypeMstDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DevTypeId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DevType"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Development Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'frmDevelopmentType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 290)
        Me.Controls.Add(Me.DevTypeMstDataGridView)
        Me.Controls.Add(Me.DevTypeMstBindingNavigator)
        Me.Name = "frmDevelopmentType"
        Me.Text = "Development Type"
        CType(Me.DevTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevTypeMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevTypeMstBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DevTypeMstBindingNavigator.ResumeLayout(False)
        Me.DevTypeMstBindingNavigator.PerformLayout()
        CType(Me.DevTypeMstDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DevTypeDataSet As KSoft_Apparel.DevTypeDataSet
    Friend WithEvents DevTypeMstBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DevTypeMstTableAdapter As KSoft_Apparel.DevTypeDataSetTableAdapters.DevTypeMstTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.DevTypeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DevTypeMstBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DevTypeMstBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DevTypeMstDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
