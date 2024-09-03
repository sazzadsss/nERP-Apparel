<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmswOperationCapacity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmswOperationCapacity))
        Me.SwOperationCapacityDataSet = New KSoft_Apparel.swOperationCapacityDataSet
        Me.SwOperationCapacityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SwOperationCapacityTableAdapter = New KSoft_Apparel.swOperationCapacityDataSetTableAdapters.swOperationCapacityTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.swOperationCapacityDataSetTableAdapters.TableAdapterManager
        Me.SwOperationCapacityBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.SwOperationCapacityBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.SwOperationCapacityGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colOperationCapacityId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCapacity = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.SwOperationCapacityDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SwOperationCapacityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SwOperationCapacityBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SwOperationCapacityBindingNavigator.SuspendLayout()
        CType(Me.SwOperationCapacityGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SwOperationCapacityDataSet
        '
        Me.SwOperationCapacityDataSet.DataSetName = "swOperationCapacityDataSet"
        Me.SwOperationCapacityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SwOperationCapacityBindingSource
        '
        Me.SwOperationCapacityBindingSource.DataMember = "swOperationCapacity"
        Me.SwOperationCapacityBindingSource.DataSource = Me.SwOperationCapacityDataSet
        '
        'SwOperationCapacityTableAdapter
        '
        Me.SwOperationCapacityTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.swOperationCapacityTableAdapter = Me.SwOperationCapacityTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.swOperationCapacityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SwOperationCapacityBindingNavigator
        '
        Me.SwOperationCapacityBindingNavigator.AddNewItem = Nothing
        Me.SwOperationCapacityBindingNavigator.BindingSource = Me.SwOperationCapacityBindingSource
        Me.SwOperationCapacityBindingNavigator.CountItem = Nothing
        Me.SwOperationCapacityBindingNavigator.DeleteItem = Nothing
        Me.SwOperationCapacityBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SwOperationCapacityBindingNavigatorSaveItem})
        Me.SwOperationCapacityBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SwOperationCapacityBindingNavigator.MoveFirstItem = Nothing
        Me.SwOperationCapacityBindingNavigator.MoveLastItem = Nothing
        Me.SwOperationCapacityBindingNavigator.MoveNextItem = Nothing
        Me.SwOperationCapacityBindingNavigator.MovePreviousItem = Nothing
        Me.SwOperationCapacityBindingNavigator.Name = "SwOperationCapacityBindingNavigator"
        Me.SwOperationCapacityBindingNavigator.PositionItem = Nothing
        Me.SwOperationCapacityBindingNavigator.Size = New System.Drawing.Size(514, 25)
        Me.SwOperationCapacityBindingNavigator.TabIndex = 0
        Me.SwOperationCapacityBindingNavigator.Text = "BindingNavigator1"
        '
        'SwOperationCapacityBindingNavigatorSaveItem
        '
        Me.SwOperationCapacityBindingNavigatorSaveItem.Image = CType(resources.GetObject("SwOperationCapacityBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SwOperationCapacityBindingNavigatorSaveItem.Name = "SwOperationCapacityBindingNavigatorSaveItem"
        Me.SwOperationCapacityBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.SwOperationCapacityBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SwOperationCapacityGridControl
        '
        Me.SwOperationCapacityGridControl.DataSource = Me.SwOperationCapacityBindingSource
        Me.SwOperationCapacityGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SwOperationCapacityGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.SwOperationCapacityGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.SwOperationCapacityGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.SwOperationCapacityGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.SwOperationCapacityGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.SwOperationCapacityGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.SwOperationCapacityGridControl.Location = New System.Drawing.Point(0, 25)
        Me.SwOperationCapacityGridControl.MainView = Me.GridView1
        Me.SwOperationCapacityGridControl.Name = "SwOperationCapacityGridControl"
        Me.SwOperationCapacityGridControl.Size = New System.Drawing.Size(514, 255)
        Me.SwOperationCapacityGridControl.TabIndex = 1
        Me.SwOperationCapacityGridControl.UseEmbeddedNavigator = True
        Me.SwOperationCapacityGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOperationCapacityId, Me.colDescription, Me.colCapacity})
        Me.GridView1.GridControl = Me.SwOperationCapacityGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colOperationCapacityId
        '
        Me.colOperationCapacityId.FieldName = "OperationCapacityId"
        Me.colOperationCapacityId.Name = "colOperationCapacityId"
        Me.colOperationCapacityId.OptionsColumn.ReadOnly = True
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 0
        Me.colDescription.Width = 396
        '
        'colCapacity
        '
        Me.colCapacity.FieldName = "Capacity"
        Me.colCapacity.Name = "colCapacity"
        Me.colCapacity.Visible = True
        Me.colCapacity.VisibleIndex = 1
        Me.colCapacity.Width = 97
        '
        'frmswOperationCapacity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 280)
        Me.Controls.Add(Me.SwOperationCapacityGridControl)
        Me.Controls.Add(Me.SwOperationCapacityBindingNavigator)
        Me.Name = "frmswOperationCapacity"
        Me.Text = "Operation Capacity"
        CType(Me.SwOperationCapacityDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SwOperationCapacityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SwOperationCapacityBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SwOperationCapacityBindingNavigator.ResumeLayout(False)
        Me.SwOperationCapacityBindingNavigator.PerformLayout()
        CType(Me.SwOperationCapacityGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SwOperationCapacityDataSet As KSoft_Apparel.swOperationCapacityDataSet
    Friend WithEvents SwOperationCapacityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SwOperationCapacityTableAdapter As KSoft_Apparel.swOperationCapacityDataSetTableAdapters.swOperationCapacityTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.swOperationCapacityDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SwOperationCapacityBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents SwOperationCapacityBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SwOperationCapacityGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOperationCapacityId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCapacity As DevExpress.XtraGrid.Columns.GridColumn
End Class
