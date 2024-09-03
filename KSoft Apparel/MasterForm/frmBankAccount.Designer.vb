<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBankAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBankAccount))
        Me.BankAccountDataSet = New KSoft_Apparel.BankAccountDataSet
        Me.BankAccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankAccountTableAdapter = New KSoft_Apparel.BankAccountDataSetTableAdapters.BankAccountTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.BankAccountDataSetTableAdapters.TableAdapterManager
        Me.BankAccountBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BankAccountBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.BankAccountGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colBankName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBankCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAccountNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAccountType = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.BankAccountDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankAccountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankAccountBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BankAccountBindingNavigator.SuspendLayout()
        CType(Me.BankAccountGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BankAccountDataSet
        '
        Me.BankAccountDataSet.DataSetName = "BankAccountDataSet"
        Me.BankAccountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BankAccountBindingSource
        '
        Me.BankAccountBindingSource.DataMember = "BankAccount"
        Me.BankAccountBindingSource.DataSource = Me.BankAccountDataSet
        '
        'BankAccountTableAdapter
        '
        Me.BankAccountTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BankAccountTableAdapter = Me.BankAccountTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.BankAccountDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BankAccountBindingNavigator
        '
        Me.BankAccountBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BankAccountBindingNavigator.BindingSource = Me.BankAccountBindingSource
        Me.BankAccountBindingNavigator.CountItem = Nothing
        Me.BankAccountBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BankAccountBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSeparator2, Me.BankAccountBindingNavigatorSaveItem})
        Me.BankAccountBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BankAccountBindingNavigator.MoveFirstItem = Nothing
        Me.BankAccountBindingNavigator.MoveLastItem = Nothing
        Me.BankAccountBindingNavigator.MoveNextItem = Nothing
        Me.BankAccountBindingNavigator.MovePreviousItem = Nothing
        Me.BankAccountBindingNavigator.Name = "BankAccountBindingNavigator"
        Me.BankAccountBindingNavigator.PositionItem = Nothing
        Me.BankAccountBindingNavigator.Size = New System.Drawing.Size(795, 25)
        Me.BankAccountBindingNavigator.TabIndex = 0
        Me.BankAccountBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BankAccountBindingNavigatorSaveItem
        '
        Me.BankAccountBindingNavigatorSaveItem.Image = CType(resources.GetObject("BankAccountBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BankAccountBindingNavigatorSaveItem.Name = "BankAccountBindingNavigatorSaveItem"
        Me.BankAccountBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.BankAccountBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BankAccountGridControl
        '
        Me.BankAccountGridControl.DataSource = Me.BankAccountBindingSource
        Me.BankAccountGridControl.Location = New System.Drawing.Point(0, 28)
        Me.BankAccountGridControl.MainView = Me.GridView1
        Me.BankAccountGridControl.Name = "BankAccountGridControl"
        Me.BankAccountGridControl.Size = New System.Drawing.Size(795, 391)
        Me.BankAccountGridControl.TabIndex = 1
        Me.BankAccountGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBankName, Me.colBankCode, Me.colAccountNo, Me.colAddress, Me.colAccountType})
        Me.GridView1.GridControl = Me.BankAccountGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colBankName
        '
        Me.colBankName.FieldName = "BankName"
        Me.colBankName.Name = "colBankName"
        Me.colBankName.Visible = True
        Me.colBankName.VisibleIndex = 0
        '
        'colBankCode
        '
        Me.colBankCode.FieldName = "BankCode"
        Me.colBankCode.Name = "colBankCode"
        Me.colBankCode.Visible = True
        Me.colBankCode.VisibleIndex = 1
        '
        'colAccountNo
        '
        Me.colAccountNo.FieldName = "AccountNo"
        Me.colAccountNo.Name = "colAccountNo"
        Me.colAccountNo.Visible = True
        Me.colAccountNo.VisibleIndex = 2
        '
        'colAddress
        '
        Me.colAddress.FieldName = "Address"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.Visible = True
        Me.colAddress.VisibleIndex = 3
        '
        'colAccountType
        '
        Me.colAccountType.FieldName = "AccountType"
        Me.colAccountType.Name = "colAccountType"
        Me.colAccountType.Visible = True
        Me.colAccountType.VisibleIndex = 4
        '
        'frmBankAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 418)
        Me.Controls.Add(Me.BankAccountGridControl)
        Me.Controls.Add(Me.BankAccountBindingNavigator)
        Me.Name = "frmBankAccount"
        Me.Text = "Bank Account"
        CType(Me.BankAccountDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankAccountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankAccountBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BankAccountBindingNavigator.ResumeLayout(False)
        Me.BankAccountBindingNavigator.PerformLayout()
        CType(Me.BankAccountGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BankAccountDataSet As KSoft_Apparel.BankAccountDataSet
    Friend WithEvents BankAccountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BankAccountTableAdapter As KSoft_Apparel.BankAccountDataSetTableAdapters.BankAccountTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.BankAccountDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BankAccountBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BankAccountBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BankAccountGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBankName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBankCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccountNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccountType As DevExpress.XtraGrid.Columns.GridColumn
End Class
