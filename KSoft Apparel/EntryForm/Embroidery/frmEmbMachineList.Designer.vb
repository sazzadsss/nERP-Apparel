<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmbMachineList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmbMachineList))
        Me.EmbMachineDataSet = New KSoft_Apparel.EmbMachineDataSet
        Me.EmbMachineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmbMachineTableAdapter = New KSoft_Apparel.EmbMachineDataSetTableAdapters.EmbMachineTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.EmbMachineDataSetTableAdapters.TableAdapterManager
        Me.EmbMachineBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.EmbMachineBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.EmbMachineGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colMachineName = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.EmbMachineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbMachineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbMachineBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmbMachineBindingNavigator.SuspendLayout()
        CType(Me.EmbMachineGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmbMachineDataSet
        '
        Me.EmbMachineDataSet.DataSetName = "EmbMachineDataSet"
        Me.EmbMachineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmbMachineBindingSource
        '
        Me.EmbMachineBindingSource.DataMember = "EmbMachine"
        Me.EmbMachineBindingSource.DataSource = Me.EmbMachineDataSet
        '
        'EmbMachineTableAdapter
        '
        Me.EmbMachineTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmbMachineTableAdapter = Me.EmbMachineTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.EmbMachineDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmbMachineBindingNavigator
        '
        Me.EmbMachineBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmbMachineBindingNavigator.BindingSource = Me.EmbMachineBindingSource
        Me.EmbMachineBindingNavigator.CountItem = Nothing
        Me.EmbMachineBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmbMachineBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmbMachineBindingNavigatorSaveItem})
        Me.EmbMachineBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmbMachineBindingNavigator.MoveFirstItem = Nothing
        Me.EmbMachineBindingNavigator.MoveLastItem = Nothing
        Me.EmbMachineBindingNavigator.MoveNextItem = Nothing
        Me.EmbMachineBindingNavigator.MovePreviousItem = Nothing
        Me.EmbMachineBindingNavigator.Name = "EmbMachineBindingNavigator"
        Me.EmbMachineBindingNavigator.PositionItem = Nothing
        Me.EmbMachineBindingNavigator.Size = New System.Drawing.Size(393, 25)
        Me.EmbMachineBindingNavigator.TabIndex = 0
        Me.EmbMachineBindingNavigator.Text = "BindingNavigator1"
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
        'EmbMachineBindingNavigatorSaveItem
        '
        Me.EmbMachineBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmbMachineBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmbMachineBindingNavigatorSaveItem.Name = "EmbMachineBindingNavigatorSaveItem"
        Me.EmbMachineBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.EmbMachineBindingNavigatorSaveItem.Text = "Save Data"
        '
        'EmbMachineGridControl
        '
        Me.EmbMachineGridControl.DataSource = Me.EmbMachineBindingSource
        Me.EmbMachineGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmbMachineGridControl.Location = New System.Drawing.Point(0, 25)
        Me.EmbMachineGridControl.MainView = Me.GridView1
        Me.EmbMachineGridControl.Name = "EmbMachineGridControl"
        Me.EmbMachineGridControl.Size = New System.Drawing.Size(393, 320)
        Me.EmbMachineGridControl.TabIndex = 1
        Me.EmbMachineGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMachineName})
        Me.GridView1.GridControl = Me.EmbMachineGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.EmbMachineGridControl
        Me.GridView2.Name = "GridView2"
        '
        'colMachineName
        '
        Me.colMachineName.FieldName = "MachineName"
        Me.colMachineName.Name = "colMachineName"
        Me.colMachineName.Visible = True
        Me.colMachineName.VisibleIndex = 0
        '
        'frmEmbMachineList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 345)
        Me.Controls.Add(Me.EmbMachineGridControl)
        Me.Controls.Add(Me.EmbMachineBindingNavigator)
        Me.Name = "frmEmbMachineList"
        Me.Text = "Emb Machine List"
        CType(Me.EmbMachineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbMachineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbMachineBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmbMachineBindingNavigator.ResumeLayout(False)
        Me.EmbMachineBindingNavigator.PerformLayout()
        CType(Me.EmbMachineGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EmbMachineDataSet As KSoft_Apparel.EmbMachineDataSet
    Friend WithEvents EmbMachineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmbMachineTableAdapter As KSoft_Apparel.EmbMachineDataSetTableAdapters.EmbMachineTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.EmbMachineDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmbMachineBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents EmbMachineBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents EmbMachineGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMachineName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
