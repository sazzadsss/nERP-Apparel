<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportBillReporter
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
        Me.ExportBillReporterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportBillReporterDataSet = New KSoft_Apparel.ExportBillReporterDataSet
        Me.fieldBillNo1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldBillDate1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldBillAmount1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldRealisedAmount1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldRealisedDate1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldDFCDeposit1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldPC1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldLACommission1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFACommission1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFDBP1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldECC1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldODInterest1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFCAmount1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMarginFDocs1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldHC1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldPostage1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldCD43541 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMLCNO1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMLCDate1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldBuyer2Name1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMLCValue1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldBTBAlreadyOpen1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMerchandiserReferenceNo1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ExportBillReporterTableAdapter = New KSoft_Apparel.ExportBillReporterDataSetTableAdapters.ExportBillReporterTableAdapter
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportBillReporterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportBillReporterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PivotGridControl1.DataSource = Me.ExportBillReporterBindingSource
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldBillNo1, Me.fieldBillDate1, Me.fieldBillAmount1, Me.fieldRealisedAmount1, Me.fieldRealisedDate1, Me.fieldDFCDeposit1, Me.fieldPC1, Me.fieldLACommission1, Me.fieldFACommission1, Me.fieldFDBP1, Me.fieldECC1, Me.fieldODInterest1, Me.fieldFCAmount1, Me.fieldMarginFDocs1, Me.fieldHC1, Me.fieldPostage1, Me.fieldCD43541, Me.fieldMLCNO1, Me.fieldMLCDate1, Me.fieldBuyer2Name1, Me.fieldMLCValue1, Me.fieldBTBAlreadyOpen1, Me.fieldMerchandiserReferenceNo1})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 34)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(957, 608)
        Me.PivotGridControl1.TabIndex = 0
        '
        'ExportBillReporterBindingSource
        '
        Me.ExportBillReporterBindingSource.DataMember = "ExportBillReporter"
        Me.ExportBillReporterBindingSource.DataSource = Me.ExportBillReporterDataSet
        '
        'ExportBillReporterDataSet
        '
        Me.ExportBillReporterDataSet.DataSetName = "ExportBillReporterDataSet"
        Me.ExportBillReporterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldBillNo1
        '
        Me.fieldBillNo1.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
                    Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldBillNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldBillNo1.AreaIndex = 6
        Me.fieldBillNo1.Caption = "Bill No"
        Me.fieldBillNo1.FieldName = "BillNo"
        Me.fieldBillNo1.Name = "fieldBillNo1"
        '
        'fieldBillDate1
        '
        Me.fieldBillDate1.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
                    Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldBillDate1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldBillDate1.AreaIndex = 7
        Me.fieldBillDate1.Caption = "Bill Date"
        Me.fieldBillDate1.FieldName = "BillDate"
        Me.fieldBillDate1.Name = "fieldBillDate1"
        '
        'fieldBillAmount1
        '
        Me.fieldBillAmount1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldBillAmount1.AreaIndex = 0
        Me.fieldBillAmount1.Caption = "Bill Amount"
        Me.fieldBillAmount1.FieldName = "BillAmount"
        Me.fieldBillAmount1.Name = "fieldBillAmount1"
        '
        'fieldRealisedAmount1
        '
        Me.fieldRealisedAmount1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldRealisedAmount1.AreaIndex = 1
        Me.fieldRealisedAmount1.Caption = "Realised Amount"
        Me.fieldRealisedAmount1.FieldName = "RealisedAmount"
        Me.fieldRealisedAmount1.Name = "fieldRealisedAmount1"
        '
        'fieldRealisedDate1
        '
        Me.fieldRealisedDate1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldRealisedDate1.AreaIndex = 8
        Me.fieldRealisedDate1.Caption = "Realised Date"
        Me.fieldRealisedDate1.FieldName = "RealisedDate"
        Me.fieldRealisedDate1.Name = "fieldRealisedDate1"
        '
        'fieldDFCDeposit1
        '
        Me.fieldDFCDeposit1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldDFCDeposit1.AreaIndex = 13
        Me.fieldDFCDeposit1.Caption = "DFC Deposit"
        Me.fieldDFCDeposit1.FieldName = "DFCDeposit"
        Me.fieldDFCDeposit1.Name = "fieldDFCDeposit1"
        '
        'fieldPC1
        '
        Me.fieldPC1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldPC1.AreaIndex = 12
        Me.fieldPC1.Caption = "PC"
        Me.fieldPC1.FieldName = "PC"
        Me.fieldPC1.Name = "fieldPC1"
        '
        'fieldLACommission1
        '
        Me.fieldLACommission1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldLACommission1.AreaIndex = 4
        Me.fieldLACommission1.Caption = "LA Commission"
        Me.fieldLACommission1.FieldName = "LACommission"
        Me.fieldLACommission1.Name = "fieldLACommission1"
        '
        'fieldFACommission1
        '
        Me.fieldFACommission1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldFACommission1.AreaIndex = 3
        Me.fieldFACommission1.Caption = "FA Commission"
        Me.fieldFACommission1.FieldName = "FACommission"
        Me.fieldFACommission1.Name = "fieldFACommission1"
        '
        'fieldFDBP1
        '
        Me.fieldFDBP1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldFDBP1.AreaIndex = 2
        Me.fieldFDBP1.Caption = "FDBP"
        Me.fieldFDBP1.FieldName = "FDBP"
        Me.fieldFDBP1.Name = "fieldFDBP1"
        '
        'fieldECC1
        '
        Me.fieldECC1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldECC1.AreaIndex = 11
        Me.fieldECC1.Caption = "ECC"
        Me.fieldECC1.FieldName = "ECC"
        Me.fieldECC1.Name = "fieldECC1"
        '
        'fieldODInterest1
        '
        Me.fieldODInterest1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldODInterest1.AreaIndex = 10
        Me.fieldODInterest1.Caption = "OD Interest"
        Me.fieldODInterest1.FieldName = "ODInterest"
        Me.fieldODInterest1.Name = "fieldODInterest1"
        '
        'fieldFCAmount1
        '
        Me.fieldFCAmount1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldFCAmount1.AreaIndex = 9
        Me.fieldFCAmount1.Caption = "FC Amount"
        Me.fieldFCAmount1.FieldName = "FCAmount"
        Me.fieldFCAmount1.Name = "fieldFCAmount1"
        '
        'fieldMarginFDocs1
        '
        Me.fieldMarginFDocs1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldMarginFDocs1.AreaIndex = 7
        Me.fieldMarginFDocs1.Caption = "Margin FDocs"
        Me.fieldMarginFDocs1.FieldName = "MarginFDocs"
        Me.fieldMarginFDocs1.Name = "fieldMarginFDocs1"
        '
        'fieldHC1
        '
        Me.fieldHC1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldHC1.AreaIndex = 6
        Me.fieldHC1.Caption = "HC"
        Me.fieldHC1.FieldName = "HC"
        Me.fieldHC1.Name = "fieldHC1"
        '
        'fieldPostage1
        '
        Me.fieldPostage1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldPostage1.AreaIndex = 5
        Me.fieldPostage1.Caption = "Postage"
        Me.fieldPostage1.FieldName = "Postage"
        Me.fieldPostage1.Name = "fieldPostage1"
        '
        'fieldCD43541
        '
        Me.fieldCD43541.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldCD43541.AreaIndex = 8
        Me.fieldCD43541.Caption = "CD4354"
        Me.fieldCD43541.FieldName = "CD4354"
        Me.fieldCD43541.Name = "fieldCD43541"
        '
        'fieldMLCNO1
        '
        Me.fieldMLCNO1.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
                    Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldMLCNO1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldMLCNO1.AreaIndex = 2
        Me.fieldMLCNO1.Caption = "MLCNO"
        Me.fieldMLCNO1.FieldName = "MLCNO"
        Me.fieldMLCNO1.Name = "fieldMLCNO1"
        '
        'fieldMLCDate1
        '
        Me.fieldMLCDate1.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
                    Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldMLCDate1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldMLCDate1.AreaIndex = 4
        Me.fieldMLCDate1.Caption = "MLC Date"
        Me.fieldMLCDate1.FieldName = "MLCDate"
        Me.fieldMLCDate1.Name = "fieldMLCDate1"
        '
        'fieldBuyer2Name1
        '
        Me.fieldBuyer2Name1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldBuyer2Name1.AreaIndex = 1
        Me.fieldBuyer2Name1.Caption = "Buyer2Name"
        Me.fieldBuyer2Name1.FieldName = "Buyer2Name"
        Me.fieldBuyer2Name1.Name = "fieldBuyer2Name1"
        '
        'fieldMLCValue1
        '
        Me.fieldMLCValue1.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
                    Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldMLCValue1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldMLCValue1.AreaIndex = 3
        Me.fieldMLCValue1.Caption = "MLC Value"
        Me.fieldMLCValue1.FieldName = "MLCValue"
        Me.fieldMLCValue1.Name = "fieldMLCValue1"
        '
        'fieldBTBAlreadyOpen1
        '
        Me.fieldBTBAlreadyOpen1.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
                    Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldBTBAlreadyOpen1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldBTBAlreadyOpen1.AreaIndex = 5
        Me.fieldBTBAlreadyOpen1.Caption = "BTB Already Open"
        Me.fieldBTBAlreadyOpen1.FieldName = "BTBAlreadyOpen"
        Me.fieldBTBAlreadyOpen1.Name = "fieldBTBAlreadyOpen1"
        '
        'fieldMerchandiserReferenceNo1
        '
        Me.fieldMerchandiserReferenceNo1.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
                    Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldMerchandiserReferenceNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldMerchandiserReferenceNo1.AreaIndex = 0
        Me.fieldMerchandiserReferenceNo1.Caption = "Merchandiser Reference No"
        Me.fieldMerchandiserReferenceNo1.FieldName = "MerchandiserReferenceNo"
        Me.fieldMerchandiserReferenceNo1.Name = "fieldMerchandiserReferenceNo1"
        '
        'ExportBillReporterTableAdapter
        '
        Me.ExportBillReporterTableAdapter.ClearBeforeFill = True
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 5)
        Me.SimpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(107, 23)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "E&xport"
        '
        'frmExportBillReporter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 642)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "frmExportBillReporter"
        Me.Text = "Export Bill Reporter"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportBillReporterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportBillReporterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents ExportBillReporterDataSet As KSoft_Apparel.ExportBillReporterDataSet
    Friend WithEvents ExportBillReporterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExportBillReporterTableAdapter As KSoft_Apparel.ExportBillReporterDataSetTableAdapters.ExportBillReporterTableAdapter
    Friend WithEvents fieldBillNo1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBillDate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBillAmount1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRealisedAmount1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRealisedDate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDFCDeposit1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPC1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldLACommission1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFACommission1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFDBP1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldECC1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldODInterest1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFCAmount1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMarginFDocs1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHC1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPostage1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCD43541 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMLCNO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMLCDate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBuyer2Name1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMLCValue1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBTBAlreadyOpen1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMerchandiserReferenceNo1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
