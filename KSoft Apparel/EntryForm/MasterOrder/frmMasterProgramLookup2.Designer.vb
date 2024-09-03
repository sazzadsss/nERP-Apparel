<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterProgramLookup2
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
        Me.components = New System.ComponentModel.Container()
        Me.MasterOrderLookUpDataSet = New KSoft_Apparel.MasterOrderLookUpDataSet()
        Me.MasterOrderLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasterOrderLookUpTableAdapter = New KSoft_Apparel.MasterOrderLookUpDataSetTableAdapters.MasterOrderLookUpTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.MasterOrderLookUpDataSetTableAdapters.TableAdapterManager()
        Me.MasterOrderLookUpGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMasterProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyer = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.MasterOrderLookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterOrderLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterOrderLookUpGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MasterOrderLookUpDataSet
        '
        Me.MasterOrderLookUpDataSet.DataSetName = "MasterOrderLookUpDataSet"
        Me.MasterOrderLookUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MasterOrderLookUpBindingSource
        '
        Me.MasterOrderLookUpBindingSource.DataMember = "MasterOrderLookUp"
        Me.MasterOrderLookUpBindingSource.DataSource = Me.MasterOrderLookUpDataSet
        '
        'MasterOrderLookUpTableAdapter
        '
        Me.MasterOrderLookUpTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.MasterOrderLookUpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MasterOrderLookUpGridControl
        '
        Me.MasterOrderLookUpGridControl.DataSource = Me.MasterOrderLookUpBindingSource
        Me.MasterOrderLookUpGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MasterOrderLookUpGridControl.Location = New System.Drawing.Point(0, 0)
        Me.MasterOrderLookUpGridControl.MainView = Me.GridView1
        Me.MasterOrderLookUpGridControl.Name = "MasterOrderLookUpGridControl"
        Me.MasterOrderLookUpGridControl.Size = New System.Drawing.Size(474, 334)
        Me.MasterOrderLookUpGridControl.TabIndex = 1
        Me.MasterOrderLookUpGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMasterProgramNo, Me.colStyleNo, Me.colBuyer})
        Me.GridView1.GridControl = Me.MasterOrderLookUpGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colMasterProgramNo
        '
        Me.colMasterProgramNo.FieldName = "MasterProgramNo"
        Me.colMasterProgramNo.Name = "colMasterProgramNo"
        Me.colMasterProgramNo.Visible = True
        Me.colMasterProgramNo.VisibleIndex = 0
        '
        'colStyleNo
        '
        Me.colStyleNo.FieldName = "StyleNo"
        Me.colStyleNo.Name = "colStyleNo"
        Me.colStyleNo.Visible = True
        Me.colStyleNo.VisibleIndex = 1
        '
        'colBuyer
        '
        Me.colBuyer.FieldName = "Buyer"
        Me.colBuyer.Name = "colBuyer"
        Me.colBuyer.Visible = True
        Me.colBuyer.VisibleIndex = 2
        '
        'frmMasterProgramLookup2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 334)
        Me.Controls.Add(Me.MasterOrderLookUpGridControl)
        Me.Name = "frmMasterProgramLookup2"
        Me.Text = "Master Program Lookup "
        CType(Me.MasterOrderLookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterOrderLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterOrderLookUpGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MasterOrderLookUpDataSet As MasterOrderLookUpDataSet
    Friend WithEvents MasterOrderLookUpBindingSource As BindingSource
    Friend WithEvents MasterOrderLookUpTableAdapter As MasterOrderLookUpDataSetTableAdapters.MasterOrderLookUpTableAdapter
    Friend WithEvents TableAdapterManager As MasterOrderLookUpDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MasterOrderLookUpGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMasterProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyer As DevExpress.XtraGrid.Columns.GridColumn
End Class
