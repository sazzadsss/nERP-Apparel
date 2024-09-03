<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLineChiefList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLineChiefList))
        Me.LineCheifDataSet = New KSoft_Apparel.LineCheifDataSet
        Me.LineChiefListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LineChiefListTableAdapter = New KSoft_Apparel.LineCheifDataSetTableAdapters.LineChiefListTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.LineCheifDataSetTableAdapters.TableAdapterManager
        Me.LineChiefListBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.LineChiefListBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.LineChiefListDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.LineCheifDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineChiefListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineChiefListBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LineChiefListBindingNavigator.SuspendLayout()
        CType(Me.LineChiefListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LineCheifDataSet
        '
        Me.LineCheifDataSet.DataSetName = "LineCheifDataSet"
        Me.LineCheifDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LineChiefListBindingSource
        '
        Me.LineChiefListBindingSource.DataMember = "LineChiefList"
        Me.LineChiefListBindingSource.DataSource = Me.LineCheifDataSet
        '
        'LineChiefListTableAdapter
        '
        Me.LineChiefListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LineChiefListTableAdapter = Me.LineChiefListTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.LineCheifDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LineChiefListBindingNavigator
        '
        Me.LineChiefListBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LineChiefListBindingNavigator.BindingSource = Me.LineChiefListBindingSource
        Me.LineChiefListBindingNavigator.CountItem = Nothing
        Me.LineChiefListBindingNavigator.DeleteItem = Nothing
        Me.LineChiefListBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.LineChiefListBindingNavigatorSaveItem})
        Me.LineChiefListBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LineChiefListBindingNavigator.MoveFirstItem = Nothing
        Me.LineChiefListBindingNavigator.MoveLastItem = Nothing
        Me.LineChiefListBindingNavigator.MoveNextItem = Nothing
        Me.LineChiefListBindingNavigator.MovePreviousItem = Nothing
        Me.LineChiefListBindingNavigator.Name = "LineChiefListBindingNavigator"
        Me.LineChiefListBindingNavigator.PositionItem = Nothing
        Me.LineChiefListBindingNavigator.Size = New System.Drawing.Size(468, 25)
        Me.LineChiefListBindingNavigator.TabIndex = 0
        Me.LineChiefListBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'LineChiefListBindingNavigatorSaveItem
        '
        Me.LineChiefListBindingNavigatorSaveItem.Image = CType(resources.GetObject("LineChiefListBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LineChiefListBindingNavigatorSaveItem.Name = "LineChiefListBindingNavigatorSaveItem"
        Me.LineChiefListBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.LineChiefListBindingNavigatorSaveItem.Text = "Save Data"
        '
        'LineChiefListDataGridView
        '
        Me.LineChiefListDataGridView.AllowUserToAddRows = False
        Me.LineChiefListDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineChiefListDataGridView.AutoGenerateColumns = False
        Me.LineChiefListDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.LineChiefListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LineChiefListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.LineChiefListDataGridView.DataSource = Me.LineChiefListBindingSource
        Me.LineChiefListDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.LineChiefListDataGridView.Name = "LineChiefListDataGridView"
        Me.LineChiefListDataGridView.Size = New System.Drawing.Size(468, 305)
        Me.LineChiefListDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'frmLineChiefList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 332)
        Me.Controls.Add(Me.LineChiefListDataGridView)
        Me.Controls.Add(Me.LineChiefListBindingNavigator)
        Me.Name = "frmLineChiefList"
        Me.Text = "Line Chief List"
        CType(Me.LineCheifDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineChiefListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineChiefListBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LineChiefListBindingNavigator.ResumeLayout(False)
        Me.LineChiefListBindingNavigator.PerformLayout()
        CType(Me.LineChiefListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LineCheifDataSet As KSoft_Apparel.LineCheifDataSet
    Friend WithEvents LineChiefListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LineChiefListTableAdapter As KSoft_Apparel.LineCheifDataSetTableAdapters.LineChiefListTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.LineCheifDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LineChiefListBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents LineChiefListBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents LineChiefListDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
