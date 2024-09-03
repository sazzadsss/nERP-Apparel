' Developer Express Code Central Example:
' How to customize the Edit Appointment form to show custom fields
' 
' This example illustrates the use of a custom form to enable the end-user to edit
' custom fields. The custom form is invoked instead of the default one by handling
' the SchedulerControl.EditAppointmentFormShowing
' (ms-help://DevExpress.NETv8.2/DevExpress.XtraScheduler/DevExpressXtraSchedulerSchedulerControl_EditAppointmentFormShowingtopic.htm)
' event.
' 
' See also:
' For a simple application that enables you to handle custom
' fields, see the http://www.devexpress.com/scid=E2782 article.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E152

Imports Microsoft.VisualBasic
Imports System
Namespace CustomAppointmentEditForm
    Partial Public Class MyAppointmentEditForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.checkAllDay = New DevExpress.XtraEditors.CheckEdit()
            Me.timeEnd = New DevExpress.XtraEditors.TimeEdit()
            Me.timeStart = New DevExpress.XtraEditors.TimeEdit()
            Me.dtEnd = New DevExpress.XtraEditors.DateEdit()
            Me.dtStart = New DevExpress.XtraEditors.DateEdit()
            Me.lblCustomStatus = New System.Windows.Forms.Label()
            Me.lblCustomName = New System.Windows.Forms.Label()
            Me.lblLabel = New System.Windows.Forms.Label()
            Me.lblStatus = New System.Windows.Forms.Label()
            Me.edStatus = New DevExpress.XtraScheduler.UI.AppointmentStatusEdit()
            Me.SchedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.AppointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.PlanningBoardNewDataSet = New KSoft_Apparel.PlanningBoardNewDataSet()
            Me.LineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.LineDataSet = New KSoft_Apparel.LineDataSet()
            Me.edLabel = New DevExpress.XtraScheduler.UI.AppointmentLabelEdit()
            Me.txSubject = New DevExpress.XtraEditors.TextEdit()
            Me.lblSubject = New System.Windows.Forms.Label()
            Me.btnRecurrence = New DevExpress.XtraEditors.SimpleButton()
            Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
            Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
            Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
            Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
            Me.txFabricColorId = New DevExpress.XtraEditors.GridLookUpEdit()
            Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOrderId1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFabricColorId = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProgramNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.SewingOutputBalanceListGridControl = New DevExpress.XtraGrid.GridControl()
            Me.PlanningBalanceOIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.PlanningBalanceDataSet = New KSoft_Apparel.PlanningBalanceDataSet()
            Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colEX = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPO = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCuttingQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInputQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOutputQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPlanningQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPlanningBalance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotalTargetQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colYR = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMH = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStyleType = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSewingPercentage = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSewingRequireQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSelect = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFabricColorName1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.OrderLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
            Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colDetails1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
            Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.MessageLabel = New System.Windows.Forms.Label()
            Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
            Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.AppointmentDetailsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDaySerial = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPlanningDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEfficiency = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPlanningQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTarget = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.PlanQtyLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.GetDataButton = New DevExpress.XtraEditors.SimpleButton()
            Me.txPlanningQuantity = New DevExpress.XtraEditors.SpinEdit()
            Me.ESPSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.LatestExDateTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.ExDateEdit = New DevExpress.XtraEditors.DateEdit()
            Me.CalculateButton = New System.Windows.Forms.Button()
            Me.WorkingLabel = New System.Windows.Forms.Label()
            Me.WHTextBox = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.POLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
            Me.OrderPOLookupNewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.OrderPOLookupNewDataSet = New KSoft_Apparel.OrderPOLookupNewDataSet()
            Me.AdvancedCheckBox = New System.Windows.Forms.CheckBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.PlanningIdLabel = New System.Windows.Forms.Label()
            Me.SaveAndContinueSimpleButton = New DevExpress.XtraEditors.SimpleButton()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.HourRequireTextBox = New System.Windows.Forms.TextBox()
            Me.TargetTextBox = New System.Windows.Forms.TextBox()
            Me.EndDateLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.StartDateLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.DayRequireTextBox = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txResourceId = New DevExpress.XtraEditors.LookUpEdit()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.txOrderId = New DevExpress.XtraEditors.LookUpEdit()
            Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.LineTableAdapter = New KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter()
            Me.AppointmentsTableAdapter = New KSoft_Apparel.PlanningBoardNewDataSetTableAdapters.AppointmentsTableAdapter()
            Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.LineTableAdapter1 = New KSoft_Apparel.PlanningBoardNewDataSetTableAdapters.LineTableAdapter()
            Me.TableAdapterManager = New KSoft_Apparel.PlanningBoardNewDataSetTableAdapters.TableAdapterManager()
            Me.AppointmentDetailsTableAdapter = New KSoft_Apparel.PlanningBoardNewDataSetTableAdapters.AppointmentDetailsTableAdapter()
            Me.OrderPOLookupNewTableAdapter = New KSoft_Apparel.OrderPOLookupNewDataSetTableAdapters.OrderPOLookupNewTableAdapter()
            Me.PlanningBalanceOIDTableAdapter = New KSoft_Apparel.PlanningBalanceDataSetTableAdapters.PlanningBalanceOIDTableAdapter()
            Me.TableAdapterManager1 = New KSoft_Apparel.PlanningBalanceDataSetTableAdapters.TableAdapterManager()
            CType(Me.checkAllDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.timeEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.timeStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PlanningBoardNewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edLabel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txFabricColorId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SewingOutputBalanceListGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PlanningBalanceOIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PlanningBalanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer1.Panel1.SuspendLayout()
            Me.SplitContainer1.Panel2.SuspendLayout()
            Me.SplitContainer1.SuspendLayout()
            CType(Me.OrderLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer2.Panel2.SuspendLayout()
            Me.SplitContainer2.SuspendLayout()
            CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AppointmentDetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txPlanningQuantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ESPSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LatestExDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ExDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ExDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.POLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.OrderPOLookupNewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.OrderPOLookupNewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txResourceId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txOrderId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'checkAllDay
            '
            Me.checkAllDay.Location = New System.Drawing.Point(267, 125)
            Me.checkAllDay.Name = "checkAllDay"
            Me.checkAllDay.Properties.Caption = "All day event"
            Me.checkAllDay.Size = New System.Drawing.Size(88, 19)
            Me.checkAllDay.TabIndex = 23
            '
            'timeEnd
            '
            Me.timeEnd.EditValue = New Date(2006, 3, 28, 17, 0, 0, 0)
            Me.timeEnd.Location = New System.Drawing.Point(738, 198)
            Me.timeEnd.Name = "timeEnd"
            Me.timeEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.timeEnd.Size = New System.Drawing.Size(113, 20)
            Me.timeEnd.TabIndex = 21
            '
            'timeStart
            '
            Me.timeStart.EditValue = New Date(2006, 3, 28, 8, 0, 0, 0)
            Me.timeStart.Location = New System.Drawing.Point(738, 173)
            Me.timeStart.Name = "timeStart"
            Me.timeStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.timeStart.Size = New System.Drawing.Size(113, 20)
            Me.timeStart.TabIndex = 19
            '
            'dtEnd
            '
            Me.dtEnd.EditValue = New Date(2005, 11, 25, 0, 0, 0, 0)
            Me.dtEnd.Location = New System.Drawing.Point(629, 199)
            Me.dtEnd.Name = "dtEnd"
            Me.dtEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dtEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dtEnd.Size = New System.Drawing.Size(94, 20)
            Me.dtEnd.TabIndex = 20
            '
            'dtStart
            '
            Me.dtStart.EditValue = New Date(2005, 11, 25, 0, 0, 0, 0)
            Me.dtStart.Location = New System.Drawing.Point(630, 173)
            Me.dtStart.Name = "dtStart"
            Me.dtStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dtStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dtStart.Size = New System.Drawing.Size(93, 20)
            Me.dtStart.TabIndex = 18
            '
            'lblCustomStatus
            '
            Me.lblCustomStatus.Enabled = False
            Me.lblCustomStatus.Location = New System.Drawing.Point(215, 75)
            Me.lblCustomStatus.Name = "lblCustomStatus"
            Me.lblCustomStatus.Size = New System.Drawing.Size(60, 19)
            Me.lblCustomStatus.TabIndex = 35
            Me.lblCustomStatus.Text = "Color Name :"
            '
            'lblCustomName
            '
            Me.lblCustomName.Location = New System.Drawing.Point(20, 74)
            Me.lblCustomName.Name = "lblCustomName"
            Me.lblCustomName.Size = New System.Drawing.Size(91, 19)
            Me.lblCustomName.TabIndex = 34
            Me.lblCustomName.Text = "Program No:"
            '
            'lblLabel
            '
            Me.lblLabel.Location = New System.Drawing.Point(20, 147)
            Me.lblLabel.Name = "lblLabel"
            Me.lblLabel.Size = New System.Drawing.Size(48, 17)
            Me.lblLabel.TabIndex = 31
            Me.lblLabel.Text = "Label:"
            '
            'lblStatus
            '
            Me.lblStatus.Location = New System.Drawing.Point(20, 127)
            Me.lblStatus.Name = "lblStatus"
            Me.lblStatus.Size = New System.Drawing.Size(48, 18)
            Me.lblStatus.TabIndex = 28
            Me.lblStatus.Text = "Status:"
            '
            'edStatus
            '
            Me.edStatus.Location = New System.Drawing.Point(116, 126)
            Me.edStatus.Name = "edStatus"
            Me.edStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.edStatus.Size = New System.Drawing.Size(93, 20)
            Me.edStatus.Storage = Me.SchedulerStorage1
            Me.edStatus.TabIndex = 24
            '
            'SchedulerStorage1
            '
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("FabricColorId", "FabricColorId"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("OrderId", "OrderId"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("PlanningQuantity", "PlanningQuantity"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Target", "Target"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("IsAdvanced", "IsAdvanced"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("OrderDetailsId", "OrderDetailsId"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("RD", "RD"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("RH", "RH"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("WH", "WH"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ExDate", "ExDate"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ExcessSewingPercentage", "ExcessSewingPercentage"))
            Me.SchedulerStorage1.Appointments.DataSource = Me.AppointmentsBindingSource
            Me.SchedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
            Me.SchedulerStorage1.Appointments.Mappings.Description = "Description"
            Me.SchedulerStorage1.Appointments.Mappings.End = "EndDate"
            Me.SchedulerStorage1.Appointments.Mappings.Label = "Label"
            Me.SchedulerStorage1.Appointments.Mappings.Location = "Location"
            Me.SchedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
            Me.SchedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
            Me.SchedulerStorage1.Appointments.Mappings.ResourceId = "LineId"
            Me.SchedulerStorage1.Appointments.Mappings.Start = "StartDate"
            Me.SchedulerStorage1.Appointments.Mappings.Status = "Status"
            Me.SchedulerStorage1.Appointments.Mappings.Subject = "Subject"
            Me.SchedulerStorage1.Appointments.Mappings.Type = "Type"
            Me.SchedulerStorage1.Resources.DataSource = Me.LineBindingSource
            Me.SchedulerStorage1.Resources.Mappings.Caption = "Line"
            Me.SchedulerStorage1.Resources.Mappings.Id = "LineId"
            '
            'AppointmentsBindingSource
            '
            Me.AppointmentsBindingSource.DataMember = "Appointments"
            Me.AppointmentsBindingSource.DataSource = Me.PlanningBoardNewDataSet
            '
            'PlanningBoardNewDataSet
            '
            Me.PlanningBoardNewDataSet.DataSetName = "PlanningBoardNewDataSet"
            Me.PlanningBoardNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
            'edLabel
            '
            Me.edLabel.Location = New System.Drawing.Point(116, 150)
            Me.edLabel.Name = "edLabel"
            Me.edLabel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.edLabel.Size = New System.Drawing.Size(93, 20)
            Me.edLabel.Storage = Me.SchedulerStorage1
            Me.edLabel.TabIndex = 25
            '
            'txSubject
            '
            Me.txSubject.EditValue = ""
            Me.txSubject.Location = New System.Drawing.Point(117, 47)
            Me.txSubject.Name = "txSubject"
            Me.txSubject.Size = New System.Drawing.Size(396, 20)
            Me.txSubject.TabIndex = 17
            '
            'lblSubject
            '
            Me.lblSubject.Location = New System.Drawing.Point(20, 47)
            Me.lblSubject.Name = "lblSubject"
            Me.lblSubject.Size = New System.Drawing.Size(59, 17)
            Me.lblSubject.TabIndex = 22
            Me.lblSubject.Text = "Subject:"
            '
            'btnRecurrence
            '
            Me.btnRecurrence.Location = New System.Drawing.Point(147, 176)
            Me.btnRecurrence.Name = "btnRecurrence"
            Me.btnRecurrence.Size = New System.Drawing.Size(114, 46)
            Me.btnRecurrence.TabIndex = 32
            Me.btnRecurrence.Text = "Recurrence"
            Me.btnRecurrence.Visible = False
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New System.Drawing.Point(738, 70)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(114, 44)
            Me.btnCancel.TabIndex = 30
            Me.btnCancel.Text = "Close"
            '
            'btnOK
            '
            Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnOK.Location = New System.Drawing.Point(738, 120)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(114, 46)
            Me.btnOK.TabIndex = 29
            Me.btnOK.Text = "Update And Close"
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
            'OrderLookupTableAdapter
            '
            Me.OrderLookupTableAdapter.ClearBeforeFill = True
            '
            'txFabricColorId
            '
            Me.txFabricColorId.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AppointmentsBindingSource, "FabricColorId", True))
            Me.txFabricColorId.Location = New System.Drawing.Point(267, 74)
            Me.txFabricColorId.Name = "txFabricColorId"
            Me.txFabricColorId.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.txFabricColorId.Properties.DisplayMember = "FabricColorName"
            Me.txFabricColorId.Properties.NullText = ""
            Me.txFabricColorId.Properties.ValueMember = "FabricColorId"
            Me.txFabricColorId.Properties.View = Me.GridView1
            Me.txFabricColorId.Size = New System.Drawing.Size(246, 20)
            Me.txFabricColorId.TabIndex = 38
            '
            'GridView1
            '
            Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderId1, Me.colFabricColorName, Me.colFabricColorId, Me.colProgramNo1})
            Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.GridView1.Name = "GridView1"
            Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.GridView1.OptionsView.ShowGroupPanel = False
            '
            'colOrderId1
            '
            Me.colOrderId1.FieldName = "OrderId"
            Me.colOrderId1.Name = "colOrderId1"
            '
            'colFabricColorName
            '
            Me.colFabricColorName.FieldName = "FabricColorName"
            Me.colFabricColorName.Name = "colFabricColorName"
            Me.colFabricColorName.Visible = True
            Me.colFabricColorName.VisibleIndex = 0
            '
            'colFabricColorId
            '
            Me.colFabricColorId.FieldName = "FabricColorId"
            Me.colFabricColorId.Name = "colFabricColorId"
            '
            'colProgramNo1
            '
            Me.colProgramNo1.FieldName = "ProgramNo"
            Me.colProgramNo1.Name = "colProgramNo1"
            '
            'SewingOutputBalanceListGridControl
            '
            Me.SewingOutputBalanceListGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.SewingOutputBalanceListGridControl.DataSource = Me.PlanningBalanceOIDBindingSource
            Me.SewingOutputBalanceListGridControl.Location = New System.Drawing.Point(0, 37)
            Me.SewingOutputBalanceListGridControl.MainView = Me.GridView2
            Me.SewingOutputBalanceListGridControl.Name = "SewingOutputBalanceListGridControl"
            Me.SewingOutputBalanceListGridControl.Size = New System.Drawing.Size(1218, 359)
            Me.SewingOutputBalanceListGridControl.TabIndex = 43
            Me.SewingOutputBalanceListGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
            '
            'PlanningBalanceOIDBindingSource
            '
            Me.PlanningBalanceOIDBindingSource.DataMember = "PlanningBalanceOID"
            Me.PlanningBalanceOIDBindingSource.DataSource = Me.PlanningBalanceDataSet
            '
            'PlanningBalanceDataSet
            '
            Me.PlanningBalanceDataSet.DataSetName = "PlanningBalanceDataSet"
            Me.PlanningBalanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'GridView2
            '
            Me.GridView2.Appearance.HeaderPanel.Options.UseTextOptions = True
            Me.GridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.GridView2.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.GridView2.ColumnPanelRowHeight = 40
            Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEX, Me.colBuyerName, Me.colStyleName, Me.colProgramNo, Me.colPO, Me.colOrderQuantity, Me.colCuttingQuantity, Me.colInputQuantity, Me.colOutputQuantity, Me.colPlanningQuantity, Me.colPlanningBalance, Me.colTotalTargetQuantity, Me.colYR, Me.colMH, Me.colStartDate, Me.colEndDate, Me.colStyleType, Me.colSewingPercentage, Me.colSewingRequireQuantity, Me.colSelect, Me.colFabricColorName1})
            Me.GridView2.CustomizationFormBounds = New System.Drawing.Rectangle(955, 40, 216, 318)
            Me.GridView2.GridControl = Me.SewingOutputBalanceListGridControl
            Me.GridView2.Name = "GridView2"
            Me.GridView2.OptionsView.ColumnAutoWidth = False
            Me.GridView2.OptionsView.ShowAutoFilterRow = True
            Me.GridView2.OptionsView.ShowFooter = True
            Me.GridView2.OptionsView.ShowGroupPanel = False
            Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colYR, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colMH, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colEX, DevExpress.Data.ColumnSortOrder.Ascending)})
            '
            'colEX
            '
            Me.colEX.FieldName = "EX"
            Me.colEX.Name = "colEX"
            Me.colEX.Visible = True
            Me.colEX.VisibleIndex = 2
            '
            'colBuyerName
            '
            Me.colBuyerName.Caption = "Buyer"
            Me.colBuyerName.FieldName = "BuyerName"
            Me.colBuyerName.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
            Me.colBuyerName.Name = "colBuyerName"
            Me.colBuyerName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Me.colBuyerName.Visible = True
            Me.colBuyerName.VisibleIndex = 5
            '
            'colStyleName
            '
            Me.colStyleName.Caption = "Style"
            Me.colStyleName.FieldName = "StyleName"
            Me.colStyleName.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
            Me.colStyleName.Name = "colStyleName"
            Me.colStyleName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Me.colStyleName.Visible = True
            Me.colStyleName.VisibleIndex = 7
            Me.colStyleName.Width = 123
            '
            'colProgramNo
            '
            Me.colProgramNo.FieldName = "ProgramNo"
            Me.colProgramNo.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
            Me.colProgramNo.Name = "colProgramNo"
            Me.colProgramNo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Me.colProgramNo.Visible = True
            Me.colProgramNo.VisibleIndex = 9
            '
            'colPO
            '
            Me.colPO.FieldName = "PO"
            Me.colPO.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
            Me.colPO.Name = "colPO"
            Me.colPO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Me.colPO.Visible = True
            Me.colPO.VisibleIndex = 10
            Me.colPO.Width = 90
            '
            'colOrderQuantity
            '
            Me.colOrderQuantity.FieldName = "OrderQuantity"
            Me.colOrderQuantity.Name = "colOrderQuantity"
            Me.colOrderQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
            Me.colOrderQuantity.Visible = True
            Me.colOrderQuantity.VisibleIndex = 11
            '
            'colCuttingQuantity
            '
            Me.colCuttingQuantity.FieldName = "CuttingQuantity"
            Me.colCuttingQuantity.Name = "colCuttingQuantity"
            Me.colCuttingQuantity.OptionsColumn.ReadOnly = True
            Me.colCuttingQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
            Me.colCuttingQuantity.Visible = True
            Me.colCuttingQuantity.VisibleIndex = 12
            '
            'colInputQuantity
            '
            Me.colInputQuantity.FieldName = "InputQuantity"
            Me.colInputQuantity.Name = "colInputQuantity"
            Me.colInputQuantity.OptionsColumn.ReadOnly = True
            Me.colInputQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
            Me.colInputQuantity.Visible = True
            Me.colInputQuantity.VisibleIndex = 13
            '
            'colOutputQuantity
            '
            Me.colOutputQuantity.FieldName = "OutputQuantity"
            Me.colOutputQuantity.Name = "colOutputQuantity"
            Me.colOutputQuantity.OptionsColumn.ReadOnly = True
            Me.colOutputQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
            Me.colOutputQuantity.Visible = True
            Me.colOutputQuantity.VisibleIndex = 16
            '
            'colPlanningQuantity
            '
            Me.colPlanningQuantity.FieldName = "PlanningQuantity"
            Me.colPlanningQuantity.Name = "colPlanningQuantity"
            Me.colPlanningQuantity.OptionsColumn.ReadOnly = True
            Me.colPlanningQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
            Me.colPlanningQuantity.Visible = True
            Me.colPlanningQuantity.VisibleIndex = 17
            '
            'colPlanningBalance
            '
            Me.colPlanningBalance.FieldName = "PlanningBalance"
            Me.colPlanningBalance.Name = "colPlanningBalance"
            Me.colPlanningBalance.OptionsColumn.ReadOnly = True
            Me.colPlanningBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
            Me.colPlanningBalance.Visible = True
            Me.colPlanningBalance.VisibleIndex = 18
            '
            'colTotalTargetQuantity
            '
            Me.colTotalTargetQuantity.Caption = "Target Quantity"
            Me.colTotalTargetQuantity.FieldName = "TotalTargetQuantity"
            Me.colTotalTargetQuantity.Name = "colTotalTargetQuantity"
            Me.colTotalTargetQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
            Me.colTotalTargetQuantity.Width = 105
            '
            'colYR
            '
            Me.colYR.Caption = "Year"
            Me.colYR.FieldName = "YR"
            Me.colYR.Name = "colYR"
            Me.colYR.Visible = True
            Me.colYR.VisibleIndex = 0
            '
            'colMH
            '
            Me.colMH.Caption = "Month"
            Me.colMH.FieldName = "MH"
            Me.colMH.Name = "colMH"
            Me.colMH.Visible = True
            Me.colMH.VisibleIndex = 1
            '
            'colStartDate
            '
            Me.colStartDate.Caption = "Sewing TNA Start Date"
            Me.colStartDate.FieldName = "StartDate"
            Me.colStartDate.Name = "colStartDate"
            Me.colStartDate.Visible = True
            Me.colStartDate.VisibleIndex = 3
            Me.colStartDate.Width = 79
            '
            'colEndDate
            '
            Me.colEndDate.Caption = "Sewind TNA End Date"
            Me.colEndDate.FieldName = "EndDate"
            Me.colEndDate.Name = "colEndDate"
            Me.colEndDate.Visible = True
            Me.colEndDate.VisibleIndex = 4
            '
            'colStyleType
            '
            Me.colStyleType.FieldName = "StyleType"
            Me.colStyleType.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
            Me.colStyleType.Name = "colStyleType"
            Me.colStyleType.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Me.colStyleType.Visible = True
            Me.colStyleType.VisibleIndex = 6
            Me.colStyleType.Width = 102
            '
            'colSewingPercentage
            '
            Me.colSewingPercentage.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.colSewingPercentage.AppearanceCell.Options.UseBackColor = True
            Me.colSewingPercentage.AppearanceHeader.Options.UseTextOptions = True
            Me.colSewingPercentage.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.colSewingPercentage.Caption = "Sewing %"
            Me.colSewingPercentage.FieldName = "SewingPercentage"
            Me.colSewingPercentage.Name = "colSewingPercentage"
            Me.colSewingPercentage.Visible = True
            Me.colSewingPercentage.VisibleIndex = 14
            '
            'colSewingRequireQuantity
            '
            Me.colSewingRequireQuantity.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.colSewingRequireQuantity.AppearanceCell.Options.UseBackColor = True
            Me.colSewingRequireQuantity.AppearanceHeader.Options.UseTextOptions = True
            Me.colSewingRequireQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.colSewingRequireQuantity.FieldName = "SewingRequireQuantity"
            Me.colSewingRequireQuantity.Name = "colSewingRequireQuantity"
            Me.colSewingRequireQuantity.Visible = True
            Me.colSewingRequireQuantity.VisibleIndex = 15
            Me.colSewingRequireQuantity.Width = 89
            '
            'colSelect
            '
            Me.colSelect.FieldName = "Select"
            Me.colSelect.Name = "colSelect"
            '
            'colFabricColorName1
            '
            Me.colFabricColorName1.Caption = "Color"
            Me.colFabricColorName1.FieldName = "FabricColorName"
            Me.colFabricColorName1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
            Me.colFabricColorName1.Name = "colFabricColorName1"
            Me.colFabricColorName1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Me.colFabricColorName1.Visible = True
            Me.colFabricColorName1.VisibleIndex = 8
            '
            'SplitContainer1
            '
            Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
            Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
            Me.SplitContainer1.Name = "SplitContainer1"
            Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
            '
            'SplitContainer1.Panel1
            '
            Me.SplitContainer1.Panel1.AutoScroll = True
            Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.OrderLookupGridLookUpEdit)
            Me.SplitContainer1.Panel1.Controls.Add(Me.SimpleButton3)
            Me.SplitContainer1.Panel1.Controls.Add(Me.SimpleButton1)
            Me.SplitContainer1.Panel1.Controls.Add(Me.MessageLabel)
            Me.SplitContainer1.Panel1.Controls.Add(Me.SewingOutputBalanceListGridControl)
            '
            'SplitContainer1.Panel2
            '
            Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
            Me.SplitContainer1.Size = New System.Drawing.Size(1218, 639)
            Me.SplitContainer1.SplitterDistance = 398
            Me.SplitContainer1.TabIndex = 44
            '
            'Label1
            '
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(15, 14)
            Me.Label1.Margin = New System.Windows.Forms.Padding(3, 12, 3, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(126, 17)
            Me.Label1.TabIndex = 48
            Me.Label1.Text = "Filter By Program No :"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'OrderLookupGridLookUpEdit
            '
            Me.OrderLookupGridLookUpEdit.EditValue = "[Select your Program]"
            Me.OrderLookupGridLookUpEdit.Location = New System.Drawing.Point(147, 10)
            Me.OrderLookupGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
            Me.OrderLookupGridLookUpEdit.Name = "OrderLookupGridLookUpEdit"
            Me.OrderLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.OrderLookupGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
            Me.OrderLookupGridLookUpEdit.Properties.DisplayMember = "Details"
            Me.OrderLookupGridLookUpEdit.Properties.ImmediatePopup = True
            Me.OrderLookupGridLookUpEdit.Properties.NullText = "Select your Program"
            Me.OrderLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
            Me.OrderLookupGridLookUpEdit.Properties.Tag = "NR"
            Me.OrderLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            Me.OrderLookupGridLookUpEdit.Properties.ValueMember = "OrderId"
            Me.OrderLookupGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
            Me.OrderLookupGridLookUpEdit.Size = New System.Drawing.Size(251, 20)
            Me.OrderLookupGridLookUpEdit.TabIndex = 49
            Me.OrderLookupGridLookUpEdit.Tag = "NR"
            '
            'GridLookUpEdit1View
            '
            Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails1})
            Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
            Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
            '
            'colDetails1
            '
            Me.colDetails1.FieldName = "Details"
            Me.colDetails1.Name = "colDetails1"
            Me.colDetails1.Visible = True
            Me.colDetails1.VisibleIndex = 0
            '
            'SimpleButton3
            '
            Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.SimpleButton3.Location = New System.Drawing.Point(506, 8)
            Me.SimpleButton3.Name = "SimpleButton3"
            Me.SimpleButton3.Size = New System.Drawing.Size(188, 23)
            Me.SimpleButton3.TabIndex = 46
            Me.SimpleButton3.Text = "Show All Planning Balance"
            '
            'SimpleButton1
            '
            Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.SimpleButton1.Location = New System.Drawing.Point(404, 8)
            Me.SimpleButton1.Name = "SimpleButton1"
            Me.SimpleButton1.Size = New System.Drawing.Size(96, 23)
            Me.SimpleButton1.TabIndex = 46
            Me.SimpleButton1.Text = "Show Program"
            '
            'MessageLabel
            '
            Me.MessageLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.MessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.MessageLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MessageLabel.Location = New System.Drawing.Point(413, 87)
            Me.MessageLabel.Name = "MessageLabel"
            Me.MessageLabel.Size = New System.Drawing.Size(325, 35)
            Me.MessageLabel.TabIndex = 45
            Me.MessageLabel.Text = "Generating Sewing Balance List , please wait.."
            Me.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'SplitContainer2
            '
            Me.SplitContainer2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
            Me.SplitContainer2.Name = "SplitContainer2"
            '
            'SplitContainer2.Panel1
            '
            Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.SplitContainer2.Panel1Collapsed = True
            '
            'SplitContainer2.Panel2
            '
            Me.SplitContainer2.Panel2.AutoScroll = True
            Me.SplitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.SplitContainer2.Panel2.Controls.Add(Me.GridControl1)
            Me.SplitContainer2.Panel2.Controls.Add(Me.PlanQtyLinkLabel)
            Me.SplitContainer2.Panel2.Controls.Add(Me.GetDataButton)
            Me.SplitContainer2.Panel2.Controls.Add(Me.txPlanningQuantity)
            Me.SplitContainer2.Panel2.Controls.Add(Me.ESPSpinEdit)
            Me.SplitContainer2.Panel2.Controls.Add(Me.LatestExDateTextEdit)
            Me.SplitContainer2.Panel2.Controls.Add(Me.LabelControl1)
            Me.SplitContainer2.Panel2.Controls.Add(Me.Label8)
            Me.SplitContainer2.Panel2.Controls.Add(Me.ExDateEdit)
            Me.SplitContainer2.Panel2.Controls.Add(Me.CalculateButton)
            Me.SplitContainer2.Panel2.Controls.Add(Me.WorkingLabel)
            Me.SplitContainer2.Panel2.Controls.Add(Me.WHTextBox)
            Me.SplitContainer2.Panel2.Controls.Add(Me.Label4)
            Me.SplitContainer2.Panel2.Controls.Add(Me.POLookUpEdit)
            Me.SplitContainer2.Panel2.Controls.Add(Me.AdvancedCheckBox)
            Me.SplitContainer2.Panel2.Controls.Add(Me.Label6)
            Me.SplitContainer2.Panel2.Controls.Add(Me.btnCancel)
            Me.SplitContainer2.Panel2.Controls.Add(Me.btnOK)
            Me.SplitContainer2.Panel2.Controls.Add(Me.PlanningIdLabel)
            Me.SplitContainer2.Panel2.Controls.Add(Me.SaveAndContinueSimpleButton)
            Me.SplitContainer2.Panel2.Controls.Add(Me.Label3)
            Me.SplitContainer2.Panel2.Controls.Add(Me.btnRecurrence)
            Me.SplitContainer2.Panel2.Controls.Add(Me.timeEnd)
            Me.SplitContainer2.Panel2.Controls.Add(Me.edLabel)
            Me.SplitContainer2.Panel2.Controls.Add(Me.lblLabel)
            Me.SplitContainer2.Panel2.Controls.Add(Me.dtEnd)
            Me.SplitContainer2.Panel2.Controls.Add(Me.edStatus)
            Me.SplitContainer2.Panel2.Controls.Add(Me.HourRequireTextBox)
            Me.SplitContainer2.Panel2.Controls.Add(Me.lblStatus)
            Me.SplitContainer2.Panel2.Controls.Add(Me.dtStart)
            Me.SplitContainer2.Panel2.Controls.Add(Me.TargetTextBox)
            Me.SplitContainer2.Panel2.Controls.Add(Me.txFabricColorId)
            Me.SplitContainer2.Panel2.Controls.Add(Me.EndDateLinkLabel)
            Me.SplitContainer2.Panel2.Controls.Add(Me.Label5)
            Me.SplitContainer2.Panel2.Controls.Add(Me.StartDateLinkLabel)
            Me.SplitContainer2.Panel2.Controls.Add(Me.DayRequireTextBox)
            Me.SplitContainer2.Panel2.Controls.Add(Me.lblSubject)
            Me.SplitContainer2.Panel2.Controls.Add(Me.checkAllDay)
            Me.SplitContainer2.Panel2.Controls.Add(Me.Label7)
            Me.SplitContainer2.Panel2.Controls.Add(Me.timeStart)
            Me.SplitContainer2.Panel2.Controls.Add(Me.txSubject)
            Me.SplitContainer2.Panel2.Controls.Add(Me.txResourceId)
            Me.SplitContainer2.Panel2.Controls.Add(Me.Label2)
            Me.SplitContainer2.Panel2.Controls.Add(Me.Label9)
            Me.SplitContainer2.Panel2.Controls.Add(Me.lblCustomName)
            Me.SplitContainer2.Panel2.Controls.Add(Me.txOrderId)
            Me.SplitContainer2.Panel2.Controls.Add(Me.lblCustomStatus)
            Me.SplitContainer2.Size = New System.Drawing.Size(1218, 237)
            Me.SplitContainer2.SplitterDistance = 25
            Me.SplitContainer2.TabIndex = 0
            '
            'GridControl1
            '
            Me.GridControl1.DataSource = Me.AppointmentDetailsBindingSource1
            Me.GridControl1.Location = New System.Drawing.Point(867, 17)
            Me.GridControl1.MainView = Me.GridView3
            Me.GridControl1.Name = "GridControl1"
            Me.GridControl1.Size = New System.Drawing.Size(339, 202)
            Me.GridControl1.TabIndex = 79
            Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
            '
            'AppointmentDetailsBindingSource1
            '
            Me.AppointmentDetailsBindingSource1.DataMember = "FK_AppointmentDetails_Appointments"
            Me.AppointmentDetailsBindingSource1.DataSource = Me.AppointmentsBindingSource
            '
            'GridView3
            '
            Me.GridView3.Appearance.HeaderPanel.Options.UseTextOptions = True
            Me.GridView3.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.GridView3.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.GridView3.ColumnPanelRowHeight = 40
            Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRemarks, Me.colDaySerial, Me.colPlanningDate, Me.colEfficiency, Me.colPlanningQuantity1, Me.colTarget})
            Me.GridView3.GridControl = Me.GridControl1
            Me.GridView3.Name = "GridView3"
            Me.GridView3.OptionsView.ColumnAutoWidth = False
            Me.GridView3.OptionsView.ShowFooter = True
            Me.GridView3.OptionsView.ShowGroupPanel = False
            '
            'colRemarks
            '
            Me.colRemarks.FieldName = "Remarks"
            Me.colRemarks.Name = "colRemarks"
            Me.colRemarks.Visible = True
            Me.colRemarks.VisibleIndex = 5
            '
            'colDaySerial
            '
            Me.colDaySerial.FieldName = "DaySerial"
            Me.colDaySerial.Name = "colDaySerial"
            Me.colDaySerial.Visible = True
            Me.colDaySerial.VisibleIndex = 0
            Me.colDaySerial.Width = 44
            '
            'colPlanningDate
            '
            Me.colPlanningDate.FieldName = "PlanningDate"
            Me.colPlanningDate.Name = "colPlanningDate"
            Me.colPlanningDate.Visible = True
            Me.colPlanningDate.VisibleIndex = 1
            Me.colPlanningDate.Width = 61
            '
            'colEfficiency
            '
            Me.colEfficiency.FieldName = "Efficiency"
            Me.colEfficiency.Name = "colEfficiency"
            Me.colEfficiency.Visible = True
            Me.colEfficiency.VisibleIndex = 2
            '
            'colPlanningQuantity1
            '
            Me.colPlanningQuantity1.FieldName = "PlanningQuantity"
            Me.colPlanningQuantity1.Name = "colPlanningQuantity1"
            Me.colPlanningQuantity1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanningQuantity", "{0:0}")})
            Me.colPlanningQuantity1.Visible = True
            Me.colPlanningQuantity1.VisibleIndex = 3
            '
            'colTarget
            '
            Me.colTarget.FieldName = "Target"
            Me.colTarget.Name = "colTarget"
            Me.colTarget.Visible = True
            Me.colTarget.VisibleIndex = 4
            '
            'PlanQtyLinkLabel
            '
            Me.PlanQtyLinkLabel.AutoSize = True
            Me.PlanQtyLinkLabel.Location = New System.Drawing.Point(526, 98)
            Me.PlanQtyLinkLabel.Name = "PlanQtyLinkLabel"
            Me.PlanQtyLinkLabel.Size = New System.Drawing.Size(99, 13)
            Me.PlanQtyLinkLabel.TabIndex = 78
            Me.PlanQtyLinkLabel.TabStop = True
            Me.PlanQtyLinkLabel.Text = "Planning Quantity :"
            '
            'GetDataButton
            '
            Me.GetDataButton.Location = New System.Drawing.Point(737, 17)
            Me.GetDataButton.Name = "GetDataButton"
            Me.GetDataButton.Size = New System.Drawing.Size(114, 47)
            Me.GetDataButton.TabIndex = 77
            Me.GetDataButton.Text = "Add to Plan"
            '
            'txPlanningQuantity
            '
            Me.txPlanningQuantity.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.txPlanningQuantity.Location = New System.Drawing.Point(629, 95)
            Me.txPlanningQuantity.Name = "txPlanningQuantity"
            Me.txPlanningQuantity.Properties.Appearance.BackColor = System.Drawing.Color.White
            Me.txPlanningQuantity.Properties.Appearance.Options.UseBackColor = True
            Me.txPlanningQuantity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.txPlanningQuantity.Size = New System.Drawing.Size(92, 20)
            Me.txPlanningQuantity.TabIndex = 76
            '
            'ESPSpinEdit
            '
            Me.ESPSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.ESPSpinEdit.Location = New System.Drawing.Point(630, 19)
            Me.ESPSpinEdit.Name = "ESPSpinEdit"
            Me.ESPSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
            Me.ESPSpinEdit.Properties.Appearance.Options.UseBackColor = True
            Me.ESPSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ESPSpinEdit.Size = New System.Drawing.Size(92, 20)
            Me.ESPSpinEdit.TabIndex = 75
            '
            'LatestExDateTextEdit
            '
            Me.LatestExDateTextEdit.Location = New System.Drawing.Point(425, 19)
            Me.LatestExDateTextEdit.Name = "LatestExDateTextEdit"
            Me.LatestExDateTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.LatestExDateTextEdit.Properties.Appearance.Options.UseBackColor = True
            Me.LatestExDateTextEdit.Size = New System.Drawing.Size(88, 20)
            Me.LatestExDateTextEdit.TabIndex = 74
            '
            'LabelControl1
            '
            Me.LabelControl1.Location = New System.Drawing.Point(338, 22)
            Me.LabelControl1.Name = "LabelControl1"
            Me.LabelControl1.Size = New System.Drawing.Size(81, 13)
            Me.LabelControl1.TabIndex = 72
            Me.LabelControl1.Text = "Latest Ex Date : "
            '
            'Label8
            '
            Me.Label8.Location = New System.Drawing.Point(202, 19)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(24, 19)
            Me.Label8.TabIndex = 71
            Me.Label8.Text = "Ex Date:"
            '
            'ExDateEdit
            '
            Me.ExDateEdit.EditValue = Nothing
            Me.ExDateEdit.Location = New System.Drawing.Point(232, 19)
            Me.ExDateEdit.Name = "ExDateEdit"
            Me.ExDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ExDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.ExDateEdit.Properties.ReadOnly = True
            Me.ExDateEdit.Size = New System.Drawing.Size(100, 20)
            Me.ExDateEdit.TabIndex = 70
            '
            'CalculateButton
            '
            Me.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.CalculateButton.Location = New System.Drawing.Point(267, 176)
            Me.CalculateButton.Name = "CalculateButton"
            Me.CalculateButton.Size = New System.Drawing.Size(114, 46)
            Me.CalculateButton.TabIndex = 69
            Me.CalculateButton.Text = "Calculate Plan"
            Me.CalculateButton.UseVisualStyleBackColor = True
            Me.CalculateButton.Visible = False
            '
            'WorkingLabel
            '
            Me.WorkingLabel.Location = New System.Drawing.Point(527, 45)
            Me.WorkingLabel.Name = "WorkingLabel"
            Me.WorkingLabel.Size = New System.Drawing.Size(86, 19)
            Me.WorkingLabel.TabIndex = 68
            Me.WorkingLabel.Text = "Working Hour :"
            '
            'WHTextBox
            '
            Me.WHTextBox.BackColor = System.Drawing.Color.Yellow
            Me.WHTextBox.Location = New System.Drawing.Point(630, 43)
            Me.WHTextBox.Name = "WHTextBox"
            Me.WHTextBox.Size = New System.Drawing.Size(93, 21)
            Me.WHTextBox.TabIndex = 67
            Me.WHTextBox.Text = "10"
            '
            'Label4
            '
            Me.Label4.Location = New System.Drawing.Point(215, 102)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(46, 19)
            Me.Label4.TabIndex = 66
            Me.Label4.Text = "PO :"
            '
            'POLookUpEdit
            '
            Me.POLookUpEdit.Location = New System.Drawing.Point(267, 101)
            Me.POLookUpEdit.Name = "POLookUpEdit"
            Me.POLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.POLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POAndColorAndDes", "PO And Color And Des", 117, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
            Me.POLookUpEdit.Properties.DataSource = Me.OrderPOLookupNewBindingSource
            Me.POLookUpEdit.Properties.DisplayMember = "POAndColorAndDes"
            Me.POLookUpEdit.Properties.NullText = ""
            Me.POLookUpEdit.Properties.ValueMember = "OrderDetailsId"
            Me.POLookUpEdit.Size = New System.Drawing.Size(246, 20)
            Me.POLookUpEdit.TabIndex = 65
            '
            'OrderPOLookupNewBindingSource
            '
            Me.OrderPOLookupNewBindingSource.DataMember = "OrderPOLookupNew"
            Me.OrderPOLookupNewBindingSource.DataSource = Me.OrderPOLookupNewDataSet
            '
            'OrderPOLookupNewDataSet
            '
            Me.OrderPOLookupNewDataSet.DataSetName = "OrderPOLookupNewDataSet"
            Me.OrderPOLookupNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'AdvancedCheckBox
            '
            Me.AdvancedCheckBox.AutoSize = True
            Me.AdvancedCheckBox.Location = New System.Drawing.Point(267, 150)
            Me.AdvancedCheckBox.Name = "AdvancedCheckBox"
            Me.AdvancedCheckBox.Size = New System.Drawing.Size(74, 17)
            Me.AdvancedCheckBox.TabIndex = 64
            Me.AdvancedCheckBox.Text = "Advanced"
            Me.AdvancedCheckBox.UseVisualStyleBackColor = True
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(20, 20)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(70, 13)
            Me.Label6.TabIndex = 63
            Me.Label6.Text = "Planning No :"
            '
            'PlanningIdLabel
            '
            Me.PlanningIdLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.PlanningIdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.PlanningIdLabel.Location = New System.Drawing.Point(116, 16)
            Me.PlanningIdLabel.Name = "PlanningIdLabel"
            Me.PlanningIdLabel.Size = New System.Drawing.Size(64, 19)
            Me.PlanningIdLabel.TabIndex = 62
            Me.PlanningIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'SaveAndContinueSimpleButton
            '
            Me.SaveAndContinueSimpleButton.Enabled = False
            Me.SaveAndContinueSimpleButton.Location = New System.Drawing.Point(23, 176)
            Me.SaveAndContinueSimpleButton.Name = "SaveAndContinueSimpleButton"
            Me.SaveAndContinueSimpleButton.Size = New System.Drawing.Size(114, 47)
            Me.SaveAndContinueSimpleButton.TabIndex = 56
            Me.SaveAndContinueSimpleButton.Text = "Save And Continue"
            Me.SaveAndContinueSimpleButton.Visible = False
            '
            'Label3
            '
            Me.Label3.Location = New System.Drawing.Point(527, 123)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(99, 19)
            Me.Label3.TabIndex = 61
            Me.Label3.Text = "Require (In Hour) :"
            '
            'HourRequireTextBox
            '
            Me.HourRequireTextBox.BackColor = System.Drawing.Color.White
            Me.HourRequireTextBox.Location = New System.Drawing.Point(630, 120)
            Me.HourRequireTextBox.Name = "HourRequireTextBox"
            Me.HourRequireTextBox.ReadOnly = True
            Me.HourRequireTextBox.Size = New System.Drawing.Size(93, 21)
            Me.HourRequireTextBox.TabIndex = 60
            '
            'TargetTextBox
            '
            Me.TargetTextBox.BackColor = System.Drawing.Color.White
            Me.TargetTextBox.Location = New System.Drawing.Point(630, 69)
            Me.TargetTextBox.Name = "TargetTextBox"
            Me.TargetTextBox.Size = New System.Drawing.Size(93, 21)
            Me.TargetTextBox.TabIndex = 47
            '
            'EndDateLinkLabel
            '
            Me.EndDateLinkLabel.AutoSize = True
            Me.EndDateLinkLabel.Location = New System.Drawing.Point(527, 201)
            Me.EndDateLinkLabel.Name = "EndDateLinkLabel"
            Me.EndDateLinkLabel.Size = New System.Drawing.Size(51, 13)
            Me.EndDateLinkLabel.TabIndex = 53
            Me.EndDateLinkLabel.TabStop = True
            Me.EndDateLinkLabel.Text = "End Date"
            '
            'Label5
            '
            Me.Label5.Location = New System.Drawing.Point(527, 71)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(97, 19)
            Me.Label5.TabIndex = 48
            Me.Label5.Text = "Target/Hr :"
            '
            'StartDateLinkLabel
            '
            Me.StartDateLinkLabel.AutoSize = True
            Me.StartDateLinkLabel.Enabled = False
            Me.StartDateLinkLabel.LinkColor = System.Drawing.Color.Black
            Me.StartDateLinkLabel.Location = New System.Drawing.Point(527, 174)
            Me.StartDateLinkLabel.Name = "StartDateLinkLabel"
            Me.StartDateLinkLabel.Size = New System.Drawing.Size(57, 13)
            Me.StartDateLinkLabel.TabIndex = 52
            Me.StartDateLinkLabel.TabStop = True
            Me.StartDateLinkLabel.Text = "Start Date"
            '
            'DayRequireTextBox
            '
            Me.DayRequireTextBox.BackColor = System.Drawing.Color.White
            Me.DayRequireTextBox.Location = New System.Drawing.Point(630, 146)
            Me.DayRequireTextBox.Name = "DayRequireTextBox"
            Me.DayRequireTextBox.Size = New System.Drawing.Size(93, 21)
            Me.DayRequireTextBox.TabIndex = 59
            '
            'Label7
            '
            Me.Label7.Location = New System.Drawing.Point(20, 100)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(36, 19)
            Me.Label7.TabIndex = 58
            Me.Label7.Text = "Line :"
            '
            'txResourceId
            '
            Me.txResourceId.Location = New System.Drawing.Point(117, 100)
            Me.txResourceId.Name = "txResourceId"
            Me.txResourceId.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.txResourceId.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Line", "Line", 29, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
            Me.txResourceId.Properties.DataSource = Me.LineBindingSource
            Me.txResourceId.Properties.DisplayMember = "Line"
            Me.txResourceId.Properties.NullText = ""
            Me.txResourceId.Properties.ValueMember = "LineId"
            Me.txResourceId.Size = New System.Drawing.Size(93, 20)
            Me.txResourceId.TabIndex = 57
            '
            'Label2
            '
            Me.Label2.Location = New System.Drawing.Point(527, 145)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(93, 19)
            Me.Label2.TabIndex = 43
            Me.Label2.Text = "Require (In Day) :"
            '
            'Label9
            '
            Me.Label9.Location = New System.Drawing.Point(527, 20)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(111, 16)
            Me.Label9.TabIndex = 40
            Me.Label9.Text = "Excess Sewing (%) :"
            '
            'txOrderId
            '
            Me.txOrderId.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AppointmentsBindingSource, "OrderId", True))
            Me.txOrderId.Location = New System.Drawing.Point(117, 73)
            Me.txOrderId.Name = "txOrderId"
            Me.txOrderId.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.txOrderId.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrderId", "Order Id", 64, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProgramNo", "Program No", 66, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsPrint", "Is Print", 44, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserId", "User Id", 45, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsMultiPart", "Is Multi Part", 67, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
            Me.txOrderId.Properties.DataSource = Me.OrderLookupBindingSource
            Me.txOrderId.Properties.DisplayMember = "ProgramNo"
            Me.txOrderId.Properties.NullText = ""
            Me.txOrderId.Properties.ValueMember = "OrderId"
            Me.txOrderId.Size = New System.Drawing.Size(92, 20)
            Me.txOrderId.TabIndex = 55
            '
            'BackgroundWorker1
            '
            '
            'LineTableAdapter
            '
            Me.LineTableAdapter.ClearBeforeFill = True
            '
            'AppointmentsTableAdapter
            '
            Me.AppointmentsTableAdapter.ClearBeforeFill = True
            '
            'BindingSource1
            '
            Me.BindingSource1.DataMember = "Line"
            Me.BindingSource1.DataSource = Me.PlanningBoardNewDataSet
            '
            'LineTableAdapter1
            '
            Me.LineTableAdapter1.ClearBeforeFill = True
            '
            'TableAdapterManager
            '
            Me.TableAdapterManager.AppointmentDetailsTableAdapter = Me.AppointmentDetailsTableAdapter
            Me.TableAdapterManager.AppointmentsTableAdapter = Me.AppointmentsTableAdapter
            Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
            Me.TableAdapterManager.LineTableAdapter = Nothing
            Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.PlanningBoardNewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
            '
            'AppointmentDetailsTableAdapter
            '
            Me.AppointmentDetailsTableAdapter.ClearBeforeFill = True
            '
            'OrderPOLookupNewTableAdapter
            '
            Me.OrderPOLookupNewTableAdapter.ClearBeforeFill = True
            '
            'PlanningBalanceOIDTableAdapter
            '
            Me.PlanningBalanceOIDTableAdapter.ClearBeforeFill = True
            '
            'TableAdapterManager1
            '
            Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
            Me.TableAdapterManager1.Connection = Nothing
            Me.TableAdapterManager1.UpdateOrder = KSoft_Apparel.PlanningBalanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
            '
            'MyAppointmentEditForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1218, 639)
            Me.Controls.Add(Me.SplitContainer1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Name = "MyAppointmentEditForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Add/Edit Planning Board"
            CType(Me.checkAllDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.timeEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.timeStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PlanningBoardNewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edLabel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txFabricColorId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SewingOutputBalanceListGridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PlanningBalanceOIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PlanningBalanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer1.Panel1.ResumeLayout(False)
            Me.SplitContainer1.Panel2.ResumeLayout(False)
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer1.ResumeLayout(False)
            CType(Me.OrderLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer2.Panel2.ResumeLayout(False)
            Me.SplitContainer2.Panel2.PerformLayout()
            CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer2.ResumeLayout(False)
            CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AppointmentDetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txPlanningQuantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ESPSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LatestExDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ExDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ExDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.POLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.OrderPOLookupNewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.OrderPOLookupNewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txResourceId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txOrderId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents checkAllDay As DevExpress.XtraEditors.CheckEdit
        Private WithEvents timeEnd As DevExpress.XtraEditors.TimeEdit
        Private WithEvents timeStart As DevExpress.XtraEditors.TimeEdit
        Private WithEvents dtEnd As DevExpress.XtraEditors.DateEdit
        Private WithEvents dtStart As DevExpress.XtraEditors.DateEdit
        Private lblCustomStatus As System.Windows.Forms.Label
        Private lblCustomName As System.Windows.Forms.Label
        Private lblLabel As System.Windows.Forms.Label
        Private lblStatus As System.Windows.Forms.Label
        Private edStatus As DevExpress.XtraScheduler.UI.AppointmentStatusEdit
        Private edLabel As DevExpress.XtraScheduler.UI.AppointmentLabelEdit
        Private txSubject As DevExpress.XtraEditors.TextEdit
        Private lblSubject As System.Windows.Forms.Label
        Private WithEvents btnRecurrence As DevExpress.XtraEditors.SimpleButton
        Private btnCancel As DevExpress.XtraEditors.SimpleButton
        Private WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
        Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
        Friend WithEvents txFabricColorId As DevExpress.XtraEditors.GridLookUpEdit
        Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colOrderId1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFabricColorId As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colProgramNo1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents SewingOutputBalanceListGridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
        Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
        Private WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents TargetTextBox As System.Windows.Forms.TextBox
        Friend WithEvents EndDateLinkLabel As System.Windows.Forms.LinkLabel
        Friend WithEvents StartDateLinkLabel As System.Windows.Forms.LinkLabel
        Friend WithEvents txOrderId As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents MessageLabel As System.Windows.Forms.Label
        Private WithEvents SaveAndContinueSimpleButton As DevExpress.XtraEditors.SimpleButton
        Private WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txResourceId As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents DayRequireTextBox As System.Windows.Forms.TextBox
        Private WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents HourRequireTextBox As System.Windows.Forms.TextBox
        Friend WithEvents LineDataSet As KSoft_Apparel.LineDataSet
        Friend WithEvents LineBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents LineTableAdapter As KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter
        Friend WithEvents SchedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
        Friend WithEvents PlanningBoardNewDataSet As KSoft_Apparel.PlanningBoardNewDataSet
        Friend WithEvents AppointmentsBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents AppointmentsTableAdapter As KSoft_Apparel.PlanningBoardNewDataSetTableAdapters.AppointmentsTableAdapter
        Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
        Friend WithEvents LineTableAdapter1 As KSoft_Apparel.PlanningBoardNewDataSetTableAdapters.LineTableAdapter
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents PlanningIdLabel As System.Windows.Forms.Label
        Friend WithEvents TableAdapterManager As KSoft_Apparel.PlanningBoardNewDataSetTableAdapters.TableAdapterManager
        Friend WithEvents AppointmentDetailsTableAdapter As KSoft_Apparel.PlanningBoardNewDataSetTableAdapters.AppointmentDetailsTableAdapter
        Friend WithEvents AdvancedCheckBox As System.Windows.Forms.CheckBox
        Friend WithEvents POLookUpEdit As DevExpress.XtraEditors.LookUpEdit
        Private WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents OrderPOLookupNewDataSet As KSoft_Apparel.OrderPOLookupNewDataSet
        Friend WithEvents OrderPOLookupNewBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents OrderPOLookupNewTableAdapter As KSoft_Apparel.OrderPOLookupNewDataSetTableAdapters.OrderPOLookupNewTableAdapter
        Friend WithEvents colEX As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPO As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCuttingQuantity As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInputQuantity As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOutputQuantity As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPlanningQuantity As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPlanningBalance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotalTargetQuantity As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents WHTextBox As System.Windows.Forms.TextBox
        Private WithEvents WorkingLabel As System.Windows.Forms.Label
        Friend WithEvents CalculateButton As System.Windows.Forms.Button
        Friend WithEvents colYR As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMH As DevExpress.XtraGrid.Columns.GridColumn
        Private WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents ExDateEdit As DevExpress.XtraEditors.DateEdit
        Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents colStartDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEndDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents LatestExDateTextEdit As DevExpress.XtraEditors.TextEdit
        Friend WithEvents colStyleType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents ESPSpinEdit As DevExpress.XtraEditors.SpinEdit
        Private WithEvents Label9 As Label
        Friend WithEvents txPlanningQuantity As DevExpress.XtraEditors.SpinEdit
        Friend WithEvents colSewingPercentage As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSewingRequireQuantity As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GetDataButton As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents colSelect As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFabricColorName1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents PlanQtyLinkLabel As LinkLabel
        Private WithEvents Label5 As Label
        Friend WithEvents AppointmentDetailsBindingSource1 As BindingSource
        Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDaySerial As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPlanningDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEfficiency As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPlanningQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTarget As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents PlanningBalanceDataSet As PlanningBalanceDataSet
        Friend WithEvents PlanningBalanceOIDBindingSource As BindingSource
        Friend WithEvents PlanningBalanceOIDTableAdapter As PlanningBalanceDataSetTableAdapters.PlanningBalanceOIDTableAdapter
        Friend WithEvents TableAdapterManager1 As PlanningBalanceDataSetTableAdapters.TableAdapterManager
        Friend WithEvents Label1 As Label
        Friend WithEvents OrderLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
        Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colDetails1 As DevExpress.XtraGrid.Columns.GridColumn
        'Friend WithEvents PlanningBalanceOIDTableAdapter As SewingPlanningBalanceTableAdapters.PlanningBalanceOIDTableAdapter
    End Class
End Namespace