<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStyleType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStyleType))
        Me.StyleTypeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.StyleTypeMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleTypeDataSet = New KSoft_Apparel.StyleTypeDataSet()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SetColorToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.StyleTypeMstTableAdapter = New KSoft_Apparel.StyleTypeDataSetTableAdapters.StyleTypeMstTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.StyleTypeDataSetTableAdapters.TableAdapterManager()
        Me.StyleTypeMstGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStyleType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColorCode = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.StyleTypeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StyleTypeBindingNavigator.SuspendLayout()
        CType(Me.StyleTypeMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleTypeMstGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleTypeBindingNavigator
        '
        Me.StyleTypeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StyleTypeBindingNavigator.BindingSource = Me.StyleTypeMstBindingSource
        Me.StyleTypeBindingNavigator.CountItem = Nothing
        Me.StyleTypeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StyleTypeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSaveItem, Me.SetColorToolStripLabel})
        Me.StyleTypeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StyleTypeBindingNavigator.MoveFirstItem = Nothing
        Me.StyleTypeBindingNavigator.MoveLastItem = Nothing
        Me.StyleTypeBindingNavigator.MoveNextItem = Nothing
        Me.StyleTypeBindingNavigator.MovePreviousItem = Nothing
        Me.StyleTypeBindingNavigator.Name = "StyleTypeBindingNavigator"
        Me.StyleTypeBindingNavigator.PositionItem = Nothing
        Me.StyleTypeBindingNavigator.Size = New System.Drawing.Size(429, 25)
        Me.StyleTypeBindingNavigator.TabIndex = 1
        Me.StyleTypeBindingNavigator.Text = "BindingNavigator"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'StyleTypeMstBindingSource
        '
        Me.StyleTypeMstBindingSource.DataMember = "StyleTypeMst"
        Me.StyleTypeMstBindingSource.DataSource = Me.StyleTypeDataSet
        '
        'StyleTypeDataSet
        '
        Me.StyleTypeDataSet.DataSetName = "StyleTypeDataSet"
        Me.StyleTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorSaveItem
        '
        Me.BindingNavigatorSaveItem.Image = CType(resources.GetObject("BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem"
        Me.BindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.BindingNavigatorSaveItem.Text = "Save Data"
        '
        'SetColorToolStripLabel
        '
        Me.SetColorToolStripLabel.Image = Global.KSoft_Apparel.My.Resources.Resources.Wizard
        Me.SetColorToolStripLabel.Name = "SetColorToolStripLabel"
        Me.SetColorToolStripLabel.Size = New System.Drawing.Size(71, 22)
        Me.SetColorToolStripLabel.Text = "Set Color"
        '
        'StyleTypeMstTableAdapter
        '
        Me.StyleTypeMstTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StyleTypeMstTableAdapter = Me.StyleTypeMstTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.StyleTypeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StyleTypeMstGridControl
        '
        Me.StyleTypeMstGridControl.DataSource = Me.StyleTypeMstBindingSource
        Me.StyleTypeMstGridControl.Location = New System.Drawing.Point(0, 28)
        Me.StyleTypeMstGridControl.MainView = Me.GridView1
        Me.StyleTypeMstGridControl.Name = "StyleTypeMstGridControl"
        Me.StyleTypeMstGridControl.Size = New System.Drawing.Size(429, 307)
        Me.StyleTypeMstGridControl.TabIndex = 1
        Me.StyleTypeMstGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStyleType, Me.colColorCode})
        Me.GridView1.GridControl = Me.StyleTypeMstGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colStyleType
        '
        Me.colStyleType.FieldName = "StyleType"
        Me.colStyleType.Name = "colStyleType"
        Me.colStyleType.Visible = True
        Me.colStyleType.VisibleIndex = 0
        Me.colStyleType.Width = 297
        '
        'colColorCode
        '
        Me.colColorCode.Caption = "Color"
        Me.colColorCode.FieldName = "ColorCode"
        Me.colColorCode.Name = "colColorCode"
        Me.colColorCode.OptionsColumn.AllowEdit = False
        Me.colColorCode.OptionsColumn.ReadOnly = True
        Me.colColorCode.Visible = True
        Me.colColorCode.VisibleIndex = 1
        Me.colColorCode.Width = 114
        '
        'frmStyleType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 333)
        Me.Controls.Add(Me.StyleTypeMstGridControl)
        Me.Controls.Add(Me.StyleTypeBindingNavigator)
        Me.Name = "frmStyleType"
        Me.Text = "Style Type"
        CType(Me.StyleTypeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StyleTypeBindingNavigator.ResumeLayout(False)
        Me.StyleTypeBindingNavigator.PerformLayout()
        CType(Me.StyleTypeMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleTypeMstGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StyleTypeBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents StyleTypeDataSet As KSoft_Apparel.StyleTypeDataSet
    Friend WithEvents StyleTypeMstBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleTypeMstTableAdapter As KSoft_Apparel.StyleTypeDataSetTableAdapters.StyleTypeMstTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.StyleTypeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StyleTypeMstGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SetColorToolStripLabel As ToolStripLabel
    Friend WithEvents colStyleType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColorCode As DevExpress.XtraGrid.Columns.GridColumn
End Class
