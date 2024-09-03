<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintProductionHour
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintProductionHour))
        Me.PrintProductionHourBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.PrintProductionHourBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintProductionHourDataSet = New KSoft_Apparel.PrintProductionHourDataSet
        Me.PrintProductionHourBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.PrintProductionHourDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ProductionMonthBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionMonthDataSet = New KSoft_Apparel.ProductionMonthDataSet
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet
        Me.ProductionHour = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MakeIn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrintProductionHourTableAdapter = New KSoft_Apparel.PrintProductionHourDataSetTableAdapters.PrintProductionHourTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.PrintProductionHourDataSetTableAdapters.TableAdapterManager
        Me.ProductionMonthComboBox = New System.Windows.Forms.ComboBox
        Me.AreaComboBox = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ProductionMonthTableAdapter = New KSoft_Apparel.ProductionMonthDataSetTableAdapters.ProductionMonthTableAdapter
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
        CType(Me.PrintProductionHourBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PrintProductionHourBindingNavigator.SuspendLayout()
        CType(Me.PrintProductionHourBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintProductionHourDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintProductionHourDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionMonthBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionMonthDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintProductionHourBindingNavigator
        '
        Me.PrintProductionHourBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PrintProductionHourBindingNavigator.BindingSource = Me.PrintProductionHourBindingSource
        Me.PrintProductionHourBindingNavigator.CountItem = Nothing
        Me.PrintProductionHourBindingNavigator.DeleteItem = Nothing
        Me.PrintProductionHourBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.PrintProductionHourBindingNavigatorSaveItem})
        Me.PrintProductionHourBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PrintProductionHourBindingNavigator.MoveFirstItem = Nothing
        Me.PrintProductionHourBindingNavigator.MoveLastItem = Nothing
        Me.PrintProductionHourBindingNavigator.MoveNextItem = Nothing
        Me.PrintProductionHourBindingNavigator.MovePreviousItem = Nothing
        Me.PrintProductionHourBindingNavigator.Name = "PrintProductionHourBindingNavigator"
        Me.PrintProductionHourBindingNavigator.PositionItem = Nothing
        Me.PrintProductionHourBindingNavigator.Size = New System.Drawing.Size(822, 25)
        Me.PrintProductionHourBindingNavigator.TabIndex = 0
        Me.PrintProductionHourBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'PrintProductionHourBindingSource
        '
        Me.PrintProductionHourBindingSource.DataMember = "PrintProductionHour"
        Me.PrintProductionHourBindingSource.DataSource = Me.PrintProductionHourDataSet
        '
        'PrintProductionHourDataSet
        '
        Me.PrintProductionHourDataSet.DataSetName = "PrintProductionHourDataSet"
        Me.PrintProductionHourDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrintProductionHourBindingNavigatorSaveItem
        '
        Me.PrintProductionHourBindingNavigatorSaveItem.Image = CType(resources.GetObject("PrintProductionHourBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PrintProductionHourBindingNavigatorSaveItem.Name = "PrintProductionHourBindingNavigatorSaveItem"
        Me.PrintProductionHourBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.PrintProductionHourBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PrintProductionHourDataGridView
        '
        Me.PrintProductionHourDataGridView.AllowUserToAddRows = False
        Me.PrintProductionHourDataGridView.AutoGenerateColumns = False
        Me.PrintProductionHourDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.PrintProductionHourDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PrintProductionHourDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.ProductionHour, Me.MakeIn, Me.DataGridViewTextBoxColumn6})
        Me.PrintProductionHourDataGridView.DataSource = Me.PrintProductionHourBindingSource
        Me.PrintProductionHourDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintProductionHourDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.PrintProductionHourDataGridView.Name = "PrintProductionHourDataGridView"
        Me.PrintProductionHourDataGridView.Size = New System.Drawing.Size(822, 368)
        Me.PrintProductionHourDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductionMonthId"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.ProductionMonthBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "ProductionMonthName"
        Me.DataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn2.HeaderText = "Production Month"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "ProductionMonthId"
        '
        'ProductionMonthBindingSource
        '
        Me.ProductionMonthBindingSource.DataMember = "ProductionMonth"
        Me.ProductionMonthBindingSource.DataSource = Me.ProductionMonthDataSet
        '
        'ProductionMonthDataSet
        '
        Me.ProductionMonthDataSet.DataSetName = "ProductionMonthDataSet"
        Me.ProductionMonthDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "OrderId"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.OrderLookupBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "ProgramNo"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.HeaderText = "Program No"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "OrderId"
        '
        'OrderLookupBindingSource
        '
        Me.OrderLookupBindingSource.DataMember = "OrderLookup"
        Me.OrderLookupBindingSource.DataSource = Me.OrderLookupDataSet
        '
        'OrderLookupDataSet
        '
        Me.OrderLookupDataSet.DataSetName = "OrderLookupDataSet"
        Me.OrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductionHour
        '
        Me.ProductionHour.DataPropertyName = "ProductionHour"
        Me.ProductionHour.HeaderText = "Production Hour"
        Me.ProductionHour.Name = "ProductionHour"
        '
        'MakeIn
        '
        Me.MakeIn.DataPropertyName = "MakeIn"
        Me.MakeIn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.MakeIn.HeaderText = "Area"
        Me.MakeIn.Items.AddRange(New Object() {"Machine", "Table"})
        Me.MakeIn.Name = "MakeIn"
        Me.MakeIn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MakeIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'PrintProductionHourTableAdapter
        '
        Me.PrintProductionHourTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PrintProductionHourTableAdapter = Me.PrintProductionHourTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.PrintProductionHourDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductionMonthComboBox
        '
        Me.ProductionMonthComboBox.DataSource = Me.ProductionMonthBindingSource
        Me.ProductionMonthComboBox.DisplayMember = "ProductionMonthName"
        Me.ProductionMonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProductionMonthComboBox.FormattingEnabled = True
        Me.ProductionMonthComboBox.Location = New System.Drawing.Point(340, 2)
        Me.ProductionMonthComboBox.Name = "ProductionMonthComboBox"
        Me.ProductionMonthComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ProductionMonthComboBox.TabIndex = 2
        Me.ProductionMonthComboBox.ValueMember = "ProductionMonthId"
        '
        'AreaComboBox
        '
        Me.AreaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AreaComboBox.FormattingEnabled = True
        Me.AreaComboBox.Items.AddRange(New Object() {"Machine", "Table"})
        Me.AreaComboBox.Location = New System.Drawing.Point(557, 2)
        Me.AreaComboBox.Name = "AreaComboBox"
        Me.AreaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.AreaComboBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(243, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Production Month"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(468, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Production Area"
        '
        'ProductionMonthTableAdapter
        '
        Me.ProductionMonthTableAdapter.ClearBeforeFill = True
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'frmPrintProductionHour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 393)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AreaComboBox)
        Me.Controls.Add(Me.ProductionMonthComboBox)
        Me.Controls.Add(Me.PrintProductionHourDataGridView)
        Me.Controls.Add(Me.PrintProductionHourBindingNavigator)
        Me.Name = "frmPrintProductionHour"
        Me.Text = "Print Production Hour"
        CType(Me.PrintProductionHourBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PrintProductionHourBindingNavigator.ResumeLayout(False)
        Me.PrintProductionHourBindingNavigator.PerformLayout()
        CType(Me.PrintProductionHourBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintProductionHourDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintProductionHourDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionMonthBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionMonthDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintProductionHourDataSet As KSoft_Apparel.PrintProductionHourDataSet
    Friend WithEvents PrintProductionHourBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintProductionHourTableAdapter As KSoft_Apparel.PrintProductionHourDataSetTableAdapters.PrintProductionHourTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.PrintProductionHourDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PrintProductionHourBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintProductionHourBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintProductionHourDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ProductionMonthComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AreaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProductionMonthDataSet As KSoft_Apparel.ProductionMonthDataSet
    Friend WithEvents ProductionMonthBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductionMonthTableAdapter As KSoft_Apparel.ProductionMonthDataSetTableAdapters.ProductionMonthTableAdapter
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ProductionHour As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MakeIn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
