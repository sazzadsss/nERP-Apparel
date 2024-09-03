<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderExportToFR
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
        Me.ExportLinkLabel = New System.Windows.Forms.LinkLabel
        Me.OrderExportForFRDataSet = New KSoft_Apparel.OrderExportForFRDataSet
        Me.OrdersExportForFRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersExportForFRTableAdapter = New KSoft_Apparel.OrderExportForFRDataSetTableAdapters.OrdersExportForFRTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.OrderExportForFRDataSetTableAdapters.TableAdapterManager
        Me.OrdersExportForFRGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSynFR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colO_CODE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colO_PROD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colO_CUST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOrderDetailsId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.OrderExportForFRDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersExportForFRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersExportForFRGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExportLinkLabel
        '
        Me.ExportLinkLabel.AutoSize = True
        Me.ExportLinkLabel.Location = New System.Drawing.Point(251, 9)
        Me.ExportLinkLabel.Name = "ExportLinkLabel"
        Me.ExportLinkLabel.Size = New System.Drawing.Size(72, 13)
        Me.ExportLinkLabel.TabIndex = 2
        Me.ExportLinkLabel.TabStop = True
        Me.ExportLinkLabel.Text = "Export For FR"
        '
        'OrderExportForFRDataSet
        '
        Me.OrderExportForFRDataSet.DataSetName = "OrderExportForFRDataSet"
        Me.OrderExportForFRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdersExportForFRBindingSource
        '
        Me.OrdersExportForFRBindingSource.DataMember = "OrdersExportForFR"
        Me.OrdersExportForFRBindingSource.DataSource = Me.OrderExportForFRDataSet
        '
        'OrdersExportForFRTableAdapter
        '
        Me.OrdersExportForFRTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.OrderExportForFRDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OrdersExportForFRGridControl
        '
        Me.OrdersExportForFRGridControl.DataSource = Me.OrdersExportForFRBindingSource
        Me.OrdersExportForFRGridControl.Location = New System.Drawing.Point(2, 33)
        Me.OrdersExportForFRGridControl.MainView = Me.GridView1
        Me.OrdersExportForFRGridControl.Name = "OrdersExportForFRGridControl"
        Me.OrdersExportForFRGridControl.Size = New System.Drawing.Size(778, 444)
        Me.OrdersExportForFRGridControl.TabIndex = 3
        Me.OrdersExportForFRGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSynFR, Me.colO_CODE, Me.colO_PROD, Me.colO_CUST, Me.GridColumn1, Me.GridColumn2, Me.colOrderDetailsId})
        Me.GridView1.GridControl = Me.OrdersExportForFRGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colSynFR
        '
        Me.colSynFR.FieldName = "SynFR"
        Me.colSynFR.Name = "colSynFR"
        Me.colSynFR.Visible = True
        Me.colSynFR.VisibleIndex = 0
        '
        'colO_CODE
        '
        Me.colO_CODE.FieldName = "O_CODE"
        Me.colO_CODE.Name = "colO_CODE"
        Me.colO_CODE.OptionsColumn.ReadOnly = True
        Me.colO_CODE.Visible = True
        Me.colO_CODE.VisibleIndex = 1
        '
        'colO_PROD
        '
        Me.colO_PROD.FieldName = "O_PROD"
        Me.colO_PROD.Name = "colO_PROD"
        Me.colO_PROD.OptionsColumn.ReadOnly = True
        Me.colO_PROD.Visible = True
        Me.colO_PROD.VisibleIndex = 2
        '
        'colO_CUST
        '
        Me.colO_CUST.FieldName = "O_CUST"
        Me.colO_CUST.Name = "colO_CUST"
        Me.colO_CUST.Visible = True
        Me.colO_CUST.VisibleIndex = 3
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "O^DD:1"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "O^DQ:1"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 5
        '
        'colOrderDetailsId
        '
        Me.colOrderDetailsId.FieldName = "OrderDetailsId"
        Me.colOrderDetailsId.Name = "colOrderDetailsId"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Export To :  E:\FR_ImportFiles\ORDERS.TXT"
        '
        'frmOrderExportToFR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 478)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OrdersExportForFRGridControl)
        Me.Controls.Add(Me.ExportLinkLabel)
        Me.Name = "frmOrderExportToFR"
        Me.Text = "Order Export To FR"
        CType(Me.OrderExportForFRDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersExportForFRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersExportForFRGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExportLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents OrderExportForFRDataSet As KSoft_Apparel.OrderExportForFRDataSet
    Friend WithEvents OrdersExportForFRBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrdersExportForFRTableAdapter As KSoft_Apparel.OrderExportForFRDataSetTableAdapters.OrdersExportForFRTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.OrderExportForFRDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrdersExportForFRGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSynFR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colO_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colO_PROD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colO_CUST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
