<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivitieView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActivitieView))
        Me.ActivitiesDataSet = New KSoft_Apparel.ActivitiesDataSet
        Me.ActivitiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActivitiesTableAdapter = New KSoft_Apparel.ActivitiesDataSetTableAdapters.ActivitiesTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.ActivitiesDataSetTableAdapters.TableAdapterManager
        Me.ActivitiesPredecessorTableAdapter = New KSoft_Apparel.ActivitiesDataSetTableAdapters.ActivitiesPredecessorTableAdapter
        Me.ActivitiesListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActivitiesListDataSet = New KSoft_Apparel.ActivitiesListDataSet
        Me.ActivitiesPredecessorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActivitiesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet
        Me.StyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleDataSet = New KSoft_Apparel.StyleDataSet
        Me.ActivitiesListTableAdapter = New KSoft_Apparel.ActivitiesListDataSetTableAdapters.ActivitiesListTableAdapter
        Me.ActivitiesProgramNoLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleTableAdapter = New KSoft_Apparel.StyleDataSetTableAdapters.StyleTableAdapter
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.RefreshButton = New System.Windows.Forms.Button
        Me.PrintButton = New System.Windows.Forms.Button
        Me.EditButton = New System.Windows.Forms.Button
        Me.ActivitiesGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colActivitiesId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colActivitiesListId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ActivitiesListGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colActivitiesListId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRemarks1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOptimisticTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMostLiklyTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPessimisticTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEET = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLET = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExDuration = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExSDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExEDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colASDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAEDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStack = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStyleId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colBuyerId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colSL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLeftDay = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStatus1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colActivitiesId2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSndASDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSndStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTrdASDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTrdStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUser_Id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.UserLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataSet = New KSoft_Apparel.UserDataSet
        Me.colGMDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GMDepGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GMDepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GMDepartmentDataSet = New KSoft_Apparel.GMDepartmentDataSet
        Me.RepositoryItemGridLookUpEdit4View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSeasonId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SeasonGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.SeasonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeasonDataSet = New KSoft_Apparel.SeasonDataSet
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ActivitiesPredecessorGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colActivitiesPredecessorId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colActivitiesId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colActivitiesListId3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ActivitiesListPreGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colActivitiesListId2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescription1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRemarks2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPreActivitiesId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colExEDate1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAEDate1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemGridLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.UserTableAdapter = New KSoft_Apparel.UserDataSetTableAdapters.UserTableAdapter
        Me.GMDepartmentTableAdapter = New KSoft_Apparel.GMDepartmentDataSetTableAdapters.GMDepartmentTableAdapter
        Me.SeasonTableAdapter = New KSoft_Apparel.SeasonDataSetTableAdapters.SeasonTableAdapter
        Me.colAAsign_UserId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AsignForGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.ActivitiesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesPredecessorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesProgramNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ActivitiesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesListGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMDepGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMDepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMDepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit4View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesPredecessorGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesListPreGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsignForGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ActivitiesDataSet
        '
        Me.ActivitiesDataSet.DataSetName = "ActivitiesDataSet"
        Me.ActivitiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActivitiesBindingSource
        '
        Me.ActivitiesBindingSource.DataMember = "Activities"
        Me.ActivitiesBindingSource.DataSource = Me.ActivitiesDataSet
        '
        'ActivitiesTableAdapter
        '
        Me.ActivitiesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActivitiesPredecessorTableAdapter = Me.ActivitiesPredecessorTableAdapter
        Me.TableAdapterManager.ActivitiesTableAdapter = Me.ActivitiesTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.ActivitiesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ActivitiesPredecessorTableAdapter
        '
        Me.ActivitiesPredecessorTableAdapter.ClearBeforeFill = True
        '
        'ActivitiesListBindingSource
        '
        Me.ActivitiesListBindingSource.DataMember = "ActivitiesList"
        Me.ActivitiesListBindingSource.DataSource = Me.ActivitiesListDataSet
        '
        'ActivitiesListDataSet
        '
        Me.ActivitiesListDataSet.DataSetName = "ActivitiesListDataSet"
        Me.ActivitiesListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActivitiesPredecessorBindingSource
        '
        Me.ActivitiesPredecessorBindingSource.DataMember = "FK_ActivitiesPredecessor_Activities"
        Me.ActivitiesPredecessorBindingSource.DataSource = Me.ActivitiesBindingSource
        '
        'ActivitiesBindingSource1
        '
        Me.ActivitiesBindingSource1.DataMember = "Activities"
        Me.ActivitiesBindingSource1.DataSource = Me.ActivitiesDataSet
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
        'StyleBindingSource
        '
        Me.StyleBindingSource.DataMember = "Style"
        Me.StyleBindingSource.DataSource = Me.StyleDataSet
        '
        'StyleDataSet
        '
        Me.StyleDataSet.DataSetName = "StyleDataSet"
        Me.StyleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActivitiesListTableAdapter
        '
        Me.ActivitiesListTableAdapter.ClearBeforeFill = True
        '
        'ActivitiesProgramNoLookupBindingSource
        '
        Me.ActivitiesProgramNoLookupBindingSource.DataMember = "ActivitiesProgramNoLookup"
        Me.ActivitiesProgramNoLookupBindingSource.DataSource = Me.ActivitiesDataSet
        '
        'StyleTableAdapter
        '
        Me.StyleTableAdapter.ClearBeforeFill = True
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Gray
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.RefreshButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PrintButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EditButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ActivitiesGridControl)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.ActivitiesPredecessorGridControl)
        Me.SplitContainer1.Size = New System.Drawing.Size(957, 470)
        Me.SplitContainer1.SplitterDistance = 303
        Me.SplitContainer1.TabIndex = 4
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(761, 5)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(91, 23)
        Me.RefreshButton.TabIndex = 46
        Me.RefreshButton.Text = "&Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(854, 5)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(91, 23)
        Me.PrintButton.TabIndex = 45
        Me.PrintButton.Text = "&Print Preview"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(666, 5)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(91, 23)
        Me.EditButton.TabIndex = 44
        Me.EditButton.Text = "&Save"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'ActivitiesGridControl
        '
        Me.ActivitiesGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActivitiesGridControl.DataSource = Me.ActivitiesBindingSource
        Me.ActivitiesGridControl.Location = New System.Drawing.Point(0, 32)
        Me.ActivitiesGridControl.MainView = Me.GridView1
        Me.ActivitiesGridControl.Name = "ActivitiesGridControl"
        Me.ActivitiesGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ActivitiesListGridLookUpEdit, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.UserLookUpEdit, Me.GMDepGridLookUpEdit, Me.SeasonGridLookUpEdit, Me.AsignForGridLookUpEdit})
        Me.ActivitiesGridControl.Size = New System.Drawing.Size(954, 272)
        Me.ActivitiesGridControl.TabIndex = 1
        Me.ActivitiesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colActivitiesId, Me.colActivitiesListId, Me.colOptimisticTime, Me.colMostLiklyTime, Me.colPessimisticTime, Me.colEST, Me.colLST, Me.colEET, Me.colLET, Me.colExDuration, Me.colExSDate, Me.colExEDate, Me.colASDate, Me.colAEDate, Me.colRemarks, Me.colStack, Me.colProgramNo, Me.colStyleId, Me.colBuyerId, Me.colSL, Me.colLeftDay, Me.colStatus1, Me.colActivitiesId2, Me.colSndASDate, Me.colSndStatus, Me.colTrdASDate, Me.colTrdStatus, Me.colUser_Id, Me.colGMDepartmentId, Me.colSeasonId, Me.colAAsign_UserId})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(893, 227, 216, 199)
        Me.GridView1.GridControl = Me.ActivitiesGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colActivitiesId
        '
        Me.colActivitiesId.AppearanceHeader.Options.UseTextOptions = True
        Me.colActivitiesId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colActivitiesId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colActivitiesId.Caption = "Asign For"
        Me.colActivitiesId.FieldName = "ActivitiesId"
        Me.colActivitiesId.Name = "colActivitiesId"
        Me.colActivitiesId.OptionsColumn.AllowEdit = False
        Me.colActivitiesId.OptionsColumn.ReadOnly = True
        '
        'colActivitiesListId
        '
        Me.colActivitiesListId.AppearanceHeader.Options.UseTextOptions = True
        Me.colActivitiesListId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colActivitiesListId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colActivitiesListId.Caption = "Activities"
        Me.colActivitiesListId.ColumnEdit = Me.ActivitiesListGridLookUpEdit
        Me.colActivitiesListId.FieldName = "ActivitiesListId"
        Me.colActivitiesListId.Name = "colActivitiesListId"
        Me.colActivitiesListId.OptionsColumn.AllowEdit = False
        Me.colActivitiesListId.OptionsColumn.ReadOnly = True
        Me.colActivitiesListId.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colActivitiesListId.Visible = True
        Me.colActivitiesListId.VisibleIndex = 5
        Me.colActivitiesListId.Width = 212
        '
        'ActivitiesListGridLookUpEdit
        '
        Me.ActivitiesListGridLookUpEdit.AutoHeight = False
        Me.ActivitiesListGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ActivitiesListGridLookUpEdit.DataSource = Me.ActivitiesListBindingSource
        Me.ActivitiesListGridLookUpEdit.DisplayMember = "Description"
        Me.ActivitiesListGridLookUpEdit.Name = "ActivitiesListGridLookUpEdit"
        Me.ActivitiesListGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ActivitiesListGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ActivitiesListGridLookUpEdit.ValueMember = "ActivitiesListId"
        Me.ActivitiesListGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colActivitiesListId1, Me.colDescription, Me.colRemarks1})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colActivitiesListId1
        '
        Me.colActivitiesListId1.FieldName = "ActivitiesListId"
        Me.colActivitiesListId1.Name = "colActivitiesListId1"
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 0
        '
        'colRemarks1
        '
        Me.colRemarks1.FieldName = "Remarks"
        Me.colRemarks1.Name = "colRemarks1"
        '
        'colOptimisticTime
        '
        Me.colOptimisticTime.AppearanceHeader.Options.UseTextOptions = True
        Me.colOptimisticTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOptimisticTime.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOptimisticTime.FieldName = "OptimisticTime"
        Me.colOptimisticTime.Name = "colOptimisticTime"
        Me.colOptimisticTime.OptionsColumn.AllowEdit = False
        Me.colOptimisticTime.OptionsColumn.ReadOnly = True
        '
        'colMostLiklyTime
        '
        Me.colMostLiklyTime.AppearanceHeader.Options.UseTextOptions = True
        Me.colMostLiklyTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMostLiklyTime.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMostLiklyTime.FieldName = "MostLiklyTime"
        Me.colMostLiklyTime.Name = "colMostLiklyTime"
        Me.colMostLiklyTime.OptionsColumn.AllowEdit = False
        Me.colMostLiklyTime.OptionsColumn.ReadOnly = True
        '
        'colPessimisticTime
        '
        Me.colPessimisticTime.AppearanceHeader.Options.UseTextOptions = True
        Me.colPessimisticTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPessimisticTime.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPessimisticTime.FieldName = "PessimisticTime"
        Me.colPessimisticTime.Name = "colPessimisticTime"
        Me.colPessimisticTime.OptionsColumn.AllowEdit = False
        Me.colPessimisticTime.OptionsColumn.ReadOnly = True
        '
        'colEST
        '
        Me.colEST.AppearanceHeader.Options.UseTextOptions = True
        Me.colEST.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEST.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEST.FieldName = "EST"
        Me.colEST.Name = "colEST"
        Me.colEST.OptionsColumn.AllowEdit = False
        Me.colEST.OptionsColumn.ReadOnly = True
        '
        'colLST
        '
        Me.colLST.AppearanceHeader.Options.UseTextOptions = True
        Me.colLST.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLST.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLST.FieldName = "LST"
        Me.colLST.Name = "colLST"
        Me.colLST.OptionsColumn.AllowEdit = False
        Me.colLST.OptionsColumn.ReadOnly = True
        '
        'colEET
        '
        Me.colEET.AppearanceHeader.Options.UseTextOptions = True
        Me.colEET.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEET.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEET.FieldName = "EET"
        Me.colEET.Name = "colEET"
        Me.colEET.OptionsColumn.AllowEdit = False
        Me.colEET.OptionsColumn.ReadOnly = True
        '
        'colLET
        '
        Me.colLET.AppearanceHeader.Options.UseTextOptions = True
        Me.colLET.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLET.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLET.FieldName = "LET"
        Me.colLET.Name = "colLET"
        Me.colLET.OptionsColumn.AllowEdit = False
        Me.colLET.OptionsColumn.ReadOnly = True
        '
        'colExDuration
        '
        Me.colExDuration.AppearanceHeader.Options.UseTextOptions = True
        Me.colExDuration.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExDuration.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colExDuration.DisplayFormat.FormatString = "n0"
        Me.colExDuration.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colExDuration.FieldName = "ExDuration"
        Me.colExDuration.Name = "colExDuration"
        Me.colExDuration.OptionsColumn.AllowEdit = False
        Me.colExDuration.OptionsColumn.ReadOnly = True
        Me.colExDuration.Width = 83
        '
        'colExSDate
        '
        Me.colExSDate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colExSDate.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colExSDate.AppearanceCell.Options.UseBackColor = True
        Me.colExSDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colExSDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExSDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colExSDate.Caption = "Ex Date"
        Me.colExSDate.FieldName = "ExEDate"
        Me.colExSDate.Name = "colExSDate"
        Me.colExSDate.OptionsColumn.AllowEdit = False
        Me.colExSDate.OptionsColumn.ReadOnly = True
        Me.colExSDate.Visible = True
        Me.colExSDate.VisibleIndex = 6
        Me.colExSDate.Width = 78
        '
        'colExEDate
        '
        Me.colExEDate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colExEDate.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colExEDate.AppearanceCell.Options.UseBackColor = True
        Me.colExEDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colExEDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExEDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colExEDate.Caption = "Ex End Date"
        Me.colExEDate.FieldName = "ExEDate"
        Me.colExEDate.Name = "colExEDate"
        Me.colExEDate.OptionsColumn.AllowEdit = False
        Me.colExEDate.OptionsColumn.ReadOnly = True
        Me.colExEDate.Width = 76
        '
        'colASDate
        '
        Me.colASDate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colASDate.AppearanceCell.Options.UseBackColor = True
        Me.colASDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colASDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colASDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colASDate.Caption = "Actual Date"
        Me.colASDate.FieldName = "AEDate"
        Me.colASDate.Name = "colASDate"
        Me.colASDate.Visible = True
        Me.colASDate.VisibleIndex = 7
        Me.colASDate.Width = 88
        '
        'colAEDate
        '
        Me.colAEDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colAEDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAEDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAEDate.Caption = "Actual End Date"
        Me.colAEDate.FieldName = "AEDate"
        Me.colAEDate.Name = "colAEDate"
        Me.colAEDate.Width = 81
        '
        'colRemarks
        '
        Me.colRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.colRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRemarks.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.OptionsColumn.AllowEdit = False
        Me.colRemarks.OptionsColumn.ReadOnly = True
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 13
        Me.colRemarks.Width = 171
        '
        'colStack
        '
        Me.colStack.AppearanceHeader.Options.UseTextOptions = True
        Me.colStack.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStack.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStack.FieldName = "Stack"
        Me.colStack.Name = "colStack"
        Me.colStack.OptionsColumn.AllowEdit = False
        Me.colStack.OptionsColumn.ReadOnly = True
        '
        'colProgramNo
        '
        Me.colProgramNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colProgramNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProgramNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.OptionsColumn.AllowEdit = False
        Me.colProgramNo.OptionsColumn.ReadOnly = True
        Me.colProgramNo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 2
        '
        'colStyleId
        '
        Me.colStyleId.AppearanceHeader.Options.UseTextOptions = True
        Me.colStyleId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStyleId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStyleId.Caption = "Style"
        Me.colStyleId.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colStyleId.FieldName = "StyleId"
        Me.colStyleId.Name = "colStyleId"
        Me.colStyleId.OptionsColumn.AllowEdit = False
        Me.colStyleId.OptionsColumn.ReadOnly = True
        Me.colStyleId.Visible = True
        Me.colStyleId.VisibleIndex = 3
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("StyleId", "Style Id", 60, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("StyleName", "Style Name", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BuyerId", "Buyer Id", 51, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DefaultTarget", "Default Target", 80, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SMV", "SMV", 30, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Picture", "Picture", 43, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsPrint", "Is Print", 44, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrintDetails", "Print Details", 67, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrintTypeId", "Print Type Id", 72, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("StyleName2", "Style Name2", 70, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("StyleNameId", "Style Name Id", 77, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GMDepartment", "GM Department", 85, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GMDescription", "GM Description", 81, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KnittingTypeId", "Knitting Type Id", 86, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompositionId", "Composition Id", 81, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GSM", "GSM", 31, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remarks", "Remarks", 51, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GMDepartmentId", "GM Department Id", 98, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserId", "User Id", 45, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModifiedOn", "Modified On", 67, DevExpress.Utils.FormatType.DateTime, "dd-MMM-yyyy", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("WashTypeId", "Wash Type Id", 77, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsEmbroidery", "Is Embroidery", 76, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsAOP", "Is AOP", 43, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsYDS", "Is YDS", 41, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrintPartId", "Print Part Id", 68, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.StyleBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "StyleName"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "StyleId"
        '
        'colBuyerId
        '
        Me.colBuyerId.AppearanceHeader.Options.UseTextOptions = True
        Me.colBuyerId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBuyerId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBuyerId.Caption = "Buyer"
        Me.colBuyerId.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colBuyerId.FieldName = "BuyerId"
        Me.colBuyerId.Name = "colBuyerId"
        Me.colBuyerId.OptionsColumn.AllowEdit = False
        Me.colBuyerId.OptionsColumn.ReadOnly = True
        Me.colBuyerId.Visible = True
        Me.colBuyerId.VisibleIndex = 4
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BuyerId", "Buyer Id", 64, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BuyerCode", "Buyer Code", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BuyerName", "Buyer Name", 68, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.BuyerBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "BuyerName"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.ValueMember = "BuyerId"
        '
        'colSL
        '
        Me.colSL.AppearanceHeader.Options.UseTextOptions = True
        Me.colSL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSL.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSL.FieldName = "SL"
        Me.colSL.Name = "colSL"
        Me.colSL.OptionsColumn.AllowEdit = False
        Me.colSL.OptionsColumn.ReadOnly = True
        Me.colSL.Width = 45
        '
        'colLeftDay
        '
        Me.colLeftDay.AppearanceHeader.Options.UseTextOptions = True
        Me.colLeftDay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLeftDay.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLeftDay.Caption = "Ex Left Day"
        Me.colLeftDay.FieldName = "LeftDay"
        Me.colLeftDay.Name = "colLeftDay"
        Me.colLeftDay.OptionsColumn.AllowEdit = False
        Me.colLeftDay.OptionsColumn.ReadOnly = True
        Me.colLeftDay.Width = 67
        '
        'colStatus1
        '
        Me.colStatus1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colStatus1.AppearanceCell.Options.UseBackColor = True
        Me.colStatus1.Caption = "Status"
        Me.colStatus1.FieldName = "Status"
        Me.colStatus1.Name = "colStatus1"
        Me.colStatus1.Visible = True
        Me.colStatus1.VisibleIndex = 8
        Me.colStatus1.Width = 78
        '
        'colActivitiesId2
        '
        Me.colActivitiesId2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colActivitiesId2.AppearanceCell.Options.UseBackColor = True
        Me.colActivitiesId2.FieldName = "ActivitiesId"
        Me.colActivitiesId2.Name = "colActivitiesId2"
        Me.colActivitiesId2.OptionsColumn.AllowEdit = False
        Me.colActivitiesId2.OptionsColumn.ReadOnly = True
        Me.colActivitiesId2.Width = 74
        '
        'colSndASDate
        '
        Me.colSndASDate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSndASDate.AppearanceCell.Options.UseBackColor = True
        Me.colSndASDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colSndASDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSndASDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSndASDate.Caption = "2nd Submission"
        Me.colSndASDate.FieldName = "SndASDate"
        Me.colSndASDate.Name = "colSndASDate"
        Me.colSndASDate.Visible = True
        Me.colSndASDate.VisibleIndex = 9
        '
        'colSndStatus
        '
        Me.colSndStatus.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSndStatus.AppearanceCell.Options.UseBackColor = True
        Me.colSndStatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colSndStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSndStatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSndStatus.Caption = "2nd Status"
        Me.colSndStatus.FieldName = "SndStatus"
        Me.colSndStatus.Name = "colSndStatus"
        Me.colSndStatus.Visible = True
        Me.colSndStatus.VisibleIndex = 10
        Me.colSndStatus.Width = 74
        '
        'colTrdASDate
        '
        Me.colTrdASDate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colTrdASDate.AppearanceCell.Options.UseBackColor = True
        Me.colTrdASDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colTrdASDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTrdASDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTrdASDate.Caption = "3rd Submission"
        Me.colTrdASDate.FieldName = "TrdASDate"
        Me.colTrdASDate.Name = "colTrdASDate"
        Me.colTrdASDate.Visible = True
        Me.colTrdASDate.VisibleIndex = 11
        '
        'colTrdStatus
        '
        Me.colTrdStatus.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colTrdStatus.AppearanceCell.Options.UseBackColor = True
        Me.colTrdStatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colTrdStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTrdStatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTrdStatus.Caption = "3rd Status"
        Me.colTrdStatus.FieldName = "TrdStatus"
        Me.colTrdStatus.Name = "colTrdStatus"
        Me.colTrdStatus.Visible = True
        Me.colTrdStatus.VisibleIndex = 12
        '
        'colUser_Id
        '
        Me.colUser_Id.Caption = "User"
        Me.colUser_Id.ColumnEdit = Me.UserLookUpEdit
        Me.colUser_Id.FieldName = "User_Id"
        Me.colUser_Id.Name = "colUser_Id"
        Me.colUser_Id.Visible = True
        Me.colUser_Id.VisibleIndex = 0
        '
        'UserLookUpEdit
        '
        Me.UserLookUpEdit.AutoHeight = False
        Me.UserLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("USER_ID", "USER_ID", 66, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("USER_NAME", "USER_NAME", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PASSWORD", "PASSWORD", 67, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("USER_LEVEL", "USER_LEVEL", 70, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACTIVE", "ACTIVE", 46, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentId", "Department Id", 80, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.UserLookUpEdit.DataSource = Me.UserBindingSource
        Me.UserLookUpEdit.DisplayMember = "USER_ID"
        Me.UserLookUpEdit.Name = "UserLookUpEdit"
        Me.UserLookUpEdit.NullText = ""
        Me.UserLookUpEdit.ValueMember = "USER_ID"
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
        'colGMDepartmentId
        '
        Me.colGMDepartmentId.ColumnEdit = Me.GMDepGridLookUpEdit
        Me.colGMDepartmentId.FieldName = "GMDepartmentId"
        Me.colGMDepartmentId.Name = "colGMDepartmentId"
        Me.colGMDepartmentId.Visible = True
        Me.colGMDepartmentId.VisibleIndex = 14
        '
        'GMDepGridLookUpEdit
        '
        Me.GMDepGridLookUpEdit.AutoHeight = False
        Me.GMDepGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GMDepGridLookUpEdit.DataSource = Me.GMDepartmentBindingSource
        Me.GMDepGridLookUpEdit.DisplayMember = "GMDepartmentName"
        Me.GMDepGridLookUpEdit.Name = "GMDepGridLookUpEdit"
        Me.GMDepGridLookUpEdit.NullText = ""
        Me.GMDepGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GMDepGridLookUpEdit.ValueMember = "GMDepartmentId"
        Me.GMDepGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit4View
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
        'RepositoryItemGridLookUpEdit4View
        '
        Me.RepositoryItemGridLookUpEdit4View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit4View.Name = "RepositoryItemGridLookUpEdit4View"
        Me.RepositoryItemGridLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit4View.OptionsView.ShowGroupPanel = False
        '
        'colSeasonId
        '
        Me.colSeasonId.ColumnEdit = Me.SeasonGridLookUpEdit
        Me.colSeasonId.FieldName = "SeasonId"
        Me.colSeasonId.Name = "colSeasonId"
        '
        'SeasonGridLookUpEdit
        '
        Me.SeasonGridLookUpEdit.AutoHeight = False
        Me.SeasonGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SeasonGridLookUpEdit.DataSource = Me.SeasonBindingSource
        Me.SeasonGridLookUpEdit.DisplayMember = "SeasonName"
        Me.SeasonGridLookUpEdit.Name = "SeasonGridLookUpEdit"
        Me.SeasonGridLookUpEdit.NullText = ""
        Me.SeasonGridLookUpEdit.ValueMember = "SeasonId"
        Me.SeasonGridLookUpEdit.View = Me.GridView7
        '
        'SeasonBindingSource
        '
        Me.SeasonBindingSource.DataMember = "Season"
        Me.SeasonBindingSource.DataSource = Me.SeasonDataSet
        '
        'SeasonDataSet
        '
        Me.SeasonDataSet.DataSetName = "SeasonDataSet"
        Me.SeasonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView7
        '
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'ActivitiesPredecessorGridControl
        '
        Me.ActivitiesPredecessorGridControl.DataSource = Me.ActivitiesPredecessorBindingSource
        Me.ActivitiesPredecessorGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActivitiesPredecessorGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.ActivitiesPredecessorGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.ActivitiesPredecessorGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.ActivitiesPredecessorGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.ActivitiesPredecessorGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.ActivitiesPredecessorGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.ActivitiesPredecessorGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ActivitiesPredecessorGridControl.MainView = Me.GridView2
        Me.ActivitiesPredecessorGridControl.Name = "ActivitiesPredecessorGridControl"
        Me.ActivitiesPredecessorGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ActivitiesListPreGridLookUpEdit, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemGridLookUpEdit3})
        Me.ActivitiesPredecessorGridControl.Size = New System.Drawing.Size(957, 163)
        Me.ActivitiesPredecessorGridControl.TabIndex = 3
        Me.ActivitiesPredecessorGridControl.UseEmbeddedNavigator = True
        Me.ActivitiesPredecessorGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colActivitiesPredecessorId, Me.colActivitiesId1, Me.colActivitiesListId3, Me.colPreActivitiesId, Me.colExEDate1, Me.colAEDate1, Me.colStatus})
        Me.GridView2.GridControl = Me.ActivitiesPredecessorGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colActivitiesPredecessorId
        '
        Me.colActivitiesPredecessorId.FieldName = "ActivitiesPredecessorId"
        Me.colActivitiesPredecessorId.Name = "colActivitiesPredecessorId"
        Me.colActivitiesPredecessorId.OptionsColumn.ReadOnly = True
        '
        'colActivitiesId1
        '
        Me.colActivitiesId1.Caption = "Activities Predecessor's"
        Me.colActivitiesId1.FieldName = "ActivitiesId"
        Me.colActivitiesId1.Name = "colActivitiesId1"
        '
        'colActivitiesListId3
        '
        Me.colActivitiesListId3.Caption = "Activities Predecessor"
        Me.colActivitiesListId3.ColumnEdit = Me.ActivitiesListPreGridLookUpEdit
        Me.colActivitiesListId3.FieldName = "ActivitiesListId"
        Me.colActivitiesListId3.Name = "colActivitiesListId3"
        Me.colActivitiesListId3.Visible = True
        Me.colActivitiesListId3.VisibleIndex = 0
        Me.colActivitiesListId3.Width = 182
        '
        'ActivitiesListPreGridLookUpEdit
        '
        Me.ActivitiesListPreGridLookUpEdit.AutoHeight = False
        Me.ActivitiesListPreGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ActivitiesListPreGridLookUpEdit.DataSource = Me.ActivitiesListBindingSource
        Me.ActivitiesListPreGridLookUpEdit.DisplayMember = "Description"
        Me.ActivitiesListPreGridLookUpEdit.Name = "ActivitiesListPreGridLookUpEdit"
        Me.ActivitiesListPreGridLookUpEdit.NullText = ""
        Me.ActivitiesListPreGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ActivitiesListPreGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ActivitiesListPreGridLookUpEdit.ValueMember = "ActivitiesListId"
        Me.ActivitiesListPreGridLookUpEdit.View = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colActivitiesListId2, Me.colDescription1, Me.colRemarks2})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colActivitiesListId2
        '
        Me.colActivitiesListId2.FieldName = "ActivitiesListId"
        Me.colActivitiesListId2.Name = "colActivitiesListId2"
        '
        'colDescription1
        '
        Me.colDescription1.FieldName = "Description"
        Me.colDescription1.Name = "colDescription1"
        Me.colDescription1.Visible = True
        Me.colDescription1.VisibleIndex = 0
        '
        'colRemarks2
        '
        Me.colRemarks2.FieldName = "Remarks"
        Me.colRemarks2.Name = "colRemarks2"
        '
        'colPreActivitiesId
        '
        Me.colPreActivitiesId.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colPreActivitiesId.AppearanceCell.Options.UseBackColor = True
        Me.colPreActivitiesId.Caption = "Status"
        Me.colPreActivitiesId.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colPreActivitiesId.FieldName = "PreActivitiesId"
        Me.colPreActivitiesId.Name = "colPreActivitiesId"
        Me.colPreActivitiesId.OptionsColumn.AllowEdit = False
        Me.colPreActivitiesId.OptionsColumn.ReadOnly = True
        Me.colPreActivitiesId.Width = 108
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.ActivitiesBindingSource1
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "Status"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = ""
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "ActivitiesId"
        Me.RepositoryItemGridLookUpEdit1.View = Me.GridView5
        '
        'GridView5
        '
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colExEDate1
        '
        Me.colExEDate1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colExEDate1.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colExEDate1.AppearanceCell.Options.UseBackColor = True
        Me.colExEDate1.Caption = "Ex Date"
        Me.colExEDate1.FieldName = "ExEDate"
        Me.colExEDate1.Name = "colExEDate1"
        Me.colExEDate1.Visible = True
        Me.colExEDate1.VisibleIndex = 1
        '
        'colAEDate1
        '
        Me.colAEDate1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colAEDate1.AppearanceCell.Options.UseBackColor = True
        Me.colAEDate1.Caption = "Actual Date"
        Me.colAEDate1.FieldName = "AEDate"
        Me.colAEDate1.Name = "colAEDate1"
        Me.colAEDate1.Visible = True
        Me.colAEDate1.VisibleIndex = 2
        Me.colAEDate1.Width = 93
        '
        'colStatus
        '
        Me.colStatus.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colStatus.AppearanceCell.Options.UseBackColor = True
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 3
        Me.colStatus.Width = 113
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DataSource = Me.ActivitiesBindingSource1
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "AEDate"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.NullText = ""
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "ActivitiesId"
        Me.RepositoryItemGridLookUpEdit2.View = Me.GridView4
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemGridLookUpEdit3
        '
        Me.RepositoryItemGridLookUpEdit3.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit3.DataSource = Me.ActivitiesBindingSource1
        Me.RepositoryItemGridLookUpEdit3.DisplayMember = "ExEDate"
        Me.RepositoryItemGridLookUpEdit3.Name = "RepositoryItemGridLookUpEdit3"
        Me.RepositoryItemGridLookUpEdit3.NullText = ""
        Me.RepositoryItemGridLookUpEdit3.ValueMember = "ActivitiesId"
        Me.RepositoryItemGridLookUpEdit3.View = Me.GridView6
        '
        'GridView6
        '
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.ExportOptions.Xls.SheetName = "OIM"
        Me.PrintingSystem1.ExportOptions.Xls.ShowGridLines = True
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.ActivitiesGridControl
        Me.PrintableComponentLink1.CustomPaperSize = New System.Drawing.Size(0, 0)
        Me.PrintableComponentLink1.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'GMDepartmentTableAdapter
        '
        Me.GMDepartmentTableAdapter.ClearBeforeFill = True
        '
        'SeasonTableAdapter
        '
        Me.SeasonTableAdapter.ClearBeforeFill = True
        '
        'colAAsign_UserId
        '
        Me.colAAsign_UserId.Caption = "Asign For"
        Me.colAAsign_UserId.ColumnEdit = Me.AsignForGridLookUpEdit
        Me.colAAsign_UserId.FieldName = "AAsign_UserId"
        Me.colAAsign_UserId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colAAsign_UserId.Name = "colAAsign_UserId"
        Me.colAAsign_UserId.Visible = True
        Me.colAAsign_UserId.VisibleIndex = 1
        Me.colAAsign_UserId.Width = 99
        '
        'AsignForGridLookUpEdit
        '
        Me.AsignForGridLookUpEdit.AutoHeight = False
        Me.AsignForGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AsignForGridLookUpEdit.DataSource = Me.UserBindingSource
        Me.AsignForGridLookUpEdit.DisplayMember = "USER_NAME"
        Me.AsignForGridLookUpEdit.Name = "AsignForGridLookUpEdit"
        Me.AsignForGridLookUpEdit.NullText = ""
        Me.AsignForGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.AsignForGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.AsignForGridLookUpEdit.ValueMember = "USER_ID"
        Me.AsignForGridLookUpEdit.View = Me.GridView8
        '
        'GridView8
        '
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'frmActivitieView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 470)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmActivitieView"
        Me.Text = "Activities View"
        CType(Me.ActivitiesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesPredecessorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesProgramNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ActivitiesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesListGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMDepGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMDepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMDepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit4View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesPredecessorGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesListPreGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsignForGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ActivitiesDataSet As KSoft_Apparel.ActivitiesDataSet
    Friend WithEvents ActivitiesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivitiesTableAdapter As KSoft_Apparel.ActivitiesDataSetTableAdapters.ActivitiesTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.ActivitiesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ActivitiesPredecessorTableAdapter As KSoft_Apparel.ActivitiesDataSetTableAdapters.ActivitiesPredecessorTableAdapter
    Friend WithEvents ActivitiesListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivitiesListDataSet As KSoft_Apparel.ActivitiesListDataSet
    Friend WithEvents ActivitiesPredecessorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivitiesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents StyleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleDataSet As KSoft_Apparel.StyleDataSet
    Friend WithEvents ActivitiesListTableAdapter As KSoft_Apparel.ActivitiesListDataSetTableAdapters.ActivitiesListTableAdapter
    Friend WithEvents ActivitiesProgramNoLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleTableAdapter As KSoft_Apparel.StyleDataSetTableAdapters.StyleTableAdapter
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents ActivitiesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colActivitiesId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActivitiesListId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ActivitiesListGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colActivitiesListId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOptimisticTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMostLiklyTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPessimisticTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExSDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExEDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colASDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAEDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStack As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLeftDay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActivitiesId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSndASDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSndStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTrdASDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTrdStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents ActivitiesPredecessorGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colActivitiesPredecessorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActivitiesId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActivitiesListId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ActivitiesListPreGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colActivitiesListId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPreActivitiesId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colExEDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAEDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUser_Id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UserLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents UserDataSet As KSoft_Apparel.UserDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As KSoft_Apparel.UserDataSetTableAdapters.UserTableAdapter
    Friend WithEvents colGMDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMDepGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit4View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSeasonId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMDepartmentDataSet As KSoft_Apparel.GMDepartmentDataSet
    Friend WithEvents GMDepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GMDepartmentTableAdapter As KSoft_Apparel.GMDepartmentDataSetTableAdapters.GMDepartmentTableAdapter
    Friend WithEvents SeasonGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SeasonDataSet As KSoft_Apparel.SeasonDataSet
    Friend WithEvents SeasonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SeasonTableAdapter As KSoft_Apparel.SeasonDataSetTableAdapters.SeasonTableAdapter
    Friend WithEvents colAAsign_UserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AsignForGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
