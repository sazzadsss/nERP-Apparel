<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintingMachineStoppage
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
        Dim StoppageReasonIdLabel As System.Windows.Forms.Label
        Dim ResasonLabel As System.Windows.Forms.Label
        Dim Total_StringLabel As System.Windows.Forms.Label
        Dim TotalsLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim FromTimeLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label8 = New System.Windows.Forms.Label
        Me.LossHourLabel = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.RemarksTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.PrintMachineStoppageDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintMachineStoppageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintingMachineStoppageDataSet = New KSoft_Apparel.PrintingMachineStoppageDataSet
        Me.StoppageReasonIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.StoppageReasonIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Label6 = New System.Windows.Forms.Label
        Me.EfficiencyLabel = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TTLHourLabel2 = New System.Windows.Forms.Label
        Me.RefreshButton = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.GTLabel = New System.Windows.Forms.Label
        Me.SaveButton = New System.Windows.Forms.Button
        Me.Total_StringTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.TotalsSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.AddButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.FromTimeDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.ToTimeDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel
        Me.Label7 = New System.Windows.Forms.Label
        Me.PrintMachineStoppageDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrintMachineStoppageDetailsDataGridView = New System.Windows.Forms.DataGridView
        Me.SlNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrintMachineStoppageTableAdapter = New KSoft_Apparel.PrintingMachineStoppageDataSetTableAdapters.PrintMachineStoppageTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.PrintingMachineStoppageDataSetTableAdapters.TableAdapterManager
        Me.PrintMachineStoppageDetailsTableAdapter = New KSoft_Apparel.PrintingMachineStoppageDataSetTableAdapters.PrintMachineStoppageDetailsTableAdapter
        Me.PrintMachineStoppageReasonDataSet = New KSoft_Apparel.PrintMachineStoppageReasonDataSet
        Me.PrintMachineStoppageReasonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintMachineStoppageReasonTableAdapter = New KSoft_Apparel.PrintMachineStoppageReasonDataSetTableAdapters.PrintMachineStoppageReasonTableAdapter
        Me.colStoppageReasonId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReason = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsLoss = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn
        StoppageReasonIdLabel = New System.Windows.Forms.Label
        ResasonLabel = New System.Windows.Forms.Label
        Total_StringLabel = New System.Windows.Forms.Label
        TotalsLabel = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        FromTimeLabel = New System.Windows.Forms.Label
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintMachineStoppageDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintMachineStoppageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingMachineStoppageDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoppageReasonIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoppageReasonIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Total_StringTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FromTimeDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FromTimeDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToTimeDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToTimeDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.PrintMachineStoppageDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintMachineStoppageDetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintMachineStoppageReasonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintMachineStoppageReasonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StoppageReasonIdLabel
        '
        StoppageReasonIdLabel.AutoSize = True
        StoppageReasonIdLabel.Location = New System.Drawing.Point(553, 132)
        StoppageReasonIdLabel.Name = "StoppageReasonIdLabel"
        StoppageReasonIdLabel.Size = New System.Drawing.Size(50, 13)
        StoppageReasonIdLabel.TabIndex = 51
        StoppageReasonIdLabel.Text = "Reason :"
        '
        'ResasonLabel
        '
        ResasonLabel.AutoSize = True
        ResasonLabel.Location = New System.Drawing.Point(553, 155)
        ResasonLabel.Name = "ResasonLabel"
        ResasonLabel.Size = New System.Drawing.Size(52, 13)
        ResasonLabel.TabIndex = 42
        ResasonLabel.Text = "Remarks:"
        '
        'Total_StringLabel
        '
        Total_StringLabel.AutoSize = True
        Total_StringLabel.Location = New System.Drawing.Point(733, 80)
        Total_StringLabel.Name = "Total_StringLabel"
        Total_StringLabel.Size = New System.Drawing.Size(71, 13)
        Total_StringLabel.TabIndex = 44
        Total_StringLabel.Text = "Total [hh:mm]"
        '
        'TotalsLabel
        '
        TotalsLabel.AutoSize = True
        TotalsLabel.Location = New System.Drawing.Point(733, 106)
        TotalsLabel.Name = "TotalsLabel"
        TotalsLabel.Size = New System.Drawing.Size(60, 13)
        TotalsLabel.TabIndex = 43
        TotalsLabel.Text = "Total [Dec]"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(553, 106)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(49, 13)
        Label3.TabIndex = 41
        Label3.Text = "To Time:"
        '
        'FromTimeLabel
        '
        FromTimeLabel.AutoSize = True
        FromTimeLabel.Location = New System.Drawing.Point(553, 80)
        FromTimeLabel.Name = "FromTimeLabel"
        FromTimeLabel.Size = New System.Drawing.Size(59, 13)
        FromTimeLabel.TabIndex = 38
        FromTimeLabel.Text = "From Time:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(608, 568)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 23)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Loss Hour"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LossHourLabel
        '
        Me.LossHourLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LossHourLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LossHourLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LossHourLabel.Location = New System.Drawing.Point(702, 568)
        Me.LossHourLabel.Name = "LossHourLabel"
        Me.LossHourLabel.Size = New System.Drawing.Size(100, 23)
        Me.LossHourLabel.TabIndex = 53
        Me.LossHourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Image = Global.KSoft_Apparel.My.Resources.Resources.Synchronize_icon
        Me.Button1.Location = New System.Drawing.Point(879, 127)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 22)
        Me.Button1.TabIndex = 35
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RemarksTextEdit
        '
        Me.RemarksTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintMachineStoppageDetailsBindingSource, "Remarks", True))
        Me.RemarksTextEdit.Location = New System.Drawing.Point(618, 152)
        Me.RemarksTextEdit.Name = "RemarksTextEdit"
        Me.RemarksTextEdit.Size = New System.Drawing.Size(255, 20)
        Me.RemarksTextEdit.TabIndex = 37
        '
        'PrintMachineStoppageDetailsBindingSource
        '
        Me.PrintMachineStoppageDetailsBindingSource.DataMember = "FK_PrintMachineStoppageDetails_PrintMachineStoppage"
        Me.PrintMachineStoppageDetailsBindingSource.DataSource = Me.PrintMachineStoppageBindingSource
        '
        'PrintMachineStoppageBindingSource
        '
        Me.PrintMachineStoppageBindingSource.DataMember = "PrintMachineStoppage"
        Me.PrintMachineStoppageBindingSource.DataSource = Me.PrintingMachineStoppageDataSet
        '
        'PrintingMachineStoppageDataSet
        '
        Me.PrintingMachineStoppageDataSet.DataSetName = "PrintingMachineStoppageDataSet"
        Me.PrintingMachineStoppageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StoppageReasonIdGridLookUpEdit
        '
        Me.StoppageReasonIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintMachineStoppageDetailsBindingSource, "StoppageReasonId", True))
        Me.StoppageReasonIdGridLookUpEdit.Location = New System.Drawing.Point(618, 128)
        Me.StoppageReasonIdGridLookUpEdit.Name = "StoppageReasonIdGridLookUpEdit"
        Me.StoppageReasonIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StoppageReasonIdGridLookUpEdit.Properties.DataSource = Me.PrintMachineStoppageReasonBindingSource
        Me.StoppageReasonIdGridLookUpEdit.Properties.DisplayMember = "Reason"
        Me.StoppageReasonIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.StoppageReasonIdGridLookUpEdit.Properties.NullText = ""
        Me.StoppageReasonIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.StoppageReasonIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.StoppageReasonIdGridLookUpEdit.Properties.ValueMember = "StoppageReasonId"
        Me.StoppageReasonIdGridLookUpEdit.Properties.View = Me.StoppageReasonIdGridLookUpEditView
        Me.StoppageReasonIdGridLookUpEdit.Size = New System.Drawing.Size(255, 20)
        Me.StoppageReasonIdGridLookUpEdit.TabIndex = 33
        '
        'StoppageReasonIdGridLookUpEditView
        '
        Me.StoppageReasonIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStoppageReasonId, Me.colReason, Me.colIsLoss, Me.colDescription})
        Me.StoppageReasonIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.StoppageReasonIdGridLookUpEditView.Name = "StoppageReasonIdGridLookUpEditView"
        Me.StoppageReasonIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.StoppageReasonIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(194, 568)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 23)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Eff:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EfficiencyLabel
        '
        Me.EfficiencyLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EfficiencyLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EfficiencyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EfficiencyLabel.Location = New System.Drawing.Point(244, 568)
        Me.EfficiencyLabel.Name = "EfficiencyLabel"
        Me.EfficiencyLabel.Size = New System.Drawing.Size(79, 23)
        Me.EfficiencyLabel.TabIndex = 50
        Me.EfficiencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(34, 568)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Total Hour"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TTLHourLabel2
        '
        Me.TTLHourLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TTLHourLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TTLHourLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TTLHourLabel2.Location = New System.Drawing.Point(109, 568)
        Me.TTLHourLabel2.Name = "TTLHourLabel2"
        Me.TTLHourLabel2.Size = New System.Drawing.Size(79, 23)
        Me.TTLHourLabel2.TabIndex = 48
        Me.TTLHourLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RefreshButton
        '
        Me.RefreshButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Synchronize_icon
        Me.RefreshButton.Location = New System.Drawing.Point(879, 151)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(39, 22)
        Me.RefreshButton.TabIndex = 39
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(385, 568)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 23)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Idle Hour"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GTLabel
        '
        Me.GTLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GTLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GTLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GTLabel.Location = New System.Drawing.Point(488, 568)
        Me.GTLabel.Name = "GTLabel"
        Me.GTLabel.Size = New System.Drawing.Size(100, 23)
        Me.GTLabel.TabIndex = 46
        Me.GTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(940, 117)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(80, 5, 3, 3)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(103, 32)
        Me.SaveButton.TabIndex = 40
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Total_StringTextEdit
        '
        Me.Total_StringTextEdit.Location = New System.Drawing.Point(818, 77)
        Me.Total_StringTextEdit.Name = "Total_StringTextEdit"
        Me.Total_StringTextEdit.Properties.ReadOnly = True
        Me.Total_StringTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Total_StringTextEdit.TabIndex = 34
        Me.Total_StringTextEdit.TabStop = False
        '
        'TotalsSpinEdit
        '
        Me.TotalsSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintMachineStoppageDetailsBindingSource, "Totals", True))
        Me.TotalsSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TotalsSpinEdit.Location = New System.Drawing.Point(818, 103)
        Me.TotalsSpinEdit.Name = "TotalsSpinEdit"
        Me.TotalsSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.TotalsSpinEdit.Properties.ReadOnly = True
        Me.TotalsSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.TotalsSpinEdit.TabIndex = 32
        Me.TotalsSpinEdit.TabStop = False
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(940, 75)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(103, 34)
        Me.AddButton.TabIndex = 29
        Me.AddButton.Text = "&New"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Machine Stoppage Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(138, 48)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(97, 20)
        Me.DateTimePicker1.TabIndex = 27
        '
        'FromTimeDateEdit
        '
        Me.FromTimeDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintMachineStoppageDetailsBindingSource, "FromTime", True))
        Me.FromTimeDateEdit.EditValue = Nothing
        Me.FromTimeDateEdit.Location = New System.Drawing.Point(618, 77)
        Me.FromTimeDateEdit.Name = "FromTimeDateEdit"
        Me.FromTimeDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FromTimeDateEdit.Properties.Appearance.Options.UseBackColor = True
        Me.FromTimeDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FromTimeDateEdit.Properties.DisplayFormat.FormatString = "t"
        Me.FromTimeDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.FromTimeDateEdit.Properties.EditFormat.FormatString = "t"
        Me.FromTimeDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.FromTimeDateEdit.Properties.Mask.EditMask = "t"
        Me.FromTimeDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.FromTimeDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.FromTimeDateEdit.TabIndex = 30
        '
        'ToTimeDateEdit
        '
        Me.ToTimeDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintMachineStoppageDetailsBindingSource, "ToTime", True))
        Me.ToTimeDateEdit.EditValue = Nothing
        Me.ToTimeDateEdit.Location = New System.Drawing.Point(618, 103)
        Me.ToTimeDateEdit.Name = "ToTimeDateEdit"
        Me.ToTimeDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToTimeDateEdit.Properties.Appearance.Options.UseBackColor = True
        Me.ToTimeDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ToTimeDateEdit.Properties.DisplayFormat.FormatString = "t"
        Me.ToTimeDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ToTimeDateEdit.Properties.EditFormat.FormatString = "t"
        Me.ToTimeDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ToTimeDateEdit.Properties.Mask.EditMask = "t"
        Me.ToTimeDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ToTimeDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.ToTimeDateEdit.TabIndex = 31
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel3.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(1129, 32)
        Me.FlowLayoutPanel3.TabIndex = 56
        Me.FlowLayoutPanel3.Tag = "NR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(3, 5)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 23)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Dyeing Machine Stoppage"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintMachineStoppageDataGridView
        '
        Me.PrintMachineStoppageDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PrintMachineStoppageDataGridView.AutoGenerateColumns = False
        Me.PrintMachineStoppageDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.PrintMachineStoppageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PrintMachineStoppageDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn9})
        Me.PrintMachineStoppageDataGridView.DataSource = Me.PrintMachineStoppageBindingSource
        Me.PrintMachineStoppageDataGridView.Location = New System.Drawing.Point(12, 78)
        Me.PrintMachineStoppageDataGridView.Name = "PrintMachineStoppageDataGridView"
        Me.PrintMachineStoppageDataGridView.Size = New System.Drawing.Size(524, 467)
        Me.PrintMachineStoppageDataGridView.TabIndex = 56
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MachineNo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MC No"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "LossHour_String"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Loss [hh:mm]"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "LossHour"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Loss [Dec]"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TotalStopage_String"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Idle [hh:mm]"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TotalStopage"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Idle [Dec]"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 70
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Efficiency"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Efficiency"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 60
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'PrintMachineStoppageDetailsDataGridView
        '
        Me.PrintMachineStoppageDetailsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintMachineStoppageDetailsDataGridView.AutoGenerateColumns = False
        Me.PrintMachineStoppageDetailsDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.PrintMachineStoppageDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PrintMachineStoppageDetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SlNo, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn14})
        Me.PrintMachineStoppageDetailsDataGridView.DataSource = Me.PrintMachineStoppageDetailsBindingSource
        Me.PrintMachineStoppageDetailsDataGridView.Location = New System.Drawing.Point(556, 191)
        Me.PrintMachineStoppageDetailsDataGridView.Name = "PrintMachineStoppageDetailsDataGridView"
        Me.PrintMachineStoppageDetailsDataGridView.Size = New System.Drawing.Size(561, 354)
        Me.PrintMachineStoppageDetailsDataGridView.TabIndex = 56
        '
        'SlNo
        '
        Me.SlNo.DataPropertyName = "SlNo"
        Me.SlNo.HeaderText = "SlNo"
        Me.SlNo.Name = "SlNo"
        Me.SlNo.Width = 50
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "FromTime"
        DataGridViewCellStyle7.Format = "t"
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn11.HeaderText = "FromTime"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ToTime"
        DataGridViewCellStyle8.Format = "t"
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn12.HeaderText = "ToTime"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Total_String"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Total [hh:mm]"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Totals"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Total [ Dec ]"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "StoppageReasonId"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Reason"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'PrintMachineStoppageTableAdapter
        '
        Me.PrintMachineStoppageTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PrintMachineStoppageDetailsTableAdapter = Me.PrintMachineStoppageDetailsTableAdapter
        Me.TableAdapterManager.PrintMachineStoppageTableAdapter = Me.PrintMachineStoppageTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.PrintingMachineStoppageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PrintMachineStoppageDetailsTableAdapter
        '
        Me.PrintMachineStoppageDetailsTableAdapter.ClearBeforeFill = True
        '
        'PrintMachineStoppageReasonDataSet
        '
        Me.PrintMachineStoppageReasonDataSet.DataSetName = "PrintMachineStoppageReasonDataSet"
        Me.PrintMachineStoppageReasonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrintMachineStoppageReasonBindingSource
        '
        Me.PrintMachineStoppageReasonBindingSource.DataMember = "PrintMachineStoppageReason"
        Me.PrintMachineStoppageReasonBindingSource.DataSource = Me.PrintMachineStoppageReasonDataSet
        '
        'PrintMachineStoppageReasonTableAdapter
        '
        Me.PrintMachineStoppageReasonTableAdapter.ClearBeforeFill = True
        '
        'colStoppageReasonId
        '
        Me.colStoppageReasonId.FieldName = "StoppageReasonId"
        Me.colStoppageReasonId.Name = "colStoppageReasonId"
        Me.colStoppageReasonId.OptionsColumn.ReadOnly = True
        '
        'colReason
        '
        Me.colReason.FieldName = "Reason"
        Me.colReason.Name = "colReason"
        Me.colReason.Visible = True
        Me.colReason.VisibleIndex = 0
        '
        'colIsLoss
        '
        Me.colIsLoss.FieldName = "IsLoss"
        Me.colIsLoss.Name = "colIsLoss"
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        '
        'frmPrintingMachineStoppage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 568)
        Me.Controls.Add(Me.PrintMachineStoppageDetailsDataGridView)
        Me.Controls.Add(Me.PrintMachineStoppageDataGridView)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LossHourLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RemarksTextEdit)
        Me.Controls.Add(StoppageReasonIdLabel)
        Me.Controls.Add(Me.StoppageReasonIdGridLookUpEdit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.EfficiencyLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TTLHourLabel2)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GTLabel)
        Me.Controls.Add(ResasonLabel)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Total_StringLabel)
        Me.Controls.Add(Me.Total_StringTextEdit)
        Me.Controls.Add(TotalsLabel)
        Me.Controls.Add(Me.TotalsSpinEdit)
        Me.Controls.Add(Label3)
        Me.Controls.Add(FromTimeLabel)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.FromTimeDateEdit)
        Me.Controls.Add(Me.ToTimeDateEdit)
        Me.Name = "frmPrintingMachineStoppage"
        Me.Text = "frmPrintingMachineStoppage"
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintMachineStoppageDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintMachineStoppageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingMachineStoppageDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoppageReasonIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoppageReasonIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Total_StringTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FromTimeDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FromTimeDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToTimeDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToTimeDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        CType(Me.PrintMachineStoppageDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintMachineStoppageDetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintMachineStoppageReasonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintMachineStoppageReasonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LossHourLabel As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RemarksTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents StoppageReasonIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents StoppageReasonIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents EfficiencyLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TTLHourLabel2 As System.Windows.Forms.Label
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GTLabel As System.Windows.Forms.Label
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents Total_StringTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TotalsSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents FromTimeDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ToTimeDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PrintingMachineStoppageDataSet As KSoft_Apparel.PrintingMachineStoppageDataSet
    Friend WithEvents PrintMachineStoppageBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintMachineStoppageTableAdapter As KSoft_Apparel.PrintingMachineStoppageDataSetTableAdapters.PrintMachineStoppageTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.PrintingMachineStoppageDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PrintMachineStoppageDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PrintMachineStoppageDetailsTableAdapter As KSoft_Apparel.PrintingMachineStoppageDataSetTableAdapters.PrintMachineStoppageDetailsTableAdapter
    Friend WithEvents PrintMachineStoppageDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintMachineStoppageDetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SlNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintMachineStoppageReasonDataSet As KSoft_Apparel.PrintMachineStoppageReasonDataSet
    Friend WithEvents PrintMachineStoppageReasonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintMachineStoppageReasonTableAdapter As KSoft_Apparel.PrintMachineStoppageReasonDataSetTableAdapters.PrintMachineStoppageReasonTableAdapter
    Friend WithEvents colStoppageReasonId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsLoss As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
End Class
