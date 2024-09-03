<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterProgramLookUp
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
        Me.MasterProgramLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasterProgramLookUpDataSet = New KSoft_Apparel.MasterProgramLookUpDataSet
        Me.MasterProgramLookUpTableAdapter = New KSoft_Apparel.MasterProgramLookUpDataSetTableAdapters.MasterProgramLookUpTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.MasterProgramLookUpDataSetTableAdapters.TableAdapterManager
        Me.MasterProgramLookUpGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colMasterProgramNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMasterOrderId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramCode = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.MasterProgramLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterProgramLookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterProgramLookUpGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MasterProgramLookUpBindingSource
        '
        Me.MasterProgramLookUpBindingSource.DataMember = "MasterProgramLookUp"
        Me.MasterProgramLookUpBindingSource.DataSource = Me.MasterProgramLookUpDataSet
        '
        'MasterProgramLookUpDataSet
        '
        Me.MasterProgramLookUpDataSet.DataSetName = "MasterProgramLookUpDataSet"
        Me.MasterProgramLookUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MasterProgramLookUpTableAdapter
        '
        Me.MasterProgramLookUpTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.MasterProgramLookUpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MasterProgramLookUpGridControl
        '
        Me.MasterProgramLookUpGridControl.DataSource = Me.MasterProgramLookUpBindingSource
        Me.MasterProgramLookUpGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MasterProgramLookUpGridControl.Location = New System.Drawing.Point(0, 0)
        Me.MasterProgramLookUpGridControl.MainView = Me.GridView1
        Me.MasterProgramLookUpGridControl.Name = "MasterProgramLookUpGridControl"
        Me.MasterProgramLookUpGridControl.Size = New System.Drawing.Size(737, 419)
        Me.MasterProgramLookUpGridControl.TabIndex = 0
        Me.MasterProgramLookUpGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMasterProgramNo, Me.colMasterOrderId, Me.colProgramNo, Me.colBuyerName, Me.colStyleName, Me.colProgramCode})
        Me.GridView1.GridControl = Me.MasterProgramLookUpGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colMasterProgramNo
        '
        Me.colMasterProgramNo.FieldName = "MasterProgramNo"
        Me.colMasterProgramNo.Name = "colMasterProgramNo"
        Me.colMasterProgramNo.OptionsColumn.AllowEdit = False
        Me.colMasterProgramNo.OptionsColumn.ReadOnly = True
        Me.colMasterProgramNo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colMasterProgramNo.Visible = True
        Me.colMasterProgramNo.VisibleIndex = 1
        '
        'colMasterOrderId
        '
        Me.colMasterOrderId.FieldName = "MasterOrderId"
        Me.colMasterOrderId.Name = "colMasterOrderId"
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.OptionsColumn.AllowEdit = False
        Me.colProgramNo.OptionsColumn.ReadOnly = True
        Me.colProgramNo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 0
        '
        'colBuyerName
        '
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.OptionsColumn.AllowEdit = False
        Me.colBuyerName.OptionsColumn.ReadOnly = True
        Me.colBuyerName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 2
        '
        'colStyleName
        '
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.OptionsColumn.AllowEdit = False
        Me.colStyleName.OptionsColumn.ReadOnly = True
        Me.colStyleName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 3
        '
        'colProgramCode
        '
        Me.colProgramCode.FieldName = "ProgramCode"
        Me.colProgramCode.Name = "colProgramCode"
        '
        'frmMasterProgramLookUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 419)
        Me.Controls.Add(Me.MasterProgramLookUpGridControl)
        Me.Name = "frmMasterProgramLookUp"
        Me.Text = "Master Program Lookup"
        Me.TopMost = True
        CType(Me.MasterProgramLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterProgramLookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterProgramLookUpGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MasterProgramLookUpDataSet As KSoft_Apparel.MasterProgramLookUpDataSet
    Friend WithEvents MasterProgramLookUpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MasterProgramLookUpTableAdapter As KSoft_Apparel.MasterProgramLookUpDataSetTableAdapters.MasterProgramLookUpTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.MasterProgramLookUpDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MasterProgramLookUpGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMasterProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMasterOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramCode As DevExpress.XtraGrid.Columns.GridColumn
End Class
