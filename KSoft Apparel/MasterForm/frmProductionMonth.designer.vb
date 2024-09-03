<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionMonth
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductionMonth))
        Me.ProductionMonthDataSet = New KSoft_Apparel.ProductionMonthDataSet()
        Me.ProductionMonthBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionMonthTableAdapter = New KSoft_Apparel.ProductionMonthDataSetTableAdapters.ProductionMonthTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.ProductionMonthDataSetTableAdapters.TableAdapterManager()
        Me.ProductionMonthBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductionMonthBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductionMonthGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProductionMonth = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductionYear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductionMonthName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.ProductionMonthDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionMonthBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionMonthBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductionMonthBindingNavigator.SuspendLayout()
        CType(Me.ProductionMonthGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductionMonthDataSet
        '
        Me.ProductionMonthDataSet.DataSetName = "ProductionMonthDataSet"
        Me.ProductionMonthDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductionMonthBindingSource
        '
        Me.ProductionMonthBindingSource.AllowNew = True
        Me.ProductionMonthBindingSource.DataMember = "ProductionMonth"
        Me.ProductionMonthBindingSource.DataSource = Me.ProductionMonthDataSet
        '
        'ProductionMonthTableAdapter
        '
        Me.ProductionMonthTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProductionMonthTableAdapter = Me.ProductionMonthTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.ProductionMonthDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductionMonthBindingNavigator
        '
        Me.ProductionMonthBindingNavigator.AddNewItem = Nothing
        Me.ProductionMonthBindingNavigator.BindingSource = Me.ProductionMonthBindingSource
        Me.ProductionMonthBindingNavigator.CountItem = Nothing
        Me.ProductionMonthBindingNavigator.DeleteItem = Nothing
        Me.ProductionMonthBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.ProductionMonthBindingNavigatorSaveItem})
        Me.ProductionMonthBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductionMonthBindingNavigator.MoveFirstItem = Nothing
        Me.ProductionMonthBindingNavigator.MoveLastItem = Nothing
        Me.ProductionMonthBindingNavigator.MoveNextItem = Nothing
        Me.ProductionMonthBindingNavigator.MovePreviousItem = Nothing
        Me.ProductionMonthBindingNavigator.Name = "ProductionMonthBindingNavigator"
        Me.ProductionMonthBindingNavigator.PositionItem = Nothing
        Me.ProductionMonthBindingNavigator.Size = New System.Drawing.Size(553, 25)
        Me.ProductionMonthBindingNavigator.TabIndex = 0
        Me.ProductionMonthBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add Year"
        '
        'ProductionMonthBindingNavigatorSaveItem
        '
        Me.ProductionMonthBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductionMonthBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductionMonthBindingNavigatorSaveItem.Name = "ProductionMonthBindingNavigatorSaveItem"
        Me.ProductionMonthBindingNavigatorSaveItem.Size = New System.Drawing.Size(51, 22)
        Me.ProductionMonthBindingNavigatorSaveItem.Text = "Save"
        '
        'ProductionMonthGridControl
        '
        Me.ProductionMonthGridControl.DataSource = Me.ProductionMonthBindingSource
        Me.ProductionMonthGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductionMonthGridControl.Location = New System.Drawing.Point(0, 25)
        Me.ProductionMonthGridControl.MainView = Me.GridView1
        Me.ProductionMonthGridControl.Name = "ProductionMonthGridControl"
        Me.ProductionMonthGridControl.Size = New System.Drawing.Size(553, 482)
        Me.ProductionMonthGridControl.TabIndex = 1
        Me.ProductionMonthGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductionMonth, Me.colProductionYear, Me.colProductionMonthName, Me.colRemarks})
        Me.GridView1.GridControl = Me.ProductionMonthGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colProductionMonth
        '
        Me.colProductionMonth.FieldName = "ProductionMonth"
        Me.colProductionMonth.Name = "colProductionMonth"
        Me.colProductionMonth.OptionsColumn.AllowEdit = False
        Me.colProductionMonth.OptionsColumn.ReadOnly = True
        Me.colProductionMonth.Visible = True
        Me.colProductionMonth.VisibleIndex = 0
        Me.colProductionMonth.Width = 87
        '
        'colProductionYear
        '
        Me.colProductionYear.FieldName = "ProductionYear"
        Me.colProductionYear.Name = "colProductionYear"
        Me.colProductionYear.OptionsColumn.AllowEdit = False
        Me.colProductionYear.OptionsColumn.ReadOnly = True
        Me.colProductionYear.Visible = True
        Me.colProductionYear.VisibleIndex = 1
        Me.colProductionYear.Width = 82
        '
        'colProductionMonthName
        '
        Me.colProductionMonthName.FieldName = "ProductionMonthName"
        Me.colProductionMonthName.Name = "colProductionMonthName"
        Me.colProductionMonthName.OptionsColumn.AllowEdit = False
        Me.colProductionMonthName.OptionsColumn.ReadOnly = True
        Me.colProductionMonthName.Visible = True
        Me.colProductionMonthName.VisibleIndex = 2
        Me.colProductionMonthName.Width = 111
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 3
        Me.colRemarks.Width = 130
        '
        'frmProductionMonth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 507)
        Me.Controls.Add(Me.ProductionMonthGridControl)
        Me.Controls.Add(Me.ProductionMonthBindingNavigator)
        Me.Name = "frmProductionMonth"
        Me.Text = "Production Month"
        CType(Me.ProductionMonthDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionMonthBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionMonthBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductionMonthBindingNavigator.ResumeLayout(False)
        Me.ProductionMonthBindingNavigator.PerformLayout()
        CType(Me.ProductionMonthGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductionMonthDataSet As ProductionMonthDataSet
    Friend WithEvents ProductionMonthBindingSource As BindingSource
    Friend WithEvents ProductionMonthTableAdapter As ProductionMonthDataSetTableAdapters.ProductionMonthTableAdapter
    Friend WithEvents TableAdapterManager As ProductionMonthDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductionMonthBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents ProductionMonthBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProductionMonthGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProductionMonth As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionYear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionMonthName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
End Class
