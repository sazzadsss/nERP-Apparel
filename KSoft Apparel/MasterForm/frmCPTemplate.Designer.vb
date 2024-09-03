<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCPTemplate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCPTemplate))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.CPTemplateDataSet = New KSoft_Apparel.CPTemplateDataSet
        Me.CP_TemplateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CP_TemplateTableAdapter = New KSoft_Apparel.CPTemplateDataSetTableAdapters.CP_TemplateTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.CPTemplateDataSetTableAdapters.TableAdapterManager
        Me.CP_TemplateBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.CP_TemplateBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.CP_TemplateGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCP_TemplateId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCP_TemplateName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCP_TemplateDescription = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.CPTemplateDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CP_TemplateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CP_TemplateBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CP_TemplateBindingNavigator.SuspendLayout()
        CType(Me.CP_TemplateGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(420, 285)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'CPTemplateDataSet
        '
        Me.CPTemplateDataSet.DataSetName = "CPTemplateDataSet"
        Me.CPTemplateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CP_TemplateBindingSource
        '
        Me.CP_TemplateBindingSource.DataMember = "CP_Template"
        Me.CP_TemplateBindingSource.DataSource = Me.CPTemplateDataSet
        '
        'CP_TemplateTableAdapter
        '
        Me.CP_TemplateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CP_TemplateTableAdapter = Me.CP_TemplateTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.CPTemplateDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CP_TemplateBindingNavigator
        '
        Me.CP_TemplateBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CP_TemplateBindingNavigator.BindingSource = Me.CP_TemplateBindingSource
        Me.CP_TemplateBindingNavigator.CountItem = Nothing
        Me.CP_TemplateBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CP_TemplateBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CP_TemplateBindingNavigatorSaveItem})
        Me.CP_TemplateBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CP_TemplateBindingNavigator.MoveFirstItem = Nothing
        Me.CP_TemplateBindingNavigator.MoveLastItem = Nothing
        Me.CP_TemplateBindingNavigator.MoveNextItem = Nothing
        Me.CP_TemplateBindingNavigator.MovePreviousItem = Nothing
        Me.CP_TemplateBindingNavigator.Name = "CP_TemplateBindingNavigator"
        Me.CP_TemplateBindingNavigator.PositionItem = Nothing
        Me.CP_TemplateBindingNavigator.Size = New System.Drawing.Size(578, 25)
        Me.CP_TemplateBindingNavigator.TabIndex = 1
        Me.CP_TemplateBindingNavigator.Text = "BindingNavigator1"
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
        'CP_TemplateBindingNavigatorSaveItem
        '
        Me.CP_TemplateBindingNavigatorSaveItem.Image = CType(resources.GetObject("CP_TemplateBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CP_TemplateBindingNavigatorSaveItem.Name = "CP_TemplateBindingNavigatorSaveItem"
        Me.CP_TemplateBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.CP_TemplateBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CP_TemplateGridControl
        '
        Me.CP_TemplateGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CP_TemplateGridControl.DataSource = Me.CP_TemplateBindingSource
        Me.CP_TemplateGridControl.Location = New System.Drawing.Point(0, 28)
        Me.CP_TemplateGridControl.MainView = Me.GridView1
        Me.CP_TemplateGridControl.Name = "CP_TemplateGridControl"
        Me.CP_TemplateGridControl.Size = New System.Drawing.Size(578, 246)
        Me.CP_TemplateGridControl.TabIndex = 2
        Me.CP_TemplateGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCP_TemplateId, Me.colCP_TemplateName, Me.colCP_TemplateDescription})
        Me.GridView1.GridControl = Me.CP_TemplateGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.CP_TemplateGridControl
        Me.GridView2.Name = "GridView2"
        '
        'colCP_TemplateId
        '
        Me.colCP_TemplateId.FieldName = "CP_TemplateId"
        Me.colCP_TemplateId.Name = "colCP_TemplateId"
        Me.colCP_TemplateId.OptionsColumn.ReadOnly = True
        '
        'colCP_TemplateName
        '
        Me.colCP_TemplateName.FieldName = "CP_TemplateName"
        Me.colCP_TemplateName.Name = "colCP_TemplateName"
        Me.colCP_TemplateName.Visible = True
        Me.colCP_TemplateName.VisibleIndex = 0
        '
        'colCP_TemplateDescription
        '
        Me.colCP_TemplateDescription.FieldName = "CP_TemplateDescription"
        Me.colCP_TemplateDescription.Name = "colCP_TemplateDescription"
        Me.colCP_TemplateDescription.Visible = True
        Me.colCP_TemplateDescription.VisibleIndex = 1
        '
        'frmCPTemplate
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(578, 323)
        Me.Controls.Add(Me.CP_TemplateGridControl)
        Me.Controls.Add(Me.CP_TemplateBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCPTemplate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CP Template"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.CPTemplateDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CP_TemplateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CP_TemplateBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CP_TemplateBindingNavigator.ResumeLayout(False)
        Me.CP_TemplateBindingNavigator.PerformLayout()
        CType(Me.CP_TemplateGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents CPTemplateDataSet As KSoft_Apparel.CPTemplateDataSet
    Friend WithEvents CP_TemplateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CP_TemplateTableAdapter As KSoft_Apparel.CPTemplateDataSetTableAdapters.CP_TemplateTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.CPTemplateDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CP_TemplateBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CP_TemplateBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CP_TemplateGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCP_TemplateId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCP_TemplateName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCP_TemplateDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView

End Class
