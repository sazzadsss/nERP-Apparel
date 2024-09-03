<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategory
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
        Me.CategoryDataSet = New KSoft_Apparel.CategoryDataSet
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryTableAdapter = New KSoft_Apparel.CategoryDataSetTableAdapters.CategoryTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.CategoryDataSetTableAdapters.TableAdapterManager
        Me.CategoryDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CancelLinkLabel = New System.Windows.Forms.LinkLabel
        Me.DeleteLinkLabel = New System.Windows.Forms.LinkLabel
        Me.NewLinkLabel = New System.Windows.Forms.LinkLabel
        Me.EditLinkLabel = New System.Windows.Forms.LinkLabel
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(20, 6, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Category"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SearchTextBox.Location = New System.Drawing.Point(267, 3)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(139, 20)
        Me.SearchTextBox.TabIndex = 16
        '
        'CategoryDataSet
        '
        Me.CategoryDataSet.DataSetName = "CategoryDataSet"
        Me.CategoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.CategoryDataSet
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoryTableAdapter = Me.CategoryTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.CategoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CategoryDataGridView
        '
        Me.CategoryDataGridView.AllowUserToAddRows = False
        Me.CategoryDataGridView.AllowUserToDeleteRows = False
        Me.CategoryDataGridView.AutoGenerateColumns = False
        Me.CategoryDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CategoryDataGridView.ColumnHeadersHeight = 25
        Me.CategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.CategoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.CategoryDataGridView.DataSource = Me.CategoryBindingSource
        Me.CategoryDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CategoryDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.CategoryDataGridView.Name = "CategoryDataGridView"
        Me.CategoryDataGridView.Size = New System.Drawing.Size(479, 240)
        Me.CategoryDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CategoryName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Category Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CategoryDescription"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Category Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
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
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(479, 25)
        Me.FlowLayoutPanel1.TabIndex = 21
        '
        'frmCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(479, 268)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.CategoryDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Category"
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryDataSet As KSoft_Apparel.CategoryDataSet
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoryTableAdapter As KSoft_Apparel.CategoryDataSetTableAdapters.CategoryTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.CategoryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CategoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CancelLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents DeleteLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents NewLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents EditLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
End Class
