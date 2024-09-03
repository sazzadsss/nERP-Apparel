<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemStyle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemStyle))
        Me.ItemStyleBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.ItemStyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingDataSet = New KSoft_Apparel.BookingDataSet
        Me.ItemStyleBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ItemStyleDataGridView = New System.Windows.Forms.DataGridView
        Me.ItemStyle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
        Me.SearchTextBox = New System.Windows.Forms.TextBox
        Me.ItemStyleTableAdapter = New KSoft_Apparel.BookingDataSetTableAdapters.ItemStyleTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.BookingDataSetTableAdapters.TableAdapterManager
        Me.OKButton = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.ItemStyleBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ItemStyleBindingNavigator.SuspendLayout()
        CType(Me.ItemStyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemStyleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemStyleBindingNavigator
        '
        Me.ItemStyleBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ItemStyleBindingNavigator.BindingSource = Me.ItemStyleBindingSource
        Me.ItemStyleBindingNavigator.CountItem = Nothing
        Me.ItemStyleBindingNavigator.DeleteItem = Nothing
        Me.ItemStyleBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.ItemStyleBindingNavigatorSaveItem})
        Me.ItemStyleBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ItemStyleBindingNavigator.MoveFirstItem = Nothing
        Me.ItemStyleBindingNavigator.MoveLastItem = Nothing
        Me.ItemStyleBindingNavigator.MoveNextItem = Nothing
        Me.ItemStyleBindingNavigator.MovePreviousItem = Nothing
        Me.ItemStyleBindingNavigator.Name = "ItemStyleBindingNavigator"
        Me.ItemStyleBindingNavigator.PositionItem = Nothing
        Me.ItemStyleBindingNavigator.Size = New System.Drawing.Size(425, 25)
        Me.ItemStyleBindingNavigator.TabIndex = 0
        Me.ItemStyleBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'ItemStyleBindingSource
        '
        Me.ItemStyleBindingSource.DataMember = "ItemStyle"
        Me.ItemStyleBindingSource.DataSource = Me.BookingDataSet
        '
        'BookingDataSet
        '
        Me.BookingDataSet.DataSetName = "BookingDataSet"
        Me.BookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemStyleBindingNavigatorSaveItem
        '
        Me.ItemStyleBindingNavigatorSaveItem.Image = CType(resources.GetObject("ItemStyleBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ItemStyleBindingNavigatorSaveItem.Name = "ItemStyleBindingNavigatorSaveItem"
        Me.ItemStyleBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.ItemStyleBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ItemStyleDataGridView
        '
        Me.ItemStyleDataGridView.AllowUserToAddRows = False
        Me.ItemStyleDataGridView.AutoGenerateColumns = False
        Me.ItemStyleDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ItemStyleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemStyleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemStyle, Me.DataGridViewTextBoxColumn3})
        Me.ItemStyleDataGridView.DataSource = Me.ItemStyleBindingSource
        Me.ItemStyleDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.ItemStyleDataGridView.Name = "ItemStyleDataGridView"
        Me.ItemStyleDataGridView.Size = New System.Drawing.Size(425, 222)
        Me.ItemStyleDataGridView.TabIndex = 1
        '
        'ItemStyle
        '
        Me.ItemStyle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ItemStyle.DataPropertyName = "ItemStyle"
        Me.ItemStyle.HeaderText = "Item Style"
        Me.ItemStyle.Name = "ItemStyle"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BuyerId"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.BuyerBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "BuyerName"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.HeaderText = "Buyer Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "BuyerId"
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
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchTextBox.BackColor = System.Drawing.Color.Yellow
        Me.SearchTextBox.Location = New System.Drawing.Point(189, 3)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(230, 20)
        Me.SearchTextBox.TabIndex = 2
        '
        'ItemStyleTableAdapter
        '
        Me.ItemStyleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookingDetailsTableAdapter = Nothing
        Me.TableAdapterManager.BookingProgramNoLookupTableAdapter = Nothing
        Me.TableAdapterManager.BookingProgramNoSearchTableAdapter = Nothing
        Me.TableAdapterManager.BookingTableAdapter = Nothing
        Me.TableAdapterManager.ItemStyleTableAdapter = Me.ItemStyleTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.BookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(338, 260)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 3
        Me.OKButton.Text = "&OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(246, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmItemStyle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 295)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.ItemStyleDataGridView)
        Me.Controls.Add(Me.ItemStyleBindingNavigator)
        Me.Name = "frmItemStyle"
        Me.Text = "Item Style"
        CType(Me.ItemStyleBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ItemStyleBindingNavigator.ResumeLayout(False)
        Me.ItemStyleBindingNavigator.PerformLayout()
        CType(Me.ItemStyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemStyleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BookingDataSet As KSoft_Apparel.BookingDataSet
    Friend WithEvents ItemStyleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemStyleTableAdapter As KSoft_Apparel.BookingDataSetTableAdapters.ItemStyleTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.BookingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemStyleBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ItemStyleBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ItemStyleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemStyle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
