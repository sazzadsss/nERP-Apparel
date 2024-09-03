<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomLearningCurve
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomLearningCurve))
        Me.SewingCustomLearningCurveDataSet = New KSoft_Apparel.SewingCustomLearningCurveDataSet()
        Me.SewingCustomLearningCurveBindingSource = New System.Windows.Forms.BindingSource()
        Me.SewingCustomLearningCurveTableAdapter = New KSoft_Apparel.SewingCustomLearningCurveDataSetTableAdapters.SewingCustomLearningCurveTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.SewingCustomLearningCurveDataSetTableAdapters.TableAdapterManager()
        Me.SewingCustomLearningCurveBindingNavigator = New System.Windows.Forms.BindingNavigator()
        Me.StyleTypeTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.SewingCustomLearningCurveBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SewingCustomLearningCurveGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDaySerial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMinSMV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaxSMV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLC_Value = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SCLGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SCLStyleTypeLookupBindingSource = New System.Windows.Forms.BindingSource()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SCLStyleTypeLookupTableAdapter = New KSoft_Apparel.SewingCustomLearningCurveDataSetTableAdapters.SCLStyleTypeLookupTableAdapter()
        CType(Me.SewingCustomLearningCurveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingCustomLearningCurveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingCustomLearningCurveBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SewingCustomLearningCurveBindingNavigator.SuspendLayout()
        CType(Me.SewingCustomLearningCurveGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCLGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCLStyleTypeLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SewingCustomLearningCurveDataSet
        '
        Me.SewingCustomLearningCurveDataSet.DataSetName = "SewingCustomLearningCurveDataSet"
        Me.SewingCustomLearningCurveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SewingCustomLearningCurveBindingSource
        '
        Me.SewingCustomLearningCurveBindingSource.DataMember = "SewingCustomLearningCurve"
        Me.SewingCustomLearningCurveBindingSource.DataSource = Me.SewingCustomLearningCurveDataSet
        '
        'SewingCustomLearningCurveTableAdapter
        '
        Me.SewingCustomLearningCurveTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SCLStyleTypeLookupTableAdapter = Nothing
        Me.TableAdapterManager.SewingCustomLearningCurveTableAdapter = Me.SewingCustomLearningCurveTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SewingCustomLearningCurveDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SewingCustomLearningCurveBindingNavigator
        '
        Me.SewingCustomLearningCurveBindingNavigator.AddNewItem = Nothing
        Me.SewingCustomLearningCurveBindingNavigator.CountItem = Nothing
        Me.SewingCustomLearningCurveBindingNavigator.DeleteItem = Nothing
        Me.SewingCustomLearningCurveBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StyleTypeTextBox, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SewingCustomLearningCurveBindingNavigatorSaveItem})
        Me.SewingCustomLearningCurveBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SewingCustomLearningCurveBindingNavigator.MoveFirstItem = Nothing
        Me.SewingCustomLearningCurveBindingNavigator.MoveLastItem = Nothing
        Me.SewingCustomLearningCurveBindingNavigator.MoveNextItem = Nothing
        Me.SewingCustomLearningCurveBindingNavigator.MovePreviousItem = Nothing
        Me.SewingCustomLearningCurveBindingNavigator.Name = "SewingCustomLearningCurveBindingNavigator"
        Me.SewingCustomLearningCurveBindingNavigator.PositionItem = Nothing
        Me.SewingCustomLearningCurveBindingNavigator.Size = New System.Drawing.Size(705, 25)
        Me.SewingCustomLearningCurveBindingNavigator.TabIndex = 0
        Me.SewingCustomLearningCurveBindingNavigator.Text = "BindingNavigator1"
        '
        'StyleTypeTextBox
        '
        Me.StyleTypeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.StyleTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StyleTypeTextBox.Name = "StyleTypeTextBox"
        Me.StyleTypeTextBox.Size = New System.Drawing.Size(150, 25)
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
        'SewingCustomLearningCurveBindingNavigatorSaveItem
        '
        Me.SewingCustomLearningCurveBindingNavigatorSaveItem.Image = CType(resources.GetObject("SewingCustomLearningCurveBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SewingCustomLearningCurveBindingNavigatorSaveItem.Name = "SewingCustomLearningCurveBindingNavigatorSaveItem"
        Me.SewingCustomLearningCurveBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.SewingCustomLearningCurveBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SewingCustomLearningCurveGridControl
        '
        Me.SewingCustomLearningCurveGridControl.DataSource = Me.SewingCustomLearningCurveBindingSource
        Me.SewingCustomLearningCurveGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SewingCustomLearningCurveGridControl.Location = New System.Drawing.Point(0, 25)
        Me.SewingCustomLearningCurveGridControl.MainView = Me.GridView1
        Me.SewingCustomLearningCurveGridControl.Name = "SewingCustomLearningCurveGridControl"
        Me.SewingCustomLearningCurveGridControl.Size = New System.Drawing.Size(705, 581)
        Me.SewingCustomLearningCurveGridControl.TabIndex = 2
        Me.SewingCustomLearningCurveGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDaySerial, Me.colMinSMV, Me.colMaxSMV, Me.colLC_Value, Me.colStyleType})
        Me.GridView1.GridControl = Me.SewingCustomLearningCurveGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colDaySerial
        '
        Me.colDaySerial.FieldName = "DaySerial"
        Me.colDaySerial.Name = "colDaySerial"
        Me.colDaySerial.OptionsColumn.AllowEdit = False
        Me.colDaySerial.OptionsColumn.ReadOnly = True
        Me.colDaySerial.Visible = True
        Me.colDaySerial.VisibleIndex = 1
        Me.colDaySerial.Width = 112
        '
        'colMinSMV
        '
        Me.colMinSMV.FieldName = "MinSMV"
        Me.colMinSMV.Name = "colMinSMV"
        Me.colMinSMV.Visible = True
        Me.colMinSMV.VisibleIndex = 2
        Me.colMinSMV.Width = 109
        '
        'colMaxSMV
        '
        Me.colMaxSMV.FieldName = "MaxSMV"
        Me.colMaxSMV.Name = "colMaxSMV"
        Me.colMaxSMV.Visible = True
        Me.colMaxSMV.VisibleIndex = 3
        Me.colMaxSMV.Width = 134
        '
        'colLC_Value
        '
        Me.colLC_Value.FieldName = "LC_Value"
        Me.colLC_Value.Name = "colLC_Value"
        Me.colLC_Value.Visible = True
        Me.colLC_Value.VisibleIndex = 4
        Me.colLC_Value.Width = 206
        '
        'colStyleType
        '
        Me.colStyleType.FieldName = "StyleType"
        Me.colStyleType.Name = "colStyleType"
        Me.colStyleType.OptionsColumn.AllowEdit = False
        Me.colStyleType.OptionsColumn.ReadOnly = True
        Me.colStyleType.Visible = True
        Me.colStyleType.VisibleIndex = 0
        Me.colStyleType.Width = 126
        '
        'SCLGridLookUpEdit
        '
        Me.SCLGridLookUpEdit.Location = New System.Drawing.Point(398, 2)
        Me.SCLGridLookUpEdit.Name = "SCLGridLookUpEdit"
        Me.SCLGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SCLGridLookUpEdit.Properties.DataSource = Me.SCLStyleTypeLookupBindingSource
        Me.SCLGridLookUpEdit.Properties.DisplayMember = "StyleType"
        Me.SCLGridLookUpEdit.Properties.NullText = "[Style Type]"
        Me.SCLGridLookUpEdit.Properties.ValueMember = "StyleType"
        Me.SCLGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.SCLGridLookUpEdit.Size = New System.Drawing.Size(184, 20)
        Me.SCLGridLookUpEdit.TabIndex = 3
        '
        'SCLStyleTypeLookupBindingSource
        '
        Me.SCLStyleTypeLookupBindingSource.DataMember = "SCLStyleTypeLookup"
        Me.SCLStyleTypeLookupBindingSource.DataSource = Me.SewingCustomLearningCurveDataSet
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'SCLStyleTypeLookupTableAdapter
        '
        Me.SCLStyleTypeLookupTableAdapter.ClearBeforeFill = True
        '
        'frmCustomLearningCurve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 606)
        Me.Controls.Add(Me.SCLGridLookUpEdit)
        Me.Controls.Add(Me.SewingCustomLearningCurveGridControl)
        Me.Controls.Add(Me.SewingCustomLearningCurveBindingNavigator)
        Me.Name = "frmCustomLearningCurve"
        Me.Text = "Custom Learning Curve"
        CType(Me.SewingCustomLearningCurveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingCustomLearningCurveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingCustomLearningCurveBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SewingCustomLearningCurveBindingNavigator.ResumeLayout(False)
        Me.SewingCustomLearningCurveBindingNavigator.PerformLayout()
        CType(Me.SewingCustomLearningCurveGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCLGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCLStyleTypeLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SewingCustomLearningCurveDataSet As SewingCustomLearningCurveDataSet
    Friend WithEvents SewingCustomLearningCurveBindingSource As BindingSource
    Friend WithEvents SewingCustomLearningCurveTableAdapter As SewingCustomLearningCurveDataSetTableAdapters.SewingCustomLearningCurveTableAdapter
    Friend WithEvents TableAdapterManager As SewingCustomLearningCurveDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SewingCustomLearningCurveBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents SewingCustomLearningCurveBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents StyleTypeTextBox As ToolStripTextBox
    Friend WithEvents SewingCustomLearningCurveGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SCLGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SCLStyleTypeLookupBindingSource As BindingSource
    Friend WithEvents SCLStyleTypeLookupTableAdapter As SewingCustomLearningCurveDataSetTableAdapters.SCLStyleTypeLookupTableAdapter
    Friend WithEvents colDaySerial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMinSMV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaxSMV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLC_Value As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleType As DevExpress.XtraGrid.Columns.GridColumn
End Class
