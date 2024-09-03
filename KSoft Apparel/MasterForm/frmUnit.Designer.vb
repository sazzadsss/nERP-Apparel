<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnit
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.SearchTextBox = New System.Windows.Forms.TextBox
        Me.UnitDataSet = New KSoft_Apparel.UnitDataSet
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitTableAdapter = New KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.UnitDataSetTableAdapters.TableAdapterManager
        Me.UnitDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CancelLinkLabel = New System.Windows.Forms.LinkLabel
        Me.DeleteLinkLabel = New System.Windows.Forms.LinkLabel
        Me.NewLinkLabel = New System.Windows.Forms.LinkLabel
        Me.EditLinkLabel = New System.Windows.Forms.LinkLabel
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(222, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(30, 6, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Unit Code"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SearchTextBox.Enabled = False
        Me.SearchTextBox.Location = New System.Drawing.Point(282, 3)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(137, 20)
        Me.SearchTextBox.TabIndex = 16
        '
        'UnitDataSet
        '
        Me.UnitDataSet.DataSetName = "UnitDataSet"
        Me.UnitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UnitBindingSource
        '
        Me.UnitBindingSource.DataMember = "Unit"
        Me.UnitBindingSource.DataSource = Me.UnitDataSet
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UnitTableAdapter = Me.UnitTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.UnitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UnitDataGridView
        '
        Me.UnitDataGridView.AllowUserToAddRows = False
        Me.UnitDataGridView.AllowUserToDeleteRows = False
        Me.UnitDataGridView.AutoGenerateColumns = False
        Me.UnitDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.UnitDataGridView.ColumnHeadersHeight = 25
        Me.UnitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.UnitDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.UnitDataGridView.DataSource = Me.UnitBindingSource
        Me.UnitDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UnitDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.UnitDataGridView.Name = "UnitDataGridView"
        Me.UnitDataGridView.ReadOnly = True
        Me.UnitDataGridView.Size = New System.Drawing.Size(431, 220)
        Me.UnitDataGridView.TabIndex = 18
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "UnitCode"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Unit Code"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "UnitName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Unit Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'CancelLinkLabel
        '
        Me.CancelLinkLabel.AutoSize = True
        Me.CancelLinkLabel.Location = New System.Drawing.Point(147, 6)
        Me.CancelLinkLabel.Margin = New System.Windows.Forms.Padding(8, 6, 5, 5)
        Me.CancelLinkLabel.Name = "CancelLinkLabel"
        Me.CancelLinkLabel.Size = New System.Drawing.Size(40, 13)
        Me.CancelLinkLabel.TabIndex = 6
        Me.CancelLinkLabel.TabStop = True
        Me.CancelLinkLabel.Text = "Cancel"
        Me.CancelLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeleteLinkLabel
        '
        Me.DeleteLinkLabel.AutoSize = True
        Me.DeleteLinkLabel.Location = New System.Drawing.Point(96, 6)
        Me.DeleteLinkLabel.Margin = New System.Windows.Forms.Padding(9, 6, 5, 5)
        Me.DeleteLinkLabel.Name = "DeleteLinkLabel"
        Me.DeleteLinkLabel.Size = New System.Drawing.Size(38, 13)
        Me.DeleteLinkLabel.TabIndex = 4
        Me.DeleteLinkLabel.TabStop = True
        Me.DeleteLinkLabel.Text = "Delete"
        '
        'NewLinkLabel
        '
        Me.NewLinkLabel.AutoSize = True
        Me.NewLinkLabel.Location = New System.Drawing.Point(13, 6)
        Me.NewLinkLabel.Margin = New System.Windows.Forms.Padding(13, 6, 5, 5)
        Me.NewLinkLabel.Name = "NewLinkLabel"
        Me.NewLinkLabel.Size = New System.Drawing.Size(26, 13)
        Me.NewLinkLabel.TabIndex = 3
        Me.NewLinkLabel.TabStop = True
        Me.NewLinkLabel.Text = "Add"
        Me.NewLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EditLinkLabel
        '
        Me.EditLinkLabel.AutoSize = True
        Me.EditLinkLabel.Location = New System.Drawing.Point(57, 6)
        Me.EditLinkLabel.Margin = New System.Windows.Forms.Padding(13, 6, 5, 5)
        Me.EditLinkLabel.Name = "EditLinkLabel"
        Me.EditLinkLabel.Size = New System.Drawing.Size(25, 13)
        Me.EditLinkLabel.TabIndex = 9
        Me.EditLinkLabel.TabStop = True
        Me.EditLinkLabel.Text = "Edit"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.NewLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.SearchTextBox)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(431, 27)
        Me.FlowLayoutPanel1.TabIndex = 20
        '
        'frmUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(431, 248)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.UnitDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUnit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Unit"
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitDataSet As KSoft_Apparel.UnitDataSet
    Friend WithEvents UnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitTableAdapter As KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.UnitDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UnitDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CancelLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents DeleteLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents NewLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents EditLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
End Class
