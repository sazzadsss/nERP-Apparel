<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.CustomerListBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.CustomerListBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.CustomerListDataGridView = New System.Windows.Forms.DataGridView
        Me.CustomerListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerListDataSet = New KSoft_Apparel.CustomerListDataSet
        Me.CustomerListTableAdapter = New KSoft_Apparel.CustomerListDataSetTableAdapters.CustomerListTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.CustomerListDataSetTableAdapters.TableAdapterManager
        Me.CustomerCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.CustomerListBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerListBindingNavigator.SuspendLayout()
        CType(Me.CustomerListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerListBindingNavigator
        '
        Me.CustomerListBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomerListBindingNavigator.BindingSource = Me.CustomerListBindingSource
        Me.CustomerListBindingNavigator.CountItem = Nothing
        Me.CustomerListBindingNavigator.DeleteItem = Nothing
        Me.CustomerListBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.CustomerListBindingNavigatorSaveItem})
        Me.CustomerListBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomerListBindingNavigator.MoveFirstItem = Nothing
        Me.CustomerListBindingNavigator.MoveLastItem = Nothing
        Me.CustomerListBindingNavigator.MoveNextItem = Nothing
        Me.CustomerListBindingNavigator.MovePreviousItem = Nothing
        Me.CustomerListBindingNavigator.Name = "CustomerListBindingNavigator"
        Me.CustomerListBindingNavigator.PositionItem = Nothing
        Me.CustomerListBindingNavigator.Size = New System.Drawing.Size(944, 25)
        Me.CustomerListBindingNavigator.TabIndex = 0
        Me.CustomerListBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'CustomerListBindingNavigatorSaveItem
        '
        Me.CustomerListBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomerListBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomerListBindingNavigatorSaveItem.Name = "CustomerListBindingNavigatorSaveItem"
        Me.CustomerListBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.CustomerListBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CustomerListDataGridView
        '
        Me.CustomerListDataGridView.AllowUserToAddRows = False
        Me.CustomerListDataGridView.AutoGenerateColumns = False
        Me.CustomerListDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CustomerListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerCode, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.CustomerListDataGridView.DataSource = Me.CustomerListBindingSource
        Me.CustomerListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomerListDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.CustomerListDataGridView.Name = "CustomerListDataGridView"
        Me.CustomerListDataGridView.Size = New System.Drawing.Size(944, 396)
        Me.CustomerListDataGridView.TabIndex = 1
        '
        'CustomerListBindingSource
        '
        Me.CustomerListBindingSource.DataMember = "CustomerList"
        Me.CustomerListBindingSource.DataSource = Me.CustomerListDataSet
        '
        'CustomerListDataSet
        '
        Me.CustomerListDataSet.DataSetName = "CustomerListDataSet"
        Me.CustomerListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerListTableAdapter
        '
        Me.CustomerListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerListTableAdapter = Me.CustomerListTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.CustomerListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerCode
        '
        Me.CustomerCode.DataPropertyName = "CustomerCode"
        Me.CustomerCode.HeaderText = "Code"
        Me.CustomerCode.Name = "CustomerCode"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CustomerName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Customer"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ContactPerson"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Contact Person"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ContactNo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Contact No"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Add1"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Add1"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Add2"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Add2"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn7.HeaderText = "City"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Country"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Country"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 421)
        Me.Controls.Add(Me.CustomerListDataGridView)
        Me.Controls.Add(Me.CustomerListBindingNavigator)
        Me.Name = "frmCustomer"
        Me.Text = "Customer"
        CType(Me.CustomerListBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerListBindingNavigator.ResumeLayout(False)
        Me.CustomerListBindingNavigator.PerformLayout()
        CType(Me.CustomerListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustomerListDataSet As KSoft_Apparel.CustomerListDataSet
    Friend WithEvents CustomerListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerListTableAdapter As KSoft_Apparel.CustomerListDataSetTableAdapters.CustomerListTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.CustomerListDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerListBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CustomerListBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CustomerListDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CustomerCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
