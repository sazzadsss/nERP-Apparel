<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrigin
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
        Me.CancelLinkLabel = New System.Windows.Forms.LinkLabel
        Me.DeleteLinkLabel = New System.Windows.Forms.LinkLabel
        Me.NewLinkLabel = New System.Windows.Forms.LinkLabel
        Me.EditLinkLabel = New System.Windows.Forms.LinkLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.SearchTextBox = New System.Windows.Forms.TextBox
        Me.OriginDataSet = New KSoft_Apparel.OriginDataSet
        Me.OriginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OriginTableAdapter = New KSoft_Apparel.OriginDataSetTableAdapters.OriginTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.OriginDataSetTableAdapters.TableAdapterManager
        Me.OriginDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        CType(Me.OriginDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OriginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OriginDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CancelLinkLabel
        '
        Me.CancelLinkLabel.AutoSize = True
        Me.CancelLinkLabel.Location = New System.Drawing.Point(147, 5)
        Me.CancelLinkLabel.Margin = New System.Windows.Forms.Padding(8, 5, 5, 5)
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
        Me.DeleteLinkLabel.Location = New System.Drawing.Point(96, 5)
        Me.DeleteLinkLabel.Margin = New System.Windows.Forms.Padding(9, 5, 5, 5)
        Me.DeleteLinkLabel.Name = "DeleteLinkLabel"
        Me.DeleteLinkLabel.Size = New System.Drawing.Size(38, 13)
        Me.DeleteLinkLabel.TabIndex = 4
        Me.DeleteLinkLabel.TabStop = True
        Me.DeleteLinkLabel.Text = "Delete"
        '
        'NewLinkLabel
        '
        Me.NewLinkLabel.AutoSize = True
        Me.NewLinkLabel.Location = New System.Drawing.Point(13, 5)
        Me.NewLinkLabel.Margin = New System.Windows.Forms.Padding(13, 5, 5, 5)
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
        Me.EditLinkLabel.Location = New System.Drawing.Point(57, 5)
        Me.EditLinkLabel.Margin = New System.Windows.Forms.Padding(13, 5, 5, 5)
        Me.EditLinkLabel.Name = "EditLinkLabel"
        Me.EditLinkLabel.Size = New System.Drawing.Size(25, 13)
        Me.EditLinkLabel.TabIndex = 9
        Me.EditLinkLabel.TabStop = True
        Me.EditLinkLabel.Text = "Edit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(20, 6, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Origin"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SearchTextBox.Location = New System.Drawing.Point(252, 3)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(180, 20)
        Me.SearchTextBox.TabIndex = 9
        '
        'OriginDataSet
        '
        Me.OriginDataSet.DataSetName = "OriginDataSet"
        Me.OriginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OriginBindingSource
        '
        Me.OriginBindingSource.DataMember = "Origin"
        Me.OriginBindingSource.DataSource = Me.OriginDataSet
        '
        'OriginTableAdapter
        '
        Me.OriginTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.OriginTableAdapter = Me.OriginTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.OriginDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OriginDataGridView
        '
        Me.OriginDataGridView.AllowUserToAddRows = False
        Me.OriginDataGridView.AllowUserToDeleteRows = False
        Me.OriginDataGridView.AutoGenerateColumns = False
        Me.OriginDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.OriginDataGridView.ColumnHeadersHeight = 25
        Me.OriginDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.OriginDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.OriginDataGridView.DataSource = Me.OriginBindingSource
        Me.OriginDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.OriginDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.OriginDataGridView.Name = "OriginDataGridView"
        Me.OriginDataGridView.ReadOnly = True
        Me.OriginDataGridView.Size = New System.Drawing.Size(439, 256)
        Me.OriginDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Origin"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Origin"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
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
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(439, 26)
        Me.FlowLayoutPanel1.TabIndex = 13
        '
        'frmOrigin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(439, 284)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.OriginDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOrigin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Origin"
        CType(Me.OriginDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OriginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OriginDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CancelLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents DeleteLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents NewLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents EditLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OriginDataSet As KSoft_Apparel.OriginDataSet
    Friend WithEvents OriginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OriginTableAdapter As KSoft_Apparel.OriginDataSetTableAdapters.OriginTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.OriginDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OriginDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
End Class
