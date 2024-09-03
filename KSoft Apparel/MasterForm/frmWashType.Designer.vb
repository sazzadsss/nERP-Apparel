<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWashType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWashType))
        Me.WashTypeDataSet = New KSoft_Apparel.WashTypeDataSet
        Me.WashTypeMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WashTypeMstTableAdapter = New KSoft_Apparel.WashTypeDataSetTableAdapters.WashTypeMstTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.WashTypeDataSetTableAdapters.TableAdapterManager
        Me.WashTypeMstBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.WashTypeMstBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.WashTypeMstDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.WashTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeMstBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WashTypeMstBindingNavigator.SuspendLayout()
        CType(Me.WashTypeMstDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WashTypeDataSet
        '
        Me.WashTypeDataSet.DataSetName = "WashTypeDataSet"
        Me.WashTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WashTypeMstBindingSource
        '
        Me.WashTypeMstBindingSource.DataMember = "WashTypeMst"
        Me.WashTypeMstBindingSource.DataSource = Me.WashTypeDataSet
        '
        'WashTypeMstTableAdapter
        '
        Me.WashTypeMstTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.WashTypeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WashTypeMstTableAdapter = Me.WashTypeMstTableAdapter
        '
        'WashTypeMstBindingNavigator
        '
        Me.WashTypeMstBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.WashTypeMstBindingNavigator.BindingSource = Me.WashTypeMstBindingSource
        Me.WashTypeMstBindingNavigator.CountItem = Nothing
        Me.WashTypeMstBindingNavigator.DeleteItem = Nothing
        Me.WashTypeMstBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.WashTypeMstBindingNavigatorSaveItem})
        Me.WashTypeMstBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.WashTypeMstBindingNavigator.MoveFirstItem = Nothing
        Me.WashTypeMstBindingNavigator.MoveLastItem = Nothing
        Me.WashTypeMstBindingNavigator.MoveNextItem = Nothing
        Me.WashTypeMstBindingNavigator.MovePreviousItem = Nothing
        Me.WashTypeMstBindingNavigator.Name = "WashTypeMstBindingNavigator"
        Me.WashTypeMstBindingNavigator.PositionItem = Nothing
        Me.WashTypeMstBindingNavigator.Size = New System.Drawing.Size(418, 25)
        Me.WashTypeMstBindingNavigator.TabIndex = 0
        Me.WashTypeMstBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'WashTypeMstBindingNavigatorSaveItem
        '
        Me.WashTypeMstBindingNavigatorSaveItem.Image = CType(resources.GetObject("WashTypeMstBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.WashTypeMstBindingNavigatorSaveItem.Name = "WashTypeMstBindingNavigatorSaveItem"
        Me.WashTypeMstBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.WashTypeMstBindingNavigatorSaveItem.Text = "Save Data"
        '
        'WashTypeMstDataGridView
        '
        Me.WashTypeMstDataGridView.AllowUserToAddRows = False
        Me.WashTypeMstDataGridView.AutoGenerateColumns = False
        Me.WashTypeMstDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.WashTypeMstDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WashTypeMstDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.WashTypeMstDataGridView.DataSource = Me.WashTypeMstBindingSource
        Me.WashTypeMstDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WashTypeMstDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.WashTypeMstDataGridView.Name = "WashTypeMstDataGridView"
        Me.WashTypeMstDataGridView.Size = New System.Drawing.Size(418, 266)
        Me.WashTypeMstDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "WashTypeId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "WashType"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Wash Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'frmWashType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 291)
        Me.Controls.Add(Me.WashTypeMstDataGridView)
        Me.Controls.Add(Me.WashTypeMstBindingNavigator)
        Me.Name = "frmWashType"
        Me.Text = "Wash Type Master"
        CType(Me.WashTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeMstBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WashTypeMstBindingNavigator.ResumeLayout(False)
        Me.WashTypeMstBindingNavigator.PerformLayout()
        CType(Me.WashTypeMstDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WashTypeDataSet As KSoft_Apparel.WashTypeDataSet
    Friend WithEvents WashTypeMstBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WashTypeMstTableAdapter As KSoft_Apparel.WashTypeDataSetTableAdapters.WashTypeMstTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.WashTypeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WashTypeMstBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents WashTypeMstBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents WashTypeMstDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
