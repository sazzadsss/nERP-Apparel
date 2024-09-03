<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDyeingShade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDyeingShade))
        Me.DyeingShadeDataSet = New KSoft_Apparel.DyeingShadeDataSet
        Me.DyeingShadeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DyeingShadeTableAdapter = New KSoft_Apparel.DyeingShadeDataSetTableAdapters.DyeingShadeTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.DyeingShadeDataSetTableAdapters.TableAdapterManager
        Me.DyeingShadeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.DyeingShadeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.DyeingShadeDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DyeingShadeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DyeingShadeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DyeingShadeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DyeingShadeBindingNavigator.SuspendLayout()
        CType(Me.DyeingShadeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DyeingShadeDataSet
        '
        Me.DyeingShadeDataSet.DataSetName = "DyeingShadeDataSet"
        Me.DyeingShadeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DyeingShadeBindingSource
        '
        Me.DyeingShadeBindingSource.DataMember = "DyeingShade"
        Me.DyeingShadeBindingSource.DataSource = Me.DyeingShadeDataSet
        '
        'DyeingShadeTableAdapter
        '
        Me.DyeingShadeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DyeingShadeTableAdapter = Me.DyeingShadeTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.DyeingShadeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DyeingShadeBindingNavigator
        '
        Me.DyeingShadeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DyeingShadeBindingNavigator.BindingSource = Me.DyeingShadeBindingSource
        Me.DyeingShadeBindingNavigator.CountItem = Nothing
        Me.DyeingShadeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DyeingShadeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DyeingShadeBindingNavigatorSaveItem})
        Me.DyeingShadeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DyeingShadeBindingNavigator.MoveFirstItem = Nothing
        Me.DyeingShadeBindingNavigator.MoveLastItem = Nothing
        Me.DyeingShadeBindingNavigator.MoveNextItem = Nothing
        Me.DyeingShadeBindingNavigator.MovePreviousItem = Nothing
        Me.DyeingShadeBindingNavigator.Name = "DyeingShadeBindingNavigator"
        Me.DyeingShadeBindingNavigator.PositionItem = Nothing
        Me.DyeingShadeBindingNavigator.Size = New System.Drawing.Size(394, 25)
        Me.DyeingShadeBindingNavigator.TabIndex = 0
        Me.DyeingShadeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'DyeingShadeBindingNavigatorSaveItem
        '
        Me.DyeingShadeBindingNavigatorSaveItem.Image = CType(resources.GetObject("DyeingShadeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DyeingShadeBindingNavigatorSaveItem.Name = "DyeingShadeBindingNavigatorSaveItem"
        Me.DyeingShadeBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.DyeingShadeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DyeingShadeDataGridView
        '
        Me.DyeingShadeDataGridView.AllowUserToAddRows = False
        Me.DyeingShadeDataGridView.AutoGenerateColumns = False
        Me.DyeingShadeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DyeingShadeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DyeingShadeDataGridView.DataSource = Me.DyeingShadeBindingSource
        Me.DyeingShadeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DyeingShadeDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.DyeingShadeDataGridView.Name = "DyeingShadeDataGridView"
        Me.DyeingShadeDataGridView.Size = New System.Drawing.Size(394, 265)
        Me.DyeingShadeDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DyeingShade"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DyeingShade"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CostPerKg"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CostPerKg"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'frmDyeingShade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 290)
        Me.Controls.Add(Me.DyeingShadeDataGridView)
        Me.Controls.Add(Me.DyeingShadeBindingNavigator)
        Me.Name = "frmDyeingShade"
        Me.Text = "Dyeing Shade"
        CType(Me.DyeingShadeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DyeingShadeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DyeingShadeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DyeingShadeBindingNavigator.ResumeLayout(False)
        Me.DyeingShadeBindingNavigator.PerformLayout()
        CType(Me.DyeingShadeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DyeingShadeDataSet As KSoft_Apparel.DyeingShadeDataSet
    Friend WithEvents DyeingShadeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DyeingShadeTableAdapter As KSoft_Apparel.DyeingShadeDataSetTableAdapters.DyeingShadeTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.DyeingShadeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DyeingShadeBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DyeingShadeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DyeingShadeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
