<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmswProcess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmswProcess))
        Me.SwProcessDataSet = New KSoft_Apparel.swProcessDataSet
        Me.SwProcessBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SwProcessTableAdapter = New KSoft_Apparel.swProcessDataSetTableAdapters.swProcessTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.swProcessDataSetTableAdapters.TableAdapterManager
        Me.SwProcessBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.SwProcessBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.SwProcessGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colswProcessId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProcessName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDistance = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTMU = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DistanceListComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        CType(Me.SwProcessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SwProcessBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SwProcessBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SwProcessBindingNavigator.SuspendLayout()
        CType(Me.SwProcessGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistanceListComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SwProcessDataSet
        '
        Me.SwProcessDataSet.DataSetName = "swProcessDataSet"
        Me.SwProcessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SwProcessBindingSource
        '
        Me.SwProcessBindingSource.DataMember = "swProcess"
        Me.SwProcessBindingSource.DataSource = Me.SwProcessDataSet
        '
        'SwProcessTableAdapter
        '
        Me.SwProcessTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.swProcessTableAdapter = Me.SwProcessTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.swProcessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SwProcessBindingNavigator
        '
        Me.SwProcessBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SwProcessBindingNavigator.BindingSource = Me.SwProcessBindingSource
        Me.SwProcessBindingNavigator.CountItem = Nothing
        Me.SwProcessBindingNavigator.DeleteItem = Nothing
        Me.SwProcessBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.SwProcessBindingNavigatorSaveItem})
        Me.SwProcessBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SwProcessBindingNavigator.MoveFirstItem = Nothing
        Me.SwProcessBindingNavigator.MoveLastItem = Nothing
        Me.SwProcessBindingNavigator.MoveNextItem = Nothing
        Me.SwProcessBindingNavigator.MovePreviousItem = Nothing
        Me.SwProcessBindingNavigator.Name = "SwProcessBindingNavigator"
        Me.SwProcessBindingNavigator.PositionItem = Nothing
        Me.SwProcessBindingNavigator.Size = New System.Drawing.Size(642, 25)
        Me.SwProcessBindingNavigator.TabIndex = 0
        Me.SwProcessBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'SwProcessBindingNavigatorSaveItem
        '
        Me.SwProcessBindingNavigatorSaveItem.Image = CType(resources.GetObject("SwProcessBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SwProcessBindingNavigatorSaveItem.Name = "SwProcessBindingNavigatorSaveItem"
        Me.SwProcessBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.SwProcessBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SwProcessGridControl
        '
        Me.SwProcessGridControl.DataSource = Me.SwProcessBindingSource
        Me.SwProcessGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SwProcessGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.SwProcessGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.SwProcessGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.SwProcessGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.SwProcessGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.SwProcessGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.SwProcessGridControl.Location = New System.Drawing.Point(0, 25)
        Me.SwProcessGridControl.MainView = Me.GridView1
        Me.SwProcessGridControl.Name = "SwProcessGridControl"
        Me.SwProcessGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.DistanceListComboBox})
        Me.SwProcessGridControl.Size = New System.Drawing.Size(642, 386)
        Me.SwProcessGridControl.TabIndex = 1
        Me.SwProcessGridControl.UseEmbeddedNavigator = True
        Me.SwProcessGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colswProcessId, Me.colProcessName, Me.colCode, Me.colDistance, Me.colTMU})
        Me.GridView1.GridControl = Me.SwProcessGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colswProcessId
        '
        Me.colswProcessId.FieldName = "swProcessId"
        Me.colswProcessId.Name = "colswProcessId"
        Me.colswProcessId.OptionsColumn.ReadOnly = True
        '
        'colProcessName
        '
        Me.colProcessName.FieldName = "ProcessName"
        Me.colProcessName.Name = "colProcessName"
        Me.colProcessName.Visible = True
        Me.colProcessName.VisibleIndex = 0
        Me.colProcessName.Width = 294
        '
        'colCode
        '
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 1
        Me.colCode.Width = 86
        '
        'colDistance
        '
        Me.colDistance.ColumnEdit = Me.DistanceListComboBox
        Me.colDistance.FieldName = "Distance"
        Me.colDistance.Name = "colDistance"
        Me.colDistance.Visible = True
        Me.colDistance.VisibleIndex = 2
        Me.colDistance.Width = 80
        '
        'colTMU
        '
        Me.colTMU.FieldName = "TMU"
        Me.colTMU.Name = "colTMU"
        Me.colTMU.Visible = True
        Me.colTMU.VisibleIndex = 3
        Me.colTMU.Width = 93
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.SwProcessGridControl
        Me.GridView2.Name = "GridView2"
        '
        'DistanceListComboBox
        '
        Me.DistanceListComboBox.AutoHeight = False
        Me.DistanceListComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DistanceListComboBox.Items.AddRange(New Object() {"6", "12", "18", "24"})
        Me.DistanceListComboBox.Name = "DistanceListComboBox"
        '
        'frmswProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 411)
        Me.Controls.Add(Me.SwProcessGridControl)
        Me.Controls.Add(Me.SwProcessBindingNavigator)
        Me.Name = "frmswProcess"
        Me.Text = "Process"
        CType(Me.SwProcessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SwProcessBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SwProcessBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SwProcessBindingNavigator.ResumeLayout(False)
        Me.SwProcessBindingNavigator.PerformLayout()
        CType(Me.SwProcessGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistanceListComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SwProcessDataSet As KSoft_Apparel.swProcessDataSet
    Friend WithEvents SwProcessBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SwProcessTableAdapter As KSoft_Apparel.swProcessDataSetTableAdapters.swProcessTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.swProcessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SwProcessBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SwProcessBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SwProcessGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colswProcessId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProcessName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDistance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTMU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DistanceListComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
End Class
