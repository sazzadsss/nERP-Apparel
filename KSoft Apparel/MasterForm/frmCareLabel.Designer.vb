<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCareLabel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCareLabel))
        Me.CareLabelDataSet = New KSoft_Apparel.CareLabelDataSet
        Me.CareLabelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CareLabelTableAdapter = New KSoft_Apparel.CareLabelDataSetTableAdapters.CareLabelTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.CareLabelDataSetTableAdapters.TableAdapterManager
        Me.CareLabelBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.CareLabelBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.CareLabelGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCareLabel = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CareLabelPictureEdit = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CareLabelImageEdit = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.CareLabelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CareLabelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CareLabelBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CareLabelBindingNavigator.SuspendLayout()
        CType(Me.CareLabelGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CareLabelPictureEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CareLabelImageEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CareLabelDataSet
        '
        Me.CareLabelDataSet.DataSetName = "CareLabelDataSet"
        Me.CareLabelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CareLabelBindingSource
        '
        Me.CareLabelBindingSource.DataMember = "CareLabel"
        Me.CareLabelBindingSource.DataSource = Me.CareLabelDataSet
        '
        'CareLabelTableAdapter
        '
        Me.CareLabelTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CareLabelTableAdapter = Me.CareLabelTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.CareLabelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CareLabelBindingNavigator
        '
        Me.CareLabelBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CareLabelBindingNavigator.BindingSource = Me.CareLabelBindingSource
        Me.CareLabelBindingNavigator.CountItem = Nothing
        Me.CareLabelBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CareLabelBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CareLabelBindingNavigatorSaveItem})
        Me.CareLabelBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CareLabelBindingNavigator.MoveFirstItem = Nothing
        Me.CareLabelBindingNavigator.MoveLastItem = Nothing
        Me.CareLabelBindingNavigator.MoveNextItem = Nothing
        Me.CareLabelBindingNavigator.MovePreviousItem = Nothing
        Me.CareLabelBindingNavigator.Name = "CareLabelBindingNavigator"
        Me.CareLabelBindingNavigator.PositionItem = Nothing
        Me.CareLabelBindingNavigator.Size = New System.Drawing.Size(586, 25)
        Me.CareLabelBindingNavigator.TabIndex = 0
        Me.CareLabelBindingNavigator.Text = "BindingNavigator1"
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
        'CareLabelBindingNavigatorSaveItem
        '
        Me.CareLabelBindingNavigatorSaveItem.Image = CType(resources.GetObject("CareLabelBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CareLabelBindingNavigatorSaveItem.Name = "CareLabelBindingNavigatorSaveItem"
        Me.CareLabelBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.CareLabelBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CareLabelGridControl
        '
        Me.CareLabelGridControl.DataSource = Me.CareLabelBindingSource
        Me.CareLabelGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CareLabelGridControl.Location = New System.Drawing.Point(0, 25)
        Me.CareLabelGridControl.MainView = Me.GridView1
        Me.CareLabelGridControl.Name = "CareLabelGridControl"
        Me.CareLabelGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.CareLabelImageEdit, Me.CareLabelPictureEdit})
        Me.CareLabelGridControl.Size = New System.Drawing.Size(586, 422)
        Me.CareLabelGridControl.TabIndex = 1
        Me.CareLabelGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCareLabel, Me.colRemarks})
        Me.GridView1.GridControl = Me.CareLabelGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.RowHeight = 50
        '
        'colCareLabel
        '
        Me.colCareLabel.ColumnEdit = Me.CareLabelPictureEdit
        Me.colCareLabel.FieldName = "CareLabel"
        Me.colCareLabel.Name = "colCareLabel"
        Me.colCareLabel.Visible = True
        Me.colCareLabel.VisibleIndex = 0
        Me.colCareLabel.Width = 152
        '
        'CareLabelPictureEdit
        '
        Me.CareLabelPictureEdit.Name = "CareLabelPictureEdit"
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 1
        Me.colRemarks.Width = 416
        '
        'CareLabelImageEdit
        '
        Me.CareLabelImageEdit.AutoHeight = False
        Me.CareLabelImageEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CareLabelImageEdit.Name = "CareLabelImageEdit"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.CareLabelGridControl
        Me.GridView2.Name = "GridView2"
        '
        'frmCareLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 447)
        Me.Controls.Add(Me.CareLabelGridControl)
        Me.Controls.Add(Me.CareLabelBindingNavigator)
        Me.Name = "frmCareLabel"
        Me.Text = "Care Label"
        CType(Me.CareLabelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CareLabelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CareLabelBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CareLabelBindingNavigator.ResumeLayout(False)
        Me.CareLabelBindingNavigator.PerformLayout()
        CType(Me.CareLabelGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CareLabelPictureEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CareLabelImageEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CareLabelDataSet As KSoft_Apparel.CareLabelDataSet
    Friend WithEvents CareLabelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CareLabelTableAdapter As KSoft_Apparel.CareLabelDataSetTableAdapters.CareLabelTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.CareLabelDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CareLabelBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CareLabelBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CareLabelGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCareLabel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CareLabelImageEdit As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Friend WithEvents CareLabelPictureEdit As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
End Class
