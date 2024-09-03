<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBTBReporter
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
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.BTBReporterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BTBReporterDataSet = New KSoft_Apparel.BTBReporterDataSet
        Me.fieldMLCNO1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMLCDate1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldBTBLCNo1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldBTBLCDate1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSupplierName1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldAmountUSD1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldAmountBDT1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldIFDBC1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldDueDate1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldPaymentAmount1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldPaymentDate1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldRemarks1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMaterialType1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldBTBMonth = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldBTBYear = New DevExpress.XtraPivotGrid.PivotGridField
        Me.BTBReporterTableAdapter = New KSoft_Apparel.BTBReporterDataSetTableAdapters.BTBReporterTableAdapter
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTBReporterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTBReporterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PivotGridControl1.DataSource = Me.BTBReporterBindingSource
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldMLCNO1, Me.fieldMLCDate1, Me.fieldBTBLCNo1, Me.fieldBTBLCDate1, Me.fieldSupplierName1, Me.fieldAmountUSD1, Me.fieldAmountBDT1, Me.fieldIFDBC1, Me.fieldDueDate1, Me.fieldPaymentAmount1, Me.fieldPaymentDate1, Me.fieldRemarks1, Me.fieldMaterialType1, Me.fieldBTBMonth, Me.fieldBTBYear})
        Me.PivotGridControl1.Location = New System.Drawing.Point(1, 35)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(1060, 610)
        Me.PivotGridControl1.TabIndex = 0
        '
        'BTBReporterBindingSource
        '
        Me.BTBReporterBindingSource.DataMember = "BTBReporter"
        Me.BTBReporterBindingSource.DataSource = Me.BTBReporterDataSet
        '
        'BTBReporterDataSet
        '
        Me.BTBReporterDataSet.DataSetName = "BTBReporterDataSet"
        Me.BTBReporterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldMLCNO1
        '
        Me.fieldMLCNO1.AreaIndex = 2
        Me.fieldMLCNO1.Caption = "MLCNO"
        Me.fieldMLCNO1.FieldName = "MLCNO"
        Me.fieldMLCNO1.Name = "fieldMLCNO1"
        '
        'fieldMLCDate1
        '
        Me.fieldMLCDate1.AreaIndex = 3
        Me.fieldMLCDate1.Caption = "MLC Date"
        Me.fieldMLCDate1.FieldName = "MLCDate"
        Me.fieldMLCDate1.Name = "fieldMLCDate1"
        '
        'fieldBTBLCNo1
        '
        Me.fieldBTBLCNo1.AreaIndex = 0
        Me.fieldBTBLCNo1.Caption = "BTBLCNo"
        Me.fieldBTBLCNo1.FieldName = "BTBLCNo"
        Me.fieldBTBLCNo1.Name = "fieldBTBLCNo1"
        '
        'fieldBTBLCDate1
        '
        Me.fieldBTBLCDate1.AreaIndex = 1
        Me.fieldBTBLCDate1.Caption = "BTBLC Date"
        Me.fieldBTBLCDate1.FieldName = "BTBLCDate"
        Me.fieldBTBLCDate1.Name = "fieldBTBLCDate1"
        '
        'fieldSupplierName1
        '
        Me.fieldSupplierName1.AreaIndex = 4
        Me.fieldSupplierName1.Caption = "Supplier Name"
        Me.fieldSupplierName1.FieldName = "SupplierName"
        Me.fieldSupplierName1.Name = "fieldSupplierName1"
        '
        'fieldAmountUSD1
        '
        Me.fieldAmountUSD1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldAmountUSD1.AreaIndex = 0
        Me.fieldAmountUSD1.Caption = "Amount USD"
        Me.fieldAmountUSD1.FieldName = "AmountUSD"
        Me.fieldAmountUSD1.Name = "fieldAmountUSD1"
        '
        'fieldAmountBDT1
        '
        Me.fieldAmountBDT1.AreaIndex = 5
        Me.fieldAmountBDT1.Caption = "Amount BDT"
        Me.fieldAmountBDT1.CellFormat.FormatString = "##,##.##"
        Me.fieldAmountBDT1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldAmountBDT1.FieldName = "AmountBDT"
        Me.fieldAmountBDT1.Name = "fieldAmountBDT1"
        '
        'fieldIFDBC1
        '
        Me.fieldIFDBC1.AreaIndex = 6
        Me.fieldIFDBC1.Caption = "IFDBC"
        Me.fieldIFDBC1.FieldName = "IFDBC"
        Me.fieldIFDBC1.Name = "fieldIFDBC1"
        '
        'fieldDueDate1
        '
        Me.fieldDueDate1.AreaIndex = 7
        Me.fieldDueDate1.Caption = "Due Date"
        Me.fieldDueDate1.FieldName = "DueDate"
        Me.fieldDueDate1.Name = "fieldDueDate1"
        '
        'fieldPaymentAmount1
        '
        Me.fieldPaymentAmount1.AreaIndex = 8
        Me.fieldPaymentAmount1.Caption = "Payment Amount"
        Me.fieldPaymentAmount1.FieldName = "PaymentAmount"
        Me.fieldPaymentAmount1.Name = "fieldPaymentAmount1"
        '
        'fieldPaymentDate1
        '
        Me.fieldPaymentDate1.AreaIndex = 9
        Me.fieldPaymentDate1.Caption = "Payment Date"
        Me.fieldPaymentDate1.FieldName = "PaymentDate"
        Me.fieldPaymentDate1.Name = "fieldPaymentDate1"
        '
        'fieldRemarks1
        '
        Me.fieldRemarks1.AreaIndex = 10
        Me.fieldRemarks1.Caption = "Remarks"
        Me.fieldRemarks1.FieldName = "Remarks"
        Me.fieldRemarks1.Name = "fieldRemarks1"
        '
        'fieldMaterialType1
        '
        Me.fieldMaterialType1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldMaterialType1.AreaIndex = 0
        Me.fieldMaterialType1.Caption = "Material Type"
        Me.fieldMaterialType1.FieldName = "MaterialType"
        Me.fieldMaterialType1.Name = "fieldMaterialType1"
        Me.fieldMaterialType1.Width = 136
        '
        'fieldBTBMonth
        '
        Me.fieldBTBMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldBTBMonth.AreaIndex = 1
        Me.fieldBTBMonth.Caption = "BTB Month"
        Me.fieldBTBMonth.FieldName = "BTBMonth"
        Me.fieldBTBMonth.Name = "fieldBTBMonth"
        '
        'fieldBTBYear
        '
        Me.fieldBTBYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldBTBYear.AreaIndex = 0
        Me.fieldBTBYear.Caption = "BTB Year"
        Me.fieldBTBYear.FieldName = "BTBYear"
        Me.fieldBTBYear.Name = "fieldBTBYear"
        '
        'BTBReporterTableAdapter
        '
        Me.BTBReporterTableAdapter.ClearBeforeFill = True
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 6)
        Me.SimpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(107, 23)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "E&xport"
        '
        'frmBTBReporter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 645)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "frmBTBReporter"
        Me.Text = "Back to Back LC Reporter"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTBReporterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTBReporterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents BTBReporterDataSet As KSoft_Apparel.BTBReporterDataSet
    Friend WithEvents BTBReporterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BTBReporterTableAdapter As KSoft_Apparel.BTBReporterDataSetTableAdapters.BTBReporterTableAdapter
    Friend WithEvents fieldMLCNO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMLCDate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBTBLCNo1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBTBLCDate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSupplierName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAmountUSD1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAmountBDT1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldIFDBC1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDueDate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPaymentAmount1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPaymentDate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRemarks1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMaterialType1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents fieldBTBMonth As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBTBYear As DevExpress.XtraPivotGrid.PivotGridField
End Class
