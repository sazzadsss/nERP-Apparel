<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompany
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
        Dim CompanyLogoLabel As System.Windows.Forms.Label
        Dim CompanyCodeLabel As System.Windows.Forms.Label
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim WebsiteLabel As System.Windows.Forms.Label
        Dim ContactPersonLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompany))
        Me.CompanyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyDataSet = New KSoft_Apparel.CompanyDataSet
        Me.CompanyBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.CompanyAddressBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyAddressDataGridView = New System.Windows.Forms.DataGridView
        Me.AddressCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CompanyTableAdapter = New KSoft_Apparel.CompanyDataSetTableAdapters.CompanyTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.CompanyDataSetTableAdapters.TableAdapterManager
        Me.CompanyAddressTableAdapter = New KSoft_Apparel.CompanyDataSetTableAdapters.CompanyAddressTableAdapter
        Me.CompanyLogoPictureEdit = New DevExpress.XtraEditors.PictureEdit
        Me.CompanyCodeTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.CompanyNameTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.FaxTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.WebsiteTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.ContactPersonTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.IsDefaultCheckEdit = New DevExpress.XtraEditors.CheckEdit
        CompanyLogoLabel = New System.Windows.Forms.Label
        CompanyCodeLabel = New System.Windows.Forms.Label
        CompanyNameLabel = New System.Windows.Forms.Label
        FaxLabel = New System.Windows.Forms.Label
        WebsiteLabel = New System.Windows.Forms.Label
        ContactPersonLabel = New System.Windows.Forms.Label
        CType(Me.CompanyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CompanyBindingNavigator.SuspendLayout()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyAddressBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyAddressDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyLogoPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WebsiteTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactPersonTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsDefaultCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CompanyLogoLabel
        '
        CompanyLogoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        CompanyLogoLabel.Location = New System.Drawing.Point(723, 41)
        CompanyLogoLabel.Name = "CompanyLogoLabel"
        CompanyLogoLabel.Size = New System.Drawing.Size(84, 19)
        CompanyLogoLabel.TabIndex = 3
        CompanyLogoLabel.Text = "Company Logo:"
        '
        'CompanyCodeLabel
        '
        CompanyCodeLabel.AutoSize = True
        CompanyCodeLabel.Location = New System.Drawing.Point(39, 41)
        CompanyCodeLabel.Name = "CompanyCodeLabel"
        CompanyCodeLabel.Size = New System.Drawing.Size(82, 13)
        CompanyCodeLabel.TabIndex = 4
        CompanyCodeLabel.Text = "Company Code:"
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.AutoSize = True
        CompanyNameLabel.Location = New System.Drawing.Point(39, 67)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(85, 13)
        CompanyNameLabel.TabIndex = 6
        CompanyNameLabel.Text = "Company Name:"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Location = New System.Drawing.Point(39, 94)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(27, 13)
        FaxLabel.TabIndex = 8
        FaxLabel.Text = "Fax:"
        '
        'WebsiteLabel
        '
        WebsiteLabel.AutoSize = True
        WebsiteLabel.Location = New System.Drawing.Point(39, 120)
        WebsiteLabel.Name = "WebsiteLabel"
        WebsiteLabel.Size = New System.Drawing.Size(49, 13)
        WebsiteLabel.TabIndex = 10
        WebsiteLabel.Text = "Website:"
        '
        'ContactPersonLabel
        '
        ContactPersonLabel.AutoSize = True
        ContactPersonLabel.Location = New System.Drawing.Point(39, 147)
        ContactPersonLabel.Name = "ContactPersonLabel"
        ContactPersonLabel.Size = New System.Drawing.Size(83, 13)
        ContactPersonLabel.TabIndex = 12
        ContactPersonLabel.Text = "Contact Person:"
        '
        'CompanyBindingNavigator
        '
        Me.CompanyBindingNavigator.AddNewItem = Nothing
        Me.CompanyBindingNavigator.BindingSource = Me.CompanyBindingSource
        Me.CompanyBindingNavigator.CountItem = Nothing
        Me.CompanyBindingNavigator.DeleteItem = Nothing
        Me.CompanyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyBindingNavigatorSaveItem})
        Me.CompanyBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CompanyBindingNavigator.MoveFirstItem = Nothing
        Me.CompanyBindingNavigator.MoveLastItem = Nothing
        Me.CompanyBindingNavigator.MoveNextItem = Nothing
        Me.CompanyBindingNavigator.MovePreviousItem = Nothing
        Me.CompanyBindingNavigator.Name = "CompanyBindingNavigator"
        Me.CompanyBindingNavigator.PositionItem = Nothing
        Me.CompanyBindingNavigator.Size = New System.Drawing.Size(1016, 25)
        Me.CompanyBindingNavigator.TabIndex = 0
        Me.CompanyBindingNavigator.Text = "BindingNavigator1"
        '
        'CompanyBindingSource
        '
        Me.CompanyBindingSource.DataMember = "Company"
        Me.CompanyBindingSource.DataSource = Me.CompanyDataSet
        '
        'CompanyDataSet
        '
        Me.CompanyDataSet.DataSetName = "CompanyDataSet"
        Me.CompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompanyBindingNavigatorSaveItem
        '
        Me.CompanyBindingNavigatorSaveItem.Image = CType(resources.GetObject("CompanyBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CompanyBindingNavigatorSaveItem.Name = "CompanyBindingNavigatorSaveItem"
        Me.CompanyBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.CompanyBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CompanyAddressBindingSource
        '
        Me.CompanyAddressBindingSource.DataMember = "Company_CompanyAddress"
        Me.CompanyAddressBindingSource.DataSource = Me.CompanyBindingSource
        '
        'CompanyAddressDataGridView
        '
        Me.CompanyAddressDataGridView.AutoGenerateColumns = False
        Me.CompanyAddressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CompanyAddressDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AddressCode, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.CompanyAddressDataGridView.DataSource = Me.CompanyAddressBindingSource
        Me.CompanyAddressDataGridView.Location = New System.Drawing.Point(22, 198)
        Me.CompanyAddressDataGridView.Name = "CompanyAddressDataGridView"
        Me.CompanyAddressDataGridView.Size = New System.Drawing.Size(974, 220)
        Me.CompanyAddressDataGridView.TabIndex = 2
        '
        'AddressCode
        '
        Me.AddressCode.DataPropertyName = "AddressCode"
        Me.AddressCode.HeaderText = "Address Code"
        Me.AddressCode.Name = "AddressCode"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "CorporateOffice"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Corporate Office"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Address1"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Address1"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 200
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Address2"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Address2"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 200
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn11.HeaderText = "City"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 50
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Country"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Country"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "ContactPerson"
        Me.DataGridViewTextBoxColumn13.HeaderText = "ContactPerson"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "ContactNo"
        Me.DataGridViewTextBoxColumn14.HeaderText = "ContactNo"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Fax"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Fax"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CompanyAddressTableAdapter = Me.CompanyAddressTableAdapter
        Me.TableAdapterManager.CompanyTableAdapter = Me.CompanyTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.CompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CompanyAddressTableAdapter
        '
        Me.CompanyAddressTableAdapter.ClearBeforeFill = True
        '
        'CompanyLogoPictureEdit
        '
        Me.CompanyLogoPictureEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CompanyLogoPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CompanyBindingSource, "CompanyLogo", True))
        Me.CompanyLogoPictureEdit.Location = New System.Drawing.Point(813, 34)
        Me.CompanyLogoPictureEdit.Name = "CompanyLogoPictureEdit"
        Me.CompanyLogoPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.CompanyLogoPictureEdit.Size = New System.Drawing.Size(173, 148)
        Me.CompanyLogoPictureEdit.TabIndex = 4
        '
        'CompanyCodeTextEdit
        '
        Me.CompanyCodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CompanyBindingSource, "CompanyCode", True))
        Me.CompanyCodeTextEdit.Location = New System.Drawing.Point(130, 38)
        Me.CompanyCodeTextEdit.Name = "CompanyCodeTextEdit"
        Me.CompanyCodeTextEdit.Size = New System.Drawing.Size(515, 20)
        Me.CompanyCodeTextEdit.TabIndex = 5
        '
        'CompanyNameTextEdit
        '
        Me.CompanyNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CompanyBindingSource, "CompanyName", True))
        Me.CompanyNameTextEdit.Location = New System.Drawing.Point(130, 64)
        Me.CompanyNameTextEdit.Name = "CompanyNameTextEdit"
        Me.CompanyNameTextEdit.Size = New System.Drawing.Size(515, 20)
        Me.CompanyNameTextEdit.TabIndex = 7
        '
        'FaxTextEdit
        '
        Me.FaxTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CompanyBindingSource, "Fax", True))
        Me.FaxTextEdit.Location = New System.Drawing.Point(130, 90)
        Me.FaxTextEdit.Name = "FaxTextEdit"
        Me.FaxTextEdit.Size = New System.Drawing.Size(515, 20)
        Me.FaxTextEdit.TabIndex = 9
        '
        'WebsiteTextEdit
        '
        Me.WebsiteTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CompanyBindingSource, "Website", True))
        Me.WebsiteTextEdit.Location = New System.Drawing.Point(130, 117)
        Me.WebsiteTextEdit.Name = "WebsiteTextEdit"
        Me.WebsiteTextEdit.Size = New System.Drawing.Size(515, 20)
        Me.WebsiteTextEdit.TabIndex = 11
        '
        'ContactPersonTextEdit
        '
        Me.ContactPersonTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CompanyBindingSource, "ContactPerson", True))
        Me.ContactPersonTextEdit.Location = New System.Drawing.Point(130, 144)
        Me.ContactPersonTextEdit.Name = "ContactPersonTextEdit"
        Me.ContactPersonTextEdit.Size = New System.Drawing.Size(515, 20)
        Me.ContactPersonTextEdit.TabIndex = 13
        '
        'IsDefaultCheckEdit
        '
        Me.IsDefaultCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CompanyBindingSource, "IsDefault", True))
        Me.IsDefaultCheckEdit.Location = New System.Drawing.Point(128, 170)
        Me.IsDefaultCheckEdit.Name = "IsDefaultCheckEdit"
        Me.IsDefaultCheckEdit.Properties.Caption = "Default"
        Me.IsDefaultCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.IsDefaultCheckEdit.TabIndex = 15
        '
        'frmCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 438)
        Me.Controls.Add(Me.IsDefaultCheckEdit)
        Me.Controls.Add(ContactPersonLabel)
        Me.Controls.Add(Me.ContactPersonTextEdit)
        Me.Controls.Add(WebsiteLabel)
        Me.Controls.Add(Me.WebsiteTextEdit)
        Me.Controls.Add(FaxLabel)
        Me.Controls.Add(Me.FaxTextEdit)
        Me.Controls.Add(CompanyNameLabel)
        Me.Controls.Add(Me.CompanyNameTextEdit)
        Me.Controls.Add(CompanyCodeLabel)
        Me.Controls.Add(Me.CompanyCodeTextEdit)
        Me.Controls.Add(CompanyLogoLabel)
        Me.Controls.Add(Me.CompanyLogoPictureEdit)
        Me.Controls.Add(Me.CompanyAddressDataGridView)
        Me.Controls.Add(Me.CompanyBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCompany"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Company"
        CType(Me.CompanyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CompanyBindingNavigator.ResumeLayout(False)
        Me.CompanyBindingNavigator.PerformLayout()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyAddressBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyAddressDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyLogoPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WebsiteTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactPersonTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsDefaultCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CompanyDataSet As KSoft_Apparel.CompanyDataSet
    Friend WithEvents CompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyTableAdapter As KSoft_Apparel.CompanyDataSetTableAdapters.CompanyTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.CompanyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CompanyBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents CompanyBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CompanyAddressBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyAddressTableAdapter As KSoft_Apparel.CompanyDataSetTableAdapters.CompanyAddressTableAdapter
    Friend WithEvents CompanyAddressDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AddressCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompanyLogoPictureEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents CompanyCodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CompanyNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FaxTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WebsiteTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContactPersonTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsDefaultCheckEdit As DevExpress.XtraEditors.CheckEdit
End Class
