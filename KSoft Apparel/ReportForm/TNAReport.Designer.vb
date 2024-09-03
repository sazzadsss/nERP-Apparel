<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TNAReport
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
        Me.ShowRunningButton = New DevExpress.XtraEditors.SimpleButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.LastUpdateLabel = New System.Windows.Forms.Label()
        Me.ReGenLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.TNAReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TNAReportDataSet = New KSoft_Apparel.TNAReportDataSet()
        Me.fieldSL1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTNAType1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTNAYear1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTNAMonth1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBuyerCode1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldStyle1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProgramNo1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTNADate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTNAQuantity1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTNAWeek1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.TNAReportTableAdapter = New KSoft_Apparel.TNAReportDataSetTableAdapters.TNAReportTableAdapter()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PivotGridControl2 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.ProductonReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionReportDataSet = New KSoft_Apparel.ProductionReportDataSet()
        Me.fieldSL2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProductionType1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProdYear1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProdMonth1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProdWeek1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBuyerName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldStyleName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProgramNo2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProdDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProdQuantity1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.ProductonReportTableAdapter = New KSoft_Apparel.ProductionReportDataSetTableAdapters.ProductonReportTableAdapter()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TNAReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TNAReportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PivotGridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductonReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionReportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShowRunningButton
        '
        Me.ShowRunningButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ShowRunningButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.ShowRunningButton.Location = New System.Drawing.Point(12, 5)
        Me.ShowRunningButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.ShowRunningButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ShowRunningButton.Name = "ShowRunningButton"
        Me.ShowRunningButton.Size = New System.Drawing.Size(98, 22)
        Me.ShowRunningButton.TabIndex = 80
        Me.ShowRunningButton.Text = "&Show"
        '
        'BackgroundWorker1
        '
        '
        'LastUpdateLabel
        '
        Me.LastUpdateLabel.AutoSize = True
        Me.LastUpdateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastUpdateLabel.ForeColor = System.Drawing.Color.Red
        Me.LastUpdateLabel.Location = New System.Drawing.Point(554, 9)
        Me.LastUpdateLabel.Name = "LastUpdateLabel"
        Me.LastUpdateLabel.Size = New System.Drawing.Size(11, 13)
        Me.LastUpdateLabel.TabIndex = 82
        Me.LastUpdateLabel.Text = "-"
        '
        'ReGenLinkLabel
        '
        Me.ReGenLinkLabel.AutoSize = True
        Me.ReGenLinkLabel.Location = New System.Drawing.Point(466, 9)
        Me.ReGenLinkLabel.Name = "ReGenLinkLabel"
        Me.ReGenLinkLabel.Size = New System.Drawing.Size(63, 13)
        Me.ReGenLinkLabel.TabIndex = 81
        Me.ReGenLinkLabel.TabStop = True
        Me.ReGenLinkLabel.Text = "Regenerate"
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataSource = Me.TNAReportBindingSource
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldSL1, Me.fieldTNAType1, Me.fieldTNAYear1, Me.fieldTNAMonth1, Me.fieldBuyerCode1, Me.fieldStyle1, Me.fieldProgramNo1, Me.fieldTNADate1, Me.fieldTNAQuantity1, Me.fieldTNAWeek1})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(799, 208)
        Me.PivotGridControl1.TabIndex = 83
        '
        'TNAReportBindingSource
        '
        Me.TNAReportBindingSource.DataMember = "TNAReport"
        Me.TNAReportBindingSource.DataSource = Me.TNAReportDataSet
        '
        'TNAReportDataSet
        '
        Me.TNAReportDataSet.DataSetName = "TNAReportDataSet"
        Me.TNAReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldSL1
        '
        Me.fieldSL1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldSL1.AreaIndex = 1
        Me.fieldSL1.Caption = "SL"
        Me.fieldSL1.FieldName = "SL"
        Me.fieldSL1.Name = "fieldSL1"
        Me.fieldSL1.Width = 50
        '
        'fieldTNAType1
        '
        Me.fieldTNAType1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldTNAType1.AreaIndex = 2
        Me.fieldTNAType1.Caption = "TNA Type"
        Me.fieldTNAType1.FieldName = "TNAType"
        Me.fieldTNAType1.Name = "fieldTNAType1"
        Me.fieldTNAType1.Width = 120
        '
        'fieldTNAYear1
        '
        Me.fieldTNAYear1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldTNAYear1.AreaIndex = 0
        Me.fieldTNAYear1.Caption = "TNA Year"
        Me.fieldTNAYear1.FieldName = "TNAYear"
        Me.fieldTNAYear1.Name = "fieldTNAYear1"
        '
        'fieldTNAMonth1
        '
        Me.fieldTNAMonth1.AreaIndex = 0
        Me.fieldTNAMonth1.Caption = "TNA Month"
        Me.fieldTNAMonth1.FieldName = "TNAMonth"
        Me.fieldTNAMonth1.Name = "fieldTNAMonth1"
        '
        'fieldBuyerCode1
        '
        Me.fieldBuyerCode1.AreaIndex = 1
        Me.fieldBuyerCode1.Caption = "Buyer Code"
        Me.fieldBuyerCode1.FieldName = "BuyerCode"
        Me.fieldBuyerCode1.Name = "fieldBuyerCode1"
        '
        'fieldStyle1
        '
        Me.fieldStyle1.AreaIndex = 2
        Me.fieldStyle1.Caption = "Style"
        Me.fieldStyle1.FieldName = "Style"
        Me.fieldStyle1.Name = "fieldStyle1"
        '
        'fieldProgramNo1
        '
        Me.fieldProgramNo1.AreaIndex = 3
        Me.fieldProgramNo1.Caption = "Program No"
        Me.fieldProgramNo1.FieldName = "ProgramNo"
        Me.fieldProgramNo1.Name = "fieldProgramNo1"
        '
        'fieldTNADate1
        '
        Me.fieldTNADate1.AreaIndex = 4
        Me.fieldTNADate1.Caption = "TNADate"
        Me.fieldTNADate1.FieldName = "TNADate"
        Me.fieldTNADate1.Name = "fieldTNADate1"
        '
        'fieldTNAQuantity1
        '
        Me.fieldTNAQuantity1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldTNAQuantity1.AreaIndex = 0
        Me.fieldTNAQuantity1.Caption = "TNA Quantity"
        Me.fieldTNAQuantity1.FieldName = "TNAQuantity"
        Me.fieldTNAQuantity1.Name = "fieldTNAQuantity1"
        '
        'fieldTNAWeek1
        '
        Me.fieldTNAWeek1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldTNAWeek1.AreaIndex = 0
        Me.fieldTNAWeek1.Caption = "TNA Week"
        Me.fieldTNAWeek1.FieldName = "TNAWeek"
        Me.fieldTNAWeek1.Name = "fieldTNAWeek1"
        '
        'TNAReportTableAdapter
        '
        Me.TNAReportTableAdapter.ClearBeforeFill = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(1, 33)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PivotGridControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PivotGridControl2)
        Me.SplitContainer1.Size = New System.Drawing.Size(799, 416)
        Me.SplitContainer1.SplitterDistance = 208
        Me.SplitContainer1.TabIndex = 84
        '
        'PivotGridControl2
        '
        Me.PivotGridControl2.DataSource = Me.ProductonReportBindingSource
        Me.PivotGridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl2.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldSL2, Me.fieldProductionType1, Me.fieldProdYear1, Me.fieldProdMonth1, Me.fieldProdWeek1, Me.fieldBuyerName1, Me.fieldStyleName1, Me.fieldProgramNo2, Me.fieldProdDate1, Me.fieldProdQuantity1})
        Me.PivotGridControl2.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl2.Name = "PivotGridControl2"
        Me.PivotGridControl2.Size = New System.Drawing.Size(799, 204)
        Me.PivotGridControl2.TabIndex = 0
        '
        'ProductonReportBindingSource
        '
        Me.ProductonReportBindingSource.DataMember = "ProductonReport"
        Me.ProductonReportBindingSource.DataSource = Me.ProductionReportDataSet
        '
        'ProductionReportDataSet
        '
        Me.ProductionReportDataSet.DataSetName = "ProductionReportDataSet"
        Me.ProductionReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldSL2
        '
        Me.fieldSL2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldSL2.AreaIndex = 1
        Me.fieldSL2.Caption = "SL"
        Me.fieldSL2.FieldName = "SL"
        Me.fieldSL2.Name = "fieldSL2"
        Me.fieldSL2.Width = 50
        '
        'fieldProductionType1
        '
        Me.fieldProductionType1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldProductionType1.AreaIndex = 2
        Me.fieldProductionType1.Caption = "Production Type"
        Me.fieldProductionType1.FieldName = "ProductionType"
        Me.fieldProductionType1.Name = "fieldProductionType1"
        Me.fieldProductionType1.Width = 120
        '
        'fieldProdYear1
        '
        Me.fieldProdYear1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldProdYear1.AreaIndex = 0
        Me.fieldProdYear1.Caption = "Prod Year"
        Me.fieldProdYear1.FieldName = "ProdYear"
        Me.fieldProdYear1.Name = "fieldProdYear1"
        '
        'fieldProdMonth1
        '
        Me.fieldProdMonth1.AreaIndex = 0
        Me.fieldProdMonth1.Caption = "Prod Month"
        Me.fieldProdMonth1.FieldName = "ProdMonth"
        Me.fieldProdMonth1.Name = "fieldProdMonth1"
        '
        'fieldProdWeek1
        '
        Me.fieldProdWeek1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldProdWeek1.AreaIndex = 0
        Me.fieldProdWeek1.Caption = "Prod Week"
        Me.fieldProdWeek1.FieldName = "ProdWeek"
        Me.fieldProdWeek1.Name = "fieldProdWeek1"
        '
        'fieldBuyerName1
        '
        Me.fieldBuyerName1.AreaIndex = 1
        Me.fieldBuyerName1.Caption = "Buyer Name"
        Me.fieldBuyerName1.FieldName = "BuyerName"
        Me.fieldBuyerName1.Name = "fieldBuyerName1"
        '
        'fieldStyleName1
        '
        Me.fieldStyleName1.AreaIndex = 2
        Me.fieldStyleName1.Caption = "Style Name"
        Me.fieldStyleName1.FieldName = "StyleName"
        Me.fieldStyleName1.Name = "fieldStyleName1"
        '
        'fieldProgramNo2
        '
        Me.fieldProgramNo2.AreaIndex = 3
        Me.fieldProgramNo2.Caption = "Program No"
        Me.fieldProgramNo2.FieldName = "ProgramNo"
        Me.fieldProgramNo2.Name = "fieldProgramNo2"
        '
        'fieldProdDate1
        '
        Me.fieldProdDate1.AreaIndex = 4
        Me.fieldProdDate1.Caption = "ProdDate"
        Me.fieldProdDate1.FieldName = "ProdDate"
        Me.fieldProdDate1.Name = "fieldProdDate1"
        '
        'fieldProdQuantity1
        '
        Me.fieldProdQuantity1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldProdQuantity1.AreaIndex = 0
        Me.fieldProdQuantity1.Caption = "Prod Quantity"
        Me.fieldProdQuantity1.FieldName = "ProdQuantity"
        Me.fieldProdQuantity1.Name = "fieldProdQuantity1"
        '
        'ProductonReportTableAdapter
        '
        Me.ProductonReportTableAdapter.ClearBeforeFill = True
        '
        'TNAReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ShowRunningButton)
        Me.Controls.Add(Me.LastUpdateLabel)
        Me.Controls.Add(Me.ReGenLinkLabel)
        Me.Name = "TNAReport"
        Me.Text = "TNAReport"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TNAReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TNAReportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PivotGridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductonReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionReportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ShowRunningButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LastUpdateLabel As Label
    Friend WithEvents ReGenLinkLabel As LinkLabel
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents TNAReportDataSet As TNAReportDataSet
    Friend WithEvents TNAReportBindingSource As BindingSource
    Friend WithEvents TNAReportTableAdapter As TNAReportDataSetTableAdapters.TNAReportTableAdapter
    Friend WithEvents fieldSL1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTNAType1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTNAYear1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTNAMonth1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBuyerCode1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStyle1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProgramNo1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTNADate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTNAQuantity1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTNAWeek1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PivotGridControl2 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents ProductionReportDataSet As ProductionReportDataSet
    Friend WithEvents ProductonReportBindingSource As BindingSource
    Friend WithEvents ProductonReportTableAdapter As ProductionReportDataSetTableAdapters.ProductonReportTableAdapter
    Friend WithEvents fieldSL2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProductionType1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProdYear1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProdMonth1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProdWeek1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBuyerName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStyleName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProgramNo2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProdDate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProdQuantity1 As DevExpress.XtraPivotGrid.PivotGridField
End Class
