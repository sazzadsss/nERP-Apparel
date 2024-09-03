<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmfinishingTypeMst
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmfinishingTypeMst))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.FabricFinishingTypeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.FabricFinishingTypeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.FabricFinishingTypeDataGridView = New System.Windows.Forms.DataGridView
        Me.FabricFinishingTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricFinishingTypeDataSet = New KSoft_Apparel.FabricFinishingTypeDataSet
        Me.FabricFinishingTypeTableAdapter = New KSoft_Apparel.FabricFinishingTypeDataSetTableAdapters.FabricFinishingTypeTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.FabricFinishingTypeDataSetTableAdapters.TableAdapterManager
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.FabricFinishingTypeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FabricFinishingTypeBindingNavigator.SuspendLayout()
        CType(Me.FabricFinishingTypeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricFinishingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricFinishingTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FabricFinishingTypeBindingNavigator
        '
        Me.FabricFinishingTypeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FabricFinishingTypeBindingNavigator.BindingSource = Me.FabricFinishingTypeBindingSource
        Me.FabricFinishingTypeBindingNavigator.CountItem = Nothing
        Me.FabricFinishingTypeBindingNavigator.DeleteItem = Nothing
        Me.FabricFinishingTypeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.FabricFinishingTypeBindingNavigatorSaveItem})
        Me.FabricFinishingTypeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FabricFinishingTypeBindingNavigator.MoveFirstItem = Nothing
        Me.FabricFinishingTypeBindingNavigator.MoveLastItem = Nothing
        Me.FabricFinishingTypeBindingNavigator.MoveNextItem = Nothing
        Me.FabricFinishingTypeBindingNavigator.MovePreviousItem = Nothing
        Me.FabricFinishingTypeBindingNavigator.Name = "FabricFinishingTypeBindingNavigator"
        Me.FabricFinishingTypeBindingNavigator.PositionItem = Nothing
        Me.FabricFinishingTypeBindingNavigator.Size = New System.Drawing.Size(431, 25)
        Me.FabricFinishingTypeBindingNavigator.TabIndex = 0
        Me.FabricFinishingTypeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'FabricFinishingTypeBindingNavigatorSaveItem
        '
        Me.FabricFinishingTypeBindingNavigatorSaveItem.Image = CType(resources.GetObject("FabricFinishingTypeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FabricFinishingTypeBindingNavigatorSaveItem.Name = "FabricFinishingTypeBindingNavigatorSaveItem"
        Me.FabricFinishingTypeBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.FabricFinishingTypeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FabricFinishingTypeDataGridView
        '
        Me.FabricFinishingTypeDataGridView.AllowUserToAddRows = False
        Me.FabricFinishingTypeDataGridView.AutoGenerateColumns = False
        Me.FabricFinishingTypeDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.FabricFinishingTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FabricFinishingTypeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.FabricFinishingTypeDataGridView.DataSource = Me.FabricFinishingTypeBindingSource
        Me.FabricFinishingTypeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FabricFinishingTypeDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.FabricFinishingTypeDataGridView.Name = "FabricFinishingTypeDataGridView"
        Me.FabricFinishingTypeDataGridView.Size = New System.Drawing.Size(431, 260)
        Me.FabricFinishingTypeDataGridView.TabIndex = 1
        '
        'FabricFinishingTypeBindingSource
        '
        Me.FabricFinishingTypeBindingSource.DataMember = "FabricFinishingType"
        Me.FabricFinishingTypeBindingSource.DataSource = Me.FabricFinishingTypeDataSet
        '
        'FabricFinishingTypeDataSet
        '
        Me.FabricFinishingTypeDataSet.DataSetName = "FabricFinishingTypeDataSet"
        Me.FabricFinishingTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FabricFinishingTypeTableAdapter
        '
        Me.FabricFinishingTypeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FabricFinishingTypeTableAdapter = Me.FabricFinishingTypeTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.FabricFinishingTypeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FinishingType"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Finishing Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Price"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn3.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'frmfinishingTypeMst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 285)
        Me.Controls.Add(Me.FabricFinishingTypeDataGridView)
        Me.Controls.Add(Me.FabricFinishingTypeBindingNavigator)
        Me.Name = "frmfinishingTypeMst"
        Me.Text = "Finishing Type"
        CType(Me.FabricFinishingTypeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FabricFinishingTypeBindingNavigator.ResumeLayout(False)
        Me.FabricFinishingTypeBindingNavigator.PerformLayout()
        CType(Me.FabricFinishingTypeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricFinishingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricFinishingTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FabricFinishingTypeDataSet As KSoft_Apparel.FabricFinishingTypeDataSet
    Friend WithEvents FabricFinishingTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricFinishingTypeTableAdapter As KSoft_Apparel.FabricFinishingTypeDataSetTableAdapters.FabricFinishingTypeTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.FabricFinishingTypeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FabricFinishingTypeBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FabricFinishingTypeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FabricFinishingTypeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
