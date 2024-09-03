<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSampleComplete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSampleComplete))
        Me.SampleRequestDataSet = New KSoft_Apparel.SampleRequestDataSet()
        Me.SampleRequestFinalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SampleRequestFinalTableAdapter = New KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleRequestFinalTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.SampleRequestDataSetTableAdapters.TableAdapterManager()
        Me.SampleRequestFinalBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.SampleRequestFinalBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SampleRequestFinalGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRequestNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CompletedOnDateEdit = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colStyleId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.StyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleDataSet = New KSoft_Apparel.StyleDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRequestDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StyleTableAdapter = New KSoft_Apparel.StyleDataSetTableAdapters.StyleTableAdapter()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        CType(Me.SampleRequestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestFinalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestFinalBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SampleRequestFinalBindingNavigator.SuspendLayout()
        CType(Me.SampleRequestFinalGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompletedOnDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompletedOnDateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SampleRequestDataSet
        '
        Me.SampleRequestDataSet.DataSetName = "SampleRequestDataSet"
        Me.SampleRequestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SampleRequestFinalBindingSource
        '
        Me.SampleRequestFinalBindingSource.DataMember = "SampleRequestFinal"
        Me.SampleRequestFinalBindingSource.DataSource = Me.SampleRequestDataSet
        '
        'SampleRequestFinalTableAdapter
        '
        Me.SampleRequestFinalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SampleFabricTableAdapter = Nothing
        Me.TableAdapterManager.SamplePrintColorTableAdapter = Nothing
        Me.TableAdapterManager.SampleRequestFinalDetailsTableAdapter = Nothing
        Me.TableAdapterManager.SampleRequestFinalTableAdapter = Me.SampleRequestFinalTableAdapter
        Me.TableAdapterManager.SampleRequireQuantityTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SampleRequestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.YarnAllocationSampleTableAdapter = Nothing
        '
        'SampleRequestFinalBindingNavigator
        '
        Me.SampleRequestFinalBindingNavigator.AddNewItem = Nothing
        Me.SampleRequestFinalBindingNavigator.BindingSource = Me.SampleRequestFinalBindingSource
        Me.SampleRequestFinalBindingNavigator.CountItem = Nothing
        Me.SampleRequestFinalBindingNavigator.DeleteItem = Nothing
        Me.SampleRequestFinalBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SampleRequestFinalBindingNavigatorSaveItem})
        Me.SampleRequestFinalBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SampleRequestFinalBindingNavigator.MoveFirstItem = Nothing
        Me.SampleRequestFinalBindingNavigator.MoveLastItem = Nothing
        Me.SampleRequestFinalBindingNavigator.MoveNextItem = Nothing
        Me.SampleRequestFinalBindingNavigator.MovePreviousItem = Nothing
        Me.SampleRequestFinalBindingNavigator.Name = "SampleRequestFinalBindingNavigator"
        Me.SampleRequestFinalBindingNavigator.PositionItem = Nothing
        Me.SampleRequestFinalBindingNavigator.Size = New System.Drawing.Size(985, 25)
        Me.SampleRequestFinalBindingNavigator.TabIndex = 0
        Me.SampleRequestFinalBindingNavigator.Text = "BindingNavigator1"
        '
        'SampleRequestFinalBindingNavigatorSaveItem
        '
        Me.SampleRequestFinalBindingNavigatorSaveItem.Image = CType(resources.GetObject("SampleRequestFinalBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SampleRequestFinalBindingNavigatorSaveItem.Name = "SampleRequestFinalBindingNavigatorSaveItem"
        Me.SampleRequestFinalBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.SampleRequestFinalBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SampleRequestFinalGridControl
        '
        Me.SampleRequestFinalGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SampleRequestFinalGridControl.DataSource = Me.SampleRequestFinalBindingSource
        Me.SampleRequestFinalGridControl.Location = New System.Drawing.Point(0, 28)
        Me.SampleRequestFinalGridControl.MainView = Me.GridView1
        Me.SampleRequestFinalGridControl.Name = "SampleRequestFinalGridControl"
        Me.SampleRequestFinalGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.CompletedOnDateEdit, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemGridLookUpEdit2})
        Me.SampleRequestFinalGridControl.Size = New System.Drawing.Size(985, 537)
        Me.SampleRequestFinalGridControl.TabIndex = 1
        Me.SampleRequestFinalGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRequestNo, Me.colIsComplete, Me.colCompletedOn, Me.colStyleId, Me.colBuyerId, Me.colRequestDate})
        Me.GridView1.GridControl = Me.SampleRequestFinalGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.EnableMasterViewMode = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colRequestNo
        '
        Me.colRequestNo.Caption = "Sample Program No"
        Me.colRequestNo.FieldName = "RequestNo"
        Me.colRequestNo.Name = "colRequestNo"
        Me.colRequestNo.OptionsColumn.AllowEdit = False
        Me.colRequestNo.OptionsColumn.ReadOnly = True
        Me.colRequestNo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colRequestNo.Visible = True
        Me.colRequestNo.VisibleIndex = 0
        Me.colRequestNo.Width = 140
        '
        'colIsComplete
        '
        Me.colIsComplete.Caption = "Complete"
        Me.colIsComplete.FieldName = "IsComplete"
        Me.colIsComplete.Name = "colIsComplete"
        Me.colIsComplete.Visible = True
        Me.colIsComplete.VisibleIndex = 4
        Me.colIsComplete.Width = 137
        '
        'colCompletedOn
        '
        Me.colCompletedOn.ColumnEdit = Me.CompletedOnDateEdit
        Me.colCompletedOn.FieldName = "CompletedOn"
        Me.colCompletedOn.Name = "colCompletedOn"
        Me.colCompletedOn.OptionsColumn.ReadOnly = True
        Me.colCompletedOn.Visible = True
        Me.colCompletedOn.VisibleIndex = 5
        Me.colCompletedOn.Width = 190
        '
        'CompletedOnDateEdit
        '
        Me.CompletedOnDateEdit.AutoHeight = False
        Me.CompletedOnDateEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompletedOnDateEdit.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompletedOnDateEdit.DisplayFormat.FormatString = "dd-MMM-yy HH:mm"
        Me.CompletedOnDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.CompletedOnDateEdit.EditFormat.FormatString = "dd-MMM-yy HH:mm"
        Me.CompletedOnDateEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.CompletedOnDateEdit.Mask.EditMask = "dd-MMM-yy HH:mm"
        Me.CompletedOnDateEdit.Name = "CompletedOnDateEdit"
        Me.CompletedOnDateEdit.ReadOnly = True
        '
        'colStyleId
        '
        Me.colStyleId.Caption = "Style"
        Me.colStyleId.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colStyleId.FieldName = "StyleId"
        Me.colStyleId.Name = "colStyleId"
        Me.colStyleId.Visible = True
        Me.colStyleId.VisibleIndex = 1
        Me.colStyleId.Width = 161
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.StyleBindingSource
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "StyleName"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "StyleId"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'StyleBindingSource
        '
        Me.StyleBindingSource.DataMember = "Style"
        Me.StyleBindingSource.DataSource = Me.StyleDataSet
        '
        'StyleDataSet
        '
        Me.StyleDataSet.DataSetName = "d"
        Me.StyleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colBuyerId
        '
        Me.colBuyerId.Caption = "Buyer"
        Me.colBuyerId.ColumnEdit = Me.RepositoryItemGridLookUpEdit2
        Me.colBuyerId.FieldName = "BuyerId"
        Me.colBuyerId.Name = "colBuyerId"
        Me.colBuyerId.Visible = True
        Me.colBuyerId.VisibleIndex = 2
        Me.colBuyerId.Width = 161
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DataSource = Me.BuyerBindingSource
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "BuyerName"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "BuyerId"
        Me.RepositoryItemGridLookUpEdit2.View = Me.RepositoryItemGridLookUpEdit2View
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
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colRequestDate
        '
        Me.colRequestDate.Caption = "Sample Program Date"
        Me.colRequestDate.FieldName = "RequestDate"
        Me.colRequestDate.Name = "colRequestDate"
        Me.colRequestDate.Visible = True
        Me.colRequestDate.VisibleIndex = 3
        Me.colRequestDate.Width = 178
        '
        'StyleTableAdapter
        '
        Me.StyleTableAdapter.ClearBeforeFill = True
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'frmSampleComplete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 563)
        Me.Controls.Add(Me.SampleRequestFinalGridControl)
        Me.Controls.Add(Me.SampleRequestFinalBindingNavigator)
        Me.Name = "frmSampleComplete"
        Me.Text = "Sample Complete"
        CType(Me.SampleRequestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestFinalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestFinalBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SampleRequestFinalBindingNavigator.ResumeLayout(False)
        Me.SampleRequestFinalBindingNavigator.PerformLayout()
        CType(Me.SampleRequestFinalGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompletedOnDateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompletedOnDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SampleRequestDataSet As KSoft_Apparel.SampleRequestDataSet
    Friend WithEvents SampleRequestFinalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SampleRequestFinalTableAdapter As KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleRequestFinalTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.SampleRequestDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SampleRequestFinalBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents SampleRequestFinalBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SampleRequestFinalGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRequestNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CompletedOnDateEdit As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colStyleId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequestDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents StyleBindingSource As BindingSource
    Friend WithEvents StyleDataSet As StyleDataSet
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents BuyerBindingSource As BindingSource
    Friend WithEvents BuyerDataSet As BuyerDataSet
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents StyleTableAdapter As StyleDataSetTableAdapters.StyleTableAdapter
    Friend WithEvents BuyerTableAdapter As BuyerDataSetTableAdapters.BuyerTableAdapter
End Class
