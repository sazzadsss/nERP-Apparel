<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSewingCapacity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSewingCapacity))
        Me.SewingCapacityDataSet = New KSoft_Apparel.SewingCapacityDataSet()
        Me.SewingCapacityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingCapacityTableAdapter = New KSoft_Apparel.SewingCapacityDataSetTableAdapters.SewingCapacityTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.SewingCapacityDataSetTableAdapters.TableAdapterManager()
        Me.SewingCapacityBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.SewingCapacityBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SewingCapacityGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSewingCapacityId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonth = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAWHPerDay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRunningLine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvarageMachine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkingDay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.SewingCapacityDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingCapacityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingCapacityBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SewingCapacityBindingNavigator.SuspendLayout()
        CType(Me.SewingCapacityGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SewingCapacityDataSet
        '
        Me.SewingCapacityDataSet.DataSetName = "SewingCapacityDataSet"
        Me.SewingCapacityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SewingCapacityBindingSource
        '
        Me.SewingCapacityBindingSource.DataMember = "SewingCapacity"
        Me.SewingCapacityBindingSource.DataSource = Me.SewingCapacityDataSet
        '
        'SewingCapacityTableAdapter
        '
        Me.SewingCapacityTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SewingCapacityTableAdapter = Me.SewingCapacityTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SewingCapacityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SewingCapacityBindingNavigator
        '
        Me.SewingCapacityBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SewingCapacityBindingNavigator.BindingSource = Me.SewingCapacityBindingSource
        Me.SewingCapacityBindingNavigator.CountItem = Nothing
        Me.SewingCapacityBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SewingCapacityBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SewingCapacityBindingNavigatorSaveItem})
        Me.SewingCapacityBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SewingCapacityBindingNavigator.MoveFirstItem = Nothing
        Me.SewingCapacityBindingNavigator.MoveLastItem = Nothing
        Me.SewingCapacityBindingNavigator.MoveNextItem = Nothing
        Me.SewingCapacityBindingNavigator.MovePreviousItem = Nothing
        Me.SewingCapacityBindingNavigator.Name = "SewingCapacityBindingNavigator"
        Me.SewingCapacityBindingNavigator.PositionItem = Nothing
        Me.SewingCapacityBindingNavigator.Size = New System.Drawing.Size(707, 25)
        Me.SewingCapacityBindingNavigator.TabIndex = 0
        Me.SewingCapacityBindingNavigator.Text = "BindingNavigator1"
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
        'SewingCapacityBindingNavigatorSaveItem
        '
        Me.SewingCapacityBindingNavigatorSaveItem.Image = CType(resources.GetObject("SewingCapacityBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SewingCapacityBindingNavigatorSaveItem.Name = "SewingCapacityBindingNavigatorSaveItem"
        Me.SewingCapacityBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.SewingCapacityBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SewingCapacityGridControl
        '
        Me.SewingCapacityGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SewingCapacityGridControl.DataSource = Me.SewingCapacityBindingSource
        Me.SewingCapacityGridControl.Location = New System.Drawing.Point(0, 28)
        Me.SewingCapacityGridControl.MainView = Me.GridView1
        Me.SewingCapacityGridControl.Name = "SewingCapacityGridControl"
        Me.SewingCapacityGridControl.Size = New System.Drawing.Size(707, 368)
        Me.SewingCapacityGridControl.TabIndex = 1
        Me.SewingCapacityGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSewingCapacityId, Me.colYear, Me.colMonth, Me.colAWHPerDay, Me.colRunningLine, Me.colAvarageMachine, Me.colWorkingDay})
        Me.GridView1.GridControl = Me.SewingCapacityGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colSewingCapacityId
        '
        Me.colSewingCapacityId.FieldName = "SewingCapacityId"
        Me.colSewingCapacityId.Name = "colSewingCapacityId"
        Me.colSewingCapacityId.OptionsColumn.ReadOnly = True
        '
        'colYear
        '
        Me.colYear.FieldName = "Year"
        Me.colYear.Name = "colYear"
        Me.colYear.Visible = True
        Me.colYear.VisibleIndex = 0
        Me.colYear.Width = 84
        '
        'colMonth
        '
        Me.colMonth.FieldName = "Month"
        Me.colMonth.Name = "colMonth"
        Me.colMonth.Visible = True
        Me.colMonth.VisibleIndex = 1
        Me.colMonth.Width = 84
        '
        'colAWHPerDay
        '
        Me.colAWHPerDay.FieldName = "AWHPerDay"
        Me.colAWHPerDay.Name = "colAWHPerDay"
        Me.colAWHPerDay.Visible = True
        Me.colAWHPerDay.VisibleIndex = 3
        Me.colAWHPerDay.Width = 66
        '
        'colRunningLine
        '
        Me.colRunningLine.FieldName = "RunningLine"
        Me.colRunningLine.Name = "colRunningLine"
        Me.colRunningLine.Visible = True
        Me.colRunningLine.VisibleIndex = 4
        Me.colRunningLine.Width = 71
        '
        'colAvarageMachine
        '
        Me.colAvarageMachine.Caption = "Average Machine Per Line"
        Me.colAvarageMachine.FieldName = "AvarageMachine"
        Me.colAvarageMachine.Name = "colAvarageMachine"
        Me.colAvarageMachine.Visible = True
        Me.colAvarageMachine.VisibleIndex = 5
        Me.colAvarageMachine.Width = 99
        '
        'colWorkingDay
        '
        Me.colWorkingDay.FieldName = "WorkingDay"
        Me.colWorkingDay.Name = "colWorkingDay"
        Me.colWorkingDay.Visible = True
        Me.colWorkingDay.VisibleIndex = 2
        Me.colWorkingDay.Width = 112
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.SewingCapacityGridControl
        Me.GridView2.Name = "GridView2"
        '
        'frmSewingCapacity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 396)
        Me.Controls.Add(Me.SewingCapacityGridControl)
        Me.Controls.Add(Me.SewingCapacityBindingNavigator)
        Me.Name = "frmSewingCapacity"
        Me.Text = "Sewing Capacity"
        CType(Me.SewingCapacityDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingCapacityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingCapacityBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SewingCapacityBindingNavigator.ResumeLayout(False)
        Me.SewingCapacityBindingNavigator.PerformLayout()
        CType(Me.SewingCapacityGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SewingCapacityDataSet As KSoft_Apparel.SewingCapacityDataSet
    Friend WithEvents SewingCapacityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SewingCapacityTableAdapter As KSoft_Apparel.SewingCapacityDataSetTableAdapters.SewingCapacityTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.SewingCapacityDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SewingCapacityBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SewingCapacityBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SewingCapacityGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSewingCapacityId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonth As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAWHPerDay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRunningLine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvarageMachine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colWorkingDay As DevExpress.XtraGrid.Columns.GridColumn
End Class
