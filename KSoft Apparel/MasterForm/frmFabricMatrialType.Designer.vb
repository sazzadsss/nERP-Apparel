<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFabricMatrialType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFabricMatrialType))
        Me.FabricMaterialTypeDataSet = New KSoft_Apparel.FabricMaterialTypeDataSet()
        Me.FabricMaterialTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricMaterialTypeTableAdapter = New KSoft_Apparel.FabricMaterialTypeDataSetTableAdapters.FabricMaterialTypeTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.FabricMaterialTypeDataSetTableAdapters.TableAdapterManager()
        Me.FabricMaterialTypeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.FabricMaterialTypeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FabricMaterialTypeGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.FabricMaterialTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricMaterialTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricMaterialTypeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FabricMaterialTypeBindingNavigator.SuspendLayout()
        CType(Me.FabricMaterialTypeGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FabricMaterialTypeDataSet
        '
        Me.FabricMaterialTypeDataSet.DataSetName = "FabricMaterialTypeDataSet"
        Me.FabricMaterialTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FabricMaterialTypeBindingSource
        '
        Me.FabricMaterialTypeBindingSource.DataMember = "FabricMaterialType"
        Me.FabricMaterialTypeBindingSource.DataSource = Me.FabricMaterialTypeDataSet
        '
        'FabricMaterialTypeTableAdapter
        '
        Me.FabricMaterialTypeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FabricMaterialTypeTableAdapter = Me.FabricMaterialTypeTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.FabricMaterialTypeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FabricMaterialTypeBindingNavigator
        '
        Me.FabricMaterialTypeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FabricMaterialTypeBindingNavigator.BindingSource = Me.FabricMaterialTypeBindingSource
        Me.FabricMaterialTypeBindingNavigator.CountItem = Nothing
        Me.FabricMaterialTypeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FabricMaterialTypeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FabricMaterialTypeBindingNavigatorSaveItem})
        Me.FabricMaterialTypeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FabricMaterialTypeBindingNavigator.MoveFirstItem = Nothing
        Me.FabricMaterialTypeBindingNavigator.MoveLastItem = Nothing
        Me.FabricMaterialTypeBindingNavigator.MoveNextItem = Nothing
        Me.FabricMaterialTypeBindingNavigator.MovePreviousItem = Nothing
        Me.FabricMaterialTypeBindingNavigator.Name = "FabricMaterialTypeBindingNavigator"
        Me.FabricMaterialTypeBindingNavigator.PositionItem = Nothing
        Me.FabricMaterialTypeBindingNavigator.Size = New System.Drawing.Size(369, 25)
        Me.FabricMaterialTypeBindingNavigator.TabIndex = 0
        Me.FabricMaterialTypeBindingNavigator.Text = "BindingNavigator1"
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
        'FabricMaterialTypeBindingNavigatorSaveItem
        '
        Me.FabricMaterialTypeBindingNavigatorSaveItem.Image = CType(resources.GetObject("FabricMaterialTypeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FabricMaterialTypeBindingNavigatorSaveItem.Name = "FabricMaterialTypeBindingNavigatorSaveItem"
        Me.FabricMaterialTypeBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.FabricMaterialTypeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FabricMaterialTypeGridControl
        '
        Me.FabricMaterialTypeGridControl.DataSource = Me.FabricMaterialTypeBindingSource
        Me.FabricMaterialTypeGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FabricMaterialTypeGridControl.Location = New System.Drawing.Point(0, 25)
        Me.FabricMaterialTypeGridControl.MainView = Me.GridView1
        Me.FabricMaterialTypeGridControl.Name = "FabricMaterialTypeGridControl"
        Me.FabricMaterialTypeGridControl.Size = New System.Drawing.Size(369, 315)
        Me.FabricMaterialTypeGridControl.TabIndex = 1
        Me.FabricMaterialTypeGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.FabricMaterialTypeGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'frmFabricMatrialType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 340)
        Me.Controls.Add(Me.FabricMaterialTypeGridControl)
        Me.Controls.Add(Me.FabricMaterialTypeBindingNavigator)
        Me.Name = "frmFabricMatrialType"
        Me.Text = "Fabric Matrial Type"
        CType(Me.FabricMaterialTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricMaterialTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricMaterialTypeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FabricMaterialTypeBindingNavigator.ResumeLayout(False)
        Me.FabricMaterialTypeBindingNavigator.PerformLayout()
        CType(Me.FabricMaterialTypeGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FabricMaterialTypeDataSet As FabricMaterialTypeDataSet
    Friend WithEvents FabricMaterialTypeBindingSource As BindingSource
    Friend WithEvents FabricMaterialTypeTableAdapter As FabricMaterialTypeDataSetTableAdapters.FabricMaterialTypeTableAdapter
    Friend WithEvents TableAdapterManager As FabricMaterialTypeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FabricMaterialTypeBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents FabricMaterialTypeBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FabricMaterialTypeGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
