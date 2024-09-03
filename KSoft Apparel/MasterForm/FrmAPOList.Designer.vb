<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAPOList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAPOList))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.CuttingAPOListDataSet = New KSoft_Apparel.CuttingAPOListDataSet
        Me.CuttingAPOListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuttingAPOListTableAdapter = New KSoft_Apparel.CuttingAPOListDataSetTableAdapters.CuttingAPOListTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.CuttingAPOListDataSetTableAdapters.TableAdapterManager
        Me.CuttingAPOListBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.CuttingAPOListBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.CuttingAPOListDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.CuttingAPOListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingAPOListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingAPOListBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CuttingAPOListBindingNavigator.SuspendLayout()
        CType(Me.CuttingAPOListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(389, 282)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'CuttingAPOListDataSet
        '
        Me.CuttingAPOListDataSet.DataSetName = "CuttingAPOListDataSet"
        Me.CuttingAPOListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CuttingAPOListBindingSource
        '
        Me.CuttingAPOListBindingSource.DataMember = "CuttingAPOList"
        Me.CuttingAPOListBindingSource.DataSource = Me.CuttingAPOListDataSet
        '
        'CuttingAPOListTableAdapter
        '
        Me.CuttingAPOListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CuttingAPOListTableAdapter = Me.CuttingAPOListTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.CuttingAPOListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CuttingAPOListBindingNavigator
        '
        Me.CuttingAPOListBindingNavigator.AddNewItem = Nothing
        Me.CuttingAPOListBindingNavigator.BindingSource = Me.CuttingAPOListBindingSource
        Me.CuttingAPOListBindingNavigator.CountItem = Nothing
        Me.CuttingAPOListBindingNavigator.DeleteItem = Nothing
        Me.CuttingAPOListBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuttingAPOListBindingNavigatorSaveItem})
        Me.CuttingAPOListBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CuttingAPOListBindingNavigator.MoveFirstItem = Nothing
        Me.CuttingAPOListBindingNavigator.MoveLastItem = Nothing
        Me.CuttingAPOListBindingNavigator.MoveNextItem = Nothing
        Me.CuttingAPOListBindingNavigator.MovePreviousItem = Nothing
        Me.CuttingAPOListBindingNavigator.Name = "CuttingAPOListBindingNavigator"
        Me.CuttingAPOListBindingNavigator.PositionItem = Nothing
        Me.CuttingAPOListBindingNavigator.Size = New System.Drawing.Size(547, 25)
        Me.CuttingAPOListBindingNavigator.TabIndex = 1
        Me.CuttingAPOListBindingNavigator.Text = "BindingNavigator1"
        '
        'CuttingAPOListBindingNavigatorSaveItem
        '
        Me.CuttingAPOListBindingNavigatorSaveItem.Image = CType(resources.GetObject("CuttingAPOListBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CuttingAPOListBindingNavigatorSaveItem.Name = "CuttingAPOListBindingNavigatorSaveItem"
        Me.CuttingAPOListBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.CuttingAPOListBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CuttingAPOListDataGridView
        '
        Me.CuttingAPOListDataGridView.AutoGenerateColumns = False
        Me.CuttingAPOListDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CuttingAPOListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CuttingAPOListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.CuttingAPOListDataGridView.DataSource = Me.CuttingAPOListBindingSource
        Me.CuttingAPOListDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.CuttingAPOListDataGridView.Name = "CuttingAPOListDataGridView"
        Me.CuttingAPOListDataGridView.Size = New System.Drawing.Size(547, 248)
        Me.CuttingAPOListDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Employee_Code"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Employee_Code"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'FrmAPOList
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(547, 323)
        Me.Controls.Add(Me.CuttingAPOListDataGridView)
        Me.Controls.Add(Me.CuttingAPOListBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAPOList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "APO List"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.CuttingAPOListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingAPOListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingAPOListBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CuttingAPOListBindingNavigator.ResumeLayout(False)
        Me.CuttingAPOListBindingNavigator.PerformLayout()
        CType(Me.CuttingAPOListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents CuttingAPOListDataSet As KSoft_Apparel.CuttingAPOListDataSet
    Friend WithEvents CuttingAPOListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CuttingAPOListTableAdapter As KSoft_Apparel.CuttingAPOListDataSetTableAdapters.CuttingAPOListTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.CuttingAPOListDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CuttingAPOListBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents CuttingAPOListBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CuttingAPOListDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
