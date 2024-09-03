<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignature
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSignature))
        Me.SignatureDataSet = New KSoft_Apparel.SignatureDataSet
        Me.SignatureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SignatureTableAdapter = New KSoft_Apparel.SignatureDataSetTableAdapters.SignatureTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.SignatureDataSetTableAdapters.TableAdapterManager
        Me.SignatureBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.SignatureBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.SignatureGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colInterface = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSignatureSL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSignatureName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUserId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.UserLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.UserLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserLookupDataSet = New KSoft_Apparel.UserLookupDataSet
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colUSER_NAME1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.UserLookupTableAdapter = New KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colType1 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.SignatureDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignatureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignatureBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SignatureBindingNavigator.SuspendLayout()
        CType(Me.SignatureGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SignatureDataSet
        '
        Me.SignatureDataSet.DataSetName = "SignatureDataSet"
        Me.SignatureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SignatureBindingSource
        '
        Me.SignatureBindingSource.DataMember = "Signature"
        Me.SignatureBindingSource.DataSource = Me.SignatureDataSet
        '
        'SignatureTableAdapter
        '
        Me.SignatureTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SignatureTableAdapter = Me.SignatureTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SignatureDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SignatureBindingNavigator
        '
        Me.SignatureBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SignatureBindingNavigator.BindingSource = Me.SignatureBindingSource
        Me.SignatureBindingNavigator.CountItem = Nothing
        Me.SignatureBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SignatureBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SignatureBindingNavigatorSaveItem})
        Me.SignatureBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SignatureBindingNavigator.MoveFirstItem = Nothing
        Me.SignatureBindingNavigator.MoveLastItem = Nothing
        Me.SignatureBindingNavigator.MoveNextItem = Nothing
        Me.SignatureBindingNavigator.MovePreviousItem = Nothing
        Me.SignatureBindingNavigator.Name = "SignatureBindingNavigator"
        Me.SignatureBindingNavigator.PositionItem = Nothing
        Me.SignatureBindingNavigator.Size = New System.Drawing.Size(797, 25)
        Me.SignatureBindingNavigator.TabIndex = 0
        Me.SignatureBindingNavigator.Text = "BindingNavigator1"
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
        'SignatureBindingNavigatorSaveItem
        '
        Me.SignatureBindingNavigatorSaveItem.Image = CType(resources.GetObject("SignatureBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SignatureBindingNavigatorSaveItem.Name = "SignatureBindingNavigatorSaveItem"
        Me.SignatureBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.SignatureBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SignatureGridControl
        '
        Me.SignatureGridControl.DataSource = Me.SignatureBindingSource
        Me.SignatureGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SignatureGridControl.Location = New System.Drawing.Point(0, 25)
        Me.SignatureGridControl.MainView = Me.GridView1
        Me.SignatureGridControl.Name = "SignatureGridControl"
        Me.SignatureGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.UserLookupGridLookUpEdit})
        Me.SignatureGridControl.Size = New System.Drawing.Size(797, 476)
        Me.SignatureGridControl.TabIndex = 1
        Me.SignatureGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInterface, Me.colSignatureSL, Me.colSignatureName, Me.colUserId, Me.colType, Me.colType1})
        Me.GridView1.GridControl = Me.SignatureGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colInterface
        '
        Me.colInterface.FieldName = "Interface"
        Me.colInterface.Name = "colInterface"
        Me.colInterface.Visible = True
        Me.colInterface.VisibleIndex = 0
        Me.colInterface.Width = 118
        '
        'colSignatureSL
        '
        Me.colSignatureSL.FieldName = "SignatureSL"
        Me.colSignatureSL.Name = "colSignatureSL"
        Me.colSignatureSL.Visible = True
        Me.colSignatureSL.VisibleIndex = 1
        Me.colSignatureSL.Width = 104
        '
        'colSignatureName
        '
        Me.colSignatureName.FieldName = "SignatureName"
        Me.colSignatureName.Name = "colSignatureName"
        Me.colSignatureName.Visible = True
        Me.colSignatureName.VisibleIndex = 2
        Me.colSignatureName.Width = 183
        '
        'colUserId
        '
        Me.colUserId.Caption = "User"
        Me.colUserId.ColumnEdit = Me.UserLookupGridLookUpEdit
        Me.colUserId.FieldName = "UserId"
        Me.colUserId.Name = "colUserId"
        Me.colUserId.Visible = True
        Me.colUserId.VisibleIndex = 3
        Me.colUserId.Width = 183
        '
        'UserLookupGridLookUpEdit
        '
        Me.UserLookupGridLookUpEdit.AutoHeight = False
        Me.UserLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserLookupGridLookUpEdit.DataSource = Me.UserLookupBindingSource
        Me.UserLookupGridLookUpEdit.DisplayMember = "USER_NAME"
        Me.UserLookupGridLookUpEdit.Name = "UserLookupGridLookUpEdit"
        Me.UserLookupGridLookUpEdit.NullText = ""
        Me.UserLookupGridLookUpEdit.ValueMember = "USER_ID"
        Me.UserLookupGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'UserLookupBindingSource
        '
        Me.UserLookupBindingSource.DataMember = "UserLookup"
        Me.UserLookupBindingSource.DataSource = Me.UserLookupDataSet
        '
        'UserLookupDataSet
        '
        Me.UserLookupDataSet.DataSetName = "UserLookupDataSet"
        Me.UserLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUSER_NAME1})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colUSER_NAME1
        '
        Me.colUSER_NAME1.FieldName = "USER_NAME"
        Me.colUSER_NAME1.Name = "colUSER_NAME1"
        Me.colUSER_NAME1.Visible = True
        Me.colUSER_NAME1.VisibleIndex = 0
        '
        'colType
        '
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.Width = 191
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.SignatureGridControl
        Me.GridView2.Name = "GridView2"
        '
        'UserLookupTableAdapter
        '
        Me.UserLookupTableAdapter.ClearBeforeFill = True
        '
        'colUSER_NAME
        '
        Me.colUSER_NAME.FieldName = "USER_NAME"
        Me.colUSER_NAME.Name = "colUSER_NAME"
        Me.colUSER_NAME.Visible = True
        Me.colUSER_NAME.VisibleIndex = 0
        '
        'colType1
        '
        Me.colType1.FieldName = "Type"
        Me.colType1.Name = "colType1"
        Me.colType1.Visible = True
        Me.colType1.VisibleIndex = 4
        '
        'frmSignature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 501)
        Me.Controls.Add(Me.SignatureGridControl)
        Me.Controls.Add(Me.SignatureBindingNavigator)
        Me.Name = "frmSignature"
        Me.Text = "Signature"
        CType(Me.SignatureDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignatureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignatureBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SignatureBindingNavigator.ResumeLayout(False)
        Me.SignatureBindingNavigator.PerformLayout()
        CType(Me.SignatureGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SignatureDataSet As KSoft_Apparel.SignatureDataSet
    Friend WithEvents SignatureBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SignatureTableAdapter As KSoft_Apparel.SignatureDataSetTableAdapters.SignatureTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.SignatureDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SignatureBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SignatureBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SignatureGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colInterface As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSignatureSL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSignatureName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UserLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UserLookupDataSet As KSoft_Apparel.UserLookupDataSet
    Friend WithEvents UserLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserLookupTableAdapter As KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter
    Friend WithEvents colUSER_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSER_NAME1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
