<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeason
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeason))
        Me.SeasonDataSet = New KSoft_Apparel.SeasonDataSet
        Me.SeasonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeasonTableAdapter = New KSoft_Apparel.SeasonDataSetTableAdapters.SeasonTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.SeasonDataSetTableAdapters.TableAdapterManager
        Me.SeasonBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.SeasonBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.SeasonDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.SeasonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SeasonBindingNavigator.SuspendLayout()
        CType(Me.SeasonDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SeasonDataSet
        '
        Me.SeasonDataSet.DataSetName = "SeasonDataSet"
        Me.SeasonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SeasonBindingSource
        '
        Me.SeasonBindingSource.DataMember = "Season"
        Me.SeasonBindingSource.DataSource = Me.SeasonDataSet
        '
        'SeasonTableAdapter
        '
        Me.SeasonTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SeasonTableAdapter = Me.SeasonTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SeasonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SeasonBindingNavigator
        '
        Me.SeasonBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SeasonBindingNavigator.BindingSource = Me.SeasonBindingSource
        Me.SeasonBindingNavigator.CountItem = Nothing
        Me.SeasonBindingNavigator.DeleteItem = Nothing
        Me.SeasonBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.SeasonBindingNavigatorSaveItem})
        Me.SeasonBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SeasonBindingNavigator.MoveFirstItem = Nothing
        Me.SeasonBindingNavigator.MoveLastItem = Nothing
        Me.SeasonBindingNavigator.MoveNextItem = Nothing
        Me.SeasonBindingNavigator.MovePreviousItem = Nothing
        Me.SeasonBindingNavigator.Name = "SeasonBindingNavigator"
        Me.SeasonBindingNavigator.PositionItem = Nothing
        Me.SeasonBindingNavigator.Size = New System.Drawing.Size(375, 25)
        Me.SeasonBindingNavigator.TabIndex = 0
        Me.SeasonBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'SeasonBindingNavigatorSaveItem
        '
        Me.SeasonBindingNavigatorSaveItem.Image = CType(resources.GetObject("SeasonBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SeasonBindingNavigatorSaveItem.Name = "SeasonBindingNavigatorSaveItem"
        Me.SeasonBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.SeasonBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SeasonDataGridView
        '
        Me.SeasonDataGridView.AllowUserToAddRows = False
        Me.SeasonDataGridView.AutoGenerateColumns = False
        Me.SeasonDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SeasonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SeasonDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.SeasonDataGridView.DataSource = Me.SeasonBindingSource
        Me.SeasonDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SeasonDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.SeasonDataGridView.Name = "SeasonDataGridView"
        Me.SeasonDataGridView.Size = New System.Drawing.Size(375, 242)
        Me.SeasonDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SeasonName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "SeasonName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'frmSeason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 267)
        Me.Controls.Add(Me.SeasonDataGridView)
        Me.Controls.Add(Me.SeasonBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSeason"
        Me.Text = " Season"
        CType(Me.SeasonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SeasonBindingNavigator.ResumeLayout(False)
        Me.SeasonBindingNavigator.PerformLayout()
        CType(Me.SeasonDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SeasonDataSet As KSoft_Apparel.SeasonDataSet
    Friend WithEvents SeasonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SeasonTableAdapter As KSoft_Apparel.SeasonDataSetTableAdapters.SeasonTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.SeasonDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SeasonBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SeasonBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SeasonDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
