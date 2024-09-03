<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPMList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPMList))
        Me.PMListDataSet = New KSoft_Apparel.PMListDataSet
        Me.PMListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PMListTableAdapter = New KSoft_Apparel.PMListDataSetTableAdapters.PMListTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.PMListDataSetTableAdapters.TableAdapterManager
        Me.PMListBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.PMListBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.PMListDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.PMListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMListBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PMListBindingNavigator.SuspendLayout()
        CType(Me.PMListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PMListDataSet
        '
        Me.PMListDataSet.DataSetName = "PMListDataSet"
        Me.PMListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PMListBindingSource
        '
        Me.PMListBindingSource.DataMember = "PMList"
        Me.PMListBindingSource.DataSource = Me.PMListDataSet
        '
        'PMListTableAdapter
        '
        Me.PMListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PMListTableAdapter = Me.PMListTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.PMListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PMListBindingNavigator
        '
        Me.PMListBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PMListBindingNavigator.BindingSource = Me.PMListBindingSource
        Me.PMListBindingNavigator.CountItem = Nothing
        Me.PMListBindingNavigator.DeleteItem = Nothing
        Me.PMListBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.PMListBindingNavigatorSaveItem})
        Me.PMListBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PMListBindingNavigator.MoveFirstItem = Nothing
        Me.PMListBindingNavigator.MoveLastItem = Nothing
        Me.PMListBindingNavigator.MoveNextItem = Nothing
        Me.PMListBindingNavigator.MovePreviousItem = Nothing
        Me.PMListBindingNavigator.Name = "PMListBindingNavigator"
        Me.PMListBindingNavigator.PositionItem = Nothing
        Me.PMListBindingNavigator.Size = New System.Drawing.Size(409, 25)
        Me.PMListBindingNavigator.TabIndex = 0
        Me.PMListBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'PMListBindingNavigatorSaveItem
        '
        Me.PMListBindingNavigatorSaveItem.Image = CType(resources.GetObject("PMListBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PMListBindingNavigatorSaveItem.Name = "PMListBindingNavigatorSaveItem"
        Me.PMListBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.PMListBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PMListDataGridView
        '
        Me.PMListDataGridView.AutoGenerateColumns = False
        Me.PMListDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.PMListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PMListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.PMListDataGridView.DataSource = Me.PMListBindingSource
        Me.PMListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PMListDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.PMListDataGridView.Name = "PMListDataGridView"
        Me.PMListDataGridView.Size = New System.Drawing.Size(409, 266)
        Me.PMListDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PMName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PM Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'frmPMList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(409, 291)
        Me.Controls.Add(Me.PMListDataGridView)
        Me.Controls.Add(Me.PMListBindingNavigator)
        Me.Name = "frmPMList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PM List"
        CType(Me.PMListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMListBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PMListBindingNavigator.ResumeLayout(False)
        Me.PMListBindingNavigator.PerformLayout()
        CType(Me.PMListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PMListDataSet As KSoft_Apparel.PMListDataSet
    Friend WithEvents PMListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PMListTableAdapter As KSoft_Apparel.PMListDataSetTableAdapters.PMListTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.PMListDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PMListBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PMListBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PMListDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
