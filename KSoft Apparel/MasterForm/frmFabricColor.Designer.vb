<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFabricColor
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
        Me.components = New System.ComponentModel.Container()
        Dim FabricColorNameLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.FabricColorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataSet = New KSoft_Apparel.UserDataSet()
        Me.ModifiedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricColorDataSet = New KSoft_Apparel.FabricColorDataSet()
        Me.CancelLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.DeleteLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.NewLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.EditLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.StartWithRadioButton = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.FabricColorNameTextBox = New System.Windows.Forms.TextBox()
        Me.FabricColorTableAdapter = New KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.FabricColorDataSetTableAdapters.TableAdapterManager()
        Me.UserTableAdapter = New KSoft_Apparel.UserDataSetTableAdapters.UserTableAdapter()
        FabricColorNameLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.FabricColorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FabricColorNameLabel
        '
        FabricColorNameLabel.AutoSize = True
        FabricColorNameLabel.Location = New System.Drawing.Point(13, 58)
        FabricColorNameLabel.Name = "FabricColorNameLabel"
        FabricColorNameLabel.Size = New System.Drawing.Size(66, 13)
        FabricColorNameLabel.TabIndex = 2
        FabricColorNameLabel.Text = "Fabric Color "
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(12, 35)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(71, 13)
        Label2.TabIndex = 2
        Label2.Text = "Search Color "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(392, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(200, 7, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Color"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SearchTextBox.Location = New System.Drawing.Point(85, 32)
        Me.SearchTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(522, 20)
        Me.SearchTextBox.TabIndex = 0
        '
        'FabricColorDataGridView
        '
        Me.FabricColorDataGridView.AllowUserToAddRows = False
        Me.FabricColorDataGridView.AllowUserToDeleteRows = False
        Me.FabricColorDataGridView.AutoGenerateColumns = False
        Me.FabricColorDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.FabricColorDataGridView.ColumnHeadersHeight = 25
        Me.FabricColorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.FabricColorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.UserId, Me.ModifiedDate})
        Me.FabricColorDataGridView.DataSource = Me.FabricColorBindingSource
        Me.FabricColorDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FabricColorDataGridView.Location = New System.Drawing.Point(0, 79)
        Me.FabricColorDataGridView.Name = "FabricColorDataGridView"
        Me.FabricColorDataGridView.ReadOnly = True
        Me.FabricColorDataGridView.Size = New System.Drawing.Size(619, 291)
        Me.FabricColorDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FabricColorName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fabric Color"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'UserId
        '
        Me.UserId.DataPropertyName = "UserId"
        Me.UserId.DataSource = Me.UserBindingSource
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UserId.DefaultCellStyle = DataGridViewCellStyle3
        Me.UserId.DisplayMember = "USER_NAME"
        Me.UserId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.UserId.HeaderText = "User"
        Me.UserId.Name = "UserId"
        Me.UserId.ReadOnly = True
        Me.UserId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UserId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.UserId.ValueMember = "USER_ID"
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "User"
        Me.UserBindingSource.DataSource = Me.UserDataSet
        '
        'UserDataSet
        '
        Me.UserDataSet.DataSetName = "UserDataSet"
        Me.UserDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ModifiedDate
        '
        Me.ModifiedDate.DataPropertyName = "ModifiedDate"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.Format = "g"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ModifiedDate.DefaultCellStyle = DataGridViewCellStyle4
        Me.ModifiedDate.HeaderText = "Modified Date"
        Me.ModifiedDate.Name = "ModifiedDate"
        Me.ModifiedDate.ReadOnly = True
        '
        'FabricColorBindingSource
        '
        Me.FabricColorBindingSource.DataMember = "FabricColor"
        Me.FabricColorBindingSource.DataSource = Me.FabricColorDataSet
        '
        'FabricColorDataSet
        '
        Me.FabricColorDataSet.DataSetName = "FabricColorDataSet"
        Me.FabricColorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CancelLinkLabel
        '
        Me.CancelLinkLabel.AutoSize = True
        Me.CancelLinkLabel.Location = New System.Drawing.Point(147, 6)
        Me.CancelLinkLabel.Margin = New System.Windows.Forms.Padding(8, 6, 5, 5)
        Me.CancelLinkLabel.Name = "CancelLinkLabel"
        Me.CancelLinkLabel.Size = New System.Drawing.Size(40, 13)
        Me.CancelLinkLabel.TabIndex = 2
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
        Me.DeleteLinkLabel.TabIndex = 3
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
        Me.NewLinkLabel.TabIndex = 5
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
        Me.EditLinkLabel.TabIndex = 4
        Me.EditLinkLabel.TabStop = True
        Me.EditLinkLabel.Text = "Edit"
        Me.EditLinkLabel.Visible = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.FlowLayoutPanel1.Controls.Add(Me.NewLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.StartWithRadioButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.RadioButton2)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(619, 28)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'StartWithRadioButton
        '
        Me.StartWithRadioButton.AutoSize = True
        Me.StartWithRadioButton.Checked = True
        Me.StartWithRadioButton.Location = New System.Drawing.Point(466, 5)
        Me.StartWithRadioButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.StartWithRadioButton.Name = "StartWithRadioButton"
        Me.StartWithRadioButton.Size = New System.Drawing.Size(69, 17)
        Me.StartWithRadioButton.TabIndex = 6
        Me.StartWithRadioButton.TabStop = True
        Me.StartWithRadioButton.Text = "Start with"
        Me.StartWithRadioButton.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(541, 5)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(61, 17)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.Text = "Contain"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'FabricColorNameTextBox
        '
        Me.FabricColorNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FabricColorNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FabricColorBindingSource, "FabricColorName", True))
        Me.FabricColorNameTextBox.Location = New System.Drawing.Point(85, 55)
        Me.FabricColorNameTextBox.Name = "FabricColorNameTextBox"
        Me.FabricColorNameTextBox.Size = New System.Drawing.Size(522, 20)
        Me.FabricColorNameTextBox.TabIndex = 3
        '
        'FabricColorTableAdapter
        '
        Me.FabricColorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FabricColorTableAdapter = Me.FabricColorTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.FabricColorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'frmFabricColor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(619, 370)
        Me.Controls.Add(Label2)
        Me.Controls.Add(FabricColorNameLabel)
        Me.Controls.Add(Me.FabricColorNameTextBox)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.FabricColorDataGridView)
        Me.Controls.Add(Me.SearchTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFabricColor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Fabric Color"
        CType(Me.FabricColorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FabricColorDataSet As KSoft_Apparel.FabricColorDataSet
    Friend WithEvents FabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricColorTableAdapter As KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.FabricColorDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FabricColorDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CancelLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents DeleteLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents NewLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents EditLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FabricColorNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StartWithRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents UserDataSet As KSoft_Apparel.UserDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As KSoft_Apparel.UserDataSetTableAdapters.UserTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents UserId As DataGridViewComboBoxColumn
    Friend WithEvents ModifiedDate As DataGridViewTextBoxColumn
End Class
