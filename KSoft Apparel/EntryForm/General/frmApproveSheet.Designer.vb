<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApproveSheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmApproveSheet))
        Me.ApproveSheetDataSet = New KSoft_Apparel.ApproveSheetDataSet
        Me.FabricBOMApproveSheetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricBOMApproveSheetTableAdapter = New KSoft_Apparel.ApproveSheetDataSetTableAdapters.FabricBOMApproveSheetTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.ApproveSheetDataSetTableAdapters.TableAdapterManager
        Me.FabricBOMApproveSheetBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.FabricBOMApproveSheetBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.FabricBOMApproveSheetGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFabricBOMId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ProgramNoLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.FabricBOMIdSearchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricBOMIdSearchDataSet = New KSoft_Apparel.FabricBOMIdSearchDataSet
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFabricBookingDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricReqDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSignature1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSignature2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSignature3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSignature4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSignature1Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSignature2Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSignature3Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSignature4Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramComments = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FabricBOMIdSearchTableAdapter = New KSoft_Apparel.FabricBOMIdSearchDataSetTableAdapters.FabricBOMIdSearchTableAdapter
        CType(Me.ApproveSheetDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBOMApproveSheetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBOMApproveSheetBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FabricBOMApproveSheetBindingNavigator.SuspendLayout()
        CType(Me.FabricBOMApproveSheetGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBOMIdSearchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBOMIdSearchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApproveSheetDataSet
        '
        Me.ApproveSheetDataSet.DataSetName = "ApproveSheetDataSet"
        Me.ApproveSheetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FabricBOMApproveSheetBindingSource
        '
        Me.FabricBOMApproveSheetBindingSource.DataMember = "FabricBOMApproveSheet"
        Me.FabricBOMApproveSheetBindingSource.DataSource = Me.ApproveSheetDataSet
        '
        'FabricBOMApproveSheetTableAdapter
        '
        Me.FabricBOMApproveSheetTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FabricBOMApproveSheetTableAdapter = Me.FabricBOMApproveSheetTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.ApproveSheetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FabricBOMApproveSheetBindingNavigator
        '
        Me.FabricBOMApproveSheetBindingNavigator.AddNewItem = Nothing
        Me.FabricBOMApproveSheetBindingNavigator.BindingSource = Me.FabricBOMApproveSheetBindingSource
        Me.FabricBOMApproveSheetBindingNavigator.CountItem = Nothing
        Me.FabricBOMApproveSheetBindingNavigator.DeleteItem = Nothing
        Me.FabricBOMApproveSheetBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FabricBOMApproveSheetBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.FabricBOMApproveSheetBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FabricBOMApproveSheetBindingNavigator.MoveFirstItem = Nothing
        Me.FabricBOMApproveSheetBindingNavigator.MoveLastItem = Nothing
        Me.FabricBOMApproveSheetBindingNavigator.MoveNextItem = Nothing
        Me.FabricBOMApproveSheetBindingNavigator.MovePreviousItem = Nothing
        Me.FabricBOMApproveSheetBindingNavigator.Name = "FabricBOMApproveSheetBindingNavigator"
        Me.FabricBOMApproveSheetBindingNavigator.PositionItem = Nothing
        Me.FabricBOMApproveSheetBindingNavigator.Size = New System.Drawing.Size(1362, 25)
        Me.FabricBOMApproveSheetBindingNavigator.TabIndex = 0
        Me.FabricBOMApproveSheetBindingNavigator.Text = "BindingNavigator1"
        '
        'FabricBOMApproveSheetBindingNavigatorSaveItem
        '
        Me.FabricBOMApproveSheetBindingNavigatorSaveItem.Image = CType(resources.GetObject("FabricBOMApproveSheetBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FabricBOMApproveSheetBindingNavigatorSaveItem.Name = "FabricBOMApproveSheetBindingNavigatorSaveItem"
        Me.FabricBOMApproveSheetBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.FabricBOMApproveSheetBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.KSoft_Apparel.My.Resources.Resources.Tick
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(135, 22)
        Me.ToolStripButton1.Text = "&Show Booking Sheet"
        '
        'FabricBOMApproveSheetGridControl
        '
        Me.FabricBOMApproveSheetGridControl.DataSource = Me.FabricBOMApproveSheetBindingSource
        Me.FabricBOMApproveSheetGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FabricBOMApproveSheetGridControl.Location = New System.Drawing.Point(0, 25)
        Me.FabricBOMApproveSheetGridControl.MainView = Me.GridView1
        Me.FabricBOMApproveSheetGridControl.Name = "FabricBOMApproveSheetGridControl"
        Me.FabricBOMApproveSheetGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ProgramNoGridLookUpEdit, Me.ProgramNoLookupGridLookUpEdit})
        Me.FabricBOMApproveSheetGridControl.Size = New System.Drawing.Size(1362, 578)
        Me.FabricBOMApproveSheetGridControl.TabIndex = 2
        Me.FabricBOMApproveSheetGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricBOMId, Me.colFabricBookingDate, Me.colFabricReqDate, Me.colSignature1, Me.colSignature2, Me.colSignature3, Me.colSignature4, Me.colSignature1Date, Me.colSignature2Date, Me.colSignature3Date, Me.colSignature4Date, Me.colProgramComments})
        Me.GridView1.GridControl = Me.FabricBOMApproveSheetGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colFabricBOMId
        '
        Me.colFabricBOMId.Caption = "Program No "
        Me.colFabricBOMId.ColumnEdit = Me.ProgramNoLookupGridLookUpEdit
        Me.colFabricBOMId.FieldName = "FabricBOMId"
        Me.colFabricBOMId.Name = "colFabricBOMId"
        Me.colFabricBOMId.Visible = True
        Me.colFabricBOMId.VisibleIndex = 0
        Me.colFabricBOMId.Width = 148
        '
        'ProgramNoLookupGridLookUpEdit
        '
        Me.ProgramNoLookupGridLookUpEdit.AutoHeight = False
        Me.ProgramNoLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoLookupGridLookUpEdit.DataSource = Me.FabricBOMIdSearchBindingSource
        Me.ProgramNoLookupGridLookUpEdit.DisplayMember = "Details2"
        Me.ProgramNoLookupGridLookUpEdit.Name = "ProgramNoLookupGridLookUpEdit"
        Me.ProgramNoLookupGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoLookupGridLookUpEdit.ValueMember = "FabricBOMId"
        Me.ProgramNoLookupGridLookUpEdit.View = Me.GridView2
        '
        'FabricBOMIdSearchBindingSource
        '
        Me.FabricBOMIdSearchBindingSource.DataMember = "FabricBOMIdSearch"
        Me.FabricBOMIdSearchBindingSource.DataSource = Me.FabricBOMIdSearchDataSet
        '
        'FabricBOMIdSearchDataSet
        '
        Me.FabricBOMIdSearchDataSet.DataSetName = "FabricBOMIdSearchDataSet"
        Me.FabricBOMIdSearchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colFabricBookingDate
        '
        Me.colFabricBookingDate.FieldName = "FabricBookingDate"
        Me.colFabricBookingDate.Name = "colFabricBookingDate"
        Me.colFabricBookingDate.OptionsColumn.AllowEdit = False
        Me.colFabricBookingDate.OptionsColumn.ReadOnly = True
        Me.colFabricBookingDate.Visible = True
        Me.colFabricBookingDate.VisibleIndex = 1
        Me.colFabricBookingDate.Width = 122
        '
        'colFabricReqDate
        '
        Me.colFabricReqDate.FieldName = "FabricReqDate"
        Me.colFabricReqDate.Name = "colFabricReqDate"
        Me.colFabricReqDate.OptionsColumn.AllowEdit = False
        Me.colFabricReqDate.OptionsColumn.ReadOnly = True
        Me.colFabricReqDate.Visible = True
        Me.colFabricReqDate.VisibleIndex = 2
        Me.colFabricReqDate.Width = 109
        '
        'colSignature1
        '
        Me.colSignature1.Caption = "CAD Manager"
        Me.colSignature1.FieldName = "Signature1"
        Me.colSignature1.Name = "colSignature1"
        Me.colSignature1.Visible = True
        Me.colSignature1.VisibleIndex = 3
        Me.colSignature1.Width = 110
        '
        'colSignature2
        '
        Me.colSignature2.Caption = "Merchandiser/S. Merchandiser"
        Me.colSignature2.FieldName = "Signature2"
        Me.colSignature2.Name = "colSignature2"
        Me.colSignature2.Visible = True
        Me.colSignature2.VisibleIndex = 5
        Me.colSignature2.Width = 161
        '
        'colSignature3
        '
        Me.colSignature3.Caption = "M. Manager"
        Me.colSignature3.FieldName = "Signature3"
        Me.colSignature3.Name = "colSignature3"
        Me.colSignature3.Visible = True
        Me.colSignature3.VisibleIndex = 7
        Me.colSignature3.Width = 103
        '
        'colSignature4
        '
        Me.colSignature4.Caption = "Approved By"
        Me.colSignature4.FieldName = "Signature4"
        Me.colSignature4.Name = "colSignature4"
        Me.colSignature4.Visible = True
        Me.colSignature4.VisibleIndex = 9
        Me.colSignature4.Width = 112
        '
        'colSignature1Date
        '
        Me.colSignature1Date.Caption = "Approved On"
        Me.colSignature1Date.DisplayFormat.FormatString = "dd-MMM-yy HH:mm"
        Me.colSignature1Date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colSignature1Date.FieldName = "Signature1Date"
        Me.colSignature1Date.Name = "colSignature1Date"
        Me.colSignature1Date.OptionsColumn.AllowEdit = False
        Me.colSignature1Date.OptionsColumn.ReadOnly = True
        Me.colSignature1Date.Visible = True
        Me.colSignature1Date.VisibleIndex = 4
        Me.colSignature1Date.Width = 95
        '
        'colSignature2Date
        '
        Me.colSignature2Date.Caption = "Approved On"
        Me.colSignature2Date.DisplayFormat.FormatString = "dd-MMM-yy HH:mm"
        Me.colSignature2Date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colSignature2Date.FieldName = "Signature2Date"
        Me.colSignature2Date.Name = "colSignature2Date"
        Me.colSignature2Date.OptionsColumn.AllowEdit = False
        Me.colSignature2Date.OptionsColumn.ReadOnly = True
        Me.colSignature2Date.Visible = True
        Me.colSignature2Date.VisibleIndex = 6
        Me.colSignature2Date.Width = 108
        '
        'colSignature3Date
        '
        Me.colSignature3Date.Caption = "Approved On"
        Me.colSignature3Date.DisplayFormat.FormatString = "dd-MMM-yy HH:mm"
        Me.colSignature3Date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colSignature3Date.FieldName = "Signature3Date"
        Me.colSignature3Date.Name = "colSignature3Date"
        Me.colSignature3Date.OptionsColumn.AllowEdit = False
        Me.colSignature3Date.OptionsColumn.ReadOnly = True
        Me.colSignature3Date.Visible = True
        Me.colSignature3Date.VisibleIndex = 8
        Me.colSignature3Date.Width = 106
        '
        'colSignature4Date
        '
        Me.colSignature4Date.Caption = "Approved On"
        Me.colSignature4Date.DisplayFormat.FormatString = "dd-MMM-yy HH:mm"
        Me.colSignature4Date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colSignature4Date.FieldName = "Signature4Date"
        Me.colSignature4Date.Name = "colSignature4Date"
        Me.colSignature4Date.OptionsColumn.AllowEdit = False
        Me.colSignature4Date.OptionsColumn.ReadOnly = True
        Me.colSignature4Date.Visible = True
        Me.colSignature4Date.VisibleIndex = 10
        Me.colSignature4Date.Width = 129
        '
        'colProgramComments
        '
        Me.colProgramComments.FieldName = "ProgramComments"
        Me.colProgramComments.Name = "colProgramComments"
        Me.colProgramComments.OptionsColumn.AllowEdit = False
        Me.colProgramComments.OptionsColumn.ReadOnly = True
        Me.colProgramComments.Visible = True
        Me.colProgramComments.VisibleIndex = 11
        Me.colProgramComments.Width = 132
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.AutoHeight = False
        Me.ProgramNoGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.DataSource = Me.FabricBOMIdSearchBindingSource
        Me.ProgramNoGridLookUpEdit.DisplayMember = "Details2"
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.NullText = ""
        Me.ProgramNoGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.ValueMember = "OrderId"
        Me.ProgramNoGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'OrderLookupBindingSource
        '
        Me.OrderLookupBindingSource.DataMember = "OrderLookup"
        Me.OrderLookupBindingSource.DataSource = Me.OrderLookupDataSet
        '
        'OrderLookupDataSet
        '
        Me.OrderLookupDataSet.DataSetName = "OrderLookupDataSet"
        Me.OrderLookupDataSet.EnforceConstraints = False
        Me.OrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'FabricBOMIdSearchTableAdapter
        '
        Me.FabricBOMIdSearchTableAdapter.ClearBeforeFill = True
        '
        'frmApproveSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 603)
        Me.Controls.Add(Me.FabricBOMApproveSheetGridControl)
        Me.Controls.Add(Me.FabricBOMApproveSheetBindingNavigator)
        Me.Name = "frmApproveSheet"
        Me.Text = "Approve Sheet"
        CType(Me.ApproveSheetDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBOMApproveSheetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBOMApproveSheetBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FabricBOMApproveSheetBindingNavigator.ResumeLayout(False)
        Me.FabricBOMApproveSheetBindingNavigator.PerformLayout()
        CType(Me.FabricBOMApproveSheetGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBOMIdSearchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBOMIdSearchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ApproveSheetDataSet As KSoft_Apparel.ApproveSheetDataSet
    Friend WithEvents FabricBOMApproveSheetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricBOMApproveSheetTableAdapter As KSoft_Apparel.ApproveSheetDataSetTableAdapters.FabricBOMApproveSheetTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.ApproveSheetDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FabricBOMApproveSheetBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents FabricBOMApproveSheetBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FabricBOMApproveSheetGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricBookingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricReqDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSignature1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSignature2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSignature3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSignature4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSignature1Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSignature2Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSignature3Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSignature4Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FabricBOMIdSearchDataSet As KSoft_Apparel.FabricBOMIdSearchDataSet
    Friend WithEvents FabricBOMIdSearchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricBOMIdSearchTableAdapter As KSoft_Apparel.FabricBOMIdSearchDataSetTableAdapters.FabricBOMIdSearchTableAdapter
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents colProgramComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricBOMId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProgramNoLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
