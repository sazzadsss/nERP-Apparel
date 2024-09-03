<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocumentLibrary
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
        Me.UserGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataSet = New KSoft_Apparel.UserDataSet()
        Me.tbProgress = New System.Windows.Forms.Label()
        Me.SaveDocButton = New DevExpress.XtraEditors.SimpleButton()
        Me.RefreshDocButton = New DevExpress.XtraEditors.SimpleButton()
        Me.DocDeleteButton = New DevExpress.XtraEditors.SimpleButton()
        Me.DocAddButton = New DevExpress.XtraEditors.SimpleButton()
        Me.ProgressBar = New DevExpress.XtraEditors.ProgressBarControl()
        Me.DocumentLibraryNewDataSet = New KSoft_Apparel.DocumentLibraryNewDataSet()
        Me.DocumentLibraryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DocumentLibraryTableAdapter = New KSoft_Apparel.DocumentLibraryNewDataSetTableAdapters.DocumentLibraryTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.DocumentLibraryNewDataSetTableAdapters.TableAdapterManager()
        Me.DocumentLibraryGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDocumentLibraryId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUploadedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DepartmentGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentDataSet = New KSoft_Apparel.DepartmentDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUploadedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UploadByGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUSER_NAME1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SaveButton = New DevExpress.XtraEditors.SimpleButton()
        Me.DepartmentLookUpGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDepartmentName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShowButton = New DevExpress.XtraEditors.SimpleButton()
        Me.DepartmentTableAdapter = New KSoft_Apparel.DepartmentDataSetTableAdapters.DepartmentTableAdapter()
        Me.UserTableAdapter = New KSoft_Apparel.UserDataSetTableAdapters.UserTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.UserGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentLibraryNewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentLibraryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentLibraryGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UploadByGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.DepartmentLookUpGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserGridLookUpEdit
        '
        Me.UserGridLookUpEdit.AutoHeight = False
        Me.UserGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserGridLookUpEdit.DataSource = Me.UserBindingSource
        Me.UserGridLookUpEdit.DisplayMember = "USER_NAME"
        Me.UserGridLookUpEdit.Name = "UserGridLookUpEdit"
        Me.UserGridLookUpEdit.NullText = ""
        Me.UserGridLookUpEdit.ValueMember = "USER_ID"
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
        'tbProgress
        '
        Me.tbProgress.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbProgress.AutoSize = True
        Me.tbProgress.BackColor = System.Drawing.Color.Transparent
        Me.tbProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProgress.Location = New System.Drawing.Point(965, 12)
        Me.tbProgress.Name = "tbProgress"
        Me.tbProgress.Size = New System.Drawing.Size(10, 13)
        Me.tbProgress.TabIndex = 62
        Me.tbProgress.Text = "."
        Me.tbProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SaveDocButton
        '
        Me.SaveDocButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveDocButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SaveDocButton.Appearance.Options.UseForeColor = True
        Me.SaveDocButton.Location = New System.Drawing.Point(116, 5)
        Me.SaveDocButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SaveDocButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.SaveDocButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaveDocButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.SaveDocButton.Name = "SaveDocButton"
        Me.SaveDocButton.Size = New System.Drawing.Size(100, 28)
        Me.SaveDocButton.TabIndex = 63
        Me.SaveDocButton.Text = "&Download"
        '
        'RefreshDocButton
        '
        Me.RefreshDocButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshDocButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RefreshDocButton.Appearance.Options.UseForeColor = True
        Me.RefreshDocButton.Location = New System.Drawing.Point(707, 5)
        Me.RefreshDocButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RefreshDocButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.RefreshDocButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.RefreshDocButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.RefreshDocButton.Name = "RefreshDocButton"
        Me.RefreshDocButton.Size = New System.Drawing.Size(100, 28)
        Me.RefreshDocButton.TabIndex = 61
        Me.RefreshDocButton.Text = "&Show All"
        '
        'DocDeleteButton
        '
        Me.DocDeleteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DocDeleteButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DocDeleteButton.Appearance.Options.UseForeColor = True
        Me.DocDeleteButton.Location = New System.Drawing.Point(328, 5)
        Me.DocDeleteButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DocDeleteButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.DocDeleteButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.DocDeleteButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.DocDeleteButton.Name = "DocDeleteButton"
        Me.DocDeleteButton.Size = New System.Drawing.Size(100, 28)
        Me.DocDeleteButton.TabIndex = 60
        Me.DocDeleteButton.Text = "&Delete"
        Me.DocDeleteButton.Visible = False
        '
        'DocAddButton
        '
        Me.DocAddButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DocAddButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DocAddButton.Appearance.Options.UseForeColor = True
        Me.DocAddButton.Location = New System.Drawing.Point(10, 5)
        Me.DocAddButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DocAddButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.DocAddButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.DocAddButton.Margin = New System.Windows.Forms.Padding(10, 5, 3, 3)
        Me.DocAddButton.Name = "DocAddButton"
        Me.DocAddButton.Size = New System.Drawing.Size(100, 28)
        Me.DocAddButton.TabIndex = 59
        Me.DocAddButton.Text = "&Upload"
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar.Location = New System.Drawing.Point(924, 10)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.ProgressBar.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProgressBar.Properties.LookAndFeel.SkinName = "Office 2010 Black"
        Me.ProgressBar.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ProgressBar.Size = New System.Drawing.Size(134, 18)
        Me.ProgressBar.TabIndex = 58
        '
        'DocumentLibraryNewDataSet
        '
        Me.DocumentLibraryNewDataSet.DataSetName = "DocumentLibraryNewDataSet"
        Me.DocumentLibraryNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DocumentLibraryBindingSource
        '
        Me.DocumentLibraryBindingSource.DataMember = "DocumentLibrary"
        Me.DocumentLibraryBindingSource.DataSource = Me.DocumentLibraryNewDataSet
        '
        'DocumentLibraryTableAdapter
        '
        Me.DocumentLibraryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DocumentLibraryTableAdapter = Me.DocumentLibraryTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.DocumentLibraryNewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DocumentLibraryGridControl
        '
        Me.DocumentLibraryGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DocumentLibraryGridControl.DataSource = Me.DocumentLibraryBindingSource
        Me.DocumentLibraryGridControl.Location = New System.Drawing.Point(-1, 43)
        Me.DocumentLibraryGridControl.MainView = Me.GridView1
        Me.DocumentLibraryGridControl.Name = "DocumentLibraryGridControl"
        Me.DocumentLibraryGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.DepartmentGridLookUpEdit, Me.UploadByGridLookUpEdit})
        Me.DocumentLibraryGridControl.Size = New System.Drawing.Size(1066, 511)
        Me.DocumentLibraryGridControl.TabIndex = 64
        Me.DocumentLibraryGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDocumentLibraryId, Me.colDocName, Me.colDocDetails, Me.colDoc, Me.colUploadedOn, Me.colRemarks, Me.colDepartmentId, Me.colUploadedBy})
        Me.GridView1.GridControl = Me.DocumentLibraryGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colDocumentLibraryId
        '
        Me.colDocumentLibraryId.FieldName = "DocumentLibraryId"
        Me.colDocumentLibraryId.Name = "colDocumentLibraryId"
        Me.colDocumentLibraryId.OptionsColumn.ReadOnly = True
        '
        'colDocName
        '
        Me.colDocName.FieldName = "DocName"
        Me.colDocName.Name = "colDocName"
        Me.colDocName.Visible = True
        Me.colDocName.VisibleIndex = 0
        Me.colDocName.Width = 109
        '
        'colDocDetails
        '
        Me.colDocDetails.FieldName = "DocDetails"
        Me.colDocDetails.Name = "colDocDetails"
        Me.colDocDetails.Visible = True
        Me.colDocDetails.VisibleIndex = 1
        Me.colDocDetails.Width = 256
        '
        'colDoc
        '
        Me.colDoc.FieldName = "Doc"
        Me.colDoc.Name = "colDoc"
        '
        'colUploadedOn
        '
        Me.colUploadedOn.FieldName = "UploadedOn"
        Me.colUploadedOn.Name = "colUploadedOn"
        Me.colUploadedOn.OptionsColumn.AllowEdit = False
        Me.colUploadedOn.OptionsColumn.ReadOnly = True
        Me.colUploadedOn.Visible = True
        Me.colUploadedOn.VisibleIndex = 2
        Me.colUploadedOn.Width = 73
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 5
        Me.colRemarks.Width = 255
        '
        'colDepartmentId
        '
        Me.colDepartmentId.Caption = "Department"
        Me.colDepartmentId.ColumnEdit = Me.DepartmentGridLookUpEdit
        Me.colDepartmentId.FieldName = "DepartmentId"
        Me.colDepartmentId.Name = "colDepartmentId"
        Me.colDepartmentId.OptionsColumn.AllowEdit = False
        Me.colDepartmentId.OptionsColumn.ReadOnly = True
        Me.colDepartmentId.Visible = True
        Me.colDepartmentId.VisibleIndex = 4
        Me.colDepartmentId.Width = 142
        '
        'DepartmentGridLookUpEdit
        '
        Me.DepartmentGridLookUpEdit.AutoHeight = False
        Me.DepartmentGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DepartmentGridLookUpEdit.DataSource = Me.DepartmentBindingSource
        Me.DepartmentGridLookUpEdit.DisplayMember = "DepartmentName"
        Me.DepartmentGridLookUpEdit.Name = "DepartmentGridLookUpEdit"
        Me.DepartmentGridLookUpEdit.NullText = ""
        Me.DepartmentGridLookUpEdit.ValueMember = "DepartmentId"
        Me.DepartmentGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.DepartmentDataSet
        '
        'DepartmentDataSet
        '
        Me.DepartmentDataSet.DataSetName = "DepartmentDataSet"
        Me.DepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colUploadedBy
        '
        Me.colUploadedBy.ColumnEdit = Me.UploadByGridLookUpEdit
        Me.colUploadedBy.FieldName = "UploadedBy"
        Me.colUploadedBy.Name = "colUploadedBy"
        Me.colUploadedBy.Visible = True
        Me.colUploadedBy.VisibleIndex = 3
        '
        'UploadByGridLookUpEdit
        '
        Me.UploadByGridLookUpEdit.AutoHeight = False
        Me.UploadByGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UploadByGridLookUpEdit.DataSource = Me.UserBindingSource
        Me.UploadByGridLookUpEdit.DisplayMember = "USER_NAME"
        Me.UploadByGridLookUpEdit.Name = "UploadByGridLookUpEdit"
        Me.UploadByGridLookUpEdit.NullText = ""
        Me.UploadByGridLookUpEdit.ValueMember = "USER_ID"
        Me.UploadByGridLookUpEdit.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUSER_NAME1})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colUSER_NAME1
        '
        Me.colUSER_NAME1.FieldName = "USER_NAME"
        Me.colUSER_NAME1.Name = "colUSER_NAME1"
        Me.colUSER_NAME1.Visible = True
        Me.colUSER_NAME1.VisibleIndex = 0
        '
        'colUSER_NAME
        '
        Me.colUSER_NAME.FieldName = "USER_NAME"
        Me.colUSER_NAME.Name = "colUSER_NAME"
        Me.colUSER_NAME.Visible = True
        Me.colUSER_NAME.VisibleIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.DocAddButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.SaveDocButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.SaveButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.DocDeleteButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.DepartmentLookUpGridLookUpEdit)
        Me.FlowLayoutPanel1.Controls.Add(Me.ShowButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.RefreshDocButton)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(-1, -1)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(915, 38)
        Me.FlowLayoutPanel1.TabIndex = 65
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SaveButton.Appearance.Options.UseForeColor = True
        Me.SaveButton.Location = New System.Drawing.Point(222, 5)
        Me.SaveButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SaveButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.SaveButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(100, 28)
        Me.SaveButton.TabIndex = 64
        Me.SaveButton.Text = "&Update"
        '
        'DepartmentLookUpGridLookUpEdit
        '
        Me.DepartmentLookUpGridLookUpEdit.Location = New System.Drawing.Point(434, 8)
        Me.DepartmentLookUpGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.DepartmentLookUpGridLookUpEdit.Name = "DepartmentLookUpGridLookUpEdit"
        Me.DepartmentLookUpGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DepartmentLookUpGridLookUpEdit.Properties.DataSource = Me.DepartmentBindingSource
        Me.DepartmentLookUpGridLookUpEdit.Properties.DisplayMember = "DepartmentName"
        Me.DepartmentLookUpGridLookUpEdit.Properties.ImmediatePopup = True
        Me.DepartmentLookUpGridLookUpEdit.Properties.NullText = ""
        Me.DepartmentLookUpGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.DepartmentLookUpGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DepartmentLookUpGridLookUpEdit.Properties.ValueMember = "DepartmentId"
        Me.DepartmentLookUpGridLookUpEdit.Properties.View = Me.GridView8
        Me.DepartmentLookUpGridLookUpEdit.Size = New System.Drawing.Size(161, 20)
        Me.DepartmentLookUpGridLookUpEdit.TabIndex = 65
        Me.DepartmentLookUpGridLookUpEdit.Tag = "NR"
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDepartmentName})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'colDepartmentName
        '
        Me.colDepartmentName.FieldName = "DepartmentName"
        Me.colDepartmentName.Name = "colDepartmentName"
        Me.colDepartmentName.Visible = True
        Me.colDepartmentName.VisibleIndex = 0
        '
        'ShowButton
        '
        Me.ShowButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ShowButton.Appearance.Options.UseForeColor = True
        Me.ShowButton.Location = New System.Drawing.Point(601, 5)
        Me.ShowButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ShowButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.ShowButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ShowButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(100, 28)
        Me.ShowButton.TabIndex = 66
        Me.ShowButton.Text = "&Show"
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(911, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 38)
        Me.Label1.TabIndex = 66
        '
        'frmDocumentLibrary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 551)
        Me.Controls.Add(Me.DocumentLibraryGridControl)
        Me.Controls.Add(Me.tbProgress)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDocumentLibrary"
        Me.Text = "Document Library"
        CType(Me.UserGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentLibraryNewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentLibraryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentLibraryGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UploadByGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.DepartmentLookUpGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbProgress As System.Windows.Forms.Label
    Friend WithEvents SaveDocButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RefreshDocButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DocDeleteButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DocAddButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProgressBar As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents DocumentLibraryNewDataSet As KSoft_Apparel.DocumentLibraryNewDataSet
    Friend WithEvents DocumentLibraryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DocumentLibraryTableAdapter As KSoft_Apparel.DocumentLibraryNewDataSetTableAdapters.DocumentLibraryTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.DocumentLibraryNewDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DocumentLibraryGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDocumentLibraryId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUploadedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSER_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents UserGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents SaveButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepartmentGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DepartmentDataSet As DepartmentDataSet
    Friend WithEvents DepartmentBindingSource As BindingSource
    Friend WithEvents DepartmentTableAdapter As DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents DepartmentLookUpGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDepartmentName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShowButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents UserDataSet As UserDataSet
    Friend WithEvents UserBindingSource As BindingSource
    Friend WithEvents UserTableAdapter As UserDataSetTableAdapters.UserTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents colUploadedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UploadByGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUSER_NAME1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
