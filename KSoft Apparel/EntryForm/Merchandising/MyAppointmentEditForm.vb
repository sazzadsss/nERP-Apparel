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
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.UI
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
'Imports KSoft_Apparel.CustomAppointmentEditForm
Imports DevExpress.Utils
Imports System.Data.SqlClient

Namespace CustomAppointmentEditForm

    Partial Public Class MyAppointmentEditForm
        Inherits DevExpress.XtraEditors.XtraForm

        Private control As SchedulerControl
        Private apt As Appointment
        Private openRecurrenceForm As Boolean = False
        Private suspendUpdateCount As Integer
        Private GetOrderflag As Boolean = False


        ' The MyAppointmentFormController class is inherited from
        ' the AppointmentFormController to add custom properties.
        ' See its declaration below.
        Private controller As MyAppointmentFormController

        Protected ReadOnly Property Appointments() As AppointmentStorage
            Get
                Return control.Storage.Appointments
            End Get
        End Property
        Protected ReadOnly Property IsUpdateSuspended() As Boolean
            Get
                Return suspendUpdateCount > 0
            End Get
        End Property

        Private _MaxExDate As Date
        Public Property MaxExDate() As Date
            Get
                Return _MaxExDate
            End Get
            Set(ByVal value As Date)
                _MaxExDate = value
            End Set
        End Property
        Private _CurrentAppointmentId As Integer
        Public Property CurrenttAppointmentId() As Integer
            Get
                Return _CurrentAppointmentId
            End Get
            Set(ByVal value As Integer)
                _CurrentAppointmentId = value
            End Set
        End Property
        Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment, ByVal openRecurrenceForm As Boolean)

            Me.openRecurrenceForm = openRecurrenceForm
            Me.controller = New MyAppointmentFormController(control, apt)
            Me.apt = apt
            Me.CurrenttAppointmentId = apt.GetValue(SchedulerStorage1, "AppointmentId")
            Me.control = control
            '
            ' Required for Windows Form Designer support
            '
            SuspendUpdate()
            InitializeComponent()
            ResumeUpdate()

            UpdateForm()

            '

            ''

        End Sub

#Region "Recurrence"
        Private Sub MyAppointmentEditForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs)
            ' Required to show the recurrence form.
            If openRecurrenceForm Then
                openRecurrenceForm = False
                OnRecurrenceButton()
            End If
        End Sub
        Private Sub btnRecurrence_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRecurrence.Click
            OnRecurrenceButton()
        End Sub

        Private Sub OnRecurrenceButton()
            ShowRecurrenceForm()
        End Sub

        Private Sub ShowRecurrenceForm()

            If (Not control.SupportsRecurrence) Then
                Return
            End If

            ' Prepare to edit the appointment's recurrence.
            Dim editedAptCopy As Appointment = controller.EditedAppointmentCopy
            Dim editedPattern As Appointment = controller.EditedPattern
            Dim patternCopy As Appointment = controller.PrepareToRecurrenceEdit()

            Dim dlg As New AppointmentRecurrenceForm(patternCopy, control.OptionsView.FirstDayOfWeek, controller)

            ' Required for skin support.
            dlg.LookAndFeel.ParentLookAndFeel = Me.LookAndFeel.ParentLookAndFeel

            Dim result As DialogResult = dlg.ShowDialog(Me)
            dlg.Dispose()

            If result = System.Windows.Forms.DialogResult.Abort Then
                controller.RemoveRecurrence()
            Else
                If result = System.Windows.Forms.DialogResult.OK Then
                    controller.ApplyRecurrence(patternCopy)
                    If controller.EditedAppointmentCopy IsNot editedAptCopy Then
                        UpdateForm()
                    End If
                End If
            End If
            UpdateIntervalControls()
        End Sub

#End Region

#Region "Form control events"

        Private Sub dtStart_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtStart.EditValueChanged
            If (Not IsUpdateSuspended) Then
                controller.DisplayStart = dtStart.DateTime.Date + timeStart.Time.TimeOfDay
            End If
            UpdateIntervalControls()
        End Sub

        Private Sub timeStart_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles timeStart.EditValueChanged
            If (Not IsUpdateSuspended) Then
                controller.DisplayStart = dtStart.DateTime.Date + timeStart.Time.TimeOfDay
            End If
            UpdateIntervalControls()
        End Sub
        Private Sub timeEnd_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles timeEnd.EditValueChanged
            If IsUpdateSuspended Then
                Return
            End If
            If IsIntervalValid() Then
                controller.DisplayEnd = dtEnd.DateTime.Date + timeEnd.Time.TimeOfDay
            Else
                timeEnd.EditValue = New DateTime(controller.DisplayEnd.TimeOfDay.Ticks)
            End If

        End Sub
        Private Sub dtEnd_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtEnd.EditValueChanged
            If IsUpdateSuspended Then
                Return
            End If
            If IsIntervalValid() Then
                controller.DisplayEnd = dtEnd.DateTime.Date + timeEnd.Time.TimeOfDay
            Else
                dtEnd.EditValue = controller.DisplayEnd.Date
            End If
        End Sub
        Private Function IsIntervalValid() As Boolean
            Dim start As DateTime = dtStart.DateTime + timeStart.Time.TimeOfDay
            Dim [end] As DateTime = dtEnd.DateTime + timeEnd.Time.TimeOfDay
            Return [end] >= start
        End Function

        Private Sub checkAllDay_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkAllDay.CheckedChanged
            controller.AllDay = Me.checkAllDay.Checked
            If (Not IsUpdateSuspended) Then
                UpdateAppointmentStatus()
            End If

            UpdateIntervalControls()
        End Sub
#End Region

