<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGSM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGSM))
        Me.GSMDataSet = New KSoft_Apparel.GSMDataSet
        Me.GSMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSMTableAdapter = New KSoft_Apparel.GSMDataSetTableAdapters.GSMTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.GSMDataSetTableAdapters.TableAdapterManager
        Me.GSMBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.GSMBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.GSMDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.GSMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GSMBindingNavigator.SuspendLayout()
        CType(Me.GSMDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GSMDataSet
        '
        Me.GSMDataSet.DataSetName = "GSMDataSet"
        Me.GSMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GSMBindingSource
        '
        Me.GSMBindingSource.DataMember = "GSM"
        Me.GSMBindingSource.DataSource = Me.GSMDataSet
        '
        'GSMTableAdapter
        '
        Me.GSMTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GSMTableAdapter = Me.GSMTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.GSMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GSMBindingNavigator
        '
        Me.GSMBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GSMBindingNavigator.BindingSource = Me.GSMBindingSource
        Me.GSMBindingNavigator.CountItem = Nothing
        Me.GSMBindingNavigator.DeleteItem = Nothing
        Me.GSMBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.GSMBindingNavigatorSaveItem})
        Me.GSMBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GSMBindingNavigator.MoveFirstItem = Nothing
        Me.GSMBindingNavigator.MoveLastItem = Nothing
        Me.GSMBindingNavigator.MoveNextItem = Nothing
        Me.GSMBindingNavigator.MovePreviousItem = Nothing
        Me.GSMBindingNavigator.Name = "GSMBindingNavigator"
        Me.GSMBindingNavigator.PositionItem = Nothing
        Me.GSMBindingNavigator.Size = New System.Drawing.Size(387, 25)
        Me.GSMBindingNavigator.TabIndex = 0
        Me.GSMBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'GSMBindingNavigatorSaveItem
        '
        Me.GSMBindingNavigatorSaveItem.Image = CType(resources.GetObject("GSMBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GSMBindingNavigatorSaveItem.Name = "GSMBindingNavigatorSaveItem"
        Me.GSMBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.GSMBindingNavigatorSaveItem.Text = "Save Data"
        '
        'GSMDataGridView
        '
        Me.GSMDataGridView.AllowUserToAddRows = False
        Me.GSMDataGridView.AutoGenerateColumns = False
        Me.GSMDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.GSMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GSMDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2})
        Me.GSMDataGridView.DataSource = Me.GSMBindingSource
        Me.GSMDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GSMDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.GSMDataGridView.Name = "GSMDataGridView"
        Me.GSMDataGridView.Size = New System.Drawing.Size(387, 262)
        Me.GSMDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "GSMCode"
        Me.DataGridViewTextBoxColumn3.HeaderText = "GSMCode"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "GSM"
        Me.DataGridViewTextBoxColumn2.HeaderText = "GSM"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'frmGSM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 287)
        Me.Controls.Add(Me.GSMDataGridView)
        Me.Controls.Add(Me.GSMBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmGSM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmGSM"
        CType(Me.GSMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GSMBindingNavigator.ResumeLayout(False)
        Me.GSMBindingNavigator.PerformLayout()
        CType(Me.GSMDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GSMDataSet As KSoft_Apparel.GSMDataSet
    Friend WithEvents GSMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GSMTableAdapter As KSoft_Apparel.GSMDataSetTableAdapters.GSMTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.GSMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GSMBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GSMBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GSMDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
