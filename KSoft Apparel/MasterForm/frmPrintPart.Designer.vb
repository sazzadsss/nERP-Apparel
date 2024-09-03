<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintPart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintPart))
        Me.PrintPartBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.PrintPartBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PrintPartDataGridView = New System.Windows.Forms.DataGridView()
        Me.PrintPartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintPartDataSet = New KSoft_Apparel.PrintPartDataSet()
        Me.PrintPartTableAdapter = New KSoft_Apparel.PrintPartDataSetTableAdapters.PrintPartTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.PrintPartDataSetTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PrintPartBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PrintPartBindingNavigator.SuspendLayout()
        CType(Me.PrintPartDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintPartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintPartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintPartBindingNavigator
        '
        Me.PrintPartBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PrintPartBindingNavigator.BindingSource = Me.PrintPartBindingSource
        Me.PrintPartBindingNavigator.CountItem = Nothing
        Me.PrintPartBindingNavigator.DeleteItem = Nothing
        Me.PrintPartBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.PrintPartBindingNavigatorSaveItem})
        Me.PrintPartBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PrintPartBindingNavigator.MoveFirstItem = Nothing
        Me.PrintPartBindingNavigator.MoveLastItem = Nothing
        Me.PrintPartBindingNavigator.MoveNextItem = Nothing
        Me.PrintPartBindingNavigator.MovePreviousItem = Nothing
        Me.PrintPartBindingNavigator.Name = "PrintPartBindingNavigator"
        Me.PrintPartBindingNavigator.PositionItem = Nothing
        Me.PrintPartBindingNavigator.Size = New System.Drawing.Size(364, 25)
        Me.PrintPartBindingNavigator.TabIndex = 0
        Me.PrintPartBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'PrintPartBindingNavigatorSaveItem
        '
        Me.PrintPartBindingNavigatorSaveItem.Image = CType(resources.GetObject("PrintPartBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PrintPartBindingNavigatorSaveItem.Name = "PrintPartBindingNavigatorSaveItem"
        Me.PrintPartBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.PrintPartBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PrintPartDataGridView
        '
        Me.PrintPartDataGridView.AllowUserToAddRows = False
        Me.PrintPartDataGridView.AutoGenerateColumns = False
        Me.PrintPartDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.PrintPartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PrintPartDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.PartGroup})
        Me.PrintPartDataGridView.DataSource = Me.PrintPartBindingSource
        Me.PrintPartDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintPartDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.PrintPartDataGridView.Name = "PrintPartDataGridView"
        Me.PrintPartDataGridView.Size = New System.Drawing.Size(364, 280)
        Me.PrintPartDataGridView.TabIndex = 1
        '
        'PrintPartBindingSource
        '
        Me.PrintPartBindingSource.DataMember = "PrintPart"
        Me.PrintPartBindingSource.DataSource = Me.PrintPartDataSet
        '
        'PrintPartDataSet
        '
        Me.PrintPartDataSet.DataSetName = "PrintPartDataSet"
        Me.PrintPartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrintPartTableAdapter
        '
        Me.PrintPartTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PrintPartTableAdapter = Me.PrintPartTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.PrintPartDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PartName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PartName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'PartGroup
        '
        Me.PartGroup.DataPropertyName = "PartGroup"
        Me.PartGroup.HeaderText = "PartGroup"
        Me.PartGroup.Name = "PartGroup"
        '
        'frmPrintPart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 305)
        Me.Controls.Add(Me.PrintPartDataGridView)
        Me.Controls.Add(Me.PrintPartBindingNavigator)
        Me.Name = "frmPrintPart"
        Me.Text = "Print Part Master"
        CType(Me.PrintPartBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PrintPartBindingNavigator.ResumeLayout(False)
        Me.PrintPartBindingNavigator.PerformLayout()
        CType(Me.PrintPartDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintPartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintPartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintPartDataSet As KSoft_Apparel.PrintPartDataSet
    Friend WithEvents PrintPartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintPartTableAdapter As KSoft_Apparel.PrintPartDataSetTableAdapters.PrintPartTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.PrintPartDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PrintPartBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintPartBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintPartDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents PartGroup As DataGridViewTextBoxColumn
End Class
