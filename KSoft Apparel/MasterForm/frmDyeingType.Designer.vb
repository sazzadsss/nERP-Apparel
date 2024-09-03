<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDyeingType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDyeingType))
        Me.DyeingTypeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.DyeingTypeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.DyeingTypeDataGridView = New System.Windows.Forms.DataGridView
        Me.DyeingTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DyeingTypeDataSet = New KSoft_Apparel.DyeingTypeDataSet
        Me.DyeingTypeTableAdapter = New KSoft_Apparel.DyeingTypeDataSetTableAdapters.DyeingTypeTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.DyeingTypeDataSetTableAdapters.TableAdapterManager
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostPerKg = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DyeingTypeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DyeingTypeBindingNavigator.SuspendLayout()
        CType(Me.DyeingTypeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DyeingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DyeingTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DyeingTypeBindingNavigator
        '
        Me.DyeingTypeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DyeingTypeBindingNavigator.BindingSource = Me.DyeingTypeBindingSource
        Me.DyeingTypeBindingNavigator.CountItem = Nothing
        Me.DyeingTypeBindingNavigator.DeleteItem = Nothing
        Me.DyeingTypeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.DyeingTypeBindingNavigatorSaveItem})
        Me.DyeingTypeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DyeingTypeBindingNavigator.MoveFirstItem = Nothing
        Me.DyeingTypeBindingNavigator.MoveLastItem = Nothing
        Me.DyeingTypeBindingNavigator.MoveNextItem = Nothing
        Me.DyeingTypeBindingNavigator.MovePreviousItem = Nothing
        Me.DyeingTypeBindingNavigator.Name = "DyeingTypeBindingNavigator"
        Me.DyeingTypeBindingNavigator.PositionItem = Nothing
        Me.DyeingTypeBindingNavigator.Size = New System.Drawing.Size(380, 25)
        Me.DyeingTypeBindingNavigator.TabIndex = 0
        Me.DyeingTypeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'DyeingTypeBindingNavigatorSaveItem
        '
        Me.DyeingTypeBindingNavigatorSaveItem.Image = CType(resources.GetObject("DyeingTypeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DyeingTypeBindingNavigatorSaveItem.Name = "DyeingTypeBindingNavigatorSaveItem"
        Me.DyeingTypeBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.DyeingTypeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DyeingTypeDataGridView
        '
        Me.DyeingTypeDataGridView.AutoGenerateColumns = False
        Me.DyeingTypeDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.DyeingTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DyeingTypeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.CostPerKg})
        Me.DyeingTypeDataGridView.DataSource = Me.DyeingTypeBindingSource
        Me.DyeingTypeDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DyeingTypeDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.DyeingTypeDataGridView.Name = "DyeingTypeDataGridView"
        Me.DyeingTypeDataGridView.Size = New System.Drawing.Size(380, 269)
        Me.DyeingTypeDataGridView.TabIndex = 1
        '
        'DyeingTypeBindingSource
        '
        Me.DyeingTypeBindingSource.DataMember = "DyeingType"
        Me.DyeingTypeBindingSource.DataSource = Me.DyeingTypeDataSet
        '
        'DyeingTypeDataSet
        '
        Me.DyeingTypeDataSet.DataSetName = "DyeingTypeDataSet"
        Me.DyeingTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DyeingTypeTableAdapter
        '
        Me.DyeingTypeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DyeingTypeTableAdapter = Me.DyeingTypeTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.DyeingTypeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DyeingType"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Dyeing Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'CostPerKg
        '
        Me.CostPerKg.DataPropertyName = "CostPerKg"
        Me.CostPerKg.HeaderText = "CostPerKg"
        Me.CostPerKg.Name = "CostPerKg"
        '
        'frmDyeingType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 294)
        Me.Controls.Add(Me.DyeingTypeDataGridView)
        Me.Controls.Add(Me.DyeingTypeBindingNavigator)
        Me.Name = "frmDyeingType"
        Me.Text = "Dyeing Type"
        CType(Me.DyeingTypeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DyeingTypeBindingNavigator.ResumeLayout(False)
        Me.DyeingTypeBindingNavigator.PerformLayout()
        CType(Me.DyeingTypeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DyeingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DyeingTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DyeingTypeDataSet As KSoft_Apparel.DyeingTypeDataSet
    Friend WithEvents DyeingTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DyeingTypeTableAdapter As KSoft_Apparel.DyeingTypeDataSetTableAdapters.DyeingTypeTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.DyeingTypeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DyeingTypeBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DyeingTypeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DyeingTypeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostPerKg As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
