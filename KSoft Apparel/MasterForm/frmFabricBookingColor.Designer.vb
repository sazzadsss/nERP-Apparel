<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFabricBookingColor
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.FabricBookingColorSearchDataSet = New KSoft_Apparel.FabricBookingColorSearchDataSet
        Me.FabricBookingColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricBookingColorTableAdapter = New KSoft_Apparel.FabricBookingColorSearchDataSetTableAdapters.FabricBookingColorTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.FabricBookingColorSearchDataSetTableAdapters.TableAdapterManager
        Me.FabricBookingColorDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.FabricBookingColorSearchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBookingColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBookingColorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(266, 246)
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
        'FabricBookingColorSearchDataSet
        '
        Me.FabricBookingColorSearchDataSet.DataSetName = "FabricBookingColorSearchDataSet"
        Me.FabricBookingColorSearchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FabricBookingColorBindingSource
        '
        Me.FabricBookingColorBindingSource.DataMember = "FabricBookingColor"
        Me.FabricBookingColorBindingSource.DataSource = Me.FabricBookingColorSearchDataSet
        '
        'FabricBookingColorTableAdapter
        '
        Me.FabricBookingColorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.FabricBookingColorSearchDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FabricBookingColorDataGridView
        '
        Me.FabricBookingColorDataGridView.AllowUserToAddRows = False
        Me.FabricBookingColorDataGridView.AllowUserToDeleteRows = False
        Me.FabricBookingColorDataGridView.AutoGenerateColumns = False
        Me.FabricBookingColorDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.FabricBookingColorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FabricBookingColorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3})
        Me.FabricBookingColorDataGridView.DataSource = Me.FabricBookingColorBindingSource
        Me.FabricBookingColorDataGridView.Location = New System.Drawing.Point(-1, 1)
        Me.FabricBookingColorDataGridView.Name = "FabricBookingColorDataGridView"
        Me.FabricBookingColorDataGridView.ReadOnly = True
        Me.FabricBookingColorDataGridView.Size = New System.Drawing.Size(420, 240)
        Me.FabricBookingColorDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FabricColorName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fabric Color Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'FrmFabricBookingColor
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(418, 281)
        Me.Controls.Add(Me.FabricBookingColorDataGridView)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFabricBookingColor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Fabric Booking Color "
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.FabricBookingColorSearchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBookingColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBookingColorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents FabricBookingColorSearchDataSet As KSoft_Apparel.FabricBookingColorSearchDataSet
    Friend WithEvents FabricBookingColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricBookingColorTableAdapter As KSoft_Apparel.FabricBookingColorSearchDataSetTableAdapters.FabricBookingColorTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.FabricBookingColorSearchDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FabricBookingColorDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
