<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderQuantity
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
        Me.Color_Size_OrderQuantityDataSet = New KSoft_Apparel.Color_Size_OrderQuantityDataSet
        Me.Color_Size_OrderQuantityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Color_Size_OrderQuantityTableAdapter = New KSoft_Apparel.Color_Size_OrderQuantityDataSetTableAdapters.Color_Size_OrderQuantityTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.Color_Size_OrderQuantityDataSetTableAdapters.TableAdapterManager
        Me.Color_Size_OrderQuantityDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OKButton = New System.Windows.Forms.Button
        Me.DialogCancelButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.OrderQuantityLabel = New System.Windows.Forms.Label
        CType(Me.Color_Size_OrderQuantityDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Color_Size_OrderQuantityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Color_Size_OrderQuantityDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Color_Size_OrderQuantityDataSet
        '
        Me.Color_Size_OrderQuantityDataSet.DataSetName = "Color_Size_OrderQuantityDataSet"
        Me.Color_Size_OrderQuantityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Color_Size_OrderQuantityBindingSource
        '
        Me.Color_Size_OrderQuantityBindingSource.DataMember = "Color_Size_OrderQuantity"
        Me.Color_Size_OrderQuantityBindingSource.DataSource = Me.Color_Size_OrderQuantityDataSet
        '
        'Color_Size_OrderQuantityTableAdapter
        '
        Me.Color_Size_OrderQuantityTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.Color_Size_OrderQuantityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Color_Size_OrderQuantityDataGridView
        '
        Me.Color_Size_OrderQuantityDataGridView.AllowUserToAddRows = False
        Me.Color_Size_OrderQuantityDataGridView.AllowUserToDeleteRows = False
        Me.Color_Size_OrderQuantityDataGridView.AutoGenerateColumns = False
        Me.Color_Size_OrderQuantityDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Color_Size_OrderQuantityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Color_Size_OrderQuantityDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Color_Size_OrderQuantityDataGridView.DataSource = Me.Color_Size_OrderQuantityBindingSource
        Me.Color_Size_OrderQuantityDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Color_Size_OrderQuantityDataGridView.Name = "Color_Size_OrderQuantityDataGridView"
        Me.Color_Size_OrderQuantityDataGridView.Size = New System.Drawing.Size(399, 246)
        Me.Color_Size_OrderQuantityDataGridView.TabIndex = 1
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "CheckBoxColumn"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "#"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SizeCode"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Size"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "OrderQuantity"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Order Quantity"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 200
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(316, 252)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 2
        Me.OKButton.Text = "&OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'DialogCancelButton
        '
        Me.DialogCancelButton.Location = New System.Drawing.Point(235, 252)
        Me.DialogCancelButton.Name = "DialogCancelButton"
        Me.DialogCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.DialogCancelButton.TabIndex = 3
        Me.DialogCancelButton.Text = "&Cancel"
        Me.DialogCancelButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total  :"
        '
        'OrderQuantityLabel
        '
        Me.OrderQuantityLabel.Location = New System.Drawing.Point(63, 257)
        Me.OrderQuantityLabel.Name = "OrderQuantityLabel"
        Me.OrderQuantityLabel.Size = New System.Drawing.Size(154, 15)
        Me.OrderQuantityLabel.TabIndex = 5
        Me.OrderQuantityLabel.Text = "0"
        Me.OrderQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmOrderQuantity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 281)
        Me.Controls.Add(Me.OrderQuantityLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DialogCancelButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.Color_Size_OrderQuantityDataGridView)
        Me.Name = "frmOrderQuantity"
        Me.Text = "Order Quantity"
        CType(Me.Color_Size_OrderQuantityDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Color_Size_OrderQuantityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Color_Size_OrderQuantityDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Color_Size_OrderQuantityDataSet As KSoft_Apparel.Color_Size_OrderQuantityDataSet
    Friend WithEvents Color_Size_OrderQuantityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Color_Size_OrderQuantityTableAdapter As KSoft_Apparel.Color_Size_OrderQuantityDataSetTableAdapters.Color_Size_OrderQuantityTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.Color_Size_OrderQuantityDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Color_Size_OrderQuantityDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents DialogCancelButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OrderQuantityLabel As System.Windows.Forms.Label
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
