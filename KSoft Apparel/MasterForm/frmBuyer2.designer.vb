<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuyer2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuyer2))
        Me.Buyer2DataSet = New KSoft_Apparel.Buyer2DataSet
        Me.Buyer2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Buyer2TableAdapter = New KSoft_Apparel.Buyer2DataSetTableAdapters.Buyer2TableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.Buyer2DataSetTableAdapters.TableAdapterManager
        Me.Buyer2BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.Buyer2BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Buyer2GridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colBuyer2Code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBuyer2Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBuyerId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BuyerLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
        Me.colBuyerCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBuyerCode1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBuyerName1 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.Buyer2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Buyer2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Buyer2BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Buyer2BindingNavigator.SuspendLayout()
        CType(Me.Buyer2GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Buyer2DataSet
        '
        Me.Buyer2DataSet.DataSetName = "Buyer2DataSet"
        Me.Buyer2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Buyer2BindingSource
        '
        Me.Buyer2BindingSource.DataMember = "Buyer2"
        Me.Buyer2BindingSource.DataSource = Me.Buyer2DataSet
        '
        'Buyer2TableAdapter
        '
        Me.Buyer2TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Buyer2TableAdapter = Me.Buyer2TableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.Buyer2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Buyer2BindingNavigator
        '
        Me.Buyer2BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Buyer2BindingNavigator.BindingSource = Me.Buyer2BindingSource
        Me.Buyer2BindingNavigator.CountItem = Nothing
        Me.Buyer2BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Buyer2BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Buyer2BindingNavigatorSaveItem})
        Me.Buyer2BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Buyer2BindingNavigator.MoveFirstItem = Nothing
        Me.Buyer2BindingNavigator.MoveLastItem = Nothing
        Me.Buyer2BindingNavigator.MoveNextItem = Nothing
        Me.Buyer2BindingNavigator.MovePreviousItem = Nothing
        Me.Buyer2BindingNavigator.Name = "Buyer2BindingNavigator"
        Me.Buyer2BindingNavigator.PositionItem = Nothing
        Me.Buyer2BindingNavigator.Size = New System.Drawing.Size(567, 25)
        Me.Buyer2BindingNavigator.TabIndex = 0
        Me.Buyer2BindingNavigator.Text = "BindingNavigator1"
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
        'Buyer2BindingNavigatorSaveItem
        '
        Me.Buyer2BindingNavigatorSaveItem.Image = CType(resources.GetObject("Buyer2BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Buyer2BindingNavigatorSaveItem.Name = "Buyer2BindingNavigatorSaveItem"
        Me.Buyer2BindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.Buyer2BindingNavigatorSaveItem.Text = "Save Data"
        '
        'Buyer2GridControl
        '
        Me.Buyer2GridControl.DataSource = Me.Buyer2BindingSource
        Me.Buyer2GridControl.Location = New System.Drawing.Point(0, 28)
        Me.Buyer2GridControl.MainView = Me.GridView1
        Me.Buyer2GridControl.Name = "Buyer2GridControl"
        Me.Buyer2GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.BuyerLookupGridLookUpEdit})
        Me.Buyer2GridControl.Size = New System.Drawing.Size(567, 368)
        Me.Buyer2GridControl.TabIndex = 1
        Me.Buyer2GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyer2Code, Me.colBuyer2Name, Me.colBuyerId})
        Me.GridView1.GridControl = Me.Buyer2GridControl
        Me.GridView1.Name = "GridView1"
        '
        'colBuyer2Code
        '
        Me.colBuyer2Code.FieldName = "Buyer2Code"
        Me.colBuyer2Code.Name = "colBuyer2Code"
        Me.colBuyer2Code.Visible = True
        Me.colBuyer2Code.VisibleIndex = 0
        '
        'colBuyer2Name
        '
        Me.colBuyer2Name.FieldName = "Buyer2Name"
        Me.colBuyer2Name.Name = "colBuyer2Name"
        Me.colBuyer2Name.Visible = True
        Me.colBuyer2Name.VisibleIndex = 1
        '
        'colBuyerId
        '
        Me.colBuyerId.Caption = "Factory Buyer"
        Me.colBuyerId.ColumnEdit = Me.BuyerLookupGridLookUpEdit
        Me.colBuyerId.FieldName = "BuyerId"
        Me.colBuyerId.Name = "colBuyerId"
        Me.colBuyerId.Visible = True
        Me.colBuyerId.VisibleIndex = 2
        '
        'BuyerLookupGridLookUpEdit
        '
        Me.BuyerLookupGridLookUpEdit.AutoHeight = False
        Me.BuyerLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerLookupGridLookUpEdit.DataSource = Me.BuyerBindingSource
        Me.BuyerLookupGridLookUpEdit.DisplayMember = "BuyerName"
        Me.BuyerLookupGridLookUpEdit.Name = "BuyerLookupGridLookUpEdit"
        Me.BuyerLookupGridLookUpEdit.ValueMember = "BuyerId"
        Me.BuyerLookupGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'BuyerBindingSource
        '
        Me.BuyerBindingSource.DataMember = "Buyer"
        Me.BuyerBindingSource.DataSource = Me.BuyerDataSet
        '
        'BuyerDataSet
        '
        Me.BuyerDataSet.DataSetName = "BuyerDataSet"
        Me.BuyerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerCode1, Me.colBuyerName1})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'colBuyerCode
        '
        Me.colBuyerCode.FieldName = "BuyerCode"
        Me.colBuyerCode.Name = "colBuyerCode"
        Me.colBuyerCode.Visible = True
        Me.colBuyerCode.VisibleIndex = 0
        '
        'colBuyerName
        '
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 1
        '
        'colBuyerCode1
        '
        Me.colBuyerCode1.FieldName = "BuyerCode"
        Me.colBuyerCode1.Name = "colBuyerCode1"
        Me.colBuyerCode1.Visible = True
        Me.colBuyerCode1.VisibleIndex = 0
        '
        'colBuyerName1
        '
        Me.colBuyerName1.FieldName = "BuyerName"
        Me.colBuyerName1.Name = "colBuyerName1"
        Me.colBuyerName1.Visible = True
        Me.colBuyerName1.VisibleIndex = 1
        '
        'frmBuyer2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 395)
        Me.Controls.Add(Me.Buyer2GridControl)
        Me.Controls.Add(Me.Buyer2BindingNavigator)
        Me.Name = "frmBuyer2"
        Me.Text = "Buyer 2"
        CType(Me.Buyer2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Buyer2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Buyer2BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Buyer2BindingNavigator.ResumeLayout(False)
        Me.Buyer2BindingNavigator.PerformLayout()
        CType(Me.Buyer2GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Buyer2DataSet As KSoft_Apparel.Buyer2DataSet
    Friend WithEvents Buyer2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Buyer2TableAdapter As KSoft_Apparel.Buyer2DataSetTableAdapters.Buyer2TableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.Buyer2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Buyer2BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Buyer2BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Buyer2GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBuyer2Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyer2Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BuyerLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents colBuyerCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
