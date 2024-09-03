<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLearningCurve
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLearningCurve))
        Me.SewingLayoutDataSet = New KSoft_Apparel.SewingLayoutDataSet()
        Me.SewingLearningCurveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingLearningCurveTableAdapter = New KSoft_Apparel.SewingLayoutDataSetTableAdapters.SewingLearningCurveTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.SewingLayoutDataSetTableAdapters.TableAdapterManager()
        Me.SewingLearningCurveBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.SewingLearningCurveBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDaySerial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMinSMV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaxSMV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLC_Value = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SewingAllocateQuantityMasterDataSet = New KSoft_Apparel.SewingAllocateQuantityMasterDataSet()
        Me.SewingAllocateQuantityMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingAllocateQuantityMasterTableAdapter = New KSoft_Apparel.SewingAllocateQuantityMasterDataSetTableAdapters.SewingAllocateQuantityMasterTableAdapter()
        Me.TableAdapterManager1 = New KSoft_Apparel.SewingAllocateQuantityMasterDataSetTableAdapters.TableAdapterManager()
        Me.SewingAllocateQuantityMasterGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAllocateQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaxSMV1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMinSMV1 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.SewingLayoutDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingLearningCurveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingLearningCurveBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SewingLearningCurveBindingNavigator.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingAllocateQuantityMasterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingAllocateQuantityMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingAllocateQuantityMasterGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SewingLayoutDataSet
        '
        Me.SewingLayoutDataSet.DataSetName = "SewingLayoutDataSet"
        Me.SewingLayoutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SewingLearningCurveBindingSource
        '
        Me.SewingLearningCurveBindingSource.DataMember = "SewingLearningCurve"
        Me.SewingLearningCurveBindingSource.DataSource = Me.SewingLayoutDataSet
        '
        'SewingLearningCurveTableAdapter
        '
        Me.SewingLearningCurveTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SewingBreakDownCopyTableAdapter = Nothing
        Me.TableAdapterManager.SewingBreakDownTableAdapter = Nothing
        Me.TableAdapterManager.SewingCategoryTableAdapter = Nothing
        Me.TableAdapterManager.SewingLayoutDetailsTableAdapter = Nothing
        Me.TableAdapterManager.SewingLayoutTableAdapter = Nothing
        Me.TableAdapterManager.SewingLearningCurveTableAdapter = Me.SewingLearningCurveTableAdapter
        Me.TableAdapterManager.SewingMachineLayoutTableAdapter = Nothing
        Me.TableAdapterManager.SewingMachineTableAdapter = Nothing
        Me.TableAdapterManager.SewingProcessTableAdapter = Nothing
        Me.TableAdapterManager.SewingSMVCopyTableAdapter = Nothing
        Me.TableAdapterManager.SewingSMVTableAdapter = Nothing
        Me.TableAdapterManager.SewingTargetAllocationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SewingLayoutDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SewingLearningCurveBindingNavigator
        '
        Me.SewingLearningCurveBindingNavigator.AddNewItem = Nothing
        Me.SewingLearningCurveBindingNavigator.BindingSource = Me.SewingLearningCurveBindingSource
        Me.SewingLearningCurveBindingNavigator.CountItem = Nothing
        Me.SewingLearningCurveBindingNavigator.DeleteItem = Nothing
        Me.SewingLearningCurveBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SewingLearningCurveBindingNavigatorSaveItem})
        Me.SewingLearningCurveBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SewingLearningCurveBindingNavigator.MoveFirstItem = Nothing
        Me.SewingLearningCurveBindingNavigator.MoveLastItem = Nothing
        Me.SewingLearningCurveBindingNavigator.MoveNextItem = Nothing
        Me.SewingLearningCurveBindingNavigator.MovePreviousItem = Nothing
        Me.SewingLearningCurveBindingNavigator.Name = "SewingLearningCurveBindingNavigator"
        Me.SewingLearningCurveBindingNavigator.PositionItem = Nothing
        Me.SewingLearningCurveBindingNavigator.Size = New System.Drawing.Size(564, 25)
        Me.SewingLearningCurveBindingNavigator.TabIndex = 0
        Me.SewingLearningCurveBindingNavigator.Text = "BindingNavigator1"
        '
        'SewingLearningCurveBindingNavigatorSaveItem
        '
        Me.SewingLearningCurveBindingNavigatorSaveItem.Image = CType(resources.GetObject("SewingLearningCurveBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SewingLearningCurveBindingNavigatorSaveItem.Name = "SewingLearningCurveBindingNavigatorSaveItem"
        Me.SewingLearningCurveBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.SewingLearningCurveBindingNavigatorSaveItem.Text = "Save Data"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.SewingLearningCurveBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(0, 25)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(564, 376)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDaySerial, Me.colMinSMV, Me.colMaxSMV, Me.colLC_Value})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colDaySerial
        '
        Me.colDaySerial.FieldName = "DaySerial"
        Me.colDaySerial.Name = "colDaySerial"
        Me.colDaySerial.Visible = True
        Me.colDaySerial.VisibleIndex = 2
        '
        'colMinSMV
        '
        Me.colMinSMV.FieldName = "MinSMV"
        Me.colMinSMV.Name = "colMinSMV"
        Me.colMinSMV.Visible = True
        Me.colMinSMV.VisibleIndex = 0
        '
        'colMaxSMV
        '
        Me.colMaxSMV.FieldName = "MaxSMV"
        Me.colMaxSMV.Name = "colMaxSMV"
        Me.colMaxSMV.Visible = True
        Me.colMaxSMV.VisibleIndex = 1
        '
        'colLC_Value
        '
        Me.colLC_Value.FieldName = "LC_Value"
        Me.colLC_Value.Name = "colLC_Value"
        Me.colLC_Value.Visible = True
        Me.colLC_Value.VisibleIndex = 3
        '
        'SewingAllocateQuantityMasterDataSet
        '
        Me.SewingAllocateQuantityMasterDataSet.DataSetName = "SewingAllocateQuantityMasterDataSet"
        Me.SewingAllocateQuantityMasterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SewingAllocateQuantityMasterBindingSource
        '
        Me.SewingAllocateQuantityMasterBindingSource.DataMember = "SewingAllocateQuantityMaster"
        Me.SewingAllocateQuantityMasterBindingSource.DataSource = Me.SewingAllocateQuantityMasterDataSet
        '
        'SewingAllocateQuantityMasterTableAdapter
        '
        Me.SewingAllocateQuantityMasterTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.SewingAllocateQuantityMasterTableAdapter = Me.SewingAllocateQuantityMasterTableAdapter
        Me.TableAdapterManager1.UpdateOrder = KSoft_Apparel.SewingAllocateQuantityMasterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SewingAllocateQuantityMasterGridControl
        '
        Me.SewingAllocateQuantityMasterGridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SewingAllocateQuantityMasterGridControl.DataSource = Me.SewingAllocateQuantityMasterBindingSource
        Me.SewingAllocateQuantityMasterGridControl.Location = New System.Drawing.Point(0, 407)
        Me.SewingAllocateQuantityMasterGridControl.MainView = Me.GridView2
        Me.SewingAllocateQuantityMasterGridControl.Name = "SewingAllocateQuantityMasterGridControl"
        Me.SewingAllocateQuantityMasterGridControl.Size = New System.Drawing.Size(564, 182)
        Me.SewingAllocateQuantityMasterGridControl.TabIndex = 2
        Me.SewingAllocateQuantityMasterGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAllocateQuantity, Me.colMaxSMV1, Me.colMinSMV1})
        Me.GridView2.GridControl = Me.SewingAllocateQuantityMasterGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colAllocateQuantity
        '
        Me.colAllocateQuantity.FieldName = "AllocateQuantity"
        Me.colAllocateQuantity.Name = "colAllocateQuantity"
        Me.colAllocateQuantity.Visible = True
        Me.colAllocateQuantity.VisibleIndex = 2
        '
        'colMaxSMV1
        '
        Me.colMaxSMV1.FieldName = "MaxSMV"
        Me.colMaxSMV1.Name = "colMaxSMV1"
        Me.colMaxSMV1.Visible = True
        Me.colMaxSMV1.VisibleIndex = 0
        '
        'colMinSMV1
        '
        Me.colMinSMV1.FieldName = "MinSMV"
        Me.colMinSMV1.Name = "colMinSMV1"
        Me.colMinSMV1.Visible = True
        Me.colMinSMV1.VisibleIndex = 1
        '
        'frmLearningCurve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(564, 593)
        Me.Controls.Add(Me.SewingAllocateQuantityMasterGridControl)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.SewingLearningCurveBindingNavigator)
        Me.Name = "frmLearningCurve"
        Me.Text = "Learning Curve"
        CType(Me.SewingLayoutDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingLearningCurveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingLearningCurveBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SewingLearningCurveBindingNavigator.ResumeLayout(False)
        Me.SewingLearningCurveBindingNavigator.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingAllocateQuantityMasterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingAllocateQuantityMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingAllocateQuantityMasterGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SewingLayoutDataSet As KSoft_Apparel.SewingLayoutDataSet
    Friend WithEvents SewingLearningCurveBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SewingLearningCurveTableAdapter As KSoft_Apparel.SewingLayoutDataSetTableAdapters.SewingLearningCurveTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.SewingLayoutDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SewingLearningCurveBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents SewingLearningCurveBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDaySerial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMinSMV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaxSMV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLC_Value As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SewingAllocateQuantityMasterDataSet As SewingAllocateQuantityMasterDataSet
    Friend WithEvents SewingAllocateQuantityMasterBindingSource As BindingSource
    Friend WithEvents SewingAllocateQuantityMasterTableAdapter As SewingAllocateQuantityMasterDataSetTableAdapters.SewingAllocateQuantityMasterTableAdapter
    Friend WithEvents TableAdapterManager1 As SewingAllocateQuantityMasterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SewingAllocateQuantityMasterGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAllocateQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaxSMV1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMinSMV1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
