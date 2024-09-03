<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGMTBrand
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGMTBrand))
        Me.GarmentsBrandBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.GMTBrandDataSet = New KSoft_Apparel.GMTBrandDataSet
        Me.GMTBrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GMTBrandTableAdapter = New KSoft_Apparel.GMTBrandDataSetTableAdapters.GMTBrandTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.GMTBrandDataSetTableAdapters.TableAdapterManager
        Me.GMTBrandGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colGMTBrandName = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.GarmentsBrandBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GarmentsBrandBindingNavigator.SuspendLayout()
        CType(Me.GMTBrandDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GarmentsBrandBindingNavigator
        '
        Me.GarmentsBrandBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GarmentsBrandBindingNavigator.BindingSource = Me.GMTBrandBindingSource
        Me.GarmentsBrandBindingNavigator.CountItem = Nothing
        Me.GarmentsBrandBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GarmentsBrandBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSaveItem})
        Me.GarmentsBrandBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GarmentsBrandBindingNavigator.MoveFirstItem = Nothing
        Me.GarmentsBrandBindingNavigator.MoveLastItem = Nothing
        Me.GarmentsBrandBindingNavigator.MoveNextItem = Nothing
        Me.GarmentsBrandBindingNavigator.MovePreviousItem = Nothing
        Me.GarmentsBrandBindingNavigator.Name = "GarmentsBrandBindingNavigator"
        Me.GarmentsBrandBindingNavigator.PositionItem = Nothing
        Me.GarmentsBrandBindingNavigator.Size = New System.Drawing.Size(367, 25)
        Me.GarmentsBrandBindingNavigator.TabIndex = 2
        Me.GarmentsBrandBindingNavigator.Text = "BindingNavigator"
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
        'BindingNavigatorSaveItem
        '
        Me.BindingNavigatorSaveItem.Image = CType(resources.GetObject("BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem"
        Me.BindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.BindingNavigatorSaveItem.Text = "Save Data"
        '
        'GMTBrandDataSet
        '
        Me.GMTBrandDataSet.DataSetName = "GMTBrandDataSet"
        Me.GMTBrandDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GMTBrandBindingSource
        '
        Me.GMTBrandBindingSource.DataMember = "GMTBrand"
        Me.GMTBrandBindingSource.DataSource = Me.GMTBrandDataSet
        '
        'GMTBrandTableAdapter
        '
        Me.GMTBrandTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GMTBrandTableAdapter = Me.GMTBrandTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.GMTBrandDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GMTBrandGridControl
        '
        Me.GMTBrandGridControl.DataSource = Me.GMTBrandBindingSource
        Me.GMTBrandGridControl.Location = New System.Drawing.Point(0, 28)
        Me.GMTBrandGridControl.MainView = Me.GridView1
        Me.GMTBrandGridControl.Name = "GMTBrandGridControl"
        Me.GMTBrandGridControl.Size = New System.Drawing.Size(367, 272)
        Me.GMTBrandGridControl.TabIndex = 2
        Me.GMTBrandGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGMTBrandName})
        Me.GridView1.GridControl = Me.GMTBrandGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colGMTBrandName
        '
        Me.colGMTBrandName.FieldName = "GMTBrandName"
        Me.colGMTBrandName.Name = "colGMTBrandName"
        Me.colGMTBrandName.Visible = True
        Me.colGMTBrandName.VisibleIndex = 0
        '
        'frmGMTBrand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 299)
        Me.Controls.Add(Me.GMTBrandGridControl)
        Me.Controls.Add(Me.GarmentsBrandBindingNavigator)
        Me.Name = "frmGMTBrand"
        Me.Text = "Garments Brand"
        CType(Me.GarmentsBrandBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GarmentsBrandBindingNavigator.ResumeLayout(False)
        Me.GarmentsBrandBindingNavigator.PerformLayout()
        CType(Me.GMTBrandDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GarmentsBrandBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GMTBrandDataSet As KSoft_Apparel.GMTBrandDataSet
    Friend WithEvents GMTBrandBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GMTBrandTableAdapter As KSoft_Apparel.GMTBrandDataSetTableAdapters.GMTBrandTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.GMTBrandDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GMTBrandGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colGMTBrandName As DevExpress.XtraGrid.Columns.GridColumn
End Class
