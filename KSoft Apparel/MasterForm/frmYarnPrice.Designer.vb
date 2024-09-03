<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYarnPrice
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
        Me.ItemListDataSet = New KSoft_Apparel.ItemListDataSet
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListTableAdapter = New KSoft_Apparel.ItemListDataSetTableAdapters.ItemListTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.ItemListDataSetTableAdapters.TableAdapterManager
        Me.ItemListGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQuantityPerPacket = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPreviousPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCurrentPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDollarPrice = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemListDataSet
        '
        Me.ItemListDataSet.DataSetName = "ItemListDataSet"
        Me.ItemListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemListBindingSource
        '
        Me.ItemListBindingSource.DataMember = "ItemList"
        Me.ItemListBindingSource.DataSource = Me.ItemListDataSet
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ItemListLookupTableAdapter = Nothing
        Me.TableAdapterManager.ItemListTableAdapter = Me.ItemListTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.ItemListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ItemListGridControl
        '
        Me.ItemListGridControl.DataSource = Me.ItemListBindingSource
        Me.ItemListGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemListGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ItemListGridControl.MainView = Me.GridView1
        Me.ItemListGridControl.Name = "ItemListGridControl"
        Me.ItemListGridControl.Size = New System.Drawing.Size(554, 446)
        Me.ItemListGridControl.TabIndex = 1
        Me.ItemListGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemName, Me.colQuantityPerPacket, Me.colPreviousPrice, Me.colCurrentPrice, Me.colDollarPrice})
        Me.GridView1.GridControl = Me.ItemListGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colItemName
        '
        Me.colItemName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colItemName.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colItemName.AppearanceCell.Options.UseBackColor = True
        Me.colItemName.FieldName = "ItemName"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.OptionsColumn.AllowEdit = False
        Me.colItemName.OptionsColumn.ReadOnly = True
        Me.colItemName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colItemName.Visible = True
        Me.colItemName.VisibleIndex = 0
        Me.colItemName.Width = 242
        '
        'colQuantityPerPacket
        '
        Me.colQuantityPerPacket.FieldName = "QuantityPerPacket"
        Me.colQuantityPerPacket.Name = "colQuantityPerPacket"
        Me.colQuantityPerPacket.Width = 116
        '
        'colPreviousPrice
        '
        Me.colPreviousPrice.FieldName = "PreviousPrice"
        Me.colPreviousPrice.Name = "colPreviousPrice"
        Me.colPreviousPrice.Visible = True
        Me.colPreviousPrice.VisibleIndex = 1
        Me.colPreviousPrice.Width = 122
        '
        'colCurrentPrice
        '
        Me.colCurrentPrice.FieldName = "CurrentPrice"
        Me.colCurrentPrice.Name = "colCurrentPrice"
        Me.colCurrentPrice.Visible = True
        Me.colCurrentPrice.VisibleIndex = 2
        Me.colCurrentPrice.Width = 125
        '
        'colDollarPrice
        '
        Me.colDollarPrice.FieldName = "DollarPrice"
        Me.colDollarPrice.Name = "colDollarPrice"
        Me.colDollarPrice.Visible = True
        Me.colDollarPrice.VisibleIndex = 3
        Me.colDollarPrice.Width = 154
        '
        'frmYarnPrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 446)
        Me.Controls.Add(Me.ItemListGridControl)
        Me.Name = "frmYarnPrice"
        Me.Text = "Yarn Price"
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ItemListDataSet As KSoft_Apparel.ItemListDataSet
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListTableAdapter As KSoft_Apparel.ItemListDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.ItemListDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemListGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantityPerPacket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPreviousPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrentPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDollarPrice As DevExpress.XtraGrid.Columns.GridColumn
End Class
