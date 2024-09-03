<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderActivitiesCommentsHistory
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
        Me.OrderActivitiesCommentsDataSet = New KSoft_Apparel.OrderActivitiesCommentsDataSet
        Me.OrderActivitiesCommentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderActivitiesCommentsTableAdapter = New KSoft_Apparel.OrderActivitiesCommentsDataSetTableAdapters.OrderActivitiesCommentsTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.OrderActivitiesCommentsDataSetTableAdapters.TableAdapterManager
        Me.OrderActivitiesCommentsGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCommentsDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComments = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.OrderActivitiesCommentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderActivitiesCommentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderActivitiesCommentsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrderActivitiesCommentsDataSet
        '
        Me.OrderActivitiesCommentsDataSet.DataSetName = "OrderActivitiesCommentsDataSet"
        Me.OrderActivitiesCommentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderActivitiesCommentsBindingSource
        '
        Me.OrderActivitiesCommentsBindingSource.DataMember = "OrderActivitiesComments"
        Me.OrderActivitiesCommentsBindingSource.DataSource = Me.OrderActivitiesCommentsDataSet
        '
        'OrderActivitiesCommentsTableAdapter
        '
        Me.OrderActivitiesCommentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.OrderActivitiesCommentsTableAdapter = Me.OrderActivitiesCommentsTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.OrderActivitiesCommentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OrderActivitiesCommentsGridControl
        '
        Me.OrderActivitiesCommentsGridControl.DataSource = Me.OrderActivitiesCommentsBindingSource
        Me.OrderActivitiesCommentsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderActivitiesCommentsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.OrderActivitiesCommentsGridControl.MainView = Me.GridView1
        Me.OrderActivitiesCommentsGridControl.Name = "OrderActivitiesCommentsGridControl"
        Me.OrderActivitiesCommentsGridControl.Size = New System.Drawing.Size(824, 402)
        Me.OrderActivitiesCommentsGridControl.TabIndex = 1
        Me.OrderActivitiesCommentsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCommentsDate, Me.colComments})
        Me.GridView1.GridControl = Me.OrderActivitiesCommentsGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCommentsDate
        '
        Me.colCommentsDate.FieldName = "CommentsDate"
        Me.colCommentsDate.Name = "colCommentsDate"
        Me.colCommentsDate.Visible = True
        Me.colCommentsDate.VisibleIndex = 0
        Me.colCommentsDate.Width = 110
        '
        'colComments
        '
        Me.colComments.FieldName = "Comments"
        Me.colComments.Name = "colComments"
        Me.colComments.Visible = True
        Me.colComments.VisibleIndex = 1
        Me.colComments.Width = 509
        '
        'frmOrderActivitiesCommentsHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 402)
        Me.Controls.Add(Me.OrderActivitiesCommentsGridControl)
        Me.Name = "frmOrderActivitiesCommentsHistory"
        Me.Text = "Order Activities Comments History"
        CType(Me.OrderActivitiesCommentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderActivitiesCommentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderActivitiesCommentsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OrderActivitiesCommentsDataSet As KSoft_Apparel.OrderActivitiesCommentsDataSet
    Friend WithEvents OrderActivitiesCommentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderActivitiesCommentsTableAdapter As KSoft_Apparel.OrderActivitiesCommentsDataSetTableAdapters.OrderActivitiesCommentsTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.OrderActivitiesCommentsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrderActivitiesCommentsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommentsDate As DevExpress.XtraGrid.Columns.GridColumn
End Class
