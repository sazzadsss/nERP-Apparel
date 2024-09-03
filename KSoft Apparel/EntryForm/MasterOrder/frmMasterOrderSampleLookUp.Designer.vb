<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterOrderSampleLookUp
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.MasterOrderSampleRequestLookUpDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MasterOrderSampleRequestLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasterOrderSampleLookUpDataSet = New KSoft_Apparel.MasterOrderSampleLookUpDataSet
        Me.MasterOrderSampleRequestLookUpTableAdapter = New KSoft_Apparel.MasterOrderSampleLookUpDataSetTableAdapters.MasterOrderSampleRequestLookUpTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.MasterOrderSampleLookUpDataSetTableAdapters.TableAdapterManager
        CType(Me.MasterOrderSampleRequestLookUpDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterOrderSampleRequestLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterOrderSampleLookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MasterOrderSampleRequestLookUpDataGridView
        '
        Me.MasterOrderSampleRequestLookUpDataGridView.AllowUserToAddRows = False
        Me.MasterOrderSampleRequestLookUpDataGridView.AllowUserToDeleteRows = False
        Me.MasterOrderSampleRequestLookUpDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MasterOrderSampleRequestLookUpDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MasterOrderSampleRequestLookUpDataGridView.ColumnHeadersHeight = 40
        Me.MasterOrderSampleRequestLookUpDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4})
        Me.MasterOrderSampleRequestLookUpDataGridView.DataSource = Me.MasterOrderSampleRequestLookUpBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MasterOrderSampleRequestLookUpDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.MasterOrderSampleRequestLookUpDataGridView.Location = New System.Drawing.Point(-1, -2)
        Me.MasterOrderSampleRequestLookUpDataGridView.Name = "MasterOrderSampleRequestLookUpDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MasterOrderSampleRequestLookUpDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MasterOrderSampleRequestLookUpDataGridView.Size = New System.Drawing.Size(500, 284)
        Me.MasterOrderSampleRequestLookUpDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SampleRequestNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SampleRequestNo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SampleRequestDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "SampleRequestDate"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MasterProgramNo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "MasterProgramNo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'MasterOrderSampleRequestLookUpBindingSource
        '
        Me.MasterOrderSampleRequestLookUpBindingSource.DataMember = "MasterOrderSampleRequestLookUp"
        Me.MasterOrderSampleRequestLookUpBindingSource.DataSource = Me.MasterOrderSampleLookUpDataSet
        '
        'MasterOrderSampleLookUpDataSet
        '
        Me.MasterOrderSampleLookUpDataSet.DataSetName = "MasterOrderSampleLookUpDataSet"
        Me.MasterOrderSampleLookUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MasterOrderSampleRequestLookUpTableAdapter
        '
        Me.MasterOrderSampleRequestLookUpTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.MasterOrderSampleLookUpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmMasterOrderSampleLookUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 280)
        Me.Controls.Add(Me.MasterOrderSampleRequestLookUpDataGridView)
        Me.Name = "frmMasterOrderSampleLookUp"
        Me.Text = "Master Order Sample LookUp"
        CType(Me.MasterOrderSampleRequestLookUpDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterOrderSampleRequestLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterOrderSampleLookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MasterOrderSampleLookUpDataSet As KSoft_Apparel.MasterOrderSampleLookUpDataSet
    Friend WithEvents MasterOrderSampleRequestLookUpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MasterOrderSampleRequestLookUpTableAdapter As KSoft_Apparel.MasterOrderSampleLookUpDataSetTableAdapters.MasterOrderSampleRequestLookUpTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.MasterOrderSampleLookUpDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MasterOrderSampleRequestLookUpDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
