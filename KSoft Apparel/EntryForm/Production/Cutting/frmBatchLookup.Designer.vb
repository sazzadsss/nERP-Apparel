<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBatchLookup
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
        Me.BatchLookupDataSet = New KSoft_Apparel.BatchLookupDataSet
        Me.BatchLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BatchLookupTableAdapter = New KSoft_Apparel.BatchLookupDataSetTableAdapters.BatchLookupTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.BatchLookupDataSetTableAdapters.TableAdapterManager
        Me.BatchLookupGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colBatchInformationId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBatchNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OKButton = New System.Windows.Forms.Button
        Me.CancelButton = New System.Windows.Forms.Button
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.BatchLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchLookupGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BatchLookupDataSet
        '
        Me.BatchLookupDataSet.DataSetName = "BatchLookupDataSet"
        Me.BatchLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BatchLookupBindingSource
        '
        Me.BatchLookupBindingSource.DataMember = "BatchLookup"
        Me.BatchLookupBindingSource.DataSource = Me.BatchLookupDataSet
        '
        'BatchLookupTableAdapter
        '
        Me.BatchLookupTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BatchLookupTableAdapter = Me.BatchLookupTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.BatchLookupDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BatchLookupGridControl
        '
        Me.BatchLookupGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BatchLookupGridControl.DataSource = Me.BatchLookupBindingSource
        Me.BatchLookupGridControl.Location = New System.Drawing.Point(0, 0)
        Me.BatchLookupGridControl.MainView = Me.GridView1
        Me.BatchLookupGridControl.Name = "BatchLookupGridControl"
        Me.BatchLookupGridControl.Size = New System.Drawing.Size(510, 207)
        Me.BatchLookupGridControl.TabIndex = 1
        Me.BatchLookupGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBatchInformationId, Me.colProgramNo, Me.colFabricColorName, Me.colBatchNo})
        Me.GridView1.GridControl = Me.BatchLookupGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colBatchInformationId
        '
        Me.colBatchInformationId.FieldName = "BatchInformationId"
        Me.colBatchInformationId.Name = "colBatchInformationId"
        Me.colBatchInformationId.OptionsColumn.ReadOnly = True
        '
        'colBatchNo
        '
        Me.colBatchNo.FieldName = "BatchNo"
        Me.colBatchNo.Name = "colBatchNo"
        Me.colBatchNo.Visible = True
        Me.colBatchNo.VisibleIndex = 2
        Me.colBatchNo.Width = 180
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(330, 213)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 2
        Me.OKButton.Text = "&OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(423, 213)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 3
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 0
        Me.colProgramNo.Width = 104
        '
        'colFabricColorName
        '
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        Me.colFabricColorName.Visible = True
        Me.colFabricColorName.VisibleIndex = 1
        Me.colFabricColorName.Width = 205
        '
        'frmBatchLookup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 245)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.BatchLookupGridControl)
        Me.Name = "frmBatchLookup"
        Me.Text = "Batch Lookup"
        CType(Me.BatchLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchLookupGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BatchLookupDataSet As KSoft_Apparel.BatchLookupDataSet
    Friend WithEvents BatchLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BatchLookupTableAdapter As KSoft_Apparel.BatchLookupDataSetTableAdapters.BatchLookupTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.BatchLookupDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BatchLookupGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBatchInformationId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBatchNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
End Class
