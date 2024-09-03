<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnitConversion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUnitConversion))
        Me.UnitConversionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.UnitConversionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitConversionDataSet = New KSoft_Apparel.UnitConversionDataSet
        Me.UnitConversionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.UnitConversionDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDataSet = New KSoft_Apparel.UnitDataSet
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CalculateSign = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnitTableAdapter = New KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter
        Me.UnitConversionTableAdapter = New KSoft_Apparel.UnitConversionDataSetTableAdapters.UnitConversionTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.UnitConversionDataSetTableAdapters.TableAdapterManager
        CType(Me.UnitConversionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UnitConversionBindingNavigator.SuspendLayout()
        CType(Me.UnitConversionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitConversionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitConversionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UnitConversionBindingNavigator
        '
        Me.UnitConversionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UnitConversionBindingNavigator.BindingSource = Me.UnitConversionBindingSource
        Me.UnitConversionBindingNavigator.CountItem = Nothing
        Me.UnitConversionBindingNavigator.DeleteItem = Nothing
        Me.UnitConversionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.UnitConversionBindingNavigatorSaveItem})
        Me.UnitConversionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UnitConversionBindingNavigator.MoveFirstItem = Nothing
        Me.UnitConversionBindingNavigator.MoveLastItem = Nothing
        Me.UnitConversionBindingNavigator.MoveNextItem = Nothing
        Me.UnitConversionBindingNavigator.MovePreviousItem = Nothing
        Me.UnitConversionBindingNavigator.Name = "UnitConversionBindingNavigator"
        Me.UnitConversionBindingNavigator.PositionItem = Nothing
        Me.UnitConversionBindingNavigator.Size = New System.Drawing.Size(629, 25)
        Me.UnitConversionBindingNavigator.TabIndex = 0
        Me.UnitConversionBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'UnitConversionBindingSource
        '
        Me.UnitConversionBindingSource.DataMember = "UnitConversion"
        Me.UnitConversionBindingSource.DataSource = Me.UnitConversionDataSet
        '
        'UnitConversionDataSet
        '
        Me.UnitConversionDataSet.DataSetName = "UnitConversionDataSet"
        Me.UnitConversionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UnitConversionBindingNavigatorSaveItem
        '
        Me.UnitConversionBindingNavigatorSaveItem.Image = CType(resources.GetObject("UnitConversionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UnitConversionBindingNavigatorSaveItem.Name = "UnitConversionBindingNavigatorSaveItem"
        Me.UnitConversionBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.UnitConversionBindingNavigatorSaveItem.Text = "Save Data"
        '
        'UnitConversionDataGridView
        '
        Me.UnitConversionDataGridView.AllowUserToAddRows = False
        Me.UnitConversionDataGridView.AutoGenerateColumns = False
        Me.UnitConversionDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.UnitConversionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnitConversionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.CalculateSign, Me.Remarks})
        Me.UnitConversionDataGridView.DataSource = Me.UnitConversionBindingSource
        Me.UnitConversionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UnitConversionDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.UnitConversionDataGridView.Name = "UnitConversionDataGridView"
        Me.UnitConversionDataGridView.Size = New System.Drawing.Size(629, 298)
        Me.UnitConversionDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FromUnitId"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.UnitBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "UnitCode"
        Me.DataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn2.HeaderText = "From Unit"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "UnitId"
        '
        'UnitBindingSource
        '
        Me.UnitBindingSource.DataMember = "Unit"
        Me.UnitBindingSource.DataSource = Me.UnitDataSet
        '
        'UnitDataSet
        '
        Me.UnitDataSet.DataSetName = "UnitDataSet"
        Me.UnitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ToUnitId"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.UnitBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "UnitCode"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.HeaderText = "To Unit"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "UnitId"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ConversionValue"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ConversionValue"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'CalculateSign
        '
        Me.CalculateSign.DataPropertyName = "CalculateSign"
        Me.CalculateSign.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.CalculateSign.HeaderText = "CalculateSign"
        Me.CalculateSign.Items.AddRange(New Object() {"X", "/", "+", "-"})
        Me.CalculateSign.Name = "CalculateSign"
        Me.CalculateSign.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CalculateSign.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Remarks
        '
        Me.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Remarks.DataPropertyName = "Remarks"
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'UnitConversionTableAdapter
        '
        Me.UnitConversionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UnitConversionTableAdapter = Me.UnitConversionTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.UnitConversionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmUnitConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 323)
        Me.Controls.Add(Me.UnitConversionDataGridView)
        Me.Controls.Add(Me.UnitConversionBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmUnitConversion"
        Me.Text = "Unit Conversion"
        CType(Me.UnitConversionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UnitConversionBindingNavigator.ResumeLayout(False)
        Me.UnitConversionBindingNavigator.PerformLayout()
        CType(Me.UnitConversionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitConversionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitConversionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UnitConversionDataSet As KSoft_Apparel.UnitConversionDataSet
    Friend WithEvents UnitConversionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitConversionTableAdapter As KSoft_Apparel.UnitConversionDataSetTableAdapters.UnitConversionTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.UnitConversionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UnitConversionBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UnitConversionBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UnitConversionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents UnitDataSet As KSoft_Apparel.UnitDataSet
    Friend WithEvents UnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitTableAdapter As KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalculateSign As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
