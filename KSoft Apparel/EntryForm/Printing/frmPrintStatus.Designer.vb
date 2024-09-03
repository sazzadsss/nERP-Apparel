<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintStatus))
        Me.PrintStatusDataSet = New KSoft_Apparel.PrintStatusDataSet
        Me.PrintStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintStatusTableAdapter = New KSoft_Apparel.PrintStatusDataSetTableAdapters.PrintStatusTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.PrintStatusDataSetTableAdapters.TableAdapterManager
        Me.PrintStatusBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.PrintStatusBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.PrintStatusGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStyle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBodyColor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOrderQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDesignStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colScreenStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFirstStep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSecondStep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colThirdStep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGoldSill = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSizeSet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSER_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.UserGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.UserLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserLookupDataSet = New KSoft_Apparel.UserLookupDataSet
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBuyer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrintStatusDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colArtworkReceiveDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricReceiveDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.UserLookupTableAdapter = New KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PrintStatusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintStatusBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PrintStatusBindingNavigator.SuspendLayout()
        CType(Me.PrintStatusGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintStatusDataSet
        '
        Me.PrintStatusDataSet.DataSetName = "PrintStatusDataSet"
        Me.PrintStatusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrintStatusBindingSource
        '
        Me.PrintStatusBindingSource.DataMember = "PrintStatus"
        Me.PrintStatusBindingSource.DataSource = Me.PrintStatusDataSet
        '
        'PrintStatusTableAdapter
        '
        Me.PrintStatusTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PrintStatusTableAdapter = Me.PrintStatusTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.PrintStatusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PrintStatusBindingNavigator
        '
        Me.PrintStatusBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PrintStatusBindingNavigator.BindingSource = Me.PrintStatusBindingSource
        Me.PrintStatusBindingNavigator.CountItem = Nothing
        Me.PrintStatusBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PrintStatusBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PrintStatusBindingNavigatorSaveItem, Me.PrintToolStripButton})
        Me.PrintStatusBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PrintStatusBindingNavigator.MoveFirstItem = Nothing
        Me.PrintStatusBindingNavigator.MoveLastItem = Nothing
        Me.PrintStatusBindingNavigator.MoveNextItem = Nothing
        Me.PrintStatusBindingNavigator.MovePreviousItem = Nothing
        Me.PrintStatusBindingNavigator.Name = "PrintStatusBindingNavigator"
        Me.PrintStatusBindingNavigator.PositionItem = Nothing
        Me.PrintStatusBindingNavigator.Size = New System.Drawing.Size(1092, 25)
        Me.PrintStatusBindingNavigator.TabIndex = 0
        Me.PrintStatusBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'PrintStatusBindingNavigatorSaveItem
        '
        Me.PrintStatusBindingNavigatorSaveItem.Image = CType(resources.GetObject("PrintStatusBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PrintStatusBindingNavigatorSaveItem.Name = "PrintStatusBindingNavigatorSaveItem"
        Me.PrintStatusBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.PrintStatusBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Text_Document_icon
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(103, 22)
        Me.PrintToolStripButton.Text = "Export to Excel"
        '
        'PrintStatusGridControl
        '
        Me.PrintStatusGridControl.DataSource = Me.PrintStatusBindingSource
        Me.PrintStatusGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintStatusGridControl.Location = New System.Drawing.Point(0, 25)
        Me.PrintStatusGridControl.MainView = Me.GridView1
        Me.PrintStatusGridControl.Name = "PrintStatusGridControl"
        Me.PrintStatusGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.UserGridLookUpEdit})
        Me.PrintStatusGridControl.Size = New System.Drawing.Size(1092, 509)
        Me.PrintStatusGridControl.TabIndex = 1
        Me.PrintStatusGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgramNo, Me.colStyle, Me.colBodyColor, Me.colOrderQty, Me.colDesignStatus, Me.colScreenStatus, Me.colFirstStep, Me.colSecondStep, Me.colThirdStep, Me.colGoldSill, Me.colSizeSet, Me.colUSER_ID, Me.colRemarks, Me.colBuyer, Me.colPrintStatusDate, Me.colArtworkReceiveDate, Me.colFabricReceiveDate})
        Me.GridView1.GridControl = Me.PrintStatusGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 1
        Me.colProgramNo.Width = 59
        '
        'colStyle
        '
        Me.colStyle.FieldName = "Style"
        Me.colStyle.Name = "colStyle"
        Me.colStyle.Visible = True
        Me.colStyle.VisibleIndex = 3
        Me.colStyle.Width = 59
        '
        'colBodyColor
        '
        Me.colBodyColor.FieldName = "BodyColor"
        Me.colBodyColor.Name = "colBodyColor"
        Me.colBodyColor.Visible = True
        Me.colBodyColor.VisibleIndex = 4
        Me.colBodyColor.Width = 59
        '
        'colOrderQty
        '
        Me.colOrderQty.FieldName = "OrderQty"
        Me.colOrderQty.Name = "colOrderQty"
        Me.colOrderQty.Visible = True
        Me.colOrderQty.VisibleIndex = 5
        Me.colOrderQty.Width = 59
        '
        'colDesignStatus
        '
        Me.colDesignStatus.FieldName = "DesignStatus"
        Me.colDesignStatus.Name = "colDesignStatus"
        Me.colDesignStatus.Visible = True
        Me.colDesignStatus.VisibleIndex = 6
        Me.colDesignStatus.Width = 85
        '
        'colScreenStatus
        '
        Me.colScreenStatus.FieldName = "ScreenStatus"
        Me.colScreenStatus.Name = "colScreenStatus"
        Me.colScreenStatus.Visible = True
        Me.colScreenStatus.VisibleIndex = 7
        '
        'colFirstStep
        '
        Me.colFirstStep.Caption = "OFS1"
        Me.colFirstStep.FieldName = "FirstStep"
        Me.colFirstStep.Name = "colFirstStep"
        Me.colFirstStep.Visible = True
        Me.colFirstStep.VisibleIndex = 8
        Me.colFirstStep.Width = 56
        '
        'colSecondStep
        '
        Me.colSecondStep.Caption = "OFS2"
        Me.colSecondStep.FieldName = "SecondStep"
        Me.colSecondStep.Name = "colSecondStep"
        Me.colSecondStep.Visible = True
        Me.colSecondStep.VisibleIndex = 9
        Me.colSecondStep.Width = 56
        '
        'colThirdStep
        '
        Me.colThirdStep.Caption = "SMS"
        Me.colThirdStep.FieldName = "ThirdStep"
        Me.colThirdStep.Name = "colThirdStep"
        Me.colThirdStep.Visible = True
        Me.colThirdStep.VisibleIndex = 10
        Me.colThirdStep.Width = 56
        '
        'colGoldSill
        '
        Me.colGoldSill.Caption = "GSS"
        Me.colGoldSill.FieldName = "GoldSill"
        Me.colGoldSill.Name = "colGoldSill"
        Me.colGoldSill.Visible = True
        Me.colGoldSill.VisibleIndex = 11
        Me.colGoldSill.Width = 56
        '
        'colSizeSet
        '
        Me.colSizeSet.FieldName = "SizeSet"
        Me.colSizeSet.Name = "colSizeSet"
        Me.colSizeSet.Visible = True
        Me.colSizeSet.VisibleIndex = 12
        Me.colSizeSet.Width = 56
        '
        'colUSER_ID
        '
        Me.colUSER_ID.AppearanceCell.Options.UseTextOptions = True
        Me.colUSER_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUSER_ID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUSER_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.colUSER_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUSER_ID.Caption = "User"
        Me.colUSER_ID.ColumnEdit = Me.UserGridLookUpEdit
        Me.colUSER_ID.FieldName = "USER_ID"
        Me.colUSER_ID.Name = "colUSER_ID"
        Me.colUSER_ID.Visible = True
        Me.colUSER_ID.VisibleIndex = 15
        Me.colUSER_ID.Width = 59
        '
        'UserGridLookUpEdit
        '
        Me.UserGridLookUpEdit.AutoHeight = False
        Me.UserGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserGridLookUpEdit.DataSource = Me.UserLookupBindingSource
        Me.UserGridLookUpEdit.DisplayMember = "USER_NAME"
        Me.UserGridLookUpEdit.Name = "UserGridLookUpEdit"
        Me.UserGridLookUpEdit.NullText = ""
        Me.UserGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.UserGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.UserGridLookUpEdit.ValueMember = "USER_ID"
        Me.UserGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'UserLookupBindingSource
        '
        Me.UserLookupBindingSource.DataMember = "UserLookup"
        Me.UserLookupBindingSource.DataSource = Me.UserLookupDataSet
        '
        'UserLookupDataSet
        '
        Me.UserLookupDataSet.DataSetName = "UserLookupDataSet"
        Me.UserLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 16
        Me.colRemarks.Width = 56
        '
        'colBuyer
        '
        Me.colBuyer.FieldName = "Buyer"
        Me.colBuyer.Name = "colBuyer"
        Me.colBuyer.Visible = True
        Me.colBuyer.VisibleIndex = 2
        Me.colBuyer.Width = 73
        '
        'colPrintStatusDate
        '
        Me.colPrintStatusDate.FieldName = "PrintStatusDate"
        Me.colPrintStatusDate.Name = "colPrintStatusDate"
        Me.colPrintStatusDate.Visible = True
        Me.colPrintStatusDate.VisibleIndex = 0
        Me.colPrintStatusDate.Width = 83
        '
        'colArtworkReceiveDate
        '
        Me.colArtworkReceiveDate.FieldName = "ArtworkReceiveDate"
        Me.colArtworkReceiveDate.Name = "colArtworkReceiveDate"
        Me.colArtworkReceiveDate.Visible = True
        Me.colArtworkReceiveDate.VisibleIndex = 13
        Me.colArtworkReceiveDate.Width = 71
        '
        'colFabricReceiveDate
        '
        Me.colFabricReceiveDate.FieldName = "FabricReceiveDate"
        Me.colFabricReceiveDate.Name = "colFabricReceiveDate"
        Me.colFabricReceiveDate.Visible = True
        Me.colFabricReceiveDate.VisibleIndex = 14
        Me.colFabricReceiveDate.Width = 79
        '
        'UserLookupTableAdapter
        '
        Me.UserLookupTableAdapter.ClearBeforeFill = True
        '
        'colUSER_NAME
        '
        Me.colUSER_NAME.FieldName = "USER_NAME"
        Me.colUSER_NAME.Name = "colUSER_NAME"
        Me.colUSER_NAME.Visible = True
        Me.colUSER_NAME.VisibleIndex = 0
        '
        'frmPrintStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 534)
        Me.Controls.Add(Me.PrintStatusGridControl)
        Me.Controls.Add(Me.PrintStatusBindingNavigator)
        Me.Name = "frmPrintStatus"
        Me.Text = "Print Status"
        CType(Me.PrintStatusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintStatusBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PrintStatusBindingNavigator.ResumeLayout(False)
        Me.PrintStatusBindingNavigator.PerformLayout()
        CType(Me.PrintStatusGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintStatusDataSet As KSoft_Apparel.PrintStatusDataSet
    Friend WithEvents PrintStatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintStatusTableAdapter As KSoft_Apparel.PrintStatusDataSetTableAdapters.PrintStatusTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.PrintStatusDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PrintStatusBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintStatusBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintStatusGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBodyColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesignStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colScreenStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFirstStep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSecondStep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colThirdStep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGoldSill As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSizeSet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSER_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UserGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UserLookupDataSet As KSoft_Apparel.UserLookupDataSet
    Friend WithEvents UserLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserLookupTableAdapter As KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter
    Friend WithEvents colUSER_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintStatusDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArtworkReceiveDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricReceiveDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
End Class
