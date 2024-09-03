<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFabricBOMColorupdate
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
        Me.FabricBOMColorListDataSet = New KSoft_Apparel.FabricBOMColorListDataSet()
        Me.FabricBOMColorListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricBOMColorListTableAdapter = New KSoft_Apparel.FabricBOMColorListDataSetTableAdapters.FabricBOMColorListTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.FabricBOMColorListDataSetTableAdapters.TableAdapterManager()
        Me.FabricBOMColorListGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricColorReference = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGarmentsColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColorCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NewFabColorGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.FabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricColorDataSet = New KSoft_Apparel.FabricColorDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NewGMTColorGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderFabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderFabricColorDataSet = New KSoft_Apparel.OrderFabricColorDataSet()
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FabricColorTableAdapter = New KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter()
        Me.OrderFabricColorTableAdapter = New KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.NewFabColorReferenceTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NewFabColorCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.FabricBOMColorListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBOMColorListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBOMColorListGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewFabColorGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewGMTColorGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FabricBOMColorListDataSet
        '
        Me.FabricBOMColorListDataSet.DataSetName = "FabricBOMColorListDataSet"
        Me.FabricBOMColorListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FabricBOMColorListBindingSource
        '
        Me.FabricBOMColorListBindingSource.DataMember = "FabricBOMColorList"
        Me.FabricBOMColorListBindingSource.DataSource = Me.FabricBOMColorListDataSet
        '
        'FabricBOMColorListTableAdapter
        '
        Me.FabricBOMColorListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.FabricBOMColorListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FabricBOMColorListGridControl
        '
        Me.FabricBOMColorListGridControl.DataSource = Me.FabricBOMColorListBindingSource
        Me.FabricBOMColorListGridControl.Location = New System.Drawing.Point(12, 37)
        Me.FabricBOMColorListGridControl.MainView = Me.GridView1
        Me.FabricBOMColorListGridControl.Name = "FabricBOMColorListGridControl"
        Me.FabricBOMColorListGridControl.Size = New System.Drawing.Size(758, 254)
        Me.FabricBOMColorListGridControl.TabIndex = 2
        Me.FabricBOMColorListGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColor, Me.colFabricColorReference, Me.colGarmentsColor, Me.colColorCode})
        Me.GridView1.GridControl = Me.FabricBOMColorListGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colFabricColor
        '
        Me.colFabricColor.FieldName = "FabricColor"
        Me.colFabricColor.Name = "colFabricColor"
        Me.colFabricColor.Visible = True
        Me.colFabricColor.VisibleIndex = 0
        '
        'colFabricColorReference
        '
        Me.colFabricColorReference.FieldName = "FabricColorReference"
        Me.colFabricColorReference.Name = "colFabricColorReference"
        Me.colFabricColorReference.Visible = True
        Me.colFabricColorReference.VisibleIndex = 2
        '
        'colGarmentsColor
        '
        Me.colGarmentsColor.FieldName = "GarmentsColor"
        Me.colGarmentsColor.Name = "colGarmentsColor"
        Me.colGarmentsColor.Visible = True
        Me.colGarmentsColor.VisibleIndex = 3
        '
        'colColorCode
        '
        Me.colColorCode.FieldName = "ColorCode"
        Me.colColorCode.Name = "colColorCode"
        Me.colColorCode.Visible = True
        Me.colColorCode.VisibleIndex = 1
        '
        'NewFabColorGridLookUpEdit
        '
        Me.NewFabColorGridLookUpEdit.Location = New System.Drawing.Point(145, 363)
        Me.NewFabColorGridLookUpEdit.Name = "NewFabColorGridLookUpEdit"
        Me.NewFabColorGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NewFabColorGridLookUpEdit.Properties.DataSource = Me.FabricColorBindingSource
        Me.NewFabColorGridLookUpEdit.Properties.DisplayMember = "FabricColorName"
        Me.NewFabColorGridLookUpEdit.Properties.NullText = ""
        Me.NewFabColorGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.NewFabColorGridLookUpEdit.Properties.ValueMember = "FabricColorId"
        Me.NewFabColorGridLookUpEdit.Size = New System.Drawing.Size(252, 20)
        Me.NewFabColorGridLookUpEdit.TabIndex = 3
        '
        'FabricColorBindingSource
        '
        Me.FabricColorBindingSource.DataMember = "FabricColor"
        Me.FabricColorBindingSource.DataSource = Me.FabricColorDataSet
        '
        'FabricColorDataSet
        '
        Me.FabricColorDataSet.DataSetName = "FabricColorDataSet"
        Me.FabricColorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorName})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorName
        '
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        Me.colFabricColorName.Visible = True
        Me.colFabricColorName.VisibleIndex = 0
        '
        'NewGMTColorGridLookUpEdit
        '
        Me.NewGMTColorGridLookUpEdit.Location = New System.Drawing.Point(145, 337)
        Me.NewGMTColorGridLookUpEdit.Name = "NewGMTColorGridLookUpEdit"
        Me.NewGMTColorGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NewGMTColorGridLookUpEdit.Properties.DataSource = Me.OrderFabricColorBindingSource
        Me.NewGMTColorGridLookUpEdit.Properties.DisplayMember = "FabricColorName"
        Me.NewGMTColorGridLookUpEdit.Properties.NullText = ""
        Me.NewGMTColorGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit2View
        Me.NewGMTColorGridLookUpEdit.Properties.ValueMember = "FabricColorId"
        Me.NewGMTColorGridLookUpEdit.Size = New System.Drawing.Size(252, 20)
        Me.NewGMTColorGridLookUpEdit.TabIndex = 4
        '
        'OrderFabricColorBindingSource
        '
        Me.OrderFabricColorBindingSource.DataMember = "OrderFabricColor"
        Me.OrderFabricColorBindingSource.DataSource = Me.OrderFabricColorDataSet
        '
        'OrderFabricColorDataSet
        '
        Me.OrderFabricColorDataSet.DataSetName = "OrderFabricColorDataSet"
        Me.OrderFabricColorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit2View
        '
        Me.GridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorName1})
        Me.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View.Name = "GridLookUpEdit2View"
        Me.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorName1
        '
        Me.colFabricColorName1.FieldName = "FabricColorName"
        Me.colFabricColorName1.Name = "colFabricColorName1"
        Me.colFabricColorName1.Visible = True
        Me.colFabricColorName1.VisibleIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 366)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fabric Color :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Garments Color :"
        '
        'FabricColorTableAdapter
        '
        Me.FabricColorTableAdapter.ClearBeforeFill = True
        '
        'OrderFabricColorTableAdapter
        '
        Me.OrderFabricColorTableAdapter.ClearBeforeFill = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(488, 368)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(215, 41)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(99, 35)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(111, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(100, 35)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'NewFabColorReferenceTextBox
        '
        Me.NewFabColorReferenceTextBox.Location = New System.Drawing.Point(145, 415)
        Me.NewFabColorReferenceTextBox.Name = "NewFabColorReferenceTextBox"
        Me.NewFabColorReferenceTextBox.Size = New System.Drawing.Size(252, 20)
        Me.NewFabColorReferenceTextBox.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 420)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fabric Color Reference :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 392)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fabric Color Code:"
        '
        'NewFabColorCodeTextBox
        '
        Me.NewFabColorCodeTextBox.Location = New System.Drawing.Point(145, 389)
        Me.NewFabColorCodeTextBox.Name = "NewFabColorCodeTextBox"
        Me.NewFabColorCodeTextBox.Size = New System.Drawing.Size(252, 20)
        Me.NewFabColorCodeTextBox.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "1. Select Color which you want to change"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 309)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "2. Select New Color Information"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(445, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(267, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "3.  Press  OK if accepted or You can cancel to decline."
        '
        'frmFabricBOMColorupdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 452)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NewFabColorCodeTextBox)
        Me.Controls.Add(Me.NewFabColorReferenceTextBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NewGMTColorGridLookUpEdit)
        Me.Controls.Add(Me.NewFabColorGridLookUpEdit)
        Me.Controls.Add(Me.FabricBOMColorListGridControl)
        Me.Name = "frmFabricBOMColorupdate"
        Me.Text = "Fabric BOM Color Update"
        CType(Me.FabricBOMColorListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBOMColorListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBOMColorListGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewFabColorGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewGMTColorGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FabricBOMColorListDataSet As FabricBOMColorListDataSet
    Friend WithEvents FabricBOMColorListBindingSource As BindingSource
    Friend WithEvents FabricBOMColorListTableAdapter As FabricBOMColorListDataSetTableAdapters.FabricBOMColorListTableAdapter
    Friend WithEvents TableAdapterManager As FabricBOMColorListDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FabricBOMColorListGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGarmentsColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NewFabColorGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NewGMTColorGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FabricColorDataSet As FabricColorDataSet
    Friend WithEvents FabricColorBindingSource As BindingSource
    Friend WithEvents FabricColorTableAdapter As FabricColorDataSetTableAdapters.FabricColorTableAdapter
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderFabricColorBindingSource As BindingSource
    Friend WithEvents OrderFabricColorDataSet As OrderFabricColorDataSet
    Friend WithEvents colFabricColorName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderFabricColorTableAdapter As OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents colFabricColorReference As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NewFabColorReferenceTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NewFabColorCodeTextBox As TextBox
    Friend WithEvents colColorCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
