<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActiveMonth
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActiveMonth))
        Me.ActiveMonthDataSet = New KSoft_Apparel.ActiveMonthDataSet
        Me.ActiveMonthBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActiveMonthTableAdapter = New KSoft_Apparel.ActiveMonthDataSetTableAdapters.ActiveMonthTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.ActiveMonthDataSetTableAdapters.TableAdapterManager
        Me.ActiveMonthBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ActiveMonthBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ActiveMonthDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        CType(Me.ActiveMonthDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActiveMonthBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActiveMonthBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ActiveMonthBindingNavigator.SuspendLayout()
        CType(Me.ActiveMonthDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ActiveMonthDataSet
        '
        Me.ActiveMonthDataSet.DataSetName = "ActiveMonthDataSet"
        Me.ActiveMonthDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActiveMonthBindingSource
        '
        Me.ActiveMonthBindingSource.DataMember = "ActiveMonth"
        Me.ActiveMonthBindingSource.DataSource = Me.ActiveMonthDataSet
        '
        'ActiveMonthTableAdapter
        '
        Me.ActiveMonthTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActiveMonthTableAdapter = Me.ActiveMonthTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.ActiveMonthDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ActiveMonthBindingNavigator
        '
        Me.ActiveMonthBindingNavigator.AddNewItem = Nothing
        Me.ActiveMonthBindingNavigator.BindingSource = Me.ActiveMonthBindingSource
        Me.ActiveMonthBindingNavigator.CountItem = Nothing
        Me.ActiveMonthBindingNavigator.DeleteItem = Nothing
        Me.ActiveMonthBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActiveMonthBindingNavigatorSaveItem})
        Me.ActiveMonthBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ActiveMonthBindingNavigator.MoveFirstItem = Nothing
        Me.ActiveMonthBindingNavigator.MoveLastItem = Nothing
        Me.ActiveMonthBindingNavigator.MoveNextItem = Nothing
        Me.ActiveMonthBindingNavigator.MovePreviousItem = Nothing
        Me.ActiveMonthBindingNavigator.Name = "ActiveMonthBindingNavigator"
        Me.ActiveMonthBindingNavigator.PositionItem = Nothing
        Me.ActiveMonthBindingNavigator.Size = New System.Drawing.Size(376, 25)
        Me.ActiveMonthBindingNavigator.TabIndex = 0
        Me.ActiveMonthBindingNavigator.Text = "BindingNavigator1"
        '
        'ActiveMonthBindingNavigatorSaveItem
        '
        Me.ActiveMonthBindingNavigatorSaveItem.Image = CType(resources.GetObject("ActiveMonthBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ActiveMonthBindingNavigatorSaveItem.Name = "ActiveMonthBindingNavigatorSaveItem"
        Me.ActiveMonthBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.ActiveMonthBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ActiveMonthDataGridView
        '
        Me.ActiveMonthDataGridView.AutoGenerateColumns = False
        Me.ActiveMonthDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ActiveMonthDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ActiveMonthDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1})
        Me.ActiveMonthDataGridView.DataSource = Me.ActiveMonthBindingSource
        Me.ActiveMonthDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActiveMonthDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.ActiveMonthDataGridView.Name = "ActiveMonthDataGridView"
        Me.ActiveMonthDataGridView.Size = New System.Drawing.Size(376, 253)
        Me.ActiveMonthDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MonthNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MonthNo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "YearNo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "YearNo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Active"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Active"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'frmActiveMonth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 278)
        Me.Controls.Add(Me.ActiveMonthDataGridView)
        Me.Controls.Add(Me.ActiveMonthBindingNavigator)
        Me.Name = "frmActiveMonth"
        Me.Text = "Active Month"
        CType(Me.ActiveMonthDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActiveMonthBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActiveMonthBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ActiveMonthBindingNavigator.ResumeLayout(False)
        Me.ActiveMonthBindingNavigator.PerformLayout()
        CType(Me.ActiveMonthDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ActiveMonthDataSet As KSoft_Apparel.ActiveMonthDataSet
    Friend WithEvents ActiveMonthBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActiveMonthTableAdapter As KSoft_Apparel.ActiveMonthDataSetTableAdapters.ActiveMonthTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.ActiveMonthDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ActiveMonthBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ActiveMonthBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ActiveMonthDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
