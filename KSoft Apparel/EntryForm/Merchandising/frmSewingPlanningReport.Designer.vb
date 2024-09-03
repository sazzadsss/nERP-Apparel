<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSewingPlanningReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim PivotGridFormatRule1 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim FormatRuleTotalTypeSettings1 As DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings = New DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings()
        Dim PivotGridFormatRule2 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
        Dim FormatConditionRuleExpression2 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim FormatRuleTotalTypeSettings2 As DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings = New DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings()
        Dim PivotGridFormatRule3 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim FormatRuleTotalTypeSettings3 As DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings = New DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings()
        Dim PivotGridFormatRule4 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim FormatRuleTotalTypeSettings4 As DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings = New DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings()
        Dim PivotGridFormatRule5 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
        Dim FormatConditionRuleExpression3 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim FormatRuleTotalTypeSettings5 As DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings = New DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings()
        Dim PivotGridFormatRule6 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
        Dim FormatConditionRuleExpression4 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim FormatRuleTotalTypeSettings6 As DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings = New DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings()
        Me.fieldAchivement1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPlanQuantity1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.ExportButton = New System.Windows.Forms.Button()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.PlanningReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitAppointmentDataSet = New KSoft_Apparel.SplitAppointmentDataSet()
        Me.fieldYear1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMonth1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProgramNo1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInformation1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldLine1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldLineSortOrder1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBuyer1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldStyle1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAppointmentId1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAppointmentDates1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldStyleType = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCuttingEnd = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCuttingStart = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEmbroideryEnd = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEmbroideryStart = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFabricDeliveryEnd = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFabricDeliveryStart = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFinihsingStart = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFinishingEnd = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInspectionEnd = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInspectionStart = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPrintingEnd = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPrintingStart = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSewingEnd = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSewingStart = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldShipmentEnd = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldShipmentStart = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldYarnInhouseEnd = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldYarnInhouseStart = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAccessoriesStart = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAccessoriesEnd = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldStartDate = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEndDate = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBranch = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.CareLabelTableAdapter1 = New KSoft_Apparel.CareLabelDataSetTableAdapters.CareLabelTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SaveLayoutLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.SplitAppointmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitAppointmentTableAdapter = New KSoft_Apparel.SplitAppointmentDataSetTableAdapters.SplitAppointmentTableAdapter()
        Me.PlanningReportTableAdapter = New KSoft_Apparel.SplitAppointmentDataSetTableAdapters.PlanningReportTableAdapter()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanningReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitAppointmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitAppointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fieldAchivement1
        '
        Me.fieldAchivement1.AreaIndex = 3
        Me.fieldAchivement1.Caption = "Achieve"
        Me.fieldAchivement1.CellFormat.FormatString = "n0"
        Me.fieldAchivement1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldAchivement1.FieldName = "Achivement"
        Me.fieldAchivement1.Name = "fieldAchivement1"
        Me.fieldAchivement1.Width = 50
        '
        'fieldPlanQuantity1
        '
        Me.fieldPlanQuantity1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldPlanQuantity1.AreaIndex = 0
        Me.fieldPlanQuantity1.Caption = "Plan"
        Me.fieldPlanQuantity1.CellFormat.FormatString = "n0"
        Me.fieldPlanQuantity1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldPlanQuantity1.FieldName = "PlanQuantity"
        Me.fieldPlanQuantity1.Name = "fieldPlanQuantity1"
        Me.fieldPlanQuantity1.Width = 49
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(127, 7)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(107, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Planning Date From : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(240, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To : "
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(275, 7)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(107, 20)
        Me.DateTimePicker2.TabIndex = 4
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(398, 6)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 5
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'ExportButton
        '
        Me.ExportButton.Location = New System.Drawing.Point(489, 6)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(75, 23)
        Me.ExportButton.TabIndex = 6
        Me.ExportButton.Text = "&Export"
        Me.ExportButton.UseVisualStyleBackColor = True
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PivotGridControl1.Appearance.GrandTotalCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PivotGridControl1.Appearance.GrandTotalCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PivotGridControl1.Appearance.GrandTotalCell.Options.UseBackColor = True
        Me.PivotGridControl1.Appearance.GrandTotalCell.Options.UseFont = True
        Me.PivotGridControl1.Appearance.TotalCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PivotGridControl1.Appearance.TotalCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PivotGridControl1.Appearance.TotalCell.Options.UseBackColor = True
        Me.PivotGridControl1.Appearance.TotalCell.Options.UseFont = True
        Me.PivotGridControl1.DataSource = Me.PlanningReportBindingSource
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldYear1, Me.fieldMonth1, Me.fieldProgramNo1, Me.fieldInformation1, Me.fieldLine1, Me.fieldLineSortOrder1, Me.fieldPlanQuantity1, Me.fieldBuyer1, Me.fieldStyle1, Me.fieldAchivement1, Me.fieldAppointmentId1, Me.fieldAppointmentDates1, Me.fieldPO, Me.fieldStyleType, Me.fieldCuttingEnd, Me.fieldCuttingStart, Me.fieldEmbroideryEnd, Me.fieldEmbroideryStart, Me.fieldFabricDeliveryEnd, Me.fieldFabricDeliveryStart, Me.fieldFinihsingStart, Me.fieldFinishingEnd, Me.fieldInspectionEnd, Me.fieldInspectionStart, Me.fieldPrintingEnd, Me.fieldPrintingStart, Me.fieldSewingEnd, Me.fieldSewingStart, Me.fieldShipmentEnd, Me.fieldShipmentStart, Me.fieldYarnInhouseEnd, Me.fieldYarnInhouseStart, Me.fieldAccessoriesStart, Me.fieldAccessoriesEnd, Me.fieldStartDate, Me.fieldEndDate, Me.fieldBranch})
        PivotGridFormatRule1.Measure = Me.fieldAchivement1
        PivotGridFormatRule1.Name = "Format0"
        FormatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleExpression1.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression1.Expression = "[Achivement] > [PlanQuantity]"
        PivotGridFormatRule1.Rule = FormatConditionRuleExpression1
        FormatRuleTotalTypeSettings1.ApplyToCustomTotalCell = False
        FormatRuleTotalTypeSettings1.ApplyToGrandTotalCell = False
        FormatRuleTotalTypeSettings1.ApplyToTotalCell = False
        PivotGridFormatRule1.Settings = FormatRuleTotalTypeSettings1
        PivotGridFormatRule2.Measure = Me.fieldAchivement1
        PivotGridFormatRule2.Name = "Format1"
        FormatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleExpression2.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression2.Expression = "[Achivement] < [PlanQuantity] And [Achivement] > 0"
        PivotGridFormatRule2.Rule = FormatConditionRuleExpression2
        FormatRuleTotalTypeSettings2.ApplyToCustomTotalCell = False
        FormatRuleTotalTypeSettings2.ApplyToGrandTotalCell = False
        FormatRuleTotalTypeSettings2.ApplyToTotalCell = False
        PivotGridFormatRule2.Settings = FormatRuleTotalTypeSettings2
        PivotGridFormatRule3.Measure = Me.fieldPlanQuantity1
        PivotGridFormatRule3.Name = "Format2"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Greater
        FormatConditionRuleValue1.Value1 = "0"
        PivotGridFormatRule3.Rule = FormatConditionRuleValue1
        FormatRuleTotalTypeSettings3.ApplyToCustomTotalCell = False
        FormatRuleTotalTypeSettings3.ApplyToGrandTotalCell = False
        FormatRuleTotalTypeSettings3.ApplyToTotalCell = False
        PivotGridFormatRule3.Settings = FormatRuleTotalTypeSettings3
        PivotGridFormatRule4.Measure = Me.fieldAchivement1
        PivotGridFormatRule4.Name = "Format3"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Value1 = "0"
        PivotGridFormatRule4.Rule = FormatConditionRuleValue2
        FormatRuleTotalTypeSettings4.ApplyToCustomTotalCell = False
        FormatRuleTotalTypeSettings4.ApplyToGrandTotalCell = False
        FormatRuleTotalTypeSettings4.ApplyToTotalCell = False
        PivotGridFormatRule4.Settings = FormatRuleTotalTypeSettings4
        PivotGridFormatRule5.Enabled = False
        PivotGridFormatRule5.Measure = Me.fieldAchivement1
        PivotGridFormatRule5.Name = "Format4"
        FormatConditionRuleExpression3.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen
        FormatConditionRuleExpression3.Appearance.ForeColor = System.Drawing.Color.White
        FormatConditionRuleExpression3.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression3.Appearance.Options.UseForeColor = True
        FormatConditionRuleExpression3.Expression = "[StyleType] = 'T-Shirt'"
        PivotGridFormatRule5.Rule = FormatConditionRuleExpression3
        FormatRuleTotalTypeSettings5.ApplyToCustomTotalCell = False
        FormatRuleTotalTypeSettings5.ApplyToGrandTotalCell = False
        FormatRuleTotalTypeSettings5.ApplyToTotalCell = False
        PivotGridFormatRule5.Settings = FormatRuleTotalTypeSettings5
        PivotGridFormatRule6.Enabled = False
        PivotGridFormatRule6.Measure = Me.fieldAchivement1
        PivotGridFormatRule6.Name = "Format5"
        FormatConditionRuleExpression4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(251, Byte), Integer))
        FormatConditionRuleExpression4.Appearance.ForeColor = System.Drawing.Color.Black
        FormatConditionRuleExpression4.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression4.Appearance.Options.UseForeColor = True
        FormatConditionRuleExpression4.Expression = "[StyleType] = 'Polo Shirt'"
        PivotGridFormatRule6.Rule = FormatConditionRuleExpression4
        FormatRuleTotalTypeSettings6.ApplyToCustomTotalCell = False
        FormatRuleTotalTypeSettings6.ApplyToGrandTotalCell = False
        FormatRuleTotalTypeSettings6.ApplyToTotalCell = False
        PivotGridFormatRule6.Settings = FormatRuleTotalTypeSettings6
        Me.PivotGridControl1.FormatRules.Add(PivotGridFormatRule1)
        Me.PivotGridControl1.FormatRules.Add(PivotGridFormatRule2)
        Me.PivotGridControl1.FormatRules.Add(PivotGridFormatRule3)
        Me.PivotGridControl1.FormatRules.Add(PivotGridFormatRule4)
        Me.PivotGridControl1.FormatRules.Add(PivotGridFormatRule5)
        Me.PivotGridControl1.FormatRules.Add(PivotGridFormatRule6)
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 35)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsMenu.EnableFormatRulesMenu = True
        Me.PivotGridControl1.Size = New System.Drawing.Size(1361, 582)
        Me.PivotGridControl1.TabIndex = 7
        '
        'PlanningReportBindingSource
        '
        Me.PlanningReportBindingSource.DataMember = "PlanningReport"
        Me.PlanningReportBindingSource.DataSource = Me.SplitAppointmentDataSet
        '
        'SplitAppointmentDataSet
        '
        Me.SplitAppointmentDataSet.DataSetName = "SplitAppointmentDataSet"
        Me.SplitAppointmentDataSet.EnforceConstraints = False
        Me.SplitAppointmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldYear1
        '
        Me.fieldYear1.AreaIndex = 4
        Me.fieldYear1.Caption = "Year"
        Me.fieldYear1.FieldName = "Year"
        Me.fieldYear1.Name = "fieldYear1"
        Me.fieldYear1.Width = 75
        '
        'fieldMonth1
        '
        Me.fieldMonth1.AreaIndex = 5
        Me.fieldMonth1.Caption = "Month"
        Me.fieldMonth1.FieldName = "Month"
        Me.fieldMonth1.Name = "fieldMonth1"
        Me.fieldMonth1.Width = 75
        '
        'fieldProgramNo1
        '
        Me.fieldProgramNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldProgramNo1.AreaIndex = 4
        Me.fieldProgramNo1.Caption = "Program No"
        Me.fieldProgramNo1.FieldName = "ProgramNo"
        Me.fieldProgramNo1.Name = "fieldProgramNo1"
        '
        'fieldInformation1
        '
        Me.fieldInformation1.AreaIndex = 1
        Me.fieldInformation1.Caption = "Details"
        Me.fieldInformation1.FieldName = "Information"
        Me.fieldInformation1.Name = "fieldInformation1"
        '
        'fieldLine1
        '
        Me.fieldLine1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldLine1.AreaIndex = 1
        Me.fieldLine1.Caption = "Line"
        Me.fieldLine1.FieldName = "Line"
        Me.fieldLine1.Name = "fieldLine1"
        Me.fieldLine1.Width = 70
        '
        'fieldLineSortOrder1
        '
        Me.fieldLineSortOrder1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldLineSortOrder1.AreaIndex = 0
        Me.fieldLineSortOrder1.Caption = "SL"
        Me.fieldLineSortOrder1.FieldName = "LineSortOrder"
        Me.fieldLineSortOrder1.Name = "fieldLineSortOrder1"
        Me.fieldLineSortOrder1.Width = 70
        '
        'fieldBuyer1
        '
        Me.fieldBuyer1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldBuyer1.AreaIndex = 3
        Me.fieldBuyer1.Caption = "Style"
        Me.fieldBuyer1.FieldName = "Buyer"
        Me.fieldBuyer1.Name = "fieldBuyer1"
        '
        'fieldStyle1
        '
        Me.fieldStyle1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldStyle1.AreaIndex = 5
        Me.fieldStyle1.Caption = "Buyer"
        Me.fieldStyle1.FieldName = "Style"
        Me.fieldStyle1.Name = "fieldStyle1"
        '
        'fieldAppointmentId1
        '
        Me.fieldAppointmentId1.AreaIndex = 0
        Me.fieldAppointmentId1.Caption = "Planning No"
        Me.fieldAppointmentId1.FieldName = "AppointmentId"
        Me.fieldAppointmentId1.Name = "fieldAppointmentId1"
        '
        'fieldAppointmentDates1
        '
        Me.fieldAppointmentDates1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldAppointmentDates1.AreaIndex = 0
        Me.fieldAppointmentDates1.Caption = "Planning Date"
        Me.fieldAppointmentDates1.CellFormat.FormatString = "dd-MMM-yy"
        Me.fieldAppointmentDates1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldAppointmentDates1.FieldName = "AppointmentDates"
        Me.fieldAppointmentDates1.Name = "fieldAppointmentDates1"
        Me.fieldAppointmentDates1.UnboundFieldName = "fieldAppointmentDates1"
        Me.fieldAppointmentDates1.ValueFormat.FormatString = "dd-MMM-yy"
        Me.fieldAppointmentDates1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldAppointmentDates1.Width = 75
        '
        'fieldPO
        '
        Me.fieldPO.AreaIndex = 2
        Me.fieldPO.Caption = "PO"
        Me.fieldPO.FieldName = "PO"
        Me.fieldPO.Name = "fieldPO"
        '
        'fieldStyleType
        '
        Me.fieldStyleType.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldStyleType.AreaIndex = 6
        Me.fieldStyleType.FieldName = "StyleType"
        Me.fieldStyleType.Name = "fieldStyleType"
        '
        'fieldCuttingEnd
        '
        Me.fieldCuttingEnd.AreaIndex = 12
        Me.fieldCuttingEnd.FieldName = "CuttingEnd"
        Me.fieldCuttingEnd.Name = "fieldCuttingEnd"
        '
        'fieldCuttingStart
        '
        Me.fieldCuttingStart.AreaIndex = 13
        Me.fieldCuttingStart.FieldName = "CuttingStart"
        Me.fieldCuttingStart.Name = "fieldCuttingStart"
        '
        'fieldEmbroideryEnd
        '
        Me.fieldEmbroideryEnd.AreaIndex = 14
        Me.fieldEmbroideryEnd.FieldName = "EmbroideryEnd"
        Me.fieldEmbroideryEnd.Name = "fieldEmbroideryEnd"
        '
        'fieldEmbroideryStart
        '
        Me.fieldEmbroideryStart.AreaIndex = 17
        Me.fieldEmbroideryStart.FieldName = "EmbroideryStart"
        Me.fieldEmbroideryStart.Name = "fieldEmbroideryStart"
        '
        'fieldFabricDeliveryEnd
        '
        Me.fieldFabricDeliveryEnd.AreaIndex = 9
        Me.fieldFabricDeliveryEnd.FieldName = "FabricDeliveryEnd"
        Me.fieldFabricDeliveryEnd.Name = "fieldFabricDeliveryEnd"
        '
        'fieldFabricDeliveryStart
        '
        Me.fieldFabricDeliveryStart.AreaIndex = 8
        Me.fieldFabricDeliveryStart.FieldName = "FabricDeliveryStart"
        Me.fieldFabricDeliveryStart.Name = "fieldFabricDeliveryStart"
        '
        'fieldFinihsingStart
        '
        Me.fieldFinihsingStart.AreaIndex = 21
        Me.fieldFinihsingStart.FieldName = "FinihsingStart"
        Me.fieldFinihsingStart.Name = "fieldFinihsingStart"
        '
        'fieldFinishingEnd
        '
        Me.fieldFinishingEnd.AreaIndex = 20
        Me.fieldFinishingEnd.FieldName = "FinishingEnd"
        Me.fieldFinishingEnd.Name = "fieldFinishingEnd"
        '
        'fieldInspectionEnd
        '
        Me.fieldInspectionEnd.AreaIndex = 23
        Me.fieldInspectionEnd.FieldName = "InspectionEnd"
        Me.fieldInspectionEnd.Name = "fieldInspectionEnd"
        '
        'fieldInspectionStart
        '
        Me.fieldInspectionStart.AreaIndex = 22
        Me.fieldInspectionStart.FieldName = "InspectionStart"
        Me.fieldInspectionStart.Name = "fieldInspectionStart"
        '
        'fieldPrintingEnd
        '
        Me.fieldPrintingEnd.AreaIndex = 15
        Me.fieldPrintingEnd.FieldName = "PrintingEnd"
        Me.fieldPrintingEnd.Name = "fieldPrintingEnd"
        '
        'fieldPrintingStart
        '
        Me.fieldPrintingStart.AreaIndex = 16
        Me.fieldPrintingStart.FieldName = "PrintingStart"
        Me.fieldPrintingStart.Name = "fieldPrintingStart"
        '
        'fieldSewingEnd
        '
        Me.fieldSewingEnd.AreaIndex = 19
        Me.fieldSewingEnd.FieldName = "SewingEnd"
        Me.fieldSewingEnd.Name = "fieldSewingEnd"
        '
        'fieldSewingStart
        '
        Me.fieldSewingStart.AreaIndex = 18
        Me.fieldSewingStart.FieldName = "SewingStart"
        Me.fieldSewingStart.Name = "fieldSewingStart"
        '
        'fieldShipmentEnd
        '
        Me.fieldShipmentEnd.AreaIndex = 24
        Me.fieldShipmentEnd.FieldName = "ShipmentEnd"
        Me.fieldShipmentEnd.Name = "fieldShipmentEnd"
        '
        'fieldShipmentStart
        '
        Me.fieldShipmentStart.AreaIndex = 25
        Me.fieldShipmentStart.FieldName = "ShipmentStart"
        Me.fieldShipmentStart.Name = "fieldShipmentStart"
        '
        'fieldYarnInhouseEnd
        '
        Me.fieldYarnInhouseEnd.AreaIndex = 6
        Me.fieldYarnInhouseEnd.FieldName = "YarnInhouseEnd"
        Me.fieldYarnInhouseEnd.Name = "fieldYarnInhouseEnd"
        '
        'fieldYarnInhouseStart
        '
        Me.fieldYarnInhouseStart.AreaIndex = 7
        Me.fieldYarnInhouseStart.FieldName = "YarnInhouseStart"
        Me.fieldYarnInhouseStart.Name = "fieldYarnInhouseStart"
        '
        'fieldAccessoriesStart
        '
        Me.fieldAccessoriesStart.AreaIndex = 10
        Me.fieldAccessoriesStart.FieldName = "AccessoriesStart"
        Me.fieldAccessoriesStart.Name = "fieldAccessoriesStart"
        '
        'fieldAccessoriesEnd
        '
        Me.fieldAccessoriesEnd.AreaIndex = 11
        Me.fieldAccessoriesEnd.FieldName = "AccessoriesEnd"
        Me.fieldAccessoriesEnd.Name = "fieldAccessoriesEnd"
        '
        'fieldStartDate
        '
        Me.fieldStartDate.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldStartDate.AreaIndex = 2
        Me.fieldStartDate.FieldName = "StartDate"
        Me.fieldStartDate.Name = "fieldStartDate"
        '
        'fieldEndDate
        '
        Me.fieldEndDate.AreaIndex = 26
        Me.fieldEndDate.FieldName = "EndDate"
        Me.fieldEndDate.Name = "fieldEndDate"
        '
        'fieldBranch
        '
        Me.fieldBranch.AreaIndex = 27
        Me.fieldBranch.FieldName = "Branch"
        Me.fieldBranch.Name = "fieldBranch"
        '
        'CareLabelTableAdapter1
        '
        Me.CareLabelTableAdapter1.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.LimeGreen
        Me.Label3.Location = New System.Drawing.Point(1197, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Jacket : Band Collar Polo"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(987, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "T-Shirt : Tank top : Round Neck Sweat"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Blue
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(987, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Polo : Serafino : Sweat Hoodie"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(1197, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Paint : Rompper : Jump Suit"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(880, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Style Type Color :"
        '
        'SaveLayoutLinkLabel
        '
        Me.SaveLayoutLinkLabel.AutoSize = True
        Me.SaveLayoutLinkLabel.Location = New System.Drawing.Point(601, 11)
        Me.SaveLayoutLinkLabel.Name = "SaveLayoutLinkLabel"
        Me.SaveLayoutLinkLabel.Size = New System.Drawing.Size(67, 13)
        Me.SaveLayoutLinkLabel.TabIndex = 13
        Me.SaveLayoutLinkLabel.TabStop = True
        Me.SaveLayoutLinkLabel.Text = "Save Layout"
        '
        'SplitAppointmentBindingSource
        '
        Me.SplitAppointmentBindingSource.DataMember = "SplitAppointment"
        Me.SplitAppointmentBindingSource.DataSource = Me.SplitAppointmentDataSet
        '
        'SplitAppointmentTableAdapter
        '
        Me.SplitAppointmentTableAdapter.ClearBeforeFill = True
        '
        'PlanningReportTableAdapter
        '
        Me.PlanningReportTableAdapter.ClearBeforeFill = True
        '
        'frmSewingPlanningReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1363, 617)
        Me.Controls.Add(Me.SaveLayoutLinkLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Controls.Add(Me.ExportButton)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "frmSewingPlanningReport"
        Me.Text = "Sewing Planning Report"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanningReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitAppointmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitAppointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitAppointmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SplitAppointmentDataSet As KSoft_Apparel.SplitAppointmentDataSet
    Friend WithEvents SplitAppointmentTableAdapter As KSoft_Apparel.SplitAppointmentDataSetTableAdapters.SplitAppointmentTableAdapter
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents ExportButton As System.Windows.Forms.Button
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldYear1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMonth1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProgramNo1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInformation1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldLine1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldLineSortOrder1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPlanQuantity1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBuyer1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStyle1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAppointmentId1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAppointmentDates1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPO As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents fieldAchivement1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStyleType As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents RepositoryItemColorEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
    Friend WithEvents CareLabelTableAdapter1 As CareLabelDataSetTableAdapters.CareLabelTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PlanningReportBindingSource As BindingSource
    Friend WithEvents PlanningReportTableAdapter As SplitAppointmentDataSetTableAdapters.PlanningReportTableAdapter
    Friend WithEvents fieldCuttingEnd As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCuttingStart As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEmbroideryEnd As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEmbroideryStart As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFabricDeliveryEnd As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFabricDeliveryStart As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFinihsingStart As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFinishingEnd As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInspectionEnd As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInspectionStart As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPrintingEnd As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPrintingStart As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSewingEnd As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSewingStart As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldShipmentEnd As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldShipmentStart As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldYarnInhouseEnd As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldYarnInhouseStart As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents SaveLayoutLinkLabel As LinkLabel
    Friend WithEvents fieldAccessoriesStart As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAccessoriesEnd As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStartDate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEndDate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBranch As DevExpress.XtraPivotGrid.PivotGridField
End Class
