<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGarments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGarments))
        Me.GarmentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.GarmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GarmentDataSet = New KSoft_Apparel.GarmentDataSet
        Me.GarmentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.GarmentDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GarmentTableAdapter = New KSoft_Apparel.GarmentDataSetTableAdapters.GarmentTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.GarmentDataSetTableAdapters.TableAdapterManager
        Me.SearchTextBox = New System.Windows.Forms.TextBox
        CType(Me.GarmentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GarmentBindingNavigator.SuspendLayout()
        CType(Me.GarmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GarmentBindingNavigator
        '
        Me.GarmentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GarmentBindingNavigator.BindingSource = Me.GarmentBindingSource
        Me.GarmentBindingNavigator.CountItem = Nothing
        Me.GarmentBindingNavigator.DeleteItem = Nothing
        Me.GarmentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.GarmentBindingNavigatorSaveItem, Me.ToolStripLabel1})
        Me.GarmentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GarmentBindingNavigator.MoveFirstItem = Nothing
        Me.GarmentBindingNavigator.MoveLastItem = Nothing
        Me.GarmentBindingNavigator.MoveNextItem = Nothing
        Me.GarmentBindingNavigator.MovePreviousItem = Nothing
        Me.GarmentBindingNavigator.Name = "GarmentBindingNavigator"
        Me.GarmentBindingNavigator.PositionItem = Nothing
        Me.GarmentBindingNavigator.Size = New System.Drawing.Size(603, 25)
        Me.GarmentBindingNavigator.TabIndex = 0
        Me.GarmentBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'GarmentBindingSource
        '
        Me.GarmentBindingSource.DataMember = "Garment"
        Me.GarmentBindingSource.DataSource = Me.GarmentDataSet
        '
        'GarmentDataSet
        '
        Me.GarmentDataSet.DataSetName = "GarmentDataSet"
        Me.GarmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GarmentBindingNavigatorSaveItem
        '
        Me.GarmentBindingNavigatorSaveItem.Image = CType(resources.GetObject("GarmentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GarmentBindingNavigatorSaveItem.Name = "GarmentBindingNavigatorSaveItem"
        Me.GarmentBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.GarmentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.ToolStripLabel1.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripLabel1.Text = "Search"
        '
        'GarmentDataGridView
        '
        Me.GarmentDataGridView.AllowUserToAddRows = False
        Me.GarmentDataGridView.AutoGenerateColumns = False
        Me.GarmentDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.GarmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GarmentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3})
        Me.GarmentDataGridView.DataSource = Me.GarmentBindingSource
        Me.GarmentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GarmentDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.GarmentDataGridView.Name = "GarmentDataGridView"
        Me.GarmentDataGridView.Size = New System.Drawing.Size(603, 329)
        Me.GarmentDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "GarmentDescription"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Garment Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'GarmentTableAdapter
        '
        Me.GarmentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GarmentTableAdapter = Me.GarmentTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.GarmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SearchTextBox
        '
        Me.SearchTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SearchTextBox.Location = New System.Drawing.Point(230, 2)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(364, 20)
        Me.SearchTextBox.TabIndex = 2
        '
        'frmGarments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 354)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.GarmentDataGridView)
        Me.Controls.Add(Me.GarmentBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmGarments"
        Me.Text = "Garments"
        CType(Me.GarmentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GarmentBindingNavigator.ResumeLayout(False)
        Me.GarmentBindingNavigator.PerformLayout()
        CType(Me.GarmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GarmentDataSet As KSoft_Apparel.GarmentDataSet
    Friend WithEvents GarmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GarmentTableAdapter As KSoft_Apparel.GarmentDataSetTableAdapters.GarmentTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.GarmentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GarmentBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GarmentBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GarmentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
End Class
