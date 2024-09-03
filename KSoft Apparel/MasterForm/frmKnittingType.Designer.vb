<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKnittingType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKnittingType))
        Me.KnittingTypeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.KnittingTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KnittingTypeDataSet = New KSoft_Apparel.KnittingTypeDataSet
        Me.KnittingTypeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.KnittingTypeDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KnittingTypeCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Discontinue = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.KnittingTypeTableAdapter = New KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.KnittingTypeDataSetTableAdapters.TableAdapterManager
        Me.SearchToolStripTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        CType(Me.KnittingTypeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KnittingTypeBindingNavigator.SuspendLayout()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KnittingTypeBindingNavigator
        '
        Me.KnittingTypeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.KnittingTypeBindingNavigator.BindingSource = Me.KnittingTypeBindingSource
        Me.KnittingTypeBindingNavigator.CountItem = Nothing
        Me.KnittingTypeBindingNavigator.DeleteItem = Nothing
        Me.KnittingTypeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.KnittingTypeBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.SearchToolStripTextBox})
        Me.KnittingTypeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.KnittingTypeBindingNavigator.MoveFirstItem = Nothing
        Me.KnittingTypeBindingNavigator.MoveLastItem = Nothing
        Me.KnittingTypeBindingNavigator.MoveNextItem = Nothing
        Me.KnittingTypeBindingNavigator.MovePreviousItem = Nothing
        Me.KnittingTypeBindingNavigator.Name = "KnittingTypeBindingNavigator"
        Me.KnittingTypeBindingNavigator.PositionItem = Nothing
        Me.KnittingTypeBindingNavigator.Size = New System.Drawing.Size(585, 25)
        Me.KnittingTypeBindingNavigator.TabIndex = 0
        Me.KnittingTypeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'KnittingTypeBindingSource
        '
        Me.KnittingTypeBindingSource.DataMember = "KnittingType"
        Me.KnittingTypeBindingSource.DataSource = Me.KnittingTypeDataSet
        '
        'KnittingTypeDataSet
        '
        Me.KnittingTypeDataSet.DataSetName = "KnittingTypeDataSet"
        Me.KnittingTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KnittingTypeBindingNavigatorSaveItem
        '
        Me.KnittingTypeBindingNavigatorSaveItem.Image = CType(resources.GetObject("KnittingTypeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.KnittingTypeBindingNavigatorSaveItem.Name = "KnittingTypeBindingNavigatorSaveItem"
        Me.KnittingTypeBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.KnittingTypeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButton1.Text = "Show All"
        '
        'KnittingTypeDataGridView
        '
        Me.KnittingTypeDataGridView.AllowUserToAddRows = False
        Me.KnittingTypeDataGridView.AllowUserToDeleteRows = False
        Me.KnittingTypeDataGridView.AutoGenerateColumns = False
        Me.KnittingTypeDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.KnittingTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KnittingTypeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.KnittingTypeCode, Me.Discontinue})
        Me.KnittingTypeDataGridView.DataSource = Me.KnittingTypeBindingSource
        Me.KnittingTypeDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KnittingTypeDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.KnittingTypeDataGridView.Name = "KnittingTypeDataGridView"
        Me.KnittingTypeDataGridView.Size = New System.Drawing.Size(585, 336)
        Me.KnittingTypeDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "KnittingType"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fabric Type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'KnittingTypeCode
        '
        Me.KnittingTypeCode.DataPropertyName = "KnittingTypeCode"
        Me.KnittingTypeCode.HeaderText = "Actual Type"
        Me.KnittingTypeCode.Name = "KnittingTypeCode"
        Me.KnittingTypeCode.Width = 200
        '
        'Discontinue
        '
        Me.Discontinue.DataPropertyName = "Discontinue"
        Me.Discontinue.HeaderText = "Discontinue"
        Me.Discontinue.Name = "Discontinue"
        '
        'KnittingTypeTableAdapter
        '
        Me.KnittingTypeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.KnittingTypeTableAdapter = Me.KnittingTypeTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.KnittingTypeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SearchToolStripTextBox
        '
        Me.SearchToolStripTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SearchToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchToolStripTextBox.Name = "SearchToolStripTextBox"
        Me.SearchToolStripTextBox.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'frmKnittingType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 364)
        Me.Controls.Add(Me.KnittingTypeDataGridView)
        Me.Controls.Add(Me.KnittingTypeBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmKnittingType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Knitting Type"
        CType(Me.KnittingTypeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KnittingTypeBindingNavigator.ResumeLayout(False)
        Me.KnittingTypeBindingNavigator.PerformLayout()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KnittingTypeDataSet As KSoft_Apparel.KnittingTypeDataSet
    Friend WithEvents KnittingTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KnittingTypeTableAdapter As KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.KnittingTypeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents KnittingTypeBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents KnittingTypeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents KnittingTypeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KnittingTypeCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Discontinue As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SearchToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
