<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSusStandard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSusStandard))
        Me.SusStandardDataSet = New KSoft_Apparel.SusStandardDataSet()
        Me.SusStandardMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SusStandardMstTableAdapter = New KSoft_Apparel.SusStandardDataSetTableAdapters.SusStandardMstTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.SusStandardDataSetTableAdapters.TableAdapterManager()
        Me.SusStandardMstBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.SusStandardMstBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SusStandardMstGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.SusStandardDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SusStandardMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SusStandardMstBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SusStandardMstBindingNavigator.SuspendLayout()
        CType(Me.SusStandardMstGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SusStandardDataSet
        '
        Me.SusStandardDataSet.DataSetName = "SusStandardDataSet"
        Me.SusStandardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SusStandardMstBindingSource
        '
        Me.SusStandardMstBindingSource.DataMember = "SusStandardMst"
        Me.SusStandardMstBindingSource.DataSource = Me.SusStandardDataSet
        '
        'SusStandardMstTableAdapter
        '
        Me.SusStandardMstTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SusStandardMstTableAdapter = Me.SusStandardMstTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SusStandardDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SusStandardMstBindingNavigator
        '
        Me.SusStandardMstBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SusStandardMstBindingNavigator.BindingSource = Me.SusStandardMstBindingSource
        Me.SusStandardMstBindingNavigator.CountItem = Nothing
        Me.SusStandardMstBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SusStandardMstBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SusStandardMstBindingNavigatorSaveItem})
        Me.SusStandardMstBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SusStandardMstBindingNavigator.MoveFirstItem = Nothing
        Me.SusStandardMstBindingNavigator.MoveLastItem = Nothing
        Me.SusStandardMstBindingNavigator.MoveNextItem = Nothing
        Me.SusStandardMstBindingNavigator.MovePreviousItem = Nothing
        Me.SusStandardMstBindingNavigator.Name = "SusStandardMstBindingNavigator"
        Me.SusStandardMstBindingNavigator.PositionItem = Nothing
        Me.SusStandardMstBindingNavigator.Size = New System.Drawing.Size(480, 25)
        Me.SusStandardMstBindingNavigator.TabIndex = 0
        Me.SusStandardMstBindingNavigator.Text = "BindingNavigator1"
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
        'SusStandardMstBindingNavigatorSaveItem
        '
        Me.SusStandardMstBindingNavigatorSaveItem.Image = CType(resources.GetObject("SusStandardMstBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SusStandardMstBindingNavigatorSaveItem.Name = "SusStandardMstBindingNavigatorSaveItem"
        Me.SusStandardMstBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.SusStandardMstBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SusStandardMstGridControl
        '
        Me.SusStandardMstGridControl.DataSource = Me.SusStandardMstBindingSource
        Me.SusStandardMstGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SusStandardMstGridControl.Location = New System.Drawing.Point(0, 25)
        Me.SusStandardMstGridControl.MainView = Me.GridView1
        Me.SusStandardMstGridControl.Name = "SusStandardMstGridControl"
        Me.SusStandardMstGridControl.Size = New System.Drawing.Size(480, 327)
        Me.SusStandardMstGridControl.TabIndex = 1
        Me.SusStandardMstGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.SusStandardMstGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'frmSusStandard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 352)
        Me.Controls.Add(Me.SusStandardMstGridControl)
        Me.Controls.Add(Me.SusStandardMstBindingNavigator)
        Me.Name = "frmSusStandard"
        Me.Text = "Sus. Standard"
        CType(Me.SusStandardDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SusStandardMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SusStandardMstBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SusStandardMstBindingNavigator.ResumeLayout(False)
        Me.SusStandardMstBindingNavigator.PerformLayout()
        CType(Me.SusStandardMstGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SusStandardDataSet As SusStandardDataSet
    Friend WithEvents SusStandardMstBindingSource As BindingSource
    Friend WithEvents SusStandardMstTableAdapter As SusStandardDataSetTableAdapters.SusStandardMstTableAdapter
    Friend WithEvents TableAdapterManager As SusStandardDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SusStandardMstBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents SusStandardMstBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents SusStandardMstGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