#Region "Updating Form"
        Protected Sub SuspendUpdate()
            suspendUpdateCount += 1
        End Sub
        Protected Sub ResumeUpdate()
            If suspendUpdateCount > 0 Then
                suspendUpdateCount -= 1
            End If
        End Sub

        Private Sub UpdateForm()

            SuspendUpdate()

            Try

                txSubject.Text = controller.Subject

                txOrderId.EditValue = controller.OrderId
                txFabricColorId.EditValue = controller.FabricColorId
                POLookUpEdit.EditValue = controller.OrderDetailsId
                ESPSpinEdit.Value = controller.ExcessSewingPercentage
                WHTextBox.Text = controller.WH
                DayRequireTextBox.Text = controller.RD
                HourRequireTextBox.Text = controller.RH


                edStatus.AppointmentStatus = Appointments.Statuses(controller.StatusKey)
                edLabel.AppointmentLabel = Appointments.Labels(controller.LabelKey)

                dtStart.DateTime = controller.DisplayStart.Date
                dtEnd.DateTime = controller.DisplayEnd.Date

                timeStart.Time = New DateTime(controller.DisplayStart.TimeOfDay.Ticks)
                timeEnd.Time = New DateTime(controller.DisplayEnd.TimeOfDay.Ticks)
                checkAllDay.Checked = controller.AllDay
                txResourceId.EditValue = controller.ResourceId


                edStatus.Storage = control.Storage
                edLabel.Storage = control.Storage



                txPlanningQuantity.Text = controller.PlanningQuantity
                POLookUpEdit.EditValue = controller.OrderDetailsId
                ESPSpinEdit.Value = controller.ExcessSewingPercentage
                TargetTextBox.Text = controller.Target
                AdvancedCheckBox.Checked = controller.IsAdvanced

                ExDateEdit.EditValue = controller.ExDate

                'LatestExDateTextEdit.EditValue = ReadDateData("Select EX From OrderDetails Where OrderDetailsId=" & controller.OrderDetailsId, cnn)


            Finally
                ResumeUpdate()
            End Try

            UpdateIntervalControls()

        End Sub

        Protected Overridable Sub UpdateIntervalControls()
            If IsUpdateSuspended Then
                Return
            End If

            SuspendUpdate()
            Try
                dtStart.EditValue = controller.DisplayStart.Date
                dtEnd.EditValue = controller.DisplayEnd.Date
                timeStart.EditValue = New DateTime(controller.DisplayStart.TimeOfDay.Ticks)
                timeEnd.EditValue = New DateTime(controller.DisplayEnd.TimeOfDay.Ticks)


                timeStart.Visible = Not controller.AllDay
                timeEnd.Visible = Not controller.AllDay
                timeStart.Enabled = Not controller.AllDay
                timeEnd.Enabled = Not controller.AllDay

            Finally
                ResumeUpdate()
            End Try
        End Sub

        Private Sub UpdateAppointmentStatus()
            Dim currentStatus As AppointmentStatus = edStatus.AppointmentStatus
            Dim newStatus As AppointmentStatus = controller.UpdateStatus(currentStatus)
            If newStatus IsNot currentStatus Then
                edStatus.AppointmentStatus = newStatus
            End If
        End Sub

#End Region

#Region "Save changes"

        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click

            ' Required to check the appointment for conflicts.
            If (Not controller.IsConflictResolved()) Then
                Return
            End If

            controller.Subject = txSubject.Text
            controller.SetStatus(edStatus.AppointmentStatus)
            controller.SetLabel(edLabel.AppointmentLabel)
            controller.AllDay = Me.checkAllDay.Checked
            controller.DisplayStart = Me.dtStart.DateTime.Date + Me.timeStart.Time.TimeOfDay
            controller.DisplayEnd = Me.dtEnd.DateTime.Date + Me.timeEnd.Time.TimeOfDay
            controller.OrderId = txOrderId.EditValue
            controller.FabricColorId = -1
            controller.OrderDetailsId = -1
            controller.ExcessSewingPercentage = ESPSpinEdit.Value
            controller.PlanningQuantity = Val(txPlanningQuantity.Text)
            controller.Target = Val(TargetTextBox.Text)
            controller.ResourceId = txResourceId.EditValue
            controller.IsAdvanced = AdvancedCheckBox.Checked
            controller.WH = Val(WHTextBox.Text)
            controller.RH = Val(HourRequireTextBox.Text)
            controller.RD = Val(DayRequireTextBox.Text)
            controller.ExDate = ExDateEdit.Text

            ' Save all changes of the editing appointment.
            controller.ApplyChanges()


            MessageBox.Show("Updated Successfully")
            Me.GetDataButton.Enabled = False

        End Sub

#End Region

