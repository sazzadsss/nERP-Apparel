<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSewingLayoutDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSewingLayoutDetails))
        Me.SewingLayoutDetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.SewingLayoutDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingLayoutDataSet = New KSoft_Apparel.SewingLayoutDataSet()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.SewingLayoutDetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.CapacityPercentageToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ShowAllToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SewingSMVViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OKButton = New System.Windows.Forms.Button()
        Me.SewingLayoutDetailsTableAdapter = New KSoft_Apparel.SewingLayoutDataSetTableAdapters.SewingLayoutDetailsTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.SewingLayoutDataSetTableAdapters.TableAdapterManager()
        Me.SewingSMVViewTableAdapter = New KSoft_Apparel.SewingLayoutDataSetTableAdapters.SewingSMVViewTableAdapter()
        Me.DownButton = New System.Windows.Forms.Button()
        Me.UpButton = New System.Windows.Forms.Button()
        Me.SewingLayoutDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSlNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProcess_Type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCapacity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCapacityPercentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSewingSMVId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProcessGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProcessName = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.SewingLayoutDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SewingLayoutDetailsBindingNavigator.SuspendLayout()
        CType(Me.SewingLayoutDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingLayoutDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingSMVViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingLayoutDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProcessGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SewingLayoutDetailsBindingNavigator
        '
        Me.SewingLayoutDetailsBindingNavigator.AddNewItem = Nothing
        Me.SewingLayoutDetailsBindingNavigator.BindingSource = Me.SewingLayoutDetailsBindingSource
        Me.SewingLayoutDetailsBindingNavigator.CountItem = Nothing
        Me.SewingLayoutDetailsBindingNavigator.DeleteItem = Nothing
        Me.SewingLayoutDetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.SewingLayoutDetailsBindingNavigatorSaveItem, Me.ToolStripButton2, Me.ToolStripLabel1, Me.CapacityPercentageToolStripTextBox, Me.ToolStripButton3, Me.ShowAllToolStripButton})
        Me.SewingLayoutDetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SewingLayoutDetailsBindingNavigator.MoveFirstItem = Nothing
        Me.SewingLayoutDetailsBindingNavigator.MoveLastItem = Nothing
        Me.SewingLayoutDetailsBindingNavigator.MoveNextItem = Nothing
        Me.SewingLayoutDetailsBindingNavigator.MovePreviousItem = Nothing
        Me.SewingLayoutDetailsBindingNavigator.Name = "SewingLayoutDetailsBindingNavigator"
        Me.SewingLayoutDetailsBindingNavigator.PositionItem = Nothing
        Me.SewingLayoutDetailsBindingNavigator.Size = New System.Drawing.Size(798, 25)
        Me.SewingLayoutDetailsBindingNavigator.TabIndex = 0
        Me.SewingLayoutDetailsBindingNavigator.Text = "BindingNavigator1"
        '
        'SewingLayoutDetailsBindingSource
        '
        Me.SewingLayoutDetailsBindingSource.DataMember = "SewingLayoutDetails"
        Me.SewingLayoutDetailsBindingSource.DataSource = Me.SewingLayoutDataSet
        '
        'SewingLayoutDataSet
        '
        Me.SewingLayoutDataSet.DataSetName = "SewingLayoutDataSet"
        Me.SewingLayoutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(74, 22)
        Me.ToolStripButton1.Text = "Generate"
        '
        'SewingLayoutDetailsBindingNavigatorSaveItem
        '
        Me.SewingLayoutDetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("SewingLayoutDetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SewingLayoutDetailsBindingNavigatorSaveItem.Name = "SewingLayoutDetailsBindingNavigatorSaveItem"
        Me.SewingLayoutDetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.SewingLayoutDetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton2.Text = "Print"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(105, 22)
        Me.ToolStripLabel1.Text = "             Capacity %"
        '
        'CapacityPercentageToolStripTextBox
        '
        Me.CapacityPercentageToolStripTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CapacityPercentageToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CapacityPercentageToolStripTextBox.Name = "CapacityPercentageToolStripTextBox"
        Me.CapacityPercentageToolStripTextBox.Size = New System.Drawing.Size(50, 25)
        Me.CapacityPercentageToolStripTextBox.Text = "100"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(58, 22)
        Me.ToolStripButton3.Text = "Apply"
        '
        'ShowAllToolStripButton
        '
        Me.ShowAllToolStripButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Copy_icon
        Me.ShowAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShowAllToolStripButton.Name = "ShowAllToolStripButton"
        Me.ShowAllToolStripButton.Size = New System.Drawing.Size(73, 22)
        Me.ShowAllToolStripButton.Text = "Show All"
        '
        'SewingSMVViewBindingSource
        '
        Me.SewingSMVViewBindingSource.DataMember = "SewingSMVView"
        Me.SewingSMVViewBindingSource.DataSource = Me.SewingLayoutDataSet
        '
        'OKButton
        '
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OKButton.Location = New System.Drawing.Point(679, 534)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(107, 27)
        Me.OKButton.TabIndex = 3
        Me.OKButton.Text = "&OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'SewingLayoutDetailsTableAdapter
        '
        Me.SewingLayoutDetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SewingBreakDownCopyTableAdapter = Nothing
        Me.TableAdapterManager.SewingBreakDownTableAdapter = Nothing
        Me.TableAdapterManager.SewingCategoryTableAdapter = Nothing
        Me.TableAdapterManager.SewingLayoutDetailsTableAdapter = Me.SewingLayoutDetailsTableAdapter
        Me.TableAdapterManager.SewingLayoutTableAdapter = Nothing
        Me.TableAdapterManager.SewingLearningCurveTableAdapter = Nothing
        Me.TableAdapterManager.SewingMachineLayoutTableAdapter = Nothing
        Me.TableAdapterManager.SewingMachineTableAdapter = Nothing
        Me.TableAdapterManager.SewingProcessTableAdapter = Nothing
        Me.TableAdapterManager.SewingSMVCopyTableAdapter = Nothing
        Me.TableAdapterManager.SewingSMVTableAdapter = Nothing
        Me.TableAdapterManager.SewingTargetAllocationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SewingLayoutDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SewingSMVViewTableAdapter
        '
        Me.SewingSMVViewTableAdapter.ClearBeforeFill = True
        '
        'DownButton
        '
        Me.DownButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DownButton.Location = New System.Drawing.Point(72, 534)
        Me.DownButton.Name = "DownButton"
        Me.DownButton.Size = New System.Drawing.Size(56, 23)
        Me.DownButton.TabIndex = 5
        Me.DownButton.Text = "Down"
        Me.DownButton.UseVisualStyleBackColor = True
        '
        'UpButton
        '
        Me.UpButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UpButton.Location = New System.Drawing.Point(11, 534)
        Me.UpButton.Name = "UpButton"
        Me.UpButton.Size = New System.Drawing.Size(55, 23)
        Me.UpButton.TabIndex = 4
        Me.UpButton.Text = "Up"
        Me.UpButton.UseVisualStyleBackColor = True
        '
        'SewingLayoutDetailsGridControl
        '
        Me.SewingLayoutDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SewingLayoutDetailsGridControl.DataSource = Me.SewingLayoutDetailsBindingSource
        Me.SewingLayoutDetailsGridControl.Location = New System.Drawing.Point(0, 28)
        Me.SewingLayoutDetailsGridControl.MainView = Me.GridView1
        Me.SewingLayoutDetailsGridControl.Name = "SewingLayoutDetailsGridControl"
        Me.SewingLayoutDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ProcessGridLookUpEdit})
        Me.SewingLayoutDetailsGridControl.Size = New System.Drawing.Size(798, 495)
        Me.SewingLayoutDetailsGridControl.TabIndex = 5
        Me.SewingLayoutDetailsGridControl.UseEmbeddedNavigator = True
        Me.SewingLayoutDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSlNo, Me.colProcess_Type, Me.colRemarks, Me.colCapacity, Me.colCapacityPercentage, Me.colSewingSMVId})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(971, 447, 216, 190)
        Me.GridView1.GridControl = Me.SewingLayoutDetailsGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSlNo, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSlNo
        '
        Me.colSlNo.Caption = "SL"
        Me.colSlNo.FieldName = "SlNo"
        Me.colSlNo.Name = "colSlNo"
        Me.colSlNo.OptionsColumn.AllowEdit = False
        Me.colSlNo.OptionsColumn.ReadOnly = True
        Me.colSlNo.Visible = True
        Me.colSlNo.VisibleIndex = 0
        Me.colSlNo.Width = 41
        '
        'colProcess_Type
        '
        Me.colProcess_Type.FieldName = "Process_Type"
        Me.colProcess_Type.Name = "colProcess_Type"
        Me.colProcess_Type.OptionsColumn.AllowEdit = False
        Me.colProcess_Type.OptionsColumn.ReadOnly = True
        Me.colProcess_Type.Visible = True
        Me.colProcess_Type.VisibleIndex = 2
        Me.colProcess_Type.Width = 127
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 5
        Me.colRemarks.Width = 255
        '
        'colCapacity
        '
        Me.colCapacity.FieldName = "Capacity"
        Me.colCapacity.Name = "colCapacity"
        Me.colCapacity.Visible = True
        Me.colCapacity.VisibleIndex = 4
        Me.colCapacity.Width = 70
        '
        'colCapacityPercentage
        '
        Me.colCapacityPercentage.Caption = "Capacity %"
        Me.colCapacityPercentage.FieldName = "CapacityPercentage"
        Me.colCapacityPercentage.Name = "colCapacityPercentage"
        Me.colCapacityPercentage.Visible = True
        Me.colCapacityPercentage.VisibleIndex = 3
        Me.colCapacityPercentage.Width = 81
        '
        'colSewingSMVId
        '
        Me.colSewingSMVId.Caption = "Process"
        Me.colSewingSMVId.ColumnEdit = Me.ProcessGridLookUpEdit
        Me.colSewingSMVId.FieldName = "SewingSMVId"
        Me.colSewingSMVId.Name = "colSewingSMVId"
        Me.colSewingSMVId.OptionsColumn.AllowEdit = False
        Me.colSewingSMVId.OptionsColumn.ReadOnly = True
        Me.colSewingSMVId.Visible = True
        Me.colSewingSMVId.VisibleIndex = 1
        Me.colSewingSMVId.Width = 206
        '
        'ProcessGridLookUpEdit
        '
        Me.ProcessGridLookUpEdit.AutoHeight = False
        Me.ProcessGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProcessGridLookUpEdit.DataSource = Me.SewingSMVViewBindingSource
        Me.ProcessGridLookUpEdit.DisplayMember = "ProcessName"
        Me.ProcessGridLookUpEdit.Name = "ProcessGridLookUpEdit"
        Me.ProcessGridLookUpEdit.NullText = ""
        Me.ProcessGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.ProcessGridLookUpEdit.ValueMember = "SewingSMVId"
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProcessName})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colProcessName
        '
        Me.colProcessName.FieldName = "ProcessName"
        Me.colProcessName.Name = "colProcessName"
        Me.colProcessName.Visible = True
        Me.colProcessName.VisibleIndex = 0
        '
        'frmSewingLayoutDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 568)
        Me.Controls.Add(Me.SewingLayoutDetailsGridControl)
        Me.Controls.Add(Me.DownButton)
        Me.Controls.Add(Me.UpButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.SewingLayoutDetailsBindingNavigator)
        Me.Name = "frmSewingLayoutDetails"
        Me.Text = "Sewing Layout Details"
        CType(Me.SewingLayoutDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SewingLayoutDetailsBindingNavigator.ResumeLayout(False)
        Me.SewingLayoutDetailsBindingNavigator.PerformLayout()
        CType(Me.SewingLayoutDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingLayoutDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingSMVViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingLayoutDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProcessGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SewingLayoutDataSet As KSoft_Apparel.SewingLayoutDataSet
    Friend WithEvents SewingLayoutDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SewingLayoutDetailsTableAdapter As KSoft_Apparel.SewingLayoutDataSetTableAdapters.SewingLayoutDetailsTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.SewingLayoutDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SewingLayoutDetailsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents SewingLayoutDetailsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SewingSMVViewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SewingSMVViewTableAdapter As KSoft_Apparel.SewingLayoutDataSetTableAdapters.SewingSMVViewTableAdapter
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CapacityPercentageToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ShowAllToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DownButton As System.Windows.Forms.Button
    Friend WithEvents UpButton As System.Windows.Forms.Button
    Friend WithEvents SewingLayoutDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSlNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProcess_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCapacity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCapacityPercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSewingSMVId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProcessGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProcessName As DevExpress.XtraGrid.Columns.GridColumn
End Class
