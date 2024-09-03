<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShipmentbyExDate
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
        Me.VOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VOrderDataSet = New KSoft_Apparel.vOrderDataSet
        Me.fieldProgramNo = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldOrderReceiveDate = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldOrderExDate = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldAmendmentDate = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldAmendmentNo = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldCauseofAmendment = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldDiscontinue = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldOrderRemarks = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldIsPrint = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldGarmentDescription = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldStyleReferenceNo = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldCode = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldPrice = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldEX = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldETA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldAS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldPayBy = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldPOType = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldRemarks = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldPackType = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldStyleName = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldCompanyCode = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldDivisionName = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSeasonName = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldGarmentName = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldOrderQuantity = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldBuyerCode = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFabricColorName = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldPO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldPrintDetails = New DevExpress.XtraPivotGrid.PivotGridField
        Me.VOrderTableAdapter = New KSoft_Apparel.vOrderDataSetTableAdapters.vOrderTableAdapter
        Me.ExportButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VOrderDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotGridControl1.DataSource = Me.VOrderBindingSource
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldProgramNo, Me.fieldOrderReceiveDate, Me.fieldOrderExDate, Me.fieldAmendmentDate, Me.fieldAmendmentNo, Me.fieldCauseofAmendment, Me.fieldDiscontinue, Me.fieldOrderRemarks, Me.fieldIsPrint, Me.fieldGarmentDescription, Me.fieldStyleReferenceNo, Me.fieldCode, Me.fieldPrice, Me.fieldEX, Me.fieldETA, Me.fieldAS, Me.fieldPayBy, Me.fieldPOType, Me.fieldRemarks, Me.fieldPackType, Me.fieldStyleName, Me.fieldCompanyCode, Me.fieldDivisionName, Me.fieldSeasonName, Me.fieldGarmentName, Me.fieldOrderQuantity, Me.fieldBuyerCode, Me.fieldFabricColorName, Me.fieldPO, Me.fieldPrintDetails})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 39)
        Me.PivotGridControl1.LookAndFeel.SkinName = "Money Twins"
        Me.PivotGridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(1033, 425)
        Me.PivotGridControl1.TabIndex = 0
        '
        'VOrderBindingSource
        '
        Me.VOrderBindingSource.DataMember = "vOrder"
        Me.VOrderBindingSource.DataSource = Me.VOrderDataSet
        '
        'VOrderDataSet
        '
        Me.VOrderDataSet.DataSetName = "vOrderDataSet"
        Me.VOrderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldProgramNo
        '
        Me.fieldProgramNo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldProgramNo.AreaIndex = 1
        Me.fieldProgramNo.Caption = "Program No"
        Me.fieldProgramNo.FieldName = "ProgramNo"
        Me.fieldProgramNo.Name = "fieldProgramNo"
        '
        'fieldOrderReceiveDate
        '
        Me.fieldOrderReceiveDate.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldOrderReceiveDate.AreaIndex = 0
        Me.fieldOrderReceiveDate.Caption = "Order Receive Date"
        Me.fieldOrderReceiveDate.FieldName = "OrderReceiveDate"
        Me.fieldOrderReceiveDate.Name = "fieldOrderReceiveDate"
        Me.fieldOrderReceiveDate.Visible = False
        '
        'fieldOrderExDate
        '
        Me.fieldOrderExDate.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldOrderExDate.AreaIndex = 0
        Me.fieldOrderExDate.Caption = "Order Ex Date"
        Me.fieldOrderExDate.FieldName = "OrderExDate"
        Me.fieldOrderExDate.Name = "fieldOrderExDate"
        Me.fieldOrderExDate.Visible = False
        '
        'fieldAmendmentDate
        '
        Me.fieldAmendmentDate.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldAmendmentDate.AreaIndex = 0
        Me.fieldAmendmentDate.Caption = "Amendment Date"
        Me.fieldAmendmentDate.FieldName = "AmendmentDate"
        Me.fieldAmendmentDate.Name = "fieldAmendmentDate"
        Me.fieldAmendmentDate.Visible = False
        '
        'fieldAmendmentNo
        '
        Me.fieldAmendmentNo.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldAmendmentNo.AreaIndex = 0
        Me.fieldAmendmentNo.Caption = "Amendment No"
        Me.fieldAmendmentNo.FieldName = "AmendmentNo"
        Me.fieldAmendmentNo.Name = "fieldAmendmentNo"
        Me.fieldAmendmentNo.Visible = False
        '
        'fieldCauseofAmendment
        '
        Me.fieldCauseofAmendment.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldCauseofAmendment.AreaIndex = 0
        Me.fieldCauseofAmendment.Caption = "Causeof Amendment"
        Me.fieldCauseofAmendment.FieldName = "CauseofAmendment"
        Me.fieldCauseofAmendment.Name = "fieldCauseofAmendment"
        Me.fieldCauseofAmendment.Visible = False
        '
        'fieldDiscontinue
        '
        Me.fieldDiscontinue.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldDiscontinue.AreaIndex = 0
        Me.fieldDiscontinue.Caption = "Discontinue"
        Me.fieldDiscontinue.FieldName = "Discontinue"
        Me.fieldDiscontinue.Name = "fieldDiscontinue"
        Me.fieldDiscontinue.Visible = False
        '
        'fieldOrderRemarks
        '
        Me.fieldOrderRemarks.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldOrderRemarks.AreaIndex = 0
        Me.fieldOrderRemarks.Caption = "Order Remarks"
        Me.fieldOrderRemarks.FieldName = "OrderRemarks"
        Me.fieldOrderRemarks.Name = "fieldOrderRemarks"
        Me.fieldOrderRemarks.Visible = False
        '
        'fieldIsPrint
        '
        Me.fieldIsPrint.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldIsPrint.AreaIndex = 0
        Me.fieldIsPrint.Caption = "Is Print"
        Me.fieldIsPrint.FieldName = "IsPrint"
        Me.fieldIsPrint.Name = "fieldIsPrint"
        Me.fieldIsPrint.Visible = False
        '
        'fieldGarmentDescription
        '
        Me.fieldGarmentDescription.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldGarmentDescription.AreaIndex = 9
        Me.fieldGarmentDescription.Caption = "Garment Description"
        Me.fieldGarmentDescription.FieldName = "GarmentDescription"
        Me.fieldGarmentDescription.Name = "fieldGarmentDescription"
        Me.fieldGarmentDescription.Visible = False
        '
        'fieldStyleReferenceNo
        '
        Me.fieldStyleReferenceNo.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldStyleReferenceNo.AreaIndex = 10
        Me.fieldStyleReferenceNo.Caption = "Style Reference No"
        Me.fieldStyleReferenceNo.FieldName = "StyleReferenceNo"
        Me.fieldStyleReferenceNo.Name = "fieldStyleReferenceNo"
        Me.fieldStyleReferenceNo.Visible = False
        '
        'fieldCode
        '
        Me.fieldCode.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldCode.AreaIndex = 11
        Me.fieldCode.Caption = "Code"
        Me.fieldCode.FieldName = "Code"
        Me.fieldCode.Name = "fieldCode"
        Me.fieldCode.Visible = False
        '
        'fieldPrice
        '
        Me.fieldPrice.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldPrice.AreaIndex = 12
        Me.fieldPrice.Caption = "Price"
        Me.fieldPrice.FieldName = "Price"
        Me.fieldPrice.Name = "fieldPrice"
        Me.fieldPrice.Visible = False
        '
        'fieldEX
        '
        Me.fieldEX.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldEX.AreaIndex = 0
        Me.fieldEX.Caption = "EX"
        Me.fieldEX.CellFormat.FormatString = "dd-MMM-yy"
        Me.fieldEX.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldEX.FieldName = "EX"
        Me.fieldEX.Name = "fieldEX"
        Me.fieldEX.ValueFormat.FormatString = "dd-MMM-yy"
        Me.fieldEX.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldETA
        '
        Me.fieldETA.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldETA.AreaIndex = 14
        Me.fieldETA.Caption = "ETA"
        Me.fieldETA.FieldName = "ETA"
        Me.fieldETA.Name = "fieldETA"
        Me.fieldETA.Visible = False
        '
        'fieldAS
        '
        Me.fieldAS.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldAS.AreaIndex = 15
        Me.fieldAS.Caption = "A_S"
        Me.fieldAS.FieldName = "A_S"
        Me.fieldAS.Name = "fieldAS"
        Me.fieldAS.Visible = False
        '
        'fieldPayBy
        '
        Me.fieldPayBy.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldPayBy.AreaIndex = 16
        Me.fieldPayBy.Caption = "Pay By"
        Me.fieldPayBy.FieldName = "PayBy"
        Me.fieldPayBy.Name = "fieldPayBy"
        Me.fieldPayBy.Visible = False
        '
        'fieldPOType
        '
        Me.fieldPOType.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldPOType.AreaIndex = 17
        Me.fieldPOType.Caption = "PO_Type"
        Me.fieldPOType.FieldName = "PO_Type"
        Me.fieldPOType.Name = "fieldPOType"
        Me.fieldPOType.Visible = False
        '
        'fieldRemarks
        '
        Me.fieldRemarks.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldRemarks.AreaIndex = 21
        Me.fieldRemarks.Caption = "Remarks"
        Me.fieldRemarks.FieldName = "Remarks"
        Me.fieldRemarks.Name = "fieldRemarks"
        Me.fieldRemarks.Visible = False
        '
        'fieldPackType
        '
        Me.fieldPackType.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldPackType.AreaIndex = 18
        Me.fieldPackType.Caption = "Pack Type"
        Me.fieldPackType.FieldName = "PackType"
        Me.fieldPackType.Name = "fieldPackType"
        Me.fieldPackType.Visible = False
        '
        'fieldStyleName
        '
        Me.fieldStyleName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldStyleName.AreaIndex = 3
        Me.fieldStyleName.Caption = "Style Name"
        Me.fieldStyleName.FieldName = "StyleName"
        Me.fieldStyleName.Name = "fieldStyleName"
        '
        'fieldCompanyCode
        '
        Me.fieldCompanyCode.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldCompanyCode.AreaIndex = 23
        Me.fieldCompanyCode.Caption = "Company Code"
        Me.fieldCompanyCode.FieldName = "CompanyCode"
        Me.fieldCompanyCode.Name = "fieldCompanyCode"
        Me.fieldCompanyCode.Visible = False
        '
        'fieldDivisionName
        '
        Me.fieldDivisionName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldDivisionName.AreaIndex = 2
        Me.fieldDivisionName.Caption = "Division Name"
        Me.fieldDivisionName.FieldName = "DivisionName"
        Me.fieldDivisionName.Name = "fieldDivisionName"
        '
        'fieldSeasonName
        '
        Me.fieldSeasonName.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldSeasonName.AreaIndex = 25
        Me.fieldSeasonName.Caption = "Season Name"
        Me.fieldSeasonName.FieldName = "SeasonName"
        Me.fieldSeasonName.Name = "fieldSeasonName"
        Me.fieldSeasonName.Visible = False
        '
        'fieldGarmentName
        '
        Me.fieldGarmentName.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldGarmentName.AreaIndex = 26
        Me.fieldGarmentName.Caption = "Garment Name"
        Me.fieldGarmentName.FieldName = "GarmentName"
        Me.fieldGarmentName.Name = "fieldGarmentName"
        Me.fieldGarmentName.Visible = False
        '
        'fieldOrderQuantity
        '
        Me.fieldOrderQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldOrderQuantity.AreaIndex = 0
        Me.fieldOrderQuantity.Caption = "Order Quantity"
        Me.fieldOrderQuantity.FieldName = "OrderQuantity"
        Me.fieldOrderQuantity.Name = "fieldOrderQuantity"
        '
        'fieldBuyerCode
        '
        Me.fieldBuyerCode.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldBuyerCode.AreaIndex = 0
        Me.fieldBuyerCode.Caption = "Buyer Code"
        Me.fieldBuyerCode.FieldName = "BuyerCode"
        Me.fieldBuyerCode.Name = "fieldBuyerCode"
        '
        'fieldFabricColorName
        '
        Me.fieldFabricColorName.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldFabricColorName.AreaIndex = 29
        Me.fieldFabricColorName.Caption = "Fabric Color Name"
        Me.fieldFabricColorName.FieldName = "FabricColorName"
        Me.fieldFabricColorName.Name = "fieldFabricColorName"
        Me.fieldFabricColorName.Visible = False
        '
        'fieldPO
        '
        Me.fieldPO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldPO.AreaIndex = 4
        Me.fieldPO.Caption = "PO"
        Me.fieldPO.FieldName = "PO"
        Me.fieldPO.Name = "fieldPO"
        '
        'fieldPrintDetails
        '
        Me.fieldPrintDetails.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.fieldPrintDetails.AreaIndex = 33
        Me.fieldPrintDetails.Caption = "Print Details"
        Me.fieldPrintDetails.FieldName = "PrintDetails"
        Me.fieldPrintDetails.Name = "fieldPrintDetails"
        Me.fieldPrintDetails.Visible = False
        '
        'VOrderTableAdapter
        '
        Me.VOrderTableAdapter.ClearBeforeFill = True
        '
        'ExportButton
        '
        Me.ExportButton.Location = New System.Drawing.Point(12, 10)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(75, 23)
        Me.ExportButton.TabIndex = 1
        Me.ExportButton.Text = "Export"
        Me.ExportButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 2
        '
        'frmShipmentbyExDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 465)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExportButton)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "frmShipmentbyExDate"
        Me.Text = "Shipment by ExDate"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VOrderDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents VOrderDataSet As KSoft_Apparel.vOrderDataSet
    Friend WithEvents VOrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VOrderTableAdapter As KSoft_Apparel.vOrderDataSetTableAdapters.vOrderTableAdapter
    Friend WithEvents fieldProgramNo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOrderReceiveDate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOrderExDate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAmendmentDate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAmendmentNo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCauseofAmendment As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDiscontinue As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOrderRemarks As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldIsPrint As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGarmentDescription As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStyleReferenceNo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCode As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPrice As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEX As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldETA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPayBy As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPOType As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRemarks As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPackType As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStyleName As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCompanyCode As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDivisionName As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSeasonName As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGarmentName As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOrderQuantity As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBuyerCode As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFabricColorName As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPrintDetails As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ExportButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