#Region "MyAppointmentFormController"

        Public Class MyAppointmentFormController
            Inherits AppointmentFormController
            'ExcessSewingPercentage
            Public Property OrderId() As Integer
                Get
                    Return CInt(EditedAppointmentCopy.CustomFields("OrderId"))
                End Get
                Set(ByVal value As Integer)
                    EditedAppointmentCopy.CustomFields("OrderId") = value
                End Set
            End Property
            Public Property FabricColorId() As Integer
                Get

                    Return CInt(EditedAppointmentCopy.CustomFields("FabricColorId"))

                End Get

                Set(ByVal value As Integer)
                    EditedAppointmentCopy.CustomFields("FabricColorId") = value
                End Set

            End Property
            Public Property OrderDetailsId() As Integer
                Get

                    Return CInt(EditedAppointmentCopy.CustomFields("OrderDetailsId"))

                End Get

                Set(ByVal value As Integer)
                    EditedAppointmentCopy.CustomFields("OrderDetailsId") = value
                End Set

            End Property

            Public Property WH() As Integer
                Get

                    Return CInt(EditedAppointmentCopy.CustomFields("WH"))

                End Get

                Set(ByVal value As Integer)
                    EditedAppointmentCopy.CustomFields("WH") = value
                End Set

            End Property

            Public Property RD() As Integer

                Get

                    Return CInt(EditedAppointmentCopy.CustomFields("RD"))

                End Get

                Set(ByVal value As Integer)
                    EditedAppointmentCopy.CustomFields("RD") = value
                End Set

            End Property

            Public Property RH() As Integer

                Get

                    Return CInt(EditedAppointmentCopy.CustomFields("RH"))

                End Get

                Set(ByVal value As Integer)
                    EditedAppointmentCopy.CustomFields("RH") = value
                End Set

            End Property

            Public Property PlanningQuantity() As Integer
                Get

                    Return CInt(EditedAppointmentCopy.CustomFields("PlanningQuantity"))

                End Get
                Set(ByVal value As Integer)
                    EditedAppointmentCopy.CustomFields("PlanningQuantity") = value
                End Set
            End Property

            Public Property ExcessSewingPercentage() As Integer
                Get

                    Return CInt(EditedAppointmentCopy.CustomFields("ExcessSewingPercentage"))

                End Get
                Set(ByVal value As Integer)
                    EditedAppointmentCopy.CustomFields("ExcessSewingPercentage") = value
                End Set
            End Property


            Public Property Target() As Integer
                Get

                    Return CInt(EditedAppointmentCopy.CustomFields("Target"))

                End Get
                Set(ByVal value As Integer)
                    EditedAppointmentCopy.CustomFields("Target") = value
                End Set
            End Property

            Public Property ExDate() As Date
                Get

                    Return CDate(EditedAppointmentCopy.CustomFields("ExDate"))

                End Get
                Set(ByVal value As Date)
                    EditedAppointmentCopy.CustomFields("ExDate") = value
                End Set
            End Property

            Public Property IsAdvanced() As Boolean

                Get
                    Return CInt(EditedAppointmentCopy.CustomFields("IsAdvanced"))
                End Get

                Set(ByVal value As Boolean)
                    EditedAppointmentCopy.CustomFields("IsAdvanced") = value
                End Set

            End Property

            Private Property SourceOrderId() As Integer
                Get
                    Return CStr(SourceAppointment.CustomFields("OrderId"))
                End Get
                Set(ByVal value As Integer)
                    SourceAppointment.CustomFields("OrderId") = value
                End Set
            End Property
            Private Property SourceFabricColorId() As Integer
                Get
                    Return CInt(SourceAppointment.CustomFields("FabricColorId"))
                End Get
                Set(ByVal value As Integer)
                    SourceAppointment.CustomFields("FabricColorId") = value
                End Set
            End Property
            Private Property SourceOrderDetailsId() As Integer
                Get
                    Return CInt(SourceAppointment.CustomFields("OrderDetailsId"))
                End Get
                Set(ByVal value As Integer)
                    SourceAppointment.CustomFields("OrderDetailsId") = value
                End Set
            End Property
            Private Property SourceWH() As Integer
                Get
                    Return CInt(SourceAppointment.CustomFields("WH"))
                End Get
                Set(ByVal value As Integer)
                    SourceAppointment.CustomFields("WH") = value
                End Set
            End Property
            Private Property SourceRD() As Integer
                Get
                    Return CInt(SourceAppointment.CustomFields("RD"))
                End Get
                Set(ByVal value As Integer)
                    SourceAppointment.CustomFields("RD") = value
                End Set
            End Property
            Private Property SourceRH() As Integer
                Get
                    Return CInt(SourceAppointment.CustomFields("RH"))
                End Get
                Set(ByVal value As Integer)
                    SourceAppointment.CustomFields("RH") = value
                End Set
            End Property
            Private Property SourcePlanningQuantity() As Integer
                Get
                    Return CInt(SourceAppointment.CustomFields("PlanningQuantity"))
                End Get
                Set(ByVal value As Integer)
                    SourceAppointment.CustomFields("PlanningQuantity") = value
                End Set
            End Property
            Private Property SourceExcessSewingPercentage() As Integer
                Get
                    Return CInt(SourceAppointment.CustomFields("ExcessSewingPercentage"))
                End Get
                Set(ByVal value As Integer)
                    SourceAppointment.CustomFields("ExcessSewingPercentage") = value
                End Set
            End Property
            Private Property SourceTarget() As Integer
                Get
                    Return CInt(SourceAppointment.CustomFields("Target"))
                End Get
                Set(ByVal value As Integer)
                    SourceAppointment.CustomFields("Target") = value
                End Set
            End Property

            Private Property SourceExDate() As Date
                Get
                    Return CDate(SourceAppointment.CustomFields("ExDate"))
                End Get
                Set(ByVal value As Date)
                    SourceAppointment.CustomFields("ExDate") = value
                End Set
            End Property

            Private Property SourceIsAdvanced() As Boolean
                Get
                    Return CInt(SourceAppointment.CustomFields("IsAdvanced"))
                End Get
                Set(ByVal value As Boolean)
                    SourceAppointment.CustomFields("IsAdvanced") = value
                End Set
            End Property

            Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment)
                MyBase.New(control, apt)
            End Sub

            Public Overrides Function IsAppointmentChanged() As Boolean

                If MyBase.IsAppointmentChanged() Then
                    Return True
                End If
                Return SourceOrderId <> OrderId OrElse SourceFabricColorId <> FabricColorId OrElse OrderDetailsId <> SourceOrderDetailsId OrElse WH <> SourceWH OrElse RD <> SourceRD OrElse RH <> SourceRH OrElse SourcePlanningQuantity <> PlanningQuantity OrElse SourceExcessSewingPercentage <> ExcessSewingPercentage OrElse SourceTarget <> Target OrElse SourceIsAdvanced <> IsAdvanced OrElse SourceExDate <> ExDate

            End Function

            Protected Overrides Sub ApplyCustomFieldsValues()

                SourceOrderId = OrderId
                SourceFabricColorId = FabricColorId
                SourcePlanningQuantity = PlanningQuantity
                SourceExcessSewingPercentage = ExcessSewingPercentage
                SourceTarget = Target
                SourceIsAdvanced = IsAdvanced
                SourceOrderDetailsId = OrderDetailsId
                SourceWH = WH
                SourceRD = RD
                SourceRH = RH
                SourceExDate = ExDate


            End Sub

        End Class

