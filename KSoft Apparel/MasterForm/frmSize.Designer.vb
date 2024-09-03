<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSize
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSize))
        Me.SizeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.SizeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.SizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizeDataSet = New KSoft_Apparel.SizeDataSet
        Me.SizeTableAdapter = New KSoft_Apparel.SizeDataSetTableAdapters.SizeTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.SizeDataSetTableAdapters.TableAdapterManager
        Me.SizeGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSizeCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSlNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGroupNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEU_Size = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.SizeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SizeBindingNavigator.SuspendLayout()
        CType(Me.SizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SizeBindingNavigator
        '
        Me.SizeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SizeBindingNavigator.BindingSource = Me.SizeBindingSource
        Me.SizeBindingNavigator.CountItem = Nothing
        Me.SizeBindingNavigator.DeleteItem = Nothing
        Me.SizeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.SizeBindingNavigatorSaveItem})
        Me.SizeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SizeBindingNavigator.MoveFirstItem = Nothing
        Me.SizeBindingNavigator.MoveLastItem = Nothing
        Me.SizeBindingNavigator.MoveNextItem = Nothing
        Me.SizeBindingNavigator.MovePreviousItem = Nothing
        Me.SizeBindingNavigator.Name = "SizeBindingNavigator"
        Me.SizeBindingNavigator.PositionItem = Nothing
        Me.SizeBindingNavigator.Size = New System.Drawing.Size(584, 25)
        Me.SizeBindingNavigator.TabIndex = 0
        Me.SizeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'SizeBindingNavigatorSaveItem
        '
        Me.SizeBindingNavigatorSaveItem.Image = CType(resources.GetObject("SizeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SizeBindingNavigatorSaveItem.Name = "SizeBindingNavigatorSaveItem"
        Me.SizeBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.SizeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SizeBindingSource
        '
        Me.SizeBindingSource.DataMember = "Size"
        Me.SizeBindingSource.DataSource = Me.SizeDataSet
        '
        'SizeDataSet
        '
        Me.SizeDataSet.DataSetName = "SizeDataSet"
        Me.SizeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SizeTableAdapter
        '
        Me.SizeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SizeTableAdapter = Me.SizeTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SizeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SizeGridControl
        '
        Me.SizeGridControl.DataSource = Me.SizeBindingSource
        Me.SizeGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SizeGridControl.Location = New System.Drawing.Point(0, 25)
        Me.SizeGridControl.MainView = Me.GridView1
        Me.SizeGridControl.Name = "SizeGridControl"
        Me.SizeGridControl.Size = New System.Drawing.Size(584, 333)
        Me.SizeGridControl.TabIndex = 1
        Me.SizeGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSizeCode, Me.colSlNo, Me.colGroupNo, Me.colEU_Size})
        Me.GridView1.GridControl = Me.SizeGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colGroupNo, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSlNo, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.SizeGridControl
        Me.GridView2.Name = "GridView2"
        '
        'colSizeCode
        '
        Me.colSizeCode.FieldName = "SizeCode"
        Me.colSizeCode.Name = "colSizeCode"
        Me.colSizeCode.Visible = True
        Me.colSizeCode.VisibleIndex = 0
        '
        'colSlNo
        '
        Me.colSlNo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colSlNo.AppearanceCell.Options.UseBackColor = True
        Me.colSlNo.FieldName = "SlNo"
        Me.colSlNo.Name = "colSlNo"
        Me.colSlNo.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.colSlNo.Visible = True
        Me.colSlNo.VisibleIndex = 3
        '
        'colGroupNo
        '
        Me.colGroupNo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colGroupNo.AppearanceCell.Options.UseBackColor = True
        Me.colGroupNo.FieldName = "GroupNo"
        Me.colGroupNo.Name = "colGroupNo"
        Me.colGroupNo.Visible = True
        Me.colGroupNo.VisibleIndex = 2
        '
        'colEU_Size
        '
        Me.colEU_Size.FieldName = "EU_Size"
        Me.colEU_Size.Name = "colEU_Size"
        Me.colEU_Size.Visible = True
        Me.colEU_Size.VisibleIndex = 1
        '
        'frmSize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 358)
        Me.Controls.Add(Me.SizeGridControl)
        Me.Controls.Add(Me.SizeBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSize"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Size"
        CType(Me.SizeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SizeBindingNavigator.ResumeLayout(False)
        Me.SizeBindingNavigator.PerformLayout()
        CType(Me.SizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SizeDataSet As KSoft_Apparel.SizeDataSet
    Friend WithEvents SizeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SizeTableAdapter As KSoft_Apparel.SizeDataSetTableAdapters.SizeTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.SizeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SizeBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SizeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SizeGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSizeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSlNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGroupNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEU_Size As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
