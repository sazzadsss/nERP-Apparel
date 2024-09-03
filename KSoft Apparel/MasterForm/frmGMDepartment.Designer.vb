<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGMDepartment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGMDepartment))
        Me.GMDepartmentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.GMDepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GMDepartmentDataSet = New KSoft_Apparel.GMDepartmentDataSet
        Me.GMDepartmentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.GMDepartmentDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BuyerId = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
        Me.GMDepartmentTableAdapter = New KSoft_Apparel.GMDepartmentDataSetTableAdapters.GMDepartmentTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.GMDepartmentDataSetTableAdapters.TableAdapterManager
        CType(Me.GMDepartmentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GMDepartmentBindingNavigator.SuspendLayout()
        CType(Me.GMDepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMDepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMDepartmentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GMDepartmentBindingNavigator
        '
        Me.GMDepartmentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GMDepartmentBindingNavigator.BindingSource = Me.GMDepartmentBindingSource
        Me.GMDepartmentBindingNavigator.CountItem = Nothing
        Me.GMDepartmentBindingNavigator.DeleteItem = Nothing
        Me.GMDepartmentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.GMDepartmentBindingNavigatorSaveItem, Me.ToolStripTextBox1, Me.ToolStripButton1})
        Me.GMDepartmentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GMDepartmentBindingNavigator.MoveFirstItem = Nothing
        Me.GMDepartmentBindingNavigator.MoveLastItem = Nothing
        Me.GMDepartmentBindingNavigator.MoveNextItem = Nothing
        Me.GMDepartmentBindingNavigator.MovePreviousItem = Nothing
        Me.GMDepartmentBindingNavigator.Name = "GMDepartmentBindingNavigator"
        Me.GMDepartmentBindingNavigator.PositionItem = Nothing
        Me.GMDepartmentBindingNavigator.Size = New System.Drawing.Size(468, 25)
        Me.GMDepartmentBindingNavigator.TabIndex = 0
        Me.GMDepartmentBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'GMDepartmentBindingSource
        '
        Me.GMDepartmentBindingSource.DataMember = "GMDepartment"
        Me.GMDepartmentBindingSource.DataSource = Me.GMDepartmentDataSet
        '
        'GMDepartmentDataSet
        '
        Me.GMDepartmentDataSet.DataSetName = "GMDepartmentDataSet"
        Me.GMDepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GMDepartmentBindingNavigatorSaveItem
        '
        Me.GMDepartmentBindingNavigatorSaveItem.Image = CType(resources.GetObject("GMDepartmentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GMDepartmentBindingNavigatorSaveItem.Name = "GMDepartmentBindingNavigatorSaveItem"
        Me.GMDepartmentBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.GMDepartmentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(200, 25)
        Me.ToolStripTextBox1.ToolTipText = "Type your letter of your desire department (ContainSearch)"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.KSoft_Apparel.My.Resources.Resources.Synchronize_icon
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'GMDepartmentDataGridView
        '
        Me.GMDepartmentDataGridView.AllowUserToAddRows = False
        Me.GMDepartmentDataGridView.AutoGenerateColumns = False
        Me.GMDepartmentDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.GMDepartmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GMDepartmentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.BuyerId})
        Me.GMDepartmentDataGridView.DataSource = Me.GMDepartmentBindingSource
        Me.GMDepartmentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GMDepartmentDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.GMDepartmentDataGridView.Name = "GMDepartmentDataGridView"
        Me.GMDepartmentDataGridView.Size = New System.Drawing.Size(468, 277)
        Me.GMDepartmentDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "GMDepartmentName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Department Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'BuyerId
        '
        Me.BuyerId.DataPropertyName = "BuyerId"
        Me.BuyerId.DataSource = Me.BuyerBindingSource
        Me.BuyerId.DisplayMember = "BuyerCode"
        Me.BuyerId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.BuyerId.HeaderText = "Buyer"
        Me.BuyerId.Name = "BuyerId"
        Me.BuyerId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BuyerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BuyerId.ValueMember = "BuyerId"
        '
        'BuyerBindingSource
        '
        Me.BuyerBindingSource.DataMember = "Buyer"
        Me.BuyerBindingSource.DataSource = Me.BuyerDataSet
        '
        'BuyerDataSet
        '
        Me.BuyerDataSet.DataSetName = "BuyerDataSet"
        Me.BuyerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'GMDepartmentTableAdapter
        '
        Me.GMDepartmentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GMDepartmentTableAdapter = Me.GMDepartmentTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.GMDepartmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmGMDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 302)
        Me.Controls.Add(Me.GMDepartmentDataGridView)
        Me.Controls.Add(Me.GMDepartmentBindingNavigator)
        Me.Name = "frmGMDepartment"
        Me.Text = "Garments Department"
        CType(Me.GMDepartmentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GMDepartmentBindingNavigator.ResumeLayout(False)
        Me.GMDepartmentBindingNavigator.PerformLayout()
        CType(Me.GMDepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMDepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMDepartmentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GMDepartmentDataSet As KSoft_Apparel.GMDepartmentDataSet
    Friend WithEvents GMDepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GMDepartmentTableAdapter As KSoft_Apparel.GMDepartmentDataSetTableAdapters.GMDepartmentTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.GMDepartmentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GMDepartmentBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GMDepartmentBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GMDepartmentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BuyerId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