#End Region


        Private Sub MyAppointmentEditForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            'Me.OrderPOLookupNewTableAdapter.Fill(Me.OrderPOLookupNewDataSet.OrderPOLookupNew)


            'With txOrderId.Properties
            '    .DataSource = GetProgramNo()
            '    .DisplayMember = "ProgramNo"
            '    .ValueMember = "OrderId"
            '    .ForceInitialize() ' Force it to initialize
            '    .PopulateColumns() ' Force the lookupedit to populate
            '    .Columns("OrderId").Visible = False
            'End With


            'With txResourceId.Properties
            '    .DataSource = GetLine()
            '    .DisplayMember = "Line"
            '    .ValueMember = "LineId"
            '    .ForceInitialize() ' Force it to initialize
            '    .PopulateColumns() ' Force the lookupedit to populate
            '    .Columns("LineId").Visible = False
            'End With


            'On Error Resume Next
            Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
            Me.LineTableAdapter.FillByPlanning(Me.LineDataSet.Line)


            Me.PlanningIdLabel.Text = Me.CurrenttAppointmentId
            Me.AppointmentsTableAdapter.FillByApmntId(Me.PlanningBoardNewDataSet.Appointments, Me.CurrenttAppointmentId)
            Me.AppointmentDetailsTableAdapter.FillByAptId(Me.PlanningBoardNewDataSet.AppointmentDetails, Me.CurrenttAppointmentId)
            Me.PlanningBalanceOIDTableAdapter.FillByOID(Me.PlanningBalanceDataSet.PlanningBalanceOID, apt.CustomFields("OrderId"))
            MessageLabel.Visible = True
            MessageLabel.Dock = DockStyle.Fill

            GetDataButton.Enabled = False
            checkAllDay.Checked = True


            Me.SewingOutputBalanceListGridControl.DataSource = Nothing

            BackgroundWorker1.RunWorkerAsync()



        End Sub

        Private Sub StartDateLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles StartDateLinkLabel.LinkClicked

            Dim NextTime As Date = dtEnd.DateTime       ' Current date and time.
            NextTime = NextTime.AddDays(0 - Math.Round(Val(DayRequireTextBox.Text), 1))
            dtStart.EditValue = NextTime


        End Sub



        Private Sub CalculateEndDate()
            'On Error Resume Next

            Dim sdt As DateTime = dtStart.DateTime.Date
            timeStart.EditValue = sdt.Date.AddHours(8)
            Dim NextTime As Date = dtStart.DateTime       ' Current date and time.

            NextTime = NextTime.AddDays(Math.Round(Val(DayRequireTextBox.Text), 1))

            Dim HLDDay As Integer = ReadIntData("Select Count(HolidayDate) AS TTLDay From Holiday Where HolidayDate between '" & Me.dtStart.DateTime.Date & "' And '" & NextTime & "'", cnn)

            dtEnd.EditValue = NextTime.AddDays(Math.Round(Val(HLDDay), 1) - 1)
            Dim edt As Date = New Date(dtEnd.DateTime.Year, dtEnd.DateTime.Month, dtEnd.DateTime.Day, 8, 0, 0)
            'timeEnd.EditValue = edt
            timeStart.Time.AddHours(Math.Round(Val(HourRequireTextBox.Text) + HLDDay * Val(WHTextBox.Text), 1))

            'Dim HLDHour As Integer = HLDDay * Val(WHTextBox.Text)
            'Dim TotalHour As Decimal = (txPlanningQuantity.Text / TargetTextBox.Text) + HLDHour
            'Dim TotalHour As Decimal = Val(HourRequireTextBox.Text) + HLDHour



            ''For Reference

            'Public override void DataBind() {
            '        Base.DataBind();
            '    ...
            '        If (Container.Control.ActiveViewType == SchedulerViewType.Week) Then        {
            '            DateTime start = (DateTime)edtStartDate.Value;
            '            edtStartDate.Value = start.Date.AddHours(8);
            '            edtEndDate.Value = start.Date.AddHours(8.5);
            '        }
            '    ...
            '}


        End Sub


        Private Sub MarkAsToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            If PlanningBalanceOIDBindingSource.Position > -1 Then

                Dim row As PlanningBalanceDataSet.PlanningBalanceOIDRow
                row = CType(CType(Me.PlanningBalanceOIDBindingSource.Current, DataRowView).Row, PlanningBalanceDataSet.PlanningBalanceOIDRow)

                'ExecuteQuery("Update OrderDetails Set IsSewingComplete=1 Where OrderDetailsId=" & row.OrderDetailsId, cnn)

                Me.PlanningBalanceOIDTableAdapter.Fill(Me.PlanningBalanceDataSet.PlanningBalanceOID)

                MessageBox.Show("Mark As Sewing Complete has been successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If

        End Sub



        Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork



            'Me.AppointmentsTableAdapter.Fill(Me.PlanningBoardNewDataSet.Appointments)
            'Me.PlanningBalanceOIDTableAdapter.Fill(Me.PlanningBalanceDataSet.PlanningBalanceOID)



        End Sub

        Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

            Me.SewingOutputBalanceListGridControl.DataSource = Me.PlanningBalanceOIDBindingSource


            MessageLabel.Visible = False

            GetDataButton.Enabled = True


        End Sub

        Private Sub OnApptChangedInsertedDeleted(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PersistentObjectsEventArgs) Handles SchedulerStorage1.AppointmentsChanged, SchedulerStorage1.AppointmentsDeleted, SchedulerStorage1.AppointmentsInserted
            AppointmentsTableAdapter.Update(PlanningBoardNewDataSet)
            PlanningBoardNewDataSet.AcceptChanges()
        End Sub

        Private Sub SaveAndContinueSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAndContinueSimpleButton.Click

            'On Error Resume Next

            'If (Not controller.IsConflictResolved()) Then
            '    Return
            'End If


            ''Dim hitInfo As SchedulerHitInfo = SchedulerControl1.ActiveView.ViewInfo.CalcHitInfo(Point, True)
            ''If hitInfo.HitTest = SchedulerHitTest.Cell Then


            ''    Dim cell As SelectableIntervalViewInfo = hitInfo.ViewInfo

            ''    If GetOrderflag = False Then
            ''        GetOrderInfo()
            ''        'GetMultipleOrderInfo()
            ''    End If
            ''End If



            'Dim TotalDay As Decimal = txPlanningQuantity.Text / (TargetTextBox.Text * 10)

            '' Add an appointment.

            'Dim myapt As Appointment = SchedulerStorage1.CreateAppointment(AppointmentType.Normal)

            'Dim orStyleName As String = ReadStringData("Select StyleName From Style Where StyleId=(Select StyleId From [Order] Where OrderId=" & txOrderId.EditValue & ")", cnn)
            'Dim orStyleName2 As String = ReadStringData("Select StyleName From StyleNameMst Where StyleNameId=(Select StyleNameId From Style Where StyleId=(Select StyleId From [Order] Where OrderId=" & txOrderId.EditValue & "))", cnn)

            'If AdvancedCheckBox.Checked = False Then
            '    myapt.Subject = txOrderId.Text & "::" & txFabricColorId.Text & "::" & txPlanningQuantity.Text & "(" & orStyleName2 & ")"
            'Else
            '    myapt.Subject = txSubject.Text
            'End If

            'myapt.Location = orStyleName & " :: " & orStyleName2
            'myapt.CustomFields("OrderId") = txOrderId.EditValue
            'myapt.CustomFields("FabricColorId") = txFabricColorId.EditValue
            'myapt.CustomFields("Target") = Val(TargetTextBox.Text)
            'myapt.CustomFields("IsAdvanced") = AdvancedCheckBox.Checked
            'myapt.CustomFields("OrderDetailsId") = POLookUpEdit.EditValue




            'myapt.ResourceId = txResourceId.EditValue
            'myapt.Description = "Style=" & orStyleName & vbNewLine & " Quantity = " & txPlanningQuantity.Text

            'SchedulerStorage1.Appointments.Add(myapt)

            'Me.CurrenttAppointmentId = myapt.GetValue(SchedulerStorage1, "AppointmentId")

            ''If AdvancedCheckBox.Checked = False Then
            ''    ExecuteQuery("Update Appointments Set OrderDetailsId=" & POLookUpEdit.EditValue & "And  IsAdvanced=0 And OrderId=" & txOrderId.EditValue & ",FabricColorId=" & txFabricColorId.EditValue & ",Target=" & Val(TargetTextBox.Text) & ",PlanningQuantity=" & Val(txPlanningQuantity.Text) & "Where AppointmentId=" & Me.CurrenttAppointmentId, cnn)
            ''ElseIf AdvancedCheckBox.Checked = True Then
            ''    ExecuteQuery("Update Appointments Set IsAdvanced=1 And OrderId=" & txOrderId.EditValue & ",FabricColorId=" & txFabricColorId.EditValue & ",Target=" & Val(TargetTextBox.Text) & ",PlanningQuantity=" & Val(txPlanningQuantity.Text) & "Where AppointmentId=" & Me.CurrenttAppointmentId, cnn)
            ''End If

            'dtStart.EditValue = dtEnd.DateTime.AddDays(1)
            'GetOrderflag = False
            'PlanningIdLabel.Text = Me.CurrenttAppointmentId

            ''If AdvancedCheckBox.Checked = False Then
            ''GetMultipleOrderInfo()
            ''End If



            'MessageBox.Show("Added Successfully")

        End Sub





        'Private Sub txFabricColorId_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txFabricColorId.EditValueChanged
        '    On Error Resume Next
        '    Me.OrderPOLookupNewTableAdapter.FillByOrderAndColor(Me.OrderPOLookupNewDataSet.OrderPOLookupNew, txFabricColorId.EditValue, txOrderId.EditValue)
        'End Sub

        Private Sub WHTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WHTextBox.TextChanged

            'If Val(WHTextBox.Text) > 0 Then
            '    DayRequireTextBox.Text = Math.Round(Val(txPlanningQuantity.Text) / (Val(TargetTextBox.Text) * Val(WHTextBox.Text)), 2)
            '    HourRequireTextBox.Text = Math.Round(Val(txPlanningQuantity.Text) / Val(TargetTextBox.Text), 2)
            'Else
            '    DayRequireTextBox.Text = 0
            '    HourRequireTextBox.Text = 0
            'End If

            'If Val(WHTextBox.Text) > 0 Then
            '    HourRequireTextBox.Text = Math.Round(Val(DayRequireTextBox.Text) * Val(WHTextBox.Text), 2)
            'End If

        End Sub

        Private Sub DayRequireNumericUpDown_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DayRequireTextBox.TextChanged

            If Val(WHTextBox.Text) > 0 Then
                HourRequireTextBox.Text = Math.Round(Val(DayRequireTextBox.Text) * Val(WHTextBox.Text), 2)
            End If

        End Sub

        Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click


            CalculateDay()



            With apt


                .CustomFields("PlanningQuantity") = txPlanningQuantity.Value
                .CustomFields("Target") = Val(TargetTextBox.Text)
                .CustomFields("RD") = Val(DayRequireTextBox.Text)
                .CustomFields("RH") = Val(HourRequireTextBox.Text)
                .End = Me.dtEnd.DateTime.Date + Me.timeEnd.Time.TimeOfDay

            End With




        End Sub

        Private Sub CalculateDay()

            If Val(TargetTextBox.Text) > 0 Then

                Dim TTLPlanning = txPlanningQuantity.Value
                DayRequireTextBox.Text = Val(TTLPlanning) / (Val(TargetTextBox.Text) * Val(WHTextBox.Text))
                HourRequireTextBox.Text = Val(TTLPlanning) / Val(TargetTextBox.Text)
                CalculateEndDate()

            Else

                DayRequireTextBox.Text = 0
                HourRequireTextBox.Text = 0

            End If



        End Sub



        Private Sub ShowAllToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub GetDataButton_Click(sender As Object, e As EventArgs) Handles GetDataButton.Click
            If Me.PlanningBalanceOIDBindingSource.Position > -1 Then
                Me.GetDataButton.Enabled = False

                Dim row As PlanningBalanceDataSet.PlanningBalanceOIDRow
                row = CType(CType(Me.PlanningBalanceOIDBindingSource.Current, DataRowView).Row, PlanningBalanceDataSet.PlanningBalanceOIDRow)

                Dim OID As Integer = row.OrderId
                Dim TQ As Integer
                Dim TExDate As Date = row.Ex.ToShortDateString()

                If row.IsTotalTargetQuantityNull Then
                    TQ = 0
                Else
                    TQ = row.TotalTargetQuantity
                End If


                Dim POList As String = String.Empty
                Dim ColorList As String = String.Empty
                Dim PreColor As String = String.Empty
                Dim TTLPlanningquantity As Integer = 0

                If ESPSpinEdit.Value > 0 Then
                    ExecuteQuery("Update OrderCuttingPercentage Set Sewing=" & ESPSpinEdit.Value & " Where OrderId in (Select OrderId From OrderDetails Where OrderDetailsId in (" & POList & ")) And FabricColorid in (Select FabricColorId From OrderDetails Where OrderDetailsId in (" & POList & "))", cnn)
                End If


                'Me.PlanningBalanceOIDBindingSource.Filter = "OrderDetailsId in ( " & POList & ")"
                'Dim myapt As Appointment = Me.apt 'SchedulerStorage1.CreateAppointment(AppointmentType.Normal)


                With Me.apt
                    dtStart.DateTime = row.StartDate
                    .Start = dtStart.DateTime
                    .End = dtStart.DateTime
                    .AllDay = True
                    txOrderId.EditValue = OID
                    .CustomFields("OrderId") = OID
                    txFabricColorId.EditValue = -1
                    .CustomFields("FabricColorId") = -1

                    .CustomFields("OrderDetailsId") = -1 'row.OrderDetailsId
                    ESPSpinEdit.Value = 2
                    .CustomFields("SewingPercentage") = ESPSpinEdit.Value
                    .CustomFields("PlanningQuantity") = 0
                    WHTextBox.Text = 10
                    .CustomFields("WH") = 10
                    .CustomFields("EX") = TExDate.ToShortDateString()
                    .CustomFields("IsAdvanced") = False
                    ExDateEdit.Text = row.Ex
                    .ResourceId = txResourceId.EditValue

                    Dim orStyleName As String = ReadStringData("Select StyleName From Style Where StyleId=(Select StyleId From [Order] Where OrderId=" & OID & ")", cnn)
                    Dim orStyleType As String = ReadStringData("Select StyleType From Style Where StyleId=(Select StyleId From [Order] Where OrderId=" & OID & ")", cnn)
                    Dim orBuyerName As String = ReadStringData("Select BuyerName From Buyer Where BuyerId=(Select BuyerId From [Order] Where OrderId=" & OID & ")", cnn)

                    .Subject = txOrderId.Text & "::" & orStyleName & "::" & orStyleType & "::" & orBuyerName & "::" & ColorList & "::" & txPlanningQuantity.Text '& "(" & PlanningIdLabel.Text & ")"
                    txSubject.Text = txOrderId.Text & "::" & orStyleName & "::" & orStyleType & "::" & orBuyerName & "::" & ColorList & "::" & txPlanningQuantity.Text '& "(" & PlanningIdLabel.Text & ")"
                    .Description = "Style=" & orStyleName & vbNewLine & " Quantity = " & 0
                    .CustomFields("Target") = TQ

                End With

                'controller.ApplyChanges()

                Me.SchedulerStorage1.Appointments.Add(apt)

                Me.CurrenttAppointmentId = apt.GetValue(SchedulerStorage1, "AppointmentId")
                PlanningIdLabel.Text = Me.CurrenttAppointmentId
                Me.AppointmentDetailsTableAdapter.FillByAptId(Me.PlanningBoardNewDataSet.AppointmentDetails, Me.CurrenttAppointmentId)
                If row.PlanningBalance > 0 Then
                    AddAppointmentDetails(Me.CurrenttAppointmentId, row.PlanningBalance, row.StartDate, row.EndDate, OID, 10)
                End If

                'Me.OrderFabricColorTableAdapter.FillByProgramNo(Me.OrderFabricColorDataSet.OrderFabricColor, txOrderId.Text)
                'txPlanningQuantity.Value = TTLPlanningquantity
                'ExDateEdit.Text = ReadDateData("Select Min(Ex) From OrderDetails Where OrderDetailsId in (Select OrderDetailsId From AppointmentDetails Where AppointmentId=" & Me.CurrenttAppointmentId & ")", cnn).ToShortDateString()

                'CalculateDay()
                GetOrderflag = True

                Try
                    Me.Validate()
                    Me.AppointmentsBindingSource.EndEdit()
                    Me.AppointmentDetailsBindingSource1.EndEdit()
                    Me.AppointmentDetailsTableAdapter.Update(Me.PlanningBoardNewDataSet.AppointmentDetails)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try


            End If



        End Sub

        Private Sub AddAppointmentDetails(ByVal aptId As Integer, ByVal PlanningBalance As Integer, ByVal StartDate As DateTime, ByVal EndDate As DateTime, ByVal OID As Integer, ByVal WHD As Integer)


            If Me.AppointmentDetailsBindingSource1.Position = -1 Then

                Dim i As Integer = 1
                Dim CumNormalQuantity As Integer = 0
                Dim CumBonusQuantity As Integer = 0
                Dim Target As Integer = 0
                Dim PlanningDate As DateTime = dtStart.DateTime.Date
                Dim SSMV As Decimal = ReadData("Select SMV From Style Where StyleId=(Select StyleId From [Order] Where OrderId=" & OID & ")", cnn)
                Dim SMC As Integer = ReadIntData("Select MCQty From Style Where StyleId=(Select StyleId From [Order] Where OrderId=" & OID & ")", cnn)
                Dim Efficiency As Decimal
                Dim ProdEff As Integer = FormatNumber(SMC * 60 / SSMV * Val(WHTextBox.Text), 0)
                Dim CumBal As Integer = 0


                Dim connection As New SqlConnection(cnn)
                connection.Open()

                Dim cmd As SqlCommand = New SqlCommand("Select dt From all_dates Where dt not in (Select HolidayDate From Holiday) And (dt between '" & StartDate & "' and '" & EndDate & "') Order By dt ", connection)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()

                    If reader.IsDBNull(0) = False Then

                        If CumNormalQuantity <= PlanningBalance Then

                            If i < 10 Then
                                Efficiency = ReadData("Select Min(LC_Value) From SewingLearningCurve Where MinSMV<=" & SSMV & " and DaySerial=" & i, cnn)
                            Else
                                Efficiency = ReadData("Select Min(LC_Value) From SewingLearningCurve Where MinSMV<=" & SSMV & " and DaySerial=10", cnn)
                            End If
                            Dim PQty As Integer = 0



                            If CumNormalQuantity + ProdEff * Efficiency <= PlanningBalance Then

                                PQty = ProdEff * Efficiency
                                CumNormalQuantity = CumNormalQuantity + PQty


                            ElseIf CumNormalQuantity + ProdEff * Efficiency > PlanningBalance Then

                                PQty = PlanningBalance - CumNormalQuantity
                                CumNormalQuantity = CumNormalQuantity + PQty

                            End If

                            ' MessageBox.Show("Day:" & i & vbNewLine & "PQty:" & PQty.ToString())

                            If i = 1 Then
                                dtStart.DateTime = reader("dt")
                            End If

                            If PQty > 0 Then

                                dtEnd.DateTime = reader("dt")
                                CRUDAppointmentDetails(aptId, i, reader("dt"), Efficiency * 100, PQty, WHD)

                                Target = (CumNormalQuantity / i / 10)
                                TargetTextBox.Text = FormatNumber(Target, 0)
                                txPlanningQuantity.Text = CumNormalQuantity
                                WHTextBox.Text = 10
                                DayRequireTextBox.Text = DateDiff("d", dtStart.DateTime, dtEnd.DateTime)
                                HourRequireTextBox.Text = DateDiff("d", dtStart.DateTime, dtEnd.DateTime) * 10

                                With apt


                                    .CustomFields("PlanningQuantity") = txPlanningQuantity.Value
                                    .CustomFields("Target") = Val(TargetTextBox.Text)
                                    .CustomFields("RD") = Val(DayRequireTextBox.Text)
                                    .CustomFields("RH") = Val(HourRequireTextBox.Text)
                                    .Start = Me.dtStart.DateTime.Date '+ Me.timeStart.Time.TimeOfDay
                                    .End = Me.dtEnd.DateTime.Date.AddDays(1) '+ Me.timeEnd.Time.TimeOfDay

                                End With


                            Else

                                GoTo line1

                            End If

                            i += 1

                        End If

                    End If

                End While

line1:
                reader.Close()
                connection.Close()

                AppointmentDetailsTableAdapter.FillByAptId(Me.PlanningBoardNewDataSet.AppointmentDetails, aptId)

            End If

        End Sub


        Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)


        End Sub

        Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
            Me.PlanningBalanceOIDTableAdapter.Fill(Me.PlanningBalanceDataSet.PlanningBalanceOID)
        End Sub

        Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
            Me.PlanningBalanceOIDTableAdapter.FillByOID(Me.PlanningBalanceDataSet.PlanningBalanceOID, OrderLookupGridLookUpEdit.EditValue)
        End Sub

        Private Sub PlanQtyLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PlanQtyLinkLabel.LinkClicked

            'Try
            '    Me.Validate()
            '    Me.AppointmentsBindingSource.EndEdit()
            '    Me.AppointmentDetailsTableAdapter.Update(Me.PlanningBoardNewDataSet.AppointmentDetails)
            'Catch ex As Exception
            '    MessageBox.Show(ex.Message)
            'End Try


            'Dim ColorList As String = String.Empty
            'Dim PQty As Integer = 0

            'For Each drv As DataRowView In AppointmentDetailsBindingSource1.List

            '    PQty = PQty + drv!PlanningQuantity
            '    Dim FCN As String = ReadStringData("Select FabricColorName From vOrder Where OrderDetailsId=" & drv!OrderDetailsId, cnn)

            '    If ColorList = String.Empty Then
            '        ColorList = FCN
            '    Else
            '        ColorList = ColorList & "," & FCN

            '    End If


            'Next

            'txPlanningQuantity.Value = PQty
            'apt.CustomFields("PlanningQuantity") = txPlanningQuantity.Value


            ''Start Removing duplicate color
            'Dim s As String = ColorList
            'Dim sp() As String = s.Split(",")

            'Dim al As New ArrayList()
            'For Each sx As String In sp

            '    If (Not al.Contains(sx)) Then

            '        al.Add(sx)

            '    End If

            'Next

            'Dim dupRemoved() As String = al.ToArray(GetType(String))
            'ColorList = String.Join(",", dupRemoved)
            ''End Removing duplicate color




            'Dim orStyleName As String = ReadStringData("Select StyleName From Style Where StyleId=(Select StyleId From [Order] Where OrderId=" & txOrderId.EditValue & ")", cnn)
            'Dim orStyleType As String = ReadStringData("Select StyleType From Style Where StyleId=(Select StyleId From [Order] Where OrderId=" & txOrderId.EditValue & ")", cnn)
            'Dim orBuyerName As String = ReadStringData("Select BuyerName From Buyer Where BuyerId=(Select BuyerId From [Order] Where OrderId=" & txOrderId.EditValue & ")", cnn)


            'txSubject.Text = txOrderId.Text & "::" & orStyleName & "::" & orStyleType & "::" & orBuyerName & "::" & ColorList & "::" & txPlanningQuantity.Text '& "(" & PlanningIdLabel.Text & ")"
            'apt.Subject = txOrderId.Text & "::" & orStyleName & "::" & orStyleType & "::" & orBuyerName & "::" & ColorList & "::" & txPlanningQuantity.Text '& "(" & PlanningIdLabel.Text & ")"

            'Me.AppointmentDetailsTableAdapter.Fill(Me.PlanningBoardNewDataSet.AppointmentDetails, Me.CurrenttAppointmentId)

        End Sub
        Private Sub GenerateActivities(ByVal PID As Integer)

            'If Me.OrderActivitiesBindingSource.Position > -1 Then
            '    Save()
            '    CalculateEarly()
            '    CalculateLatest()
            '    Save()
            '    Exit Sub
            'End If

            'Dim row1 As OrderDataSet.OrderDetailsRow
            'row1 = CType(CType(Me.OrderDetailsBindingSource.Current, DataRowView).Row, OrderDataSet.OrderDetailsRow)

            'Using connection As New SqlConnection(cnn)

            '    Dim command As New SqlCommand("Select SL,ActivitiesListId,Duration,ES,EF,LS,LF,Slack,AAsign_UserId From ActivitiesTemplate Where ActivitiesGroupId=" & row1.ActivitiesGroupId & "ORDER BY SL ASC", connection)
            '    command.Connection.Open()
            '    command.ExecuteNonQuery()

            '    Dim reader As SqlDataReader = command.ExecuteReader()

            '    While reader.Read()

            '        Dim newRow As OrderDataSet.OrderActivitiesRow = Me.OrderDataSet.OrderActivities.NewRow()
            '        newRow.OrderDetailsId = row1.OrderDetailsId
            '        newRow.SL = reader("SL")
            '        newRow.ActivitiesListId = reader("ActivitiesListId")
            '        newRow.Duration = reader("Duration")
            '        Dim ESDate As DateTime = DateAdd(DateInterval.Day, reader("ES"), OrderReceiveDateDateEdit.DateTime.Date)
            '        Dim EFDate As DateTime = DateAdd(DateInterval.Day, reader("EF"), OrderReceiveDateDateEdit.DateTime.Date)
            '        Dim HLDDay As Integer = ReadIntData("Select Count(HolidayDate) AS TTLDay From Holiday Where HolidayDate between '" & ESDate & "' And '" & EFDate & "'", cnn)

            '        Dim ESDate1 As DateTime = DateAdd(DateInterval.Day, HLDDay, EFDate)
            '        Dim EFDate1 As DateTime = DateAdd(DateInterval.Day, HLDDay, EFDate)
            '        Dim HLDDay1 As Integer = ReadIntData("Select Count(HolidayDate) AS TTLDay From Holiday Where HolidayDate between '" & ESDate1 & "' And '" & EFDate1 & "'", cnn)

            '        'Dim WKDay As Integer = ReadIntData("select datediff(day, -2, '" & EFDate & "')/7  - datediff(day, -3, '" & ESDate & "')/7", cnn)
            '        newRow.OffDay = HLDDay + HLDDay1
            '        newRow.ES = OrderReceiveDateDateEdit.DateTime.Date
            '        newRow.EF = OrderReceiveDateDateEdit.DateTime.Date
            '        newRow.LS = OrderReceiveDateDateEdit.DateTime.Date
            '        newRow.LF = OrderReceiveDateDateEdit.DateTime.Date
            '        newRow.Slack = reader("Slack")
            '        newRow.TaskComplete = 0
            '        newRow.AAsign_UserId = reader("AAsign_UserId")
            '        Me.OrderDataSet.OrderActivities.Rows.Add(newRow)

            '    End While

            '    reader.Close()

            'End Using

            'Save()

            'For Each drv As DataRowView In Me.OrderActivitiesBindingSource.List

            '    Dim ATID As Integer = ReadIntegerData("Select ActivitiesTemplateId From ActivitiesTemplate Where ActivitiesGroupId=" & row1.ActivitiesGroupId & "And ActivitiesListId=" & drv!ActivitiesListId, cnn)

            '    Using connection As New SqlConnection(cnn)

            '        Dim command As New SqlCommand("Select ActivitiesListId From ActivitiesTemplate Where ActivitiesTemplateId in (Select Predecessors From ActivitiesTemplateDetails Where ActivitiesTemplateId=" & ATID & ")", connection)
            '        command.Connection.Open()
            '        command.ExecuteNonQuery()

            '        Dim reader As SqlDataReader = command.ExecuteReader()

            '        While reader.Read()

            '            Dim newRow As OrderDataSet.OrderActivitiesPredecessorRow = Me.OrderDataSet.OrderActivitiesPredecessor.NewRow()

            '            newRow.OrderActivitiesId = drv!OrderActivitiesId
            '            newRow.ActivitiesListId = reader("ActivitiesListId")
            '            newRow.PreOrderActivitiesId = ReadIntegerData("Select OrderActivitiesId From OrderActivities Where ActivitiesListId = " & reader("ActivitiesListId") & " And OrderDetailsId=" & row1.OrderDetailsId, cnn)

            '            Me.OrderDataSet.OrderActivitiesPredecessor.Rows.Add(newRow)

            '        End While

            '        reader.Close()

            '    End Using

            'Next
            'Save()
            'CalculateEarly()
            'CalculateLatest()

        End Sub

        Private Sub CalculateEarly()
            'On Error Resume Next

            'Dim row As OrderDataSet.OrderRow
            'row = CType(CType(Me.OrderBindingSource.Current, DataRowView).Row, OrderDataSet.OrderRow)

            'For Each drv As DataRowView In Me.OrderActivitiesBindingSource.List

            '    Dim Start_AID As Integer = ReadIntegerData("Select ActivitiesListId From ActivitiesList Where Description='Order Received'", cnn)
            '    Dim End_AID As Integer = ReadIntegerData("Select ActivitiesListId From ActivitiesList Where Description='Shipment'", cnn)

            '    If drv!ActivitiesListId = Start_AID Then
            '        'MessageBox.Show(row.OrderReceiveDate)
            '        drv!ES = row.OrderReceiveDate
            '        drv!EF = row.OrderReceiveDate
            '        drv!LS = row.OrderReceiveDate
            '        drv!LF = row.OrderReceiveDate
            '        drv!StartDate = row.OrderReceiveDate
            '        drv!EndDate = row.OrderReceiveDate
            '        drv!TaskComplete = 1
            '        drv!OrderQuantity = ReadData("Select Sum(OrderQuantity) From OrderDetails Where OrderDetailsId=" & drv!OrderDetailsId, cnn)
            '        'To Refresh
            '        OrderActivitiesBindingSource.MoveNext()
            '        OrderActivitiesBindingSource.MovePrevious()

            '    ElseIf drv!ActivitiesListId = End_AID Then

            '        Dim MaxEF As Date = ReadDateData("Select Max(EF) From OrderActivities Where OrderDetailsId=" & drv!OrderDetailsId & " And ActivitiesListId in ( Select ActivitiesListId From OrderActivitiesPredecessor Where OrderActivitiesId=" & drv!OrderActivitiesId & ")", cnn)

            '        drv!ES = DateAdd(DateInterval.Day, 1, MaxEF)
            '        drv!EF = drv!ES
            '        drv!LS = drv!ES
            '        drv!LF = drv!ES
            '        drv!OrderQuantity = ReadData("Select Sum(OrderQuantity) From OrderDetails Where OrderDetailsId=" & drv!OrderDetailsId, cnn)


            '    Else

            '        Dim MaxEF As Date = ReadDateData("Select Max(EF) From OrderActivities Where OrderDetailsId=" & drv!OrderDetailsId & " And ActivitiesListId in ( Select ActivitiesListId From OrderActivitiesPredecessor Where OrderActivitiesId=" & drv!OrderActivitiesId & ")", cnn)
            '        Dim LDay As Integer = ReadIntData("Select LeftDay From OrderActivities Where OrderDetailsId=" & drv!OrderDetailsId & " And ActivitiesListId in ( Select ActivitiesListId From OrderActivitiesPredecessor Where OrderActivitiesId=" & drv!OrderActivitiesId & ")", cnn)
            '        'MessageBox.Show("Hello")
            '        'If MaxEF = 0 Then
            '        '    drv!ES = MaxEF
            '        '    drv!EF = drv!ES + drv!Duration
            '        'Else
            '        drv!ES = DateAdd(DateInterval.Day, (1 - LDay), MaxEF)
            '        Dim TTLDuration = drv!Duration + drv!OffDay - 1
            '        drv!EF = DateAdd(DateInterval.Day, TTLDuration, drv!ES)
            '        'End If

            '    End If
            '    Save()
            'Next


        End Sub

        Private Sub CalculateLatest()
            'On Error Resume Next
            'Dim i As Integer = Me.OrderActivitiesBindingSource.Count

            'Do While i <= Me.OrderActivitiesBindingSource.Count And i >= 0

            '    Me.OrderActivitiesBindingSource.Position = i

            '    i = i - 1

            '    Dim row As OrderDataSet.OrderActivitiesRow
            '    row = CType(CType(Me.OrderActivitiesBindingSource.Current, DataRowView).Row, OrderDataSet.OrderActivitiesRow)

            '    Dim Start_AID As Integer = ReadIntegerData("Select ActivitiesListId From ActivitiesList Where Description='Order Received'", cnn)
            '    Dim End_AID As Integer = ReadIntegerData("Select ActivitiesListId From ActivitiesList Where Description='Shipment'", cnn)

            '    If row.ActivitiesListId = End_AID Then

            '        row.LS = row.ES
            '        row.LF = row.EF

            '    ElseIf row.ActivitiesListId = Start_AID Then

            '        row.LS = row.ES
            '        row.LF = row.EF

            '    Else

            '        Dim MinLF As Date = ReadDateData("Select Min(LS) From OrderActivities Where OrderDetailsId=" & row.OrderDetailsId & " AND OrderActivitiesId in ( Select OrderActivitiesId From OrderActivitiesPredecessor Where ActivitiesListId =" & row.ActivitiesListId & ")", cnn)
            '        'MessageBox.Show("Hello")
            '        row.LF = DateAdd(DateInterval.Day, -1, MinLF) 'MinLF - 1 
            '        Dim TTLDuration = row.Duration + row.OffDay - 1
            '        row.LS = DateAdd(DateInterval.Day, -TTLDuration, row.LF)  'row.LF - row.Duration + 1
            '        row.Slack = DateDiff(DateInterval.Day, row.EF, row.LF) 'row.LF - row.EF

            '    End If
            '    Save()

            'Loop

            'MessageBox.Show("Activities Generated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Sub


    End Class

End Namespace