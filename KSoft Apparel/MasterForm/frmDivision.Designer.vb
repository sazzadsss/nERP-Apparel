<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDivision
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDivision))
        Me.DivisionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.DivisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DivisionDataSet = New KSoft_Apparel.DivisionDataSet
        Me.DivisionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.DivisionDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet
        Me.DivisionTableAdapter = New KSoft_Apparel.DivisionDataSetTableAdapters.DivisionTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.DivisionDataSetTableAdapters.TableAdapterManager
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
        CType(Me.DivisionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DivisionBindingNavigator.SuspendLayout()
        CType(Me.DivisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DivisionBindingNavigator
        '
        Me.DivisionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DivisionBindingNavigator.BindingSource = Me.DivisionBindingSource
        Me.DivisionBindingNavigator.CountItem = Nothing
        Me.DivisionBindingNavigator.DeleteItem = Nothing
        Me.DivisionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.DivisionBindingNavigatorSaveItem})
        Me.DivisionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DivisionBindingNavigator.MoveFirstItem = Nothing
        Me.DivisionBindingNavigator.MoveLastItem = Nothing
        Me.DivisionBindingNavigator.MoveNextItem = Nothing
        Me.DivisionBindingNavigator.MovePreviousItem = Nothing
        Me.DivisionBindingNavigator.Name = "DivisionBindingNavigator"
        Me.DivisionBindingNavigator.PositionItem = Nothing
        Me.DivisionBindingNavigator.Size = New System.Drawing.Size(467, 25)
        Me.DivisionBindingNavigator.TabIndex = 0
        Me.DivisionBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'DivisionBindingSource
        '
        Me.DivisionBindingSource.DataMember = "Division"
        Me.DivisionBindingSource.DataSource = Me.DivisionDataSet
        '
        'DivisionDataSet
        '
        Me.DivisionDataSet.DataSetName = "DivisionDataSet"
        Me.DivisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DivisionBindingNavigatorSaveItem
        '
        Me.DivisionBindingNavigatorSaveItem.Image = CType(resources.GetObject("DivisionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DivisionBindingNavigatorSaveItem.Name = "DivisionBindingNavigatorSaveItem"
        Me.DivisionBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.DivisionBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DivisionDataGridView
        '
        Me.DivisionDataGridView.AllowUserToAddRows = False
        Me.DivisionDataGridView.AutoGenerateColumns = False
        Me.DivisionDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.DivisionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DivisionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DivisionDataGridView.DataSource = Me.DivisionBindingSource
        Me.DivisionDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DivisionDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.DivisionDataGridView.Name = "DivisionDataGridView"
        Me.DivisionDataGridView.Size = New System.Drawing.Size(467, 248)
        Me.DivisionDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DivisionName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Division Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
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
        'DivisionTableAdapter
        '
        Me.DivisionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DivisionTableAdapter = Me.DivisionTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.DivisionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'frmDivision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 276)
        Me.Controls.Add(Me.DivisionDataGridView)
        Me.Controls.Add(Me.DivisionBindingNavigator)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDivision"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Division"
        CType(Me.DivisionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DivisionBindingNavigator.ResumeLayout(False)
        Me.DivisionBindingNavigator.PerformLayout()
        CType(Me.DivisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DivisionDataSet As KSoft_Apparel.DivisionDataSet
    Friend WithEvents DivisionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DivisionTableAdapter As KSoft_Apparel.DivisionDataSetTableAdapters.DivisionTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.DivisionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DivisionBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DivisionBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DivisionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
