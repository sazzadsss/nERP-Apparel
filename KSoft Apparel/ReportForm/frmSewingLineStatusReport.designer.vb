<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSewingLineStatusReport
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
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.colNL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTargetsPerHour = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RefreshButton = New DevExpress.XtraEditors.SimpleButton()
        Me.SewingDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ShowButton = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SewingLineStatusNewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingLineStatusDataSet = New KSoft_Apparel.SewingLineStatusDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTargetPerHour = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colH1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colH2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colH3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colH4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colH5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colH6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colH7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colH8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colH9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colH10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colH11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colH12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTTLProduction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMCUsage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPresent_Helper = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPresent_Operator = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.ClockLabel = New System.Windows.Forms.Label()
        Me.LastRefreshLabel = New System.Windows.Forms.Label()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.SewingLineStatusNewTableAdapter = New KSoft_Apparel.SewingLineStatusDataSetTableAdapters.SewingLineStatusNewTableAdapter()
        Me.CloseSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.U1Button = New DevExpress.XtraEditors.SimpleButton()
        Me.U2Button = New DevExpress.XtraEditors.SimpleButton()
        Me.U4Button = New DevExpress.XtraEditors.SimpleButton()
        Me.U3Button = New DevExpress.XtraEditors.SimpleButton()
        Me.U6Button = New DevExpress.XtraEditors.SimpleButton()
        Me.U5Button = New DevExpress.XtraEditors.SimpleButton()
        Me.U8Button = New DevExpress.XtraEditors.SimpleButton()
        Me.U7Button = New DevExpress.XtraEditors.SimpleButton()
        Me.Unit10Button = New DevExpress.XtraEditors.SimpleButton()
        Me.Unit9Button = New DevExpress.XtraEditors.SimpleButton()
        Me.UnitLabel = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PlusButton = New DevExpress.XtraEditors.SimpleButton()
        Me.MinusButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
        Me.CheckedComboBoxEdit1 = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LineDataSet = New KSoft_Apparel.LineDataSet()
        Me.LineTableAdapter = New KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.SewingDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingLineStatusNewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingLineStatusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckedComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colNL
        '
        Me.colNL.AppearanceCell.BackColor = System.Drawing.Color.DimGray
        Me.colNL.AppearanceCell.BackColor2 = System.Drawing.Color.DimGray
        Me.colNL.AppearanceCell.ForeColor = System.Drawing.Color.LightGray
        Me.colNL.AppearanceCell.Options.UseBackColor = True
        Me.colNL.AppearanceCell.Options.UseFont = True
        Me.colNL.AppearanceCell.Options.UseForeColor = True
        Me.colNL.FieldName = "NL"
        Me.colNL.Name = "colNL"
        Me.colNL.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NL", "{0:0.##}")})
        Me.colNL.Visible = True
        Me.colNL.VisibleIndex = 18
        '
        'colTargetsPerHour
        '
        Me.colTargetsPerHour.Name = "colTargetsPerHour"
        '
        'RefreshButton
        '
        Me.RefreshButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshButton.Location = New System.Drawing.Point(1223, 213)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(110, 23)
        Me.RefreshButton.TabIndex = 2
        Me.RefreshButton.Text = "&Export to XLS"
        '
        'SewingDateDateEdit
        '
        Me.SewingDateDateEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SewingDateDateEdit.EditValue = Nothing
        Me.SewingDateDateEdit.Location = New System.Drawing.Point(1223, 158)
        Me.SewingDateDateEdit.Name = "SewingDateDateEdit"
        Me.SewingDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SewingDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SewingDateDateEdit.Size = New System.Drawing.Size(110, 20)
        Me.SewingDateDateEdit.TabIndex = 3
        '
        'ShowButton
        '
        Me.ShowButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowButton.Location = New System.Drawing.Point(1223, 184)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(110, 23)
        Me.ShowButton.TabIndex = 4
        Me.ShowButton.Text = "&Show All Lines"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.SewingLineStatusNewBindingSource
        Me.GridControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridControl1.Location = New System.Drawing.Point(0, 55)
        Me.GridControl1.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.GridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1211, 691)
        Me.GridControl1.TabIndex = 5
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SewingLineStatusNewBindingSource
        '
        Me.SewingLineStatusNewBindingSource.DataMember = "SewingLineStatusNew"
        Me.SewingLineStatusNewBindingSource.DataSource = Me.SewingLineStatusDataSet
        '
        'SewingLineStatusDataSet
        '
        Me.SewingLineStatusDataSet.DataSetName = "SewingLineStatusDataSet"
        Me.SewingLineStatusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Appearance.FixedLine.Font = New System.Drawing.Font("Tahoma", 6.0!)
        Me.GridView1.Appearance.FixedLine.Options.UseFont = True
        Me.GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 5.0!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLine, Me.colTargetPerHour, Me.colH1, Me.colH2, Me.colH3, Me.colH4, Me.colH5, Me.colH6, Me.colH7, Me.colH8, Me.colH9, Me.colH10, Me.colH11, Me.colH12, Me.colTTLProduction, Me.colNL, Me.colMCUsage, Me.colPresent_Helper, Me.colPresent_Operator})
        GridFormatRule1.Column = Me.colNL
        GridFormatRule1.ColumnApplyTo = Me.colNL
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.Yellow
        FormatConditionRuleValue1.Appearance.BackColor2 = System.Drawing.Color.Yellow
        FormatConditionRuleValue1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.Yellow
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Appearance.Options.UseFont = True
        FormatConditionRuleValue1.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Expression = "1"
        FormatConditionRuleValue1.Value1 = "1"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.Column = Me.colNL
        GridFormatRule2.ColumnApplyTo = Me.colNL
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.White
        FormatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.White
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Expression = "0"
        FormatConditionRuleValue2.Value1 = "0"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        Me.GridView1.FormatRules.Add(GridFormatRule1)
        Me.GridView1.FormatRules.Add(GridFormatRule2)
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.KeepGroupExpandedOnSorting = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.RowHeight = 3
        '
        'colLine
        '
        Me.colLine.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colLine.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colLine.AppearanceCell.Options.UseBorderColor = True
        Me.colLine.AppearanceCell.Options.UseFont = True
        Me.colLine.FieldName = "Line"
        Me.colLine.Name = "colLine"
        Me.colLine.Visible = True
        Me.colLine.VisibleIndex = 0
        Me.colLine.Width = 73
        '
        'colTargetPerHour
        '
        Me.colTargetPerHour.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTargetPerHour.AppearanceCell.Options.UseFont = True
        Me.colTargetPerHour.AppearanceCell.Options.UseTextOptions = True
        Me.colTargetPerHour.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTargetPerHour.Caption = "Target/Hr"
        Me.colTargetPerHour.FieldName = "TargetPerHour"
        Me.colTargetPerHour.Name = "colTargetPerHour"
        Me.colTargetPerHour.Visible = True
        Me.colTargetPerHour.VisibleIndex = 4
        Me.colTargetPerHour.Width = 92
        '
        'colH1
        '
        Me.colH1.AppearanceCell.Options.UseFont = True
        Me.colH1.FieldName = "H1"
        Me.colH1.Name = "colH1"
        Me.colH1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H1", "{0:0.##}")})
        Me.colH1.Visible = True
        Me.colH1.VisibleIndex = 5
        Me.colH1.Width = 72
        '
        'colH2
        '
        Me.colH2.AppearanceCell.Options.UseFont = True
        Me.colH2.FieldName = "H2"
        Me.colH2.Name = "colH2"
        Me.colH2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H2", "{0:0.##}")})
        Me.colH2.Visible = True
        Me.colH2.VisibleIndex = 6
        Me.colH2.Width = 72
        '
        'colH3
        '
        Me.colH3.AppearanceCell.Options.UseFont = True
        Me.colH3.FieldName = "H3"
        Me.colH3.Name = "colH3"
        Me.colH3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H3", "{0:0.##}")})
        Me.colH3.Visible = True
        Me.colH3.VisibleIndex = 7
        Me.colH3.Width = 72
        '
        'colH4
        '
        Me.colH4.AppearanceCell.Options.UseFont = True
        Me.colH4.FieldName = "H4"
        Me.colH4.Name = "colH4"
        Me.colH4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H4", "{0:0.##}")})
        Me.colH4.Visible = True
        Me.colH4.VisibleIndex = 8
        Me.colH4.Width = 72
        '
        'colH5
        '
        Me.colH5.AppearanceCell.Options.UseFont = True
        Me.colH5.FieldName = "H5"
        Me.colH5.Name = "colH5"
        Me.colH5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H5", "{0:0.##}")})
        Me.colH5.Visible = True
        Me.colH5.VisibleIndex = 9
        Me.colH5.Width = 72
        '
        'colH6
        '
        Me.colH6.AppearanceCell.Options.UseFont = True
        Me.colH6.FieldName = "H6"
        Me.colH6.Name = "colH6"
        Me.colH6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H6", "{0:0.##}")})
        Me.colH6.Visible = True
        Me.colH6.VisibleIndex = 10
        Me.colH6.Width = 72
        '
        'colH7
        '
        Me.colH7.AppearanceCell.Options.UseFont = True
        Me.colH7.FieldName = "H7"
        Me.colH7.Name = "colH7"
        Me.colH7.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H7", "{0:0.##}")})
        Me.colH7.Visible = True
        Me.colH7.VisibleIndex = 11
        Me.colH7.Width = 72
        '
        'colH8
        '
        Me.colH8.AppearanceCell.Options.UseFont = True
        Me.colH8.FieldName = "H8"
        Me.colH8.Name = "colH8"
        Me.colH8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H8", "{0:0.##}")})
        Me.colH8.Visible = True
        Me.colH8.VisibleIndex = 12
        Me.colH8.Width = 72
        '
        'colH9
        '
        Me.colH9.AppearanceCell.Options.UseFont = True
        Me.colH9.FieldName = "H9"
        Me.colH9.Name = "colH9"
        Me.colH9.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H9", "{0:0.##}")})
        Me.colH9.Visible = True
        Me.colH9.VisibleIndex = 13
        Me.colH9.Width = 72
        '
        'colH10
        '
        Me.colH10.AppearanceCell.Options.UseFont = True
        Me.colH10.FieldName = "H10"
        Me.colH10.Name = "colH10"
        Me.colH10.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H10", "{0:0.##}")})
        Me.colH10.Visible = True
        Me.colH10.VisibleIndex = 14
        Me.colH10.Width = 72
        '
        'colH11
        '
        Me.colH11.AppearanceCell.Options.UseFont = True
        Me.colH11.FieldName = "H11"
        Me.colH11.Name = "colH11"
        Me.colH11.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H11", "{0:0.##}")})
        Me.colH11.Visible = True
        Me.colH11.VisibleIndex = 15
        Me.colH11.Width = 72
        '
        'colH12
        '
        Me.colH12.AppearanceCell.Options.UseFont = True
        Me.colH12.FieldName = "H12"
        Me.colH12.Name = "colH12"
        Me.colH12.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "H12", "{0:0.##}")})
        Me.colH12.Visible = True
        Me.colH12.VisibleIndex = 16
        Me.colH12.Width = 72
        '
        'colTTLProduction
        '
        Me.colTTLProduction.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTTLProduction.AppearanceCell.Options.UseFont = True
        Me.colTTLProduction.AppearanceCell.Options.UseTextOptions = True
        Me.colTTLProduction.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTTLProduction.FieldName = "TTLProduction"
        Me.colTTLProduction.Name = "colTTLProduction"
        Me.colTTLProduction.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TTLProduction", "{0:0.##}")})
        Me.colTTLProduction.Visible = True
        Me.colTTLProduction.VisibleIndex = 17
        Me.colTTLProduction.Width = 89
        '
        'colMCUsage
        '
        Me.colMCUsage.AppearanceCell.Options.UseFont = True
        Me.colMCUsage.Caption = "MC"
        Me.colMCUsage.FieldName = "MCUsage"
        Me.colMCUsage.Name = "colMCUsage"
        Me.colMCUsage.Visible = True
        Me.colMCUsage.VisibleIndex = 1
        '
        'colPresent_Helper
        '
        Me.colPresent_Helper.AppearanceCell.Options.UseFont = True
        Me.colPresent_Helper.Caption = "P.H"
        Me.colPresent_Helper.FieldName = "Present_Helper"
        Me.colPresent_Helper.Name = "colPresent_Helper"
        Me.colPresent_Helper.Visible = True
        Me.colPresent_Helper.VisibleIndex = 3
        '
        'colPresent_Operator
        '
        Me.colPresent_Operator.AppearanceCell.Options.UseFont = True
        Me.colPresent_Operator.Caption = "P.O"
        Me.colPresent_Operator.FieldName = "Present_Operator"
        Me.colPresent_Operator.Name = "colPresent_Operator"
        Me.colPresent_Operator.Visible = True
        Me.colPresent_Operator.VisibleIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(1223, 674)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Above Targets"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(1223, 697)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Achieve Targets"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(1223, 721)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Bellow Targets"
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.LabelControl4.Appearance.BackColor2 = System.Drawing.Color.RoyalBlue
        Me.LabelControl4.Appearance.Options.UseBackColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(1307, 674)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl4.TabIndex = 9
        Me.LabelControl4.Text = "         "
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.BackColor = System.Drawing.Color.Green
        Me.LabelControl5.Appearance.BackColor2 = System.Drawing.Color.Green
        Me.LabelControl5.Appearance.Options.UseBackColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(1307, 697)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl5.TabIndex = 10
        Me.LabelControl5.Text = "         "
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.Appearance.BackColor = System.Drawing.Color.Red
        Me.LabelControl6.Appearance.BackColor2 = System.Drawing.Color.Red
        Me.LabelControl6.Appearance.Options.UseBackColor = True
        Me.LabelControl6.Location = New System.Drawing.Point(1307, 721)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl6.TabIndex = 11
        Me.LabelControl6.Text = "         "
        '
        'LabelControl8
        '
        Me.LabelControl8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl8.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.LabelControl8.Appearance.BackColor2 = System.Drawing.Color.Yellow
        Me.LabelControl8.Appearance.Options.UseBackColor = True
        Me.LabelControl8.Location = New System.Drawing.Point(1307, 651)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl8.TabIndex = 14
        Me.LabelControl8.Text = "         "
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(1223, 651)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl9.TabIndex = 13
        Me.LabelControl9.Text = "New Line"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(1223, 139)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(99, 13)
        Me.LabelControl7.TabIndex = 12
        Me.LabelControl7.Text = "Select Sewing Date :"
        '
        'ClockLabel
        '
        Me.ClockLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClockLabel.BackColor = System.Drawing.Color.Yellow
        Me.ClockLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ClockLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClockLabel.Location = New System.Drawing.Point(1224, 73)
        Me.ClockLabel.Name = "ClockLabel"
        Me.ClockLabel.Size = New System.Drawing.Size(110, 22)
        Me.ClockLabel.TabIndex = 15
        Me.ClockLabel.Text = "Label1"
        Me.ClockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LastRefreshLabel
        '
        Me.LastRefreshLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LastRefreshLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LastRefreshLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LastRefreshLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastRefreshLabel.Location = New System.Drawing.Point(1224, 114)
        Me.LastRefreshLabel.Name = "LastRefreshLabel"
        Me.LastRefreshLabel.Size = New System.Drawing.Size(110, 22)
        Me.LastRefreshLabel.TabIndex = 15
        Me.LastRefreshLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl10
        '
        Me.LabelControl10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.Location = New System.Drawing.Point(1224, 98)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(97, 13)
        Me.LabelControl10.TabIndex = 12
        Me.LabelControl10.Text = "Last Refreshed On :"
        '
        'LabelControl11
        '
        Me.LabelControl11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl11.Appearance.Options.UseForeColor = True
        Me.LabelControl11.Location = New System.Drawing.Point(1224, 57)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl11.TabIndex = 12
        Me.LabelControl11.Text = "Clock :"
        '
        'SewingLineStatusNewTableAdapter
        '
        Me.SewingLineStatusNewTableAdapter.ClearBeforeFill = True
        '
        'CloseSimpleButton
        '
        Me.CloseSimpleButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseSimpleButton.Location = New System.Drawing.Point(1223, 242)
        Me.CloseSimpleButton.Name = "CloseSimpleButton"
        Me.CloseSimpleButton.Size = New System.Drawing.Size(110, 23)
        Me.CloseSimpleButton.TabIndex = 2
        Me.CloseSimpleButton.Text = "&Close"
        '
        'MessageLabel
        '
        Me.MessageLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MessageLabel.AutoSize = True
        Me.MessageLabel.Location = New System.Drawing.Point(1316, 55)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(16, 13)
        Me.MessageLabel.TabIndex = 16
        Me.MessageLabel.Text = "..."
        '
        'U1Button
        '
        Me.U1Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.U1Button.Location = New System.Drawing.Point(1223, 347)
        Me.U1Button.Name = "U1Button"
        Me.U1Button.Size = New System.Drawing.Size(111, 23)
        Me.U1Button.TabIndex = 17
        Me.U1Button.Text = "Sewing Unit 1"
        '
        'U2Button
        '
        Me.U2Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.U2Button.Location = New System.Drawing.Point(1223, 372)
        Me.U2Button.Name = "U2Button"
        Me.U2Button.Size = New System.Drawing.Size(110, 23)
        Me.U2Button.TabIndex = 17
        Me.U2Button.Text = "Sewing Unit 2"
        '
        'U4Button
        '
        Me.U4Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.U4Button.Location = New System.Drawing.Point(1223, 422)
        Me.U4Button.Name = "U4Button"
        Me.U4Button.Size = New System.Drawing.Size(110, 23)
        Me.U4Button.TabIndex = 18
        Me.U4Button.Text = "Sewing Unit 4"
        '
        'U3Button
        '
        Me.U3Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.U3Button.Location = New System.Drawing.Point(1223, 397)
        Me.U3Button.Name = "U3Button"
        Me.U3Button.Size = New System.Drawing.Size(111, 23)
        Me.U3Button.TabIndex = 19
        Me.U3Button.Text = "Sewing Unit 3"
        '
        'U6Button
        '
        Me.U6Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.U6Button.Location = New System.Drawing.Point(1223, 472)
        Me.U6Button.Name = "U6Button"
        Me.U6Button.Size = New System.Drawing.Size(110, 23)
        Me.U6Button.TabIndex = 20
        Me.U6Button.Text = "Sewing Unit 6"
        '
        'U5Button
        '
        Me.U5Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.U5Button.Location = New System.Drawing.Point(1223, 447)
        Me.U5Button.Name = "U5Button"
        Me.U5Button.Size = New System.Drawing.Size(111, 23)
        Me.U5Button.TabIndex = 21
        Me.U5Button.Text = "Sewing Unit 5"
        '
        'U8Button
        '
        Me.U8Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.U8Button.Location = New System.Drawing.Point(1223, 522)
        Me.U8Button.Name = "U8Button"
        Me.U8Button.Size = New System.Drawing.Size(110, 23)
        Me.U8Button.TabIndex = 22
        Me.U8Button.Text = "Sewing Unit 8"
        '
        'U7Button
        '
        Me.U7Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.U7Button.Location = New System.Drawing.Point(1223, 497)
        Me.U7Button.Name = "U7Button"
        Me.U7Button.Size = New System.Drawing.Size(111, 23)
        Me.U7Button.TabIndex = 23
        Me.U7Button.Text = "Sewing Unit 7"
        '
        'Unit10Button
        '
        Me.Unit10Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Unit10Button.Location = New System.Drawing.Point(1223, 572)
        Me.Unit10Button.Name = "Unit10Button"
        Me.Unit10Button.Size = New System.Drawing.Size(110, 23)
        Me.Unit10Button.TabIndex = 24
        Me.Unit10Button.Text = "Sewing Unit 10"
        '
        'Unit9Button
        '
        Me.Unit9Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Unit9Button.Location = New System.Drawing.Point(1223, 547)
        Me.Unit9Button.Name = "Unit9Button"
        Me.Unit9Button.Size = New System.Drawing.Size(111, 23)
        Me.Unit9Button.TabIndex = 25
        Me.Unit9Button.Text = "Sewing Unit 9"
        '
        'UnitLabel
        '
        Me.UnitLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UnitLabel.AutoSize = True
        Me.UnitLabel.BackColor = System.Drawing.Color.Black
        Me.UnitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitLabel.ForeColor = System.Drawing.Color.Yellow
        Me.UnitLabel.Location = New System.Drawing.Point(12, 8)
        Me.UnitLabel.Name = "UnitLabel"
        Me.UnitLabel.Size = New System.Drawing.Size(579, 39)
        Me.UnitLabel.TabIndex = 26
        Me.UnitLabel.Text = "NORBAN COMTEX LIMITED  :  {0}"
        Me.UnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer2
        '
        '
        'PlusButton
        '
        Me.PlusButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlusButton.Location = New System.Drawing.Point(1282, 274)
        Me.PlusButton.Name = "PlusButton"
        Me.PlusButton.Size = New System.Drawing.Size(22, 22)
        Me.PlusButton.TabIndex = 27
        Me.PlusButton.Text = "+"
        '
        'MinusButton
        '
        Me.MinusButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinusButton.Location = New System.Drawing.Point(1310, 274)
        Me.MinusButton.Name = "MinusButton"
        Me.MinusButton.Size = New System.Drawing.Size(22, 22)
        Me.MinusButton.TabIndex = 27
        Me.MinusButton.Text = "-"
        '
        'LabelControl12
        '
        Me.LabelControl12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl12.Appearance.Options.UseForeColor = True
        Me.LabelControl12.Location = New System.Drawing.Point(1228, 278)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl12.TabIndex = 12
        Me.LabelControl12.Text = "Row :"
        '
        'LabelControl13
        '
        Me.LabelControl13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl13.Appearance.Options.UseForeColor = True
        Me.LabelControl13.Location = New System.Drawing.Point(1228, 301)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl13.TabIndex = 12
        Me.LabelControl13.Text = "Font :"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Location = New System.Drawing.Point(1282, 298)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(22, 22)
        Me.SimpleButton1.TabIndex = 27
        Me.SimpleButton1.Text = "+"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Location = New System.Drawing.Point(1310, 298)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(22, 22)
        Me.SimpleButton2.TabIndex = 27
        Me.SimpleButton2.Text = "-"
        '
        'Timer3
        '
        '
        'LabelControl14
        '
        Me.LabelControl14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl14.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl14.Appearance.Options.UseForeColor = True
        Me.LabelControl14.Location = New System.Drawing.Point(1228, 326)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl14.TabIndex = 12
        Me.LabelControl14.Text = "Refresh :"
        '
        'SpinEdit1
        '
        Me.SpinEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(1282, 323)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit1.Size = New System.Drawing.Size(51, 20)
        Me.SpinEdit1.TabIndex = 28
        '
        'CheckedComboBoxEdit1
        '
        Me.CheckedComboBoxEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckedComboBoxEdit1.Location = New System.Drawing.Point(1223, 601)
        Me.CheckedComboBoxEdit1.Name = "CheckedComboBoxEdit1"
        Me.CheckedComboBoxEdit1.Properties.AllowMultiSelect = True
        Me.CheckedComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CheckedComboBoxEdit1.Properties.DataSource = Me.LineBindingSource
        Me.CheckedComboBoxEdit1.Properties.DisplayMember = "Line"
        Me.CheckedComboBoxEdit1.Properties.DropDownRows = 10
        Me.CheckedComboBoxEdit1.Properties.ValueMember = "LineId"
        Me.CheckedComboBoxEdit1.Size = New System.Drawing.Size(109, 20)
        Me.CheckedComboBoxEdit1.TabIndex = 29
        '
        'LineBindingSource
        '
        Me.LineBindingSource.DataMember = "Line"
        Me.LineBindingSource.DataSource = Me.LineDataSet
        '
        'LineDataSet
        '
        Me.LineDataSet.DataSetName = "LineDataSet"
        Me.LineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LineTableAdapter
        '
        Me.LineTableAdapter.ClearBeforeFill = True
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Location = New System.Drawing.Point(1223, 623)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(110, 23)
        Me.SimpleButton3.TabIndex = 30
        Me.SimpleButton3.Text = "Show by Selected"
        '
        'frmSewingLineStatusReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1354, 746)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.CheckedComboBoxEdit1)
        Me.Controls.Add(Me.SpinEdit1)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.MinusButton)
        Me.Controls.Add(Me.PlusButton)
        Me.Controls.Add(Me.UnitLabel)
        Me.Controls.Add(Me.Unit10Button)
        Me.Controls.Add(Me.Unit9Button)
        Me.Controls.Add(Me.U8Button)
        Me.Controls.Add(Me.U7Button)
        Me.Controls.Add(Me.U6Button)
        Me.Controls.Add(Me.U5Button)
        Me.Controls.Add(Me.U4Button)
        Me.Controls.Add(Me.U3Button)
        Me.Controls.Add(Me.U2Button)
        Me.Controls.Add(Me.U1Button)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.LastRefreshLabel)
        Me.Controls.Add(Me.ClockLabel)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.SewingDateDateEdit)
        Me.Controls.Add(Me.CloseSimpleButton)
        Me.Controls.Add(Me.RefreshButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSewingLineStatusReport"
        Me.Text = "Sewing Line Status"
        CType(Me.SewingDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingLineStatusNewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingLineStatusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckedComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents RefreshButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colTargetsPerHour As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SewingDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ShowButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ClockLabel As Label
    Friend WithEvents LastRefreshLabel As Label
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SewingLineStatusDataSet As SewingLineStatusDataSet
    Friend WithEvents SewingLineStatusNewBindingSource As BindingSource
    Friend WithEvents SewingLineStatusNewTableAdapter As SewingLineStatusDataSetTableAdapters.SewingLineStatusNewTableAdapter
    Friend WithEvents colLine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTargetPerHour As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colH1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colH2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colH3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colH4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colH5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colH6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colH7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colH8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colH9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colH10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colH11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colH12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTTLProduction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CloseSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MessageLabel As Label
    Friend WithEvents U1Button As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents U2Button As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents U4Button As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents U3Button As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents U6Button As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents U5Button As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents U8Button As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents U7Button As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Unit10Button As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Unit9Button As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents UnitLabel As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PlusButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MinusButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer3 As Timer
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents colMCUsage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPresent_Helper As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPresent_Operator As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckedComboBoxEdit1 As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LineDataSet As LineDataSet
    Friend WithEvents LineBindingSource As BindingSource
    Friend WithEvents LineTableAdapter As LineDataSetTableAdapters.LineTableAdapter
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
End Class
