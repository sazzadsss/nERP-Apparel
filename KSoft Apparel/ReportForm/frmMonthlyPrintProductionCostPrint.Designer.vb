<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonthlyPrintProductionCostPrint
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ProductionMonthBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionMonthDataSet = New KSoft_Apparel.ProductionMonthDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProductionMonthId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductionMonth = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductionYear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductionMonthName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductionMonthTableAdapter = New KSoft_Apparel.ProductionMonthDataSetTableAdapters.ProductionMonthTableAdapter()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.GridLookUpEdit2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShowByProgramButton = New System.Windows.Forms.Button()
        Me.StyleGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.StyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleLookupDataSet = New KSoft_Apparel.StyleLookupDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStyleId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDefaultTarget = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSMV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StyleButton = New System.Windows.Forms.Button()
        Me.StyleTableAdapter = New KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleTableAdapter()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SampleCheckBox = New System.Windows.Forms.CheckBox()
        Me.ShowExposeButton = New System.Windows.Forms.Button()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionMonthBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionMonthDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 65)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1021, 354)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(60, 4)
        Me.GridLookUpEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.ProductionMonthBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "ProductionMonthName"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = "[Select Month]"
        Me.GridLookUpEdit1.Properties.ValueMember = "ProductionMonthId"
        Me.GridLookUpEdit1.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(97, 20)
        Me.GridLookUpEdit1.TabIndex = 1
        '
        'ProductionMonthBindingSource
        '
        Me.ProductionMonthBindingSource.DataMember = "ProductionMonth"
        Me.ProductionMonthBindingSource.DataSource = Me.ProductionMonthDataSet
        '
        'ProductionMonthDataSet
        '
        Me.ProductionMonthDataSet.DataSetName = "ProductionMonthDataSet"
        Me.ProductionMonthDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductionMonthId, Me.colProductionMonth, Me.colProductionYear, Me.colRemarks, Me.colProductionMonthName})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colProductionMonthId
        '
        Me.colProductionMonthId.FieldName = "ProductionMonthId"
        Me.colProductionMonthId.Name = "colProductionMonthId"
        Me.colProductionMonthId.OptionsColumn.ReadOnly = True
        '
        'colProductionMonth
        '
        Me.colProductionMonth.FieldName = "ProductionMonth"
        Me.colProductionMonth.Name = "colProductionMonth"
        '
        'colProductionYear
        '
        Me.colProductionYear.FieldName = "ProductionYear"
        Me.colProductionYear.Name = "colProductionYear"
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        '
        'colProductionMonthName
        '
        Me.colProductionMonthName.FieldName = "ProductionMonthName"
        Me.colProductionMonthName.Name = "colProductionMonthName"
        Me.colProductionMonthName.Visible = True
        Me.colProductionMonthName.VisibleIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 7, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Month"
        '
        'ProductionMonthTableAdapter
        '
        Me.ProductionMonthTableAdapter.ClearBeforeFill = True
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(230, 3)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(134, 23)
        Me.ShowButton.TabIndex = 3
        Me.ShowButton.Text = "&Show Chemical Costing"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'GridLookUpEdit2
        '
        Me.GridLookUpEdit2.Location = New System.Drawing.Point(582, 4)
        Me.GridLookUpEdit2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.GridLookUpEdit2.Name = "GridLookUpEdit2"
        Me.GridLookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit2.Properties.DataSource = Me.OrderLookupBindingSource
        Me.GridLookUpEdit2.Properties.DisplayMember = "Details"
        Me.GridLookUpEdit2.Properties.ImmediatePopup = True
        Me.GridLookUpEdit2.Properties.NullText = "[Select Program]"
        Me.GridLookUpEdit2.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit2.Properties.ValueMember = "OrderId"
        Me.GridLookUpEdit2.Properties.View = Me.GridView1
        Me.GridLookUpEdit2.Size = New System.Drawing.Size(103, 20)
        Me.GridLookUpEdit2.TabIndex = 4
        '
        'OrderLookupBindingSource
        '
        Me.OrderLookupBindingSource.DataMember = "OrderLookup"
        Me.OrderLookupBindingSource.DataSource = Me.OrderLookupDataSet
        '
        'OrderLookupDataSet
        '
        Me.OrderLookupDataSet.DataSetName = "OrderLookupDataSet"
        Me.OrderLookupDataSet.EnforceConstraints = False
        Me.OrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(503, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 7, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Program No"
        '
        'ShowByProgramButton
        '
        Me.ShowByProgramButton.Location = New System.Drawing.Point(691, 3)
        Me.ShowByProgramButton.Name = "ShowByProgramButton"
        Me.ShowByProgramButton.Size = New System.Drawing.Size(68, 23)
        Me.ShowByProgramButton.TabIndex = 6
        Me.ShowByProgramButton.Text = "&Show"
        Me.ShowByProgramButton.UseVisualStyleBackColor = True
        '
        'StyleGridLookUpEdit
        '
        Me.StyleGridLookUpEdit.Location = New System.Drawing.Point(806, 4)
        Me.StyleGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.StyleGridLookUpEdit.Name = "StyleGridLookUpEdit"
        Me.StyleGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StyleGridLookUpEdit.Properties.DataSource = Me.StyleBindingSource
        Me.StyleGridLookUpEdit.Properties.DisplayMember = "StyleName"
        Me.StyleGridLookUpEdit.Properties.ImmediatePopup = True
        Me.StyleGridLookUpEdit.Properties.NullText = "[Type Style]"
        Me.StyleGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.StyleGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.StyleGridLookUpEdit.Properties.ValueMember = "StyleId"
        Me.StyleGridLookUpEdit.Properties.View = Me.GridView2
        Me.StyleGridLookUpEdit.Size = New System.Drawing.Size(103, 20)
        Me.StyleGridLookUpEdit.TabIndex = 7
        '
        'StyleBindingSource
        '
        Me.StyleBindingSource.DataMember = "Style"
        Me.StyleBindingSource.DataSource = Me.StyleLookupDataSet
        '
        'StyleLookupDataSet
        '
        Me.StyleLookupDataSet.DataSetName = "StyleLookupDataSet"
        Me.StyleLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStyleId, Me.colStyleName, Me.colBuyerId, Me.colDefaultTarget, Me.colSMV})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colStyleId
        '
        Me.colStyleId.FieldName = "StyleId"
        Me.colStyleId.Name = "colStyleId"
        Me.colStyleId.OptionsColumn.ReadOnly = True
        '
        'colStyleName
        '
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 0
        '
        'colBuyerId
        '
        Me.colBuyerId.FieldName = "BuyerId"
        Me.colBuyerId.Name = "colBuyerId"
        '
        'colDefaultTarget
        '
        Me.colDefaultTarget.FieldName = "DefaultTarget"
        Me.colDefaultTarget.Name = "colDefaultTarget"
        '
        'colSMV
        '
        Me.colSMV.FieldName = "SMV"
        Me.colSMV.Name = "colSMV"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(765, 7)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 7, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Style"
        '
        'StyleButton
        '
        Me.StyleButton.Location = New System.Drawing.Point(915, 3)
        Me.StyleButton.Name = "StyleButton"
        Me.StyleButton.Size = New System.Drawing.Size(76, 23)
        Me.StyleButton.TabIndex = 9
        Me.StyleButton.Text = "&Show"
        Me.StyleButton.UseVisualStyleBackColor = True
        '
        'StyleTableAdapter
        '
        Me.StyleTableAdapter.ClearBeforeFill = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.GridLookUpEdit1)
        Me.FlowLayoutPanel1.Controls.Add(Me.SampleCheckBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.ShowButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.ShowExposeButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.GridLookUpEdit2)
        Me.FlowLayoutPanel1.Controls.Add(Me.ShowByProgramButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.StyleGridLookUpEdit)
        Me.FlowLayoutPanel1.Controls.Add(Me.StyleButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1020, 29)
        Me.FlowLayoutPanel1.TabIndex = 10
        '
        'SampleCheckBox
        '
        Me.SampleCheckBox.AutoSize = True
        Me.SampleCheckBox.Location = New System.Drawing.Point(163, 7)
        Me.SampleCheckBox.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.SampleCheckBox.Name = "SampleCheckBox"
        Me.SampleCheckBox.Size = New System.Drawing.Size(61, 17)
        Me.SampleCheckBox.TabIndex = 10
        Me.SampleCheckBox.Text = "Sample"
        Me.SampleCheckBox.UseVisualStyleBackColor = True
        '
        'ShowExposeButton
        '
        Me.ShowExposeButton.Location = New System.Drawing.Point(370, 3)
        Me.ShowExposeButton.Name = "ShowExposeButton"
        Me.ShowExposeButton.Size = New System.Drawing.Size(127, 23)
        Me.ShowExposeButton.TabIndex = 11
        Me.ShowExposeButton.Text = "&Show Expose Costing"
        Me.ShowExposeButton.UseVisualStyleBackColor = True
        '
        'frmMonthlyPrintProductionCostPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 418)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmMonthlyPrintProductionCostPrint"
        Me.Text = "Monthly Print Production Cost Print"
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionMonthBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionMonthDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProductionMonthDataSet As KSoft_Apparel.ProductionMonthDataSet
    Friend WithEvents ProductionMonthBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductionMonthTableAdapter As KSoft_Apparel.ProductionMonthDataSetTableAdapters.ProductionMonthTableAdapter
    Friend WithEvents colProductionMonthId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionMonth As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionYear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionMonthName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents GridLookUpEdit2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShowByProgramButton As System.Windows.Forms.Button
    Friend WithEvents StyleGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StyleButton As System.Windows.Forms.Button
    Friend WithEvents StyleLookupDataSet As KSoft_Apparel.StyleLookupDataSet
    Friend WithEvents StyleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleTableAdapter As KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleTableAdapter
    Friend WithEvents colStyleId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDefaultTarget As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSMV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents SampleCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ShowExposeButton As System.Windows.Forms.Button
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
End Class
