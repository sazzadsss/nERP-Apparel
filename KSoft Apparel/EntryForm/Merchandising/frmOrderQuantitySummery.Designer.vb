<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderQuantitySummery
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.OrderQuantitySummeryByEXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderQuantitySummeryByExDataSet = New KSoft_Apparel.OrderQuantitySummeryByExDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsSelected = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderQuantitySummeryByEXTableAdapter = New KSoft_Apparel.OrderQuantitySummeryByExDataSetTableAdapters.OrderQuantitySummeryByEXTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderQuantitySummeryByEXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderQuantitySummeryByExDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 277)
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
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.OrderQuantitySummeryByEXBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(2, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(432, 268)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'OrderQuantitySummeryByEXBindingSource
        '
        Me.OrderQuantitySummeryByEXBindingSource.DataMember = "OrderQuantitySummeryByEX"
        Me.OrderQuantitySummeryByEXBindingSource.DataSource = Me.OrderQuantitySummeryByExDataSet
        '
        'OrderQuantitySummeryByExDataSet
        '
        Me.OrderQuantitySummeryByExDataSet.DataSetName = "OrderQuantitySummeryByExDataSet"
        Me.OrderQuantitySummeryByExDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderQuantity, Me.colEX, Me.colIsSelected})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colOrderQuantity
        '
        Me.colOrderQuantity.DisplayFormat.FormatString = "n0"
        Me.colOrderQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colOrderQuantity.FieldName = "OrderQuantity"
        Me.colOrderQuantity.Name = "colOrderQuantity"
        Me.colOrderQuantity.OptionsColumn.AllowEdit = False
        Me.colOrderQuantity.OptionsColumn.ReadOnly = True
        Me.colOrderQuantity.Visible = True
        Me.colOrderQuantity.VisibleIndex = 2
        Me.colOrderQuantity.Width = 202
        '
        'colEX
        '
        Me.colEX.FieldName = "EX"
        Me.colEX.Name = "colEX"
        Me.colEX.OptionsColumn.AllowEdit = False
        Me.colEX.OptionsColumn.ReadOnly = True
        Me.colEX.Visible = True
        Me.colEX.VisibleIndex = 1
        Me.colEX.Width = 126
        '
        'colIsSelected
        '
        Me.colIsSelected.FieldName = "IsSelected"
        Me.colIsSelected.Name = "colIsSelected"
        Me.colIsSelected.Visible = True
        Me.colIsSelected.VisibleIndex = 0
        Me.colIsSelected.Width = 86
        '
        'OrderQuantitySummeryByEXTableAdapter
        '
        Me.OrderQuantitySummeryByEXTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Order Quantity"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(98, 281)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(102, 20)
        Me.NumericUpDown1.TabIndex = 3
        '
        'frmOrderQuantitySummery
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 315)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOrderQuantitySummery"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Order Quantity Summery"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderQuantitySummeryByEXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderQuantitySummeryByExDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OrderQuantitySummeryByEXBindingSource As BindingSource
    Friend WithEvents OrderQuantitySummeryByExDataSet As OrderQuantitySummeryByExDataSet
    Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderQuantitySummeryByEXTableAdapter As OrderQuantitySummeryByExDataSetTableAdapters.OrderQuantitySummeryByEXTableAdapter
    Friend WithEvents colIsSelected As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
End Class
