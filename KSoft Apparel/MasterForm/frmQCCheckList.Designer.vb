<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQCCheckList
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQCCheckList))
        Me.QCCheckListDataSet = New KSoft_Apparel.QCCheckListDataSet()
        Me.QCCheckListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QCCheckListTableAdapter = New KSoft_Apparel.QCCheckListDataSetTableAdapters.QCCheckListTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.QCCheckListDataSetTableAdapters.TableAdapterManager()
        Me.QCCheckListBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.QCCheckListBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.QCCheckListDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.GarmentType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.QCCheckListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QCCheckListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QCCheckListBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QCCheckListBindingNavigator.SuspendLayout()
        CType(Me.QCCheckListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QCCheckListDataSet
        '
        Me.QCCheckListDataSet.DataSetName = "QCCheckListDataSet"
        Me.QCCheckListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QCCheckListBindingSource
        '
        Me.QCCheckListBindingSource.DataMember = "QCCheckList"
        Me.QCCheckListBindingSource.DataSource = Me.QCCheckListDataSet
        '
        'QCCheckListTableAdapter
        '
        Me.QCCheckListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.QCCheckListTableAdapter = Me.QCCheckListTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.QCCheckListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'QCCheckListBindingNavigator
        '
        Me.QCCheckListBindingNavigator.AddNewItem = Nothing
        Me.QCCheckListBindingNavigator.BindingSource = Me.QCCheckListBindingSource
        Me.QCCheckListBindingNavigator.CountItem = Nothing
        Me.QCCheckListBindingNavigator.DeleteItem = Nothing
        Me.QCCheckListBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QCCheckListBindingNavigatorSaveItem})
        Me.QCCheckListBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.QCCheckListBindingNavigator.MoveFirstItem = Nothing
        Me.QCCheckListBindingNavigator.MoveLastItem = Nothing
        Me.QCCheckListBindingNavigator.MoveNextItem = Nothing
        Me.QCCheckListBindingNavigator.MovePreviousItem = Nothing
        Me.QCCheckListBindingNavigator.Name = "QCCheckListBindingNavigator"
        Me.QCCheckListBindingNavigator.PositionItem = Nothing
        Me.QCCheckListBindingNavigator.Size = New System.Drawing.Size(654, 25)
        Me.QCCheckListBindingNavigator.TabIndex = 0
        Me.QCCheckListBindingNavigator.Text = "BindingNavigator1"
        '
        'QCCheckListBindingNavigatorSaveItem
        '
        Me.QCCheckListBindingNavigatorSaveItem.Image = CType(resources.GetObject("QCCheckListBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.QCCheckListBindingNavigatorSaveItem.Name = "QCCheckListBindingNavigatorSaveItem"
        Me.QCCheckListBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.QCCheckListBindingNavigatorSaveItem.Text = "Save Data"
        '
        'QCCheckListDataGridView
        '
        Me.QCCheckListDataGridView.AutoGenerateColumns = False
        Me.QCCheckListDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.QCCheckListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QCCheckListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.GarmentType})
        Me.QCCheckListDataGridView.DataSource = Me.QCCheckListBindingSource
        Me.QCCheckListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QCCheckListDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.QCCheckListDataGridView.Name = "QCCheckListDataGridView"
        Me.QCCheckListDataGridView.Size = New System.Drawing.Size(654, 299)
        Me.QCCheckListDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Category"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn3.Items.AddRange(New Object() {"Alter", "Spot n Shade", "Reject"})
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Department"
        Me.DataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn4.HeaderText = "Department"
        Me.DataGridViewTextBoxColumn4.Items.AddRange(New Object() {"Cutting", "Printing", "Sewing", "Finishing"})
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'GarmentType
        '
        Me.GarmentType.DataPropertyName = "GarmentType"
        Me.GarmentType.HeaderText = "GarmentType"
        Me.GarmentType.Name = "GarmentType"
        '
        'frmQCCheckList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 324)
        Me.Controls.Add(Me.QCCheckListDataGridView)
        Me.Controls.Add(Me.QCCheckListBindingNavigator)
        Me.Name = "frmQCCheckList"
        Me.Text = "QC Check List"
        CType(Me.QCCheckListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QCCheckListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QCCheckListBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QCCheckListBindingNavigator.ResumeLayout(False)
        Me.QCCheckListBindingNavigator.PerformLayout()
        CType(Me.QCCheckListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents QCCheckListDataSet As KSoft_Apparel.QCCheckListDataSet
    Friend WithEvents QCCheckListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QCCheckListTableAdapter As KSoft_Apparel.QCCheckListDataSetTableAdapters.QCCheckListTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.QCCheckListDataSetTableAdapters.TableAdapterManager
    Friend WithEvents QCCheckListBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents QCCheckListBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents QCCheckListDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewComboBoxColumn
    Friend WithEvents GarmentType As DataGridViewTextBoxColumn
End Class
