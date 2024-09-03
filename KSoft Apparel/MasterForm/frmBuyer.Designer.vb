<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuyer
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CancelLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.DeleteLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.EditLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.NewLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.BuyerDataGridView = New System.Windows.Forms.DataGridView()
        Me.SynFR = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuyerType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuyerLateOK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ExportLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.BuyerDataSetTableAdapters.TableAdapterManager()
        Me.BuyerAsignTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerAsignTableAdapter()
        Me.BuyerAsignBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerAsignGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerAsignId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UserGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataSet = New KSoft_Apparel.UserDataSet()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDivisionId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GMDepGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.DivisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DivisionDataSet = New KSoft_Apparel.DivisionDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDivisionName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GMDepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GMDepartmentDataSet = New KSoft_Apparel.GMDepartmentDataSet()
        Me.GMDepartmentTableAdapter = New KSoft_Apparel.GMDepartmentDataSetTableAdapters.GMDepartmentTableAdapter()
        Me.UserTableAdapter = New KSoft_Apparel.UserDataSetTableAdapters.UserTableAdapter()
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGMDepartmentName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DivisionTableAdapter = New KSoft_Apparel.DivisionDataSetTableAdapters.DivisionTableAdapter()
        Me.colDivisionName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSER_NAME1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSER_NAME2 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BuyerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.BuyerAsignBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerAsignGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMDepGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMDepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMDepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'BuyerDataGridView
        '
        Me.BuyerDataGridView.AllowUserToAddRows = False
        Me.BuyerDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BuyerDataGridView.AutoGenerateColumns = False
        Me.BuyerDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.BuyerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BuyerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SynFR, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.BuyerType, Me.BuyerLateOK})
        Me.BuyerDataGridView.DataSource = Me.BuyerBindingSource
        Me.BuyerDataGridView.Location = New System.Drawing.Point(0, 26)
        Me.BuyerDataGridView.Name = "BuyerDataGridView"
        Me.BuyerDataGridView.Size = New System.Drawing.Size(621, 220)
        Me.BuyerDataGridView.TabIndex = 18
        '
        'SynFR
        '
        Me.SynFR.DataPropertyName = "SynFR"
        Me.SynFR.HeaderText = "SynFR"
        Me.SynFR.Name = "SynFR"
        Me.SynFR.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "BuyerCode"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Buyer Code"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BuyerName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Buyer Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'BuyerType
        '
        Me.BuyerType.DataPropertyName = "BuyerType"
        Me.BuyerType.HeaderText = "Buyer Type"
        Me.BuyerType.Name = "BuyerType"
        Me.BuyerType.Width = 50
        '
        'BuyerLateOK
        '
        Me.BuyerLateOK.DataPropertyName = "BuyerLateOK"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BuyerLateOK.DefaultCellStyle = DataGridViewCellStyle1
        Me.BuyerLateOK.HeaderText = "Buyer Late OK"
        Me.BuyerLateOK.Name = "BuyerLateOK"
        Me.BuyerLateOK.Width = 50
        '
        'BuyerBindingSource
        '
        Me.BuyerBindingSource.DataMember = "Buyer"
        Me.BuyerBindingSource.DataSource = Me.BuyerDataSet
        '
        'BuyerDataSet
        '
        Me.BuyerDataSet.DataSetName = "BuyerDataSet"
        Me.BuyerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.NewLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.ExportLinkLabel)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(621, 24)
        Me.FlowLayoutPanel1.TabIndex = 19
        '
        'ExportLinkLabel
        '
        Me.ExportLinkLabel.AutoSize = True
        Me.ExportLinkLabel.Location = New System.Drawing.Point(200, 5)
        Me.ExportLinkLabel.Margin = New System.Windows.Forms.Padding(8, 5, 5, 5)
        Me.ExportLinkLabel.Name = "ExportLinkLabel"
        Me.ExportLinkLabel.Size = New System.Drawing.Size(72, 13)
        Me.ExportLinkLabel.TabIndex = 10
        Me.ExportLinkLabel.TabStop = True
        Me.ExportLinkLabel.Text = "Export For FR"
        Me.ExportLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BuyerAsignTableAdapter = Me.BuyerAsignTableAdapter
        Me.TableAdapterManager.BuyerTableAdapter = Me.BuyerTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.BuyerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BuyerAsignTableAdapter
        '
        Me.BuyerAsignTableAdapter.ClearBeforeFill = True
        '
        'BuyerAsignBindingSource
        '
        Me.BuyerAsignBindingSource.DataMember = "FK_BuyerAsign_Buyer"
        Me.BuyerAsignBindingSource.DataSource = Me.BuyerBindingSource
        '
        'BuyerAsignGridControl
        '
        Me.BuyerAsignGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BuyerAsignGridControl.DataSource = Me.BuyerAsignBindingSource
        Me.BuyerAsignGridControl.Location = New System.Drawing.Point(0, 252)
        Me.BuyerAsignGridControl.MainView = Me.GridView1
        Me.BuyerAsignGridControl.Name = "BuyerAsignGridControl"
        Me.BuyerAsignGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.GMDepGridLookUpEdit, Me.UserGridLookUpEdit})
        Me.BuyerAsignGridControl.Size = New System.Drawing.Size(621, 181)
        Me.BuyerAsignGridControl.TabIndex = 19
        Me.BuyerAsignGridControl.UseEmbeddedNavigator = True
        Me.BuyerAsignGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerAsignId, Me.colBuyerId, Me.colUserId, Me.colDivisionId})
        Me.GridView1.GridControl = Me.BuyerAsignGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colBuyerAsignId
        '
        Me.colBuyerAsignId.FieldName = "BuyerAsignId"
        Me.colBuyerAsignId.Name = "colBuyerAsignId"
        Me.colBuyerAsignId.OptionsColumn.ReadOnly = True
        '
        'colBuyerId
        '
        Me.colBuyerId.FieldName = "BuyerId"
        Me.colBuyerId.Name = "colBuyerId"
        '
        'colUserId
        '
        Me.colUserId.Caption = "Merchandiser"
        Me.colUserId.ColumnEdit = Me.UserGridLookUpEdit
        Me.colUserId.FieldName = "UserId"
        Me.colUserId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colUserId.Name = "colUserId"
        Me.colUserId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        Me.colUserId.Visible = True
        Me.colUserId.VisibleIndex = 0
        Me.colUserId.Width = 296
        '
        'UserGridLookUpEdit
        '
        Me.UserGridLookUpEdit.AutoHeight = False
        Me.UserGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserGridLookUpEdit.DataSource = Me.UserBindingSource
        Me.UserGridLookUpEdit.DisplayMember = "USER_NAME"
        Me.UserGridLookUpEdit.Name = "UserGridLookUpEdit"
        Me.UserGridLookUpEdit.NullText = ""
        Me.UserGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.UserGridLookUpEdit.ValueMember = "USER_ID"
        Me.UserGridLookUpEdit.View = Me.GridView3
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
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUSER_NAME2})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colDivisionId
        '
        Me.colDivisionId.Caption = "Division"
        Me.colDivisionId.ColumnEdit = Me.GMDepGridLookUpEdit
        Me.colDivisionId.FieldName = "DivisionId"
        Me.colDivisionId.Name = "colDivisionId"
        Me.colDivisionId.Visible = True
        Me.colDivisionId.VisibleIndex = 1
        Me.colDivisionId.Width = 248
        '
        'GMDepGridLookUpEdit
        '
        Me.GMDepGridLookUpEdit.AutoHeight = False
        Me.GMDepGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GMDepGridLookUpEdit.DataSource = Me.DivisionBindingSource
        Me.GMDepGridLookUpEdit.DisplayMember = "DivisionName"
        Me.GMDepGridLookUpEdit.Name = "GMDepGridLookUpEdit"
        Me.GMDepGridLookUpEdit.NullText = ""
        Me.GMDepGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GMDepGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GMDepGridLookUpEdit.ValueMember = "DivisionId"
        Me.GMDepGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'DivisionBindingSource
        '
        Me.DivisionBindingSource.DataMember = "Division"
        Me.DivisionBindingSource.DataSource = Me.DivisionDataSet
        '
        'DivisionDataSet
        '
        Me.DivisionDataSet.DataSetName = "DivisionDataSet"
        Me.DivisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDivisionName1})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colDivisionName1
        '
        Me.colDivisionName1.FieldName = "DivisionName"
        Me.colDivisionName1.Name = "colDivisionName1"
        Me.colDivisionName1.Visible = True
        Me.colDivisionName1.VisibleIndex = 0
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.BuyerAsignGridControl
        Me.GridView2.Name = "GridView2"
        '
        'GMDepartmentBindingSource
        '
        Me.GMDepartmentBindingSource.DataMember = "GMDepartment"
        Me.GMDepartmentBindingSource.DataSource = Me.GMDepartmentDataSet
        '
        'GMDepartmentDataSet
        '
        Me.GMDepartmentDataSet.DataSetName = "GMDepartmentDataSet"
        Me.GMDepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GMDepartmentTableAdapter
        '
        Me.GMDepartmentTableAdapter.ClearBeforeFill = True
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'colUSER_NAME
        '
        Me.colUSER_NAME.FieldName = "USER_NAME"
        Me.colUSER_NAME.Name = "colUSER_NAME"
        Me.colUSER_NAME.Visible = True
        Me.colUSER_NAME.VisibleIndex = 0
        '
        'colGMDepartmentName
        '
        Me.colGMDepartmentName.FieldName = "GMDepartmentName"
        Me.colGMDepartmentName.Name = "colGMDepartmentName"
        Me.colGMDepartmentName.Visible = True
        Me.colGMDepartmentName.VisibleIndex = 0
        '
        'DivisionTableAdapter
        '
        Me.DivisionTableAdapter.ClearBeforeFill = True
        '
        'colDivisionName
        '
        Me.colDivisionName.FieldName = "DivisionName"
        Me.colDivisionName.Name = "colDivisionName"
        Me.colDivisionName.Visible = True
        Me.colDivisionName.VisibleIndex = 0
        '
        'colUSER_NAME1
        '
        Me.colUSER_NAME1.FieldName = "USER_NAME"
        Me.colUSER_NAME1.Name = "colUSER_NAME1"
        Me.colUSER_NAME1.Visible = True
        Me.colUSER_NAME1.VisibleIndex = 0
        '
        'colUSER_NAME2
        '
        Me.colUSER_NAME2.Caption = "Merchandiser"
        Me.colUSER_NAME2.FieldName = "USER_NAME"
        Me.colUSER_NAME2.Name = "colUSER_NAME2"
        Me.colUSER_NAME2.Visible = True
        Me.colUSER_NAME2.VisibleIndex = 0
        '
        'frmBuyer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(621, 433)
        Me.Controls.Add(Me.BuyerAsignGridControl)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.BuyerDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmBuyer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buyer"
        CType(Me.BuyerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.BuyerAsignBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerAsignGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMDepGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMDepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMDepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CancelLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents DeleteLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents NewLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents EditLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.BuyerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BuyerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ExportLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents SynFR As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BuyerType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BuyerLateOK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BuyerAsignBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerAsignTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerAsignTableAdapter
    Friend WithEvents BuyerAsignGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBuyerAsignId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GMDepGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GMDepartmentDataSet As KSoft_Apparel.GMDepartmentDataSet
    Friend WithEvents GMDepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GMDepartmentTableAdapter As KSoft_Apparel.GMDepartmentDataSetTableAdapters.GMDepartmentTableAdapter
    Friend WithEvents UserGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UserDataSet As KSoft_Apparel.UserDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As KSoft_Apparel.UserDataSetTableAdapters.UserTableAdapter
    Friend WithEvents colUSER_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGMDepartmentName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDivisionId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DivisionDataSet As KSoft_Apparel.DivisionDataSet
    Friend WithEvents DivisionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DivisionTableAdapter As KSoft_Apparel.DivisionDataSetTableAdapters.DivisionTableAdapter
    Friend WithEvents colDivisionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSER_NAME1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDivisionName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSER_NAME2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
