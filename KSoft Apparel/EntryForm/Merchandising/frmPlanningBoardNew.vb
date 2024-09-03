Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports KSoft_Apparel.CustomAppointmentEditForm
Imports DevExpress.Utils
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraReports.UI
Imports DevExpress.Schedule
Imports DevExpress.XtraScheduler.Commands
Imports DevExpress.Utils.Menu
Imports System.Data.SqlClient
Imports DevExpress
Imports DevExpress.Services

Namespace TimelineTimeScales

    Partial Public Class frmPlanningBoardNew
        Inherits Form
        Private mysaptid As Integer 'My Selected Appointment Id.
        'Public Class frmPlanningBoardNew
        ' A drag box rectangle to check if it's necessary to start drag&drop.
        Private dragBox As Rectangle = Rectangle.Empty
        Dim DragStart As Boolean
        Private downHitInfo As GridHitInfo
        Dim RCal As Boolean = False
        Private _MIS As Boolean
        Public Property MIS() As Boolean
            Get
                Return _MIS
            End Get
            Set(ByVal value As Boolean)
                _MIS = value
            End Set
        End Property

        Dim Updateflag As Boolean = False
        Dim PubAptId As Integer = -1
        Dim RID As Integer = -1
        Dim MyStDate As Date
        Public Sub New()

            InitializeComponent()

            'Dim scales As TimeScaleCollection = SchedulerControl1.TimelineView.Scales

            'scales.BeginUpdate()

            'Try
            '    scales.Clear()

            '    scales.Add(New TimeScaleMonth())
            '    scales.Add(New CustomTimeScaleDay())
            '    scales.Add(New CustomTimeScaleHour())

            'Finally

            '    scales.EndUpdate()

            'End Try

            'Me.SchedulerControl1.Views.TimelineView.Scales(2).Enabled = False

        End Sub

        Private Sub frmPlanningBoardNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'TODO: This line of code loads data into the 'SewingOutputBalance_POwiseDataSet.SewingOutputBalance_POwise' table. You can move, or remove it, as needed.
            'Me.SewingOutputBalance_POwiseTableAdapter.Fill(Me.SewingOutputBalance_POwiseDataSet.SewingOutputBalance_POwise)
            'TODO: This line of code loads data into the 'PlanningBalanceDataSet.PlanningBalanceBySID' table. You can move, or remove it, as needed.
            Me.PlanningBalanceBySIDTableAdapter.Fill(Me.PlanningBalanceDataSet.PlanningBalanceBySID)
            Me.AppointmentsLogTableAdapter.Fill(Me.AppointmentsLogDataSet.AppointmentsLog)
            Me.PlanningBalanceBySIDTableAdapter.Fill(Me.PlanningBalanceDataSet.PlanningBalanceBySID)
            Me.SCLStyleTypeLookupTableAdapter.Fill(Me.SewingCustomLearningCurveDataSet.SCLStyleTypeLookup)
            Me.SCLGridLookUpEdit.EditValue = "Common"

            On Error Resume Next
            ExecuteQuery("Exec UpdateSewingPlanningNew 'Production'", cnn)
            StatusByComboBox.Text = "Production"
            OrangeLabel.Text = "Not Cutting"
            YellowLabel.Text = "Cutting Start"
            BlueLabel.Text = "Sewing Start"
            GreenLabel.Text = "Sewing Complete"

            Me.ApmntLookupTableAdapter.Fill(Me.PlanningBoardNewDataSet.ApmntLookup)

            Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)

            Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
            Me.BranchTableAdapter.FillByBranchType(Me.BranchDataSet.Branch, "Garments")
            Me.LineTableAdapter.Fill(Me.PlanningBoardNewDataSet.Line)
            Me.AppointmentsTableAdapter.FillByAll(Me.PlanningBoardNewDataSet.Appointments)

            AllButton.Text = "Show Branch"
            'ComboBox1.Visible = False

            SchedulerControl1.WorkDays.BeginUpdate()
            SchedulerControl1.Start = Today()
            SchedulerControl1.OptionsView.FirstDayOfWeek = DevExpress.XtraScheduler.FirstDayOfWeek.Saturday
            SchedulerControl1.WorkDays.Clear()
            SchedulerControl1.WorkDays.Add(WeekDays.Tuesday Or WeekDays.Wednesday Or WeekDays.Thursday Or WeekDays.Monday Or WeekDays.Saturday Or WeekDays.Sunday)
            SchedulerControl1.WorkDays.EndUpdate()
            SchedulerControl1.OptionsView.ToolTipVisibility = ToolTipVisibility.Always
            SchedulerControl1.DayView.WorkTime = New TimeOfDayInterval(TimeSpan.FromHours(8), TimeSpan.FromHours(17))
            SchedulerControl1.DayView.ShowWorkTimeOnly = True

            SchedulerControl1.OptionsCustomization.AllowAppointmentConflicts = AppointmentConflictsMode.Custom
            SchedulerControl1.OptionsCustomization.AllowDisplayAppointmentFlyout = False
            SchedulerControl1.Views.TimelineView.ResourcesPerPage = My.Settings.ResourcePerPage

            GenerateHolidays()

            SchedulerControl1.OptionsCustomization.AllowAppointmentResize = UsedAppointmentType.None

            Me.DateTimePicker2.Text = Me.DateTimePicker1.Value.AddDays(365)
            Me.MaxExDateTimePicker.Text = Today.AddMonths(2)


            'Start -------- eck and Set user rights


            Dim MENUID As Integer = ReadIntegerData("Select Distinct Menu_Id From [Menu] Where Menu_Name='Sewing Planning'", cnn)
            Dim CANEDIT As Boolean = ReadBooleanData("Select CAN_EDIT From UserRights Where User_Id=" & UserId & " and Menu_Id=" & MENUID, cnn)

            If CANEDIT = False OrElse Me.MIS = True Then

                With SchedulerControl1

                    .OptionsCustomization.AllowAppointmentDrag = UsedAppointmentType.None
                    .OptionsCustomization.AllowAppointmentDelete = UsedAppointmentType.None
                    .OptionsCustomization.AllowAppointmentCopy = UsedAppointmentType.None
                    .OptionsCustomization.AllowAppointmentEdit = UsedAppointmentType.None
                    .OptionsCustomization.AllowAppointmentMultiSelect = False

                    .OptionsCustomization.AllowAppointmentCreate = UsedAppointmentType.None


                End With
                SplitContainer6.Panel2.Enabled = False

            End If
            NumericUpDown1.Value = My.Settings.ResourcePerPage
            'End ------- Check and Set user rights
            Dim oldMouseHandler As IMouseHandlerService = CType(SchedulerControl1.GetService(GetType(IMouseHandlerService)), IMouseHandlerService)
            If Not oldMouseHandler Is Nothing Then
                Dim newMouseHandler As MyMouseHandlerService =
                    New MyMouseHandlerService(SchedulerControl1, oldMouseHandler)
                SchedulerControl1.RemoveService(GetType(IMouseHandlerService))
                SchedulerControl1.AddService(GetType(IMouseHandlerService), newMouseHandler)
            End If

        End Sub
        Private Sub SchedulerControl1_AllowAppointmentConflicts(sender As Object, e As AppointmentConflictEventArgs) Handles SchedulerControl1.AllowAppointmentConflicts
            e.Conflicts.Clear()
            FillConflictedAppointmentsCollection(e.Conflicts, e.Interval, DirectCast(sender, SchedulerControl).Storage.Appointments.Items, e.AppointmentClone)
        End Sub

        Private Shared Sub FillConflictedAppointmentsCollection(ByVal conflicts As AppointmentBaseCollection, ByVal interval As TimeInterval, ByVal collection As AppointmentBaseCollection, ByVal currApt As Appointment)
            For i As Integer = 0 To collection.Count - 1
                Dim apt As Appointment = collection(i)
                If (New TimeInterval(apt.Start, apt.End)).IntersectsWith(interval) And Not (apt.Start = interval.End OrElse apt.End = interval.Start) Then
                    If apt.ResourceId Is currApt.ResourceId Then
                        conflicts.Add(apt)
                    End If
                End If
                If apt.Type = AppointmentType.Pattern Then
                    FillConflictedAppointmentsCollection(conflicts, interval, apt.GetExceptions(), currApt)
                End If
            Next i
        End Sub
        Private Sub GenerateHolidays()
            'On Error Resume Next

            Dim workDays As WorkDaysCollection = Me.SchedulerControl1.WorkDays
            workDays.BeginUpdate()

            Dim connection As New SqlConnection(cnn)
            connection.Open()
            Dim cmd As SqlCommand = New SqlCommand("Select * From Holiday Where isWeekend=0", connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim i As Integer = 0

            While reader.Read
                If reader.IsDBNull(0) = False Then
                    Dim HDate As Date = reader("HolidayDate")

                    workDays.AddHoliday(New DateTime(HDate.Year, HDate.Month, HDate.Day), reader("Description").ToString())
                    i += 1
                End If
            End While

            reader.Close()
            connection.Close()
            workDays.EndUpdate()



        End Sub


        Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
            Me.LineTableAdapter.FillByBranchId(Me.PlanningBoardNewDataSet.Line, ComboBox1.SelectedValue)
        End Sub

        Private Sub AllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllButton.Click
            If AllButton.Text = "Show All" Then
                'ComboBox1.Visible = False
                AllButton.Text = "Show Branch"
                Me.LineTableAdapter.Fill(Me.PlanningBoardNewDataSet.Line)
            Else
                'ComboBox1.Visible = True
                AllButton.Text = "Show All"
                Me.LineTableAdapter.FillByBranchId(Me.PlanningBoardNewDataSet.Line, ComboBox1.SelectedValue)
            End If

        End Sub

        Private Sub OnApptChanged(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PersistentObjectsEventArgs) Handles SchedulerStorage1.AppointmentsInserted, SchedulerStorage1.AppointmentsChanged
            Try

                'AppointmentsTableAdapter.Update(PlanningBoardNewDataSet)
                'PlanningBoardNewDataSet.AcceptChanges()
                If RCal = False Then
                    UpdateSelectedAppointment(0)
                End If


                'If SplitCheckBox.Checked Then

                '    SchedulerControl1.SelectedAppointments.Add(CType(e.Objects(0), DevExpress.XtraScheduler.Appointment))
                '    'SplitCheckBox.Checked = False

                'Else

                'End If

                AppointmentsTableAdapter.Update(PlanningBoardNewDataSet)
                PlanningBoardNewDataSet.AcceptChanges()


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Sub
        Private Sub OnApptDeleted(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PersistentObjectsEventArgs) Handles SchedulerStorage1.AppointmentsDeleted
            Try

                AppointmentsTableAdapter.Update(PlanningBoardNewDataSet)
                PlanningBoardNewDataSet.AcceptChanges()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Sub

        Private Sub UpdateSelectedAppointment(ByVal indx As Integer)

            On Error Resume Next
            Dim apt As Appointment = SchedulerControl1.SelectedAppointments(indx)

            'If SelAptIndex = 0 Then
            '    SchedulerControl1.Refresh()
            'End If

            Dim AptId As Integer = apt.GetValue(SchedulerStorage1, "AppointmentId")

            Dim OrderId As Integer = apt.GetValue(SchedulerStorage1, "OrderId")
            Dim SID As Integer = apt.GetValue(SchedulerStorage1, "StyleId")
            Dim SDate As Date = SchedulerControl1.SelectedAppointments(indx).Start 'apt.Start.Date
            Dim FDate As Date = SchedulerControl1.SelectedAppointments(indx).End.AddDays(-1) 'apt.End.Date
            apt.CustomFields("WH") = Val(WHDTextBox.Text)
            apt.CustomFields("SMV") = CType(SMVTextBox.Text, Decimal)
            apt.CustomFields("MC") = Val(MCTextBox.Text)
            apt.CustomFields("LCSD") = Val(LCSDTextBox.Text)
            apt.CustomFields("LCA") = Val(LCATextBox.Text)
            apt.CustomFields("LC") = SCLGridLookUpEdit.EditValue
            'apt.CustomFields("PlanningQuantity")=

            'If ResizeCheckBox.Checked = False Then
            '    apt.CustomFields("PlanningQuantity") = Val(PQtyTextBox.Text)
            'End If

            'apt.ResourceId = LineGridLookupEdit.EditValue

            'If DBNull.Value.Equals(SDate) = True Then
            '    MessageBox.Show("Start Date Missing")
            'ElseIf DBNull.Value.Equals(FDate) = True Then
            '    MessageBox.Show("Finish Date Missing")
            'ElseIf OrderId = 0 Then
            '    MessageBox.Show("Order Id Missing")
            'ElseIf AptId = 0 Then
            '    MessageBox.Show("Apt Id Missing")
            'ElseIf indx = -1 Then
            '    MessageBox.Show("Index Missing")
            'Else
            'If Val(PQtyTextBox.Text) > 0 Then
            AddAppointmentDetails(AptId, indx, SDate, FDate, OrderId, Val(WHDTextBox.Text), SID, Val(LCSDTextBox.Text), Val(LCATextBox.Text), SCLGridLookUpEdit.Text)
            ShowAppointmentDetails(indx)
            'End If

            'End If





        End Sub

        Private Sub AddAppointmentDetails(ByVal aptId As Integer, ByVal aptindex As Integer, ByVal SDate As DateTime, ByVal FDate As DateTime, ByVal OID As Integer, ByVal WHD As Integer, ByVal SID As Integer, ByVal LCSD As Integer, ByVal LCA As Integer, ByVal LC As Integer)

            If DBNull.Value.Equals(aptId) = False Then
                ExecuteQuery("Delete AppointmentDetails Where AppointmentId=" & aptId, cnn)
                'ExecuteQuery("Update Appointments Set PlanningQuantity=0  Where AppointmentId=" & aptId, cnn)
                SchedulerControl1.SelectedAppointments(aptindex).SetValue(SchedulerStorage1, "PlanningQuantity", 0)

            End If

            Dim i As Integer = 1
            Dim CumNormalQuantity As Integer = 0
            Dim CumBonusQuantity As Integer = 0
            Dim Target As Integer = 0
            Dim MinEx As Date = ExDateEdit.Text 'ReadDateData("Select Min(Ex) From OrderDetails Where OrderId=" & OID, cnn)
            Dim SSMV As Decimal = CType(SMVTextBox.Text, Decimal) 'ReadData("Select SMV From Style Where StyleId=(Select StyleId From [Order] Where OrderId=" & OID & ")", cnn)
            Dim SMC As Integer = Val(MCTextBox.Text) 'ReadIntData("Select MCQty From Style Where StyleId=(Select StyleId From [Order] Where OrderId=" & OID & ")", cnn)
            Dim WH As Integer = 0
            Dim Efficiency As Decimal
            Dim ProdEff As Integer = 0
            Dim DayRequire As Integer = 0
            Dim HourRequire As Integer = 0
            Dim SDate2 As DateTime
            Dim FDate2 As DateTime
            Dim PlanningBalance = 0
            Dim FDate3 As Date


            'If Updateflag = True Then
            If QuantityRadioButton.Checked = True Then
                PlanningBalance = Val(Me.PQtyTextBox.Text) 'ReadData("Select PlanningBalance From PlanningBalanceBySID Where OrderId=" & OID, cnn)
                FDate3 = FDate.AddDays(100)
            ElseIf DateRadioButton.Checked = True Then
                PlanningBalance = ReadData("Select PlanningBalance From PlanningBalanceBySID Where OrderId=" & OID & "And StyleId=" & SID, cnn)
                FDate3 = FDate
            End If

            'Else
            '    PlanningBalance = ReadData("Select PlanningBalance From PlanningBalanceBySID Where OrderId=" & OID & "And StyleId=" & SID, cnn)
            '    FDate3 = FDate
            'End If

            'Updateflag = False


            ' Create new DataTable instance.
            Dim ADTable As New DataTable
            ' Create four typed columns in the DataTable.
            ADTable.Columns.Add("AppointmentId", GetType(Integer))
            ADTable.Columns.Add("DaySerial", GetType(Integer))
            ADTable.Columns.Add("PlanningDate", GetType(Date))
            ADTable.Columns.Add("Efficiency", GetType(Integer))
            ADTable.Columns.Add("PlanningQuantity", GetType(Integer))
            ADTable.Columns.Add("WH", GetType(Integer))




            If SSMV > 0 Then
                ProdEff = FormatNumber(SMC * 60 / SSMV * Val(WHD), 0)
                'MessageBox.Show("ProdEff :" & ProdEff.ToString())
            Else
                MessageBox.Show("SMV Missing in Style")
            End If

            Dim CumBal As Integer = 0


            Dim connection As New SqlConnection(cnn)
            connection.Open()



            Dim cmd As SqlCommand = New SqlCommand("Select dt From all_dates Where dt not in (Select HolidayDate From Holiday) And (dt between '" & SDate & "' and '" & FDate3 & "') Order By dt ", connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()

                If reader.IsDBNull(0) = False Then

                    'If CumNormalQuantity <= PlanningBalance Then

                    If i + LCSD - 1 < 10 Then
                        Efficiency = ReadData("Select Min(LC_Value) From SewingCustomLearningCurve Where StyleType='" & SCLGridLookUpEdit.EditValue & "' And MinSMV<=" & SSMV & " and DaySerial=" & i + LCSD - 1, cnn)
                        Efficiency = Efficiency * (1 - LCA / 100)
                    Else
                        Efficiency = ReadData("Select Min(LC_Value) From SewingCustomLearningCurve Where StyleType='" & SCLGridLookUpEdit.EditValue & "' And MinSMV<=" & SSMV & " and DaySerial=10", cnn)
                        Efficiency = Efficiency * (1 - LCA / 100)
                    End If
                    Dim PQty As Integer = 0


                    If DateRadioButton.Checked Then

                        PQty = ProdEff * Efficiency
                        CumNormalQuantity = CumNormalQuantity + PQty
                        WH = WHD

                    Else

                        If CumNormalQuantity + ProdEff * Efficiency <= PlanningBalance Then

                            PQty = ProdEff * Efficiency
                            CumNormalQuantity = CumNormalQuantity + PQty
                            WH = WHD

                        ElseIf CumNormalQuantity + ProdEff * Efficiency > PlanningBalance Then

                            PQty = PlanningBalance - CumNormalQuantity
                            CumNormalQuantity = CumNormalQuantity + PQty
                            WH = roundUp((PQty / ProdEff) * WHD)
                            'Debug.Print("Efficiency2:" & Efficiency.ToString())
                        End If

                    End If


                    If i = 1 Then
                        SDate2 = reader("dt")
                    End If

                    If PQty > 0 Then
                        FDate2 = DateAdd("d", 1, reader("dt"))

                        Dim dr As DataRow = ADTable.NewRow()
                        dr("DaySerial") = i
                        dr("PlanningDate") = reader("dt")
                        dr("Efficiency") = Efficiency * 100
                        dr("PlanningQuantity") = PQty
                        dr("WH") = WH
                        ADTable.Rows.Add(dr)

                        Target = (CumNormalQuantity / i / WHD)
                        DayRequire = DateDiff("d", SDate2, FDate2)
                        HourRequire = DateDiff("d", SDate2, FDate2) * WHD

                        SchedulerControl1.SelectedAppointments(aptindex).SetValue(SchedulerStorage1, "EndDate", FDate2)
                        SchedulerControl1.SelectedAppointments(aptindex).SetValue(SchedulerStorage1, "Target", Target)
                        SchedulerControl1.SelectedAppointments(aptindex).SetValue(SchedulerStorage1, "RD", DayRequire)
                        SchedulerControl1.SelectedAppointments(aptindex).SetValue(SchedulerStorage1, "HR", HourRequire)
                        SchedulerControl1.SelectedAppointments(aptindex).SetValue(SchedulerStorage1, "LCSD", LCSD)
                        SchedulerControl1.SelectedAppointments(aptindex).SetValue(SchedulerStorage1, "LCA", LCA)
                        SchedulerControl1.SelectedAppointments(aptindex).SetValue(SchedulerStorage1, "LC", LC)
                        SchedulerControl1.SelectedAppointments(aptindex).SetValue(SchedulerStorage1, "PlanningQuantity", CumNormalQuantity)
                        SchedulerControl1.SelectedAppointments(aptindex).SetValue(SchedulerStorage1, "ExDate", ExDateEdit.DateTime.Date)

                    Else
                        GoTo line1
                    End If

                    i += 1

                    'End If

                End If

            End While
line1:


            reader.Close()
            connection.Close()

            For Each drv As DataRow In ADTable.Rows
                CRUDAppointmentDetails(aptId, drv("DaySerial"), drv("PlanningDate"), drv("Efficiency"), drv("PlanningQuantity"), drv("WH"))
            Next drv

        End Sub



        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAllButton.Click
            Me.AppointmentsTableAdapter.Fill(Me.PlanningBoardNewDataSet.Appointments)
        End Sub

        Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
            On Error Resume Next

            If Val(PIDTextBox.Text) > 0 Then

                Updateflag = True

                Dim apt As Appointment = SchedulerControl1.SelectedAppointments(0)

                'If SelAptIndex = 0 Then
                '    SchedulerControl1.Refresh()
                'End If

                Dim AptId As Integer = apt.GetValue(SchedulerStorage1, "AppointmentId")

                Using Connection As New SqlConnection(cnn)

                    Connection.Open()

                    Dim cmd As SqlCommand = New SqlCommand("CopytoTempAppointment", Connection)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@AptId", AptId)
                    cmd.ExecuteNonQuery()

                End Using


                'UpdateSelectedAppointment(0)

                UpdateSelectedAppointment(0)


                Using Connection As New SqlConnection(cnn)

                    Connection.Open()

                    Dim cmd As SqlCommand = New SqlCommand("GenSewingBasedTNA", Connection)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@AID", Val(PIDTextBox.Text))
                    cmd.ExecuteNonQuery()

                End Using


                Me.Validate()
                Me.AppointmentsBindingSource.EndEdit()
                Me.AppointmentDetailsBindingSource.EndEdit()
                Me.AppointmentsTableAdapter.Update(Me.PlanningBoardNewDataSet)

                MessageBox.Show("Update Successfully", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Information)



                Me.AppointmentsTableAdapter.FillByAll(Me.PlanningBoardNewDataSet.Appointments)

            End If

        End Sub
        Private Sub SaveData()
            Try
                UpdateSelectedAppointment(0)

                Me.Validate()
                Me.AppointmentsBindingSource.EndEdit()
                Me.AppointmentDetailsBindingSource.EndEdit()
                Me.AppointmentsTableAdapter.Update(Me.PlanningBoardNewDataSet)

                MessageBox.Show("Saved Successfully", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub schedulerControl1_CustomDrawDayHeader(ByVal sender As Object,
         ByVal e As CustomDrawObjectEventArgs) Handles SchedulerControl1.CustomDrawDayHeader
            ' Check whether the current object is a Day Header.
            Dim header As SchedulerHeader = TryCast(e.ObjectInfo, SchedulerHeader)
            If Not header Is Nothing Then

                ' Check whether the current date is a known holiday.
                Dim hol As Holiday = FindHoliday(header.Interval.Start.Date)
                If Not hol Is Nothing Then

                    ' Add the holiday name to the day header's caption.

                    header.Caption = String.Format("{0} ({1})", hol.DisplayName,
                    hol.Date.ToShortDateString())

                End If
            End If
        End Sub
        Private Function FindHoliday(ByVal [date] As DateTime) As Holiday
            For Each item As WorkDay In SchedulerControl1.WorkDays
                If TypeOf item Is Holiday Then
                    Dim hol As Holiday = CType(item, Holiday)
                    If hol.Date = [date] Then
                        Return hol
                    End If
                End If
            Next item
            Return Nothing
        End Function

        Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click

            Dim xr As XtraSchedulerReport1 = New XtraSchedulerReport1()
            Dim scPrintAdapter As SchedulerControlPrintAdapter = New SchedulerControlPrintAdapter(Me.SchedulerControl1)

            xr.SchedulerAdapter = scPrintAdapter
            xr.PageWidth = 1000

            xr.CreateDocument(True)
            xr.ShowPreview()

            'ShowSchedulerPreview(SchedulerControl1)

        End Sub

        Sub ShowSchedulerPreview(ByVal scheduler As SchedulerControl)
            ' Check whether the SchedulerControl can be previewed.
            If Not scheduler.IsPrintingAvailable Then
                MessageBox.Show("The 'DevExpress.XtraPrinting.vX.Y.dll' is not found", "Error")
                Return
            End If

            ' Opens the Preview window.
            scheduler.ShowPrintPreview()
        End Sub

        Sub PrintScheduler(ByVal scheduler As SchedulerControl)
            ' Check whether the SchedulerControl can be printed.
            If Not scheduler.IsPrintingAvailable Then
                MessageBox.Show("The 'DevExpress.XtraPrinting.vX.Y.dll' is not found", "Error")
                Return
            End If

            ' Print.

            scheduler.Print()
        End Sub



        Private Sub schedulerControl_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As AppointmentFormEventArgs) Handles SchedulerControl1.EditAppointmentFormShowing

            Dim apt As Appointment = e.Appointment


            ' Required to open the recurrence form via context menu.
            Dim openRecurrenceForm As Boolean = apt.IsRecurring AndAlso SchedulerStorage1.Appointments.IsNewAppointment(apt)

            ' Create a custom form.
            Dim myForm As New MyAppointmentEditForm(CType(sender, SchedulerControl), apt, openRecurrenceForm)
            Try

                'Required for skins support.
                myForm.LookAndFeel.ParentLookAndFeel = SchedulerControl1.LookAndFeel

                If DBNull.Value.Equals(apt.GetValue(SchedulerStorage1, "AppointmentId")) = False Then

                    myForm.CurrenttAppointmentId = apt.GetValue(SchedulerStorage1, "AppointmentId")
                End If

                'myForm.MaxExDate = MaxExDateTimePicker.Text

                e.DialogResult = myForm.ShowDialog()
                Me.AppointmentsTableAdapter.Fill(Me.PlanningBoardNewDataSet.Appointments)
                SchedulerControl1.Refresh()
                e.Handled = True

            Finally
                myForm.Dispose()
            End Try

        End Sub

        Private Sub SchedulerControl1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchedulerControl1.SelectionChanged

            On Error Resume Next
            DateTimePicker1.Text = Format(SchedulerControl1.SelectedAppointments(0).Start.Date, "dd-MMM-yy")
            ShowAppointmentDetails(0)
            SchedulerControl1.Select()


        End Sub

        Private Sub ShowAppointmentDetails(ByVal indx As Integer)
            On Error Resume Next

            If indx >= 0 Then

                Dim apt As Appointment = SchedulerControl1.SelectedAppointments(indx)
                If apt Is Nothing Then
                    Exit Sub
                End If
                Dim aptId As Integer = apt.GetValue(SchedulerStorage1, "AppointmentId")
                Dim OID As Integer = apt.CustomFields("OrderId")
                Dim SID As Integer = apt.CustomFields("StyleId")


                Dim TNAStart As Date = ReadDateData("Select ES From OrderActivities Where ActivitiesListId=22 And OrderId=" & OID, cnn)
                Dim TNAEnd As Date = ReadDateData("Select EF From OrderActivities Where ActivitiesListId=22 And OrderId=" & OID, cnn)
                TNAStartLabel.Text = TNAStart
                TNAEndLabel.Text = TNAEnd


                StyleTextBox.Text = ReadStringData("Select StyleName From [Style] Where StyleId=" & SID, cnn)
                Dim PrgNo As String = ReadStringData("Select ProgramNo From [Order] Where OrderId=" & OID, cnn)
                Dim OQty As Decimal = ReadIntData("Select Sum(OrderQuantity)  From OrderQuantitySummeryBySID Where StyleId=" & SID & "And OrderId=" & OID, cnn)
                Dim PlanQty As Decimal = ReadData("Select Sum(PlanningQuantity)  From Appointments Where StyleId=" & SID & " And OrderId=" & OID, cnn)
                Dim PBal As Decimal = OQty - PlanQty


                StyleTextBox.Text = ReadStringData("Select StyleName From Style Where StyleId=" & SID, cnn)
                ProgNoTextBox.Text = PrgNo
                OrdQtyTextBox.Text = OQty
                PBalTextBox.Text = PBal
                WHDTextBox.Text = apt.CustomFields("WH")
                SMVTextBox.Text = apt.CustomFields("SMV")
                MCTextBox.Text = apt.CustomFields("MC")
                LCSDTextBox.Text = apt.CustomFields("LCSD")
                LCATextBox.Text = apt.CustomFields("LCA")
                SCLGridLookUpEdit.EditValue = apt.CustomFields("LC")
                PQtyTextBox.Text = apt.CustomFields("PlanningQuantity")
                LineGridLookupEdit.EditValue = apt.ResourceId
                dtStart.EditValue = apt.Start
                dtEnd.EditValue = apt.End
                ExDateEdit.EditValue = apt.CustomFields("ExDate")
                PIDTextBox.Text = aptId


                Me.StyleTableAdapter.FillByStyleId(Me.StyleDataSet.Style, SID)
                Me.ActivitiesPivotTableAdapter.Fill(Me.ActivitiesPivotDataSet.ActivitiesPivot, OID)
                Me.AppointmentDetailsTableAdapter.FillByAptId(Me.PlanningBoardNewDataSet.AppointmentDetails, aptId)

            End If


        End Sub



        Private Sub OnBeforeShow(ByVal sender As Object, ByVal e As ToolTipControllerShowEventArgs)

            'On Error Resume Next
            '' Get the ToolTipController.
            'Dim controller As ToolTipController = sender

            '' Check, if it's an appointment or not.
            '' If it's not an appointment, then exit.
            'Dim aptViewInfo As AppointmentViewInfo = controller.ActiveObject

            'If aptViewInfo Is Nothing Then
            '    Return
            'End If


            '' Set a custom icon for a tooltip.
            'e.IconType = ToolTipIconType.Information

            '' Set a custom title for a tooltip.
            'e.Title = aptViewInfo.Appointment.Subject

            '' Set a custom text for a tooltip.
            'e.ToolTip = GetCustomDescription(aptViewInfo)

            '---------------------------------------------------------------------

            'Dim aptViewInfo As AppointmentViewInfo
            'Dim controller As ToolTipController = CType(sender, ToolTipController)
            'Try
            '    aptViewInfo = CType(controller.ActiveObject, AppointmentViewInfo)
            'Catch
            '    Return
            'End Try

            'If aptViewInfo Is Nothing Then
            '    Return
            'End If

            'If ToolTipController1.ToolTipType = ToolTipType.Standard Then
            '    e.IconType = ToolTipIconType.Information
            '    e.ToolTip = GetCustomDescription(aptViewInfo)
            'End If

            ''If ToolTipController1.ToolTipType = ToolTipType.SuperTip Then
            'Dim SuperTip As New SuperToolTip()
            'Dim args As New SuperToolTipSetupArgs()
            'args.Title.Text = "Info"
            'args.Title.Font = New Font("Times New Roman", 14)
            'args.Contents.Text = GetCustomDescription(aptViewInfo)
            ''args.Contents.Image = resImage
            'args.ShowFooterSeparator = True
            'args.Footer.Font = New Font("Comic Sans MS", 8)
            'args.Footer.Text = "Sincerely yours SuperTip"
            'SuperTip.Setup(args)
            'e.SuperTip = SuperTip
            ''End If



            '----------------------------------------------------------------------------



        End Sub

        Function GetCustomDescription(ByVal aptViewInfo As AppointmentViewInfo) As String

            'Return "Description: " + aptViewInfo.Appointment.Subject

            Dim aptDuration As TimeSpan = aptViewInfo.AppointmentInterval.Duration

            If aptViewInfo.Appointment.AllDay Then
                Return "Your custom description for AllDay appointment"
            Else
                Return aptViewInfo.Appointment.Description & Constants.vbCrLf & " Duration: " & aptDuration.Days & " day(s) " & aptDuration.Hours & " hour(s) " & aptDuration.Minutes & " minute(s)"
            End If

        End Function



        Private Sub SelectAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllButton.Click

            Dim aptColl As AppointmentBaseCollection = SchedulerStorage1.GetAppointments(DateTimePicker1.Text, DateTimePicker2.Text)

            For Each apt As Appointment In aptColl

                If apt.ResourceId = SchedulerControl1.SelectedResource.Id Then

                    SchedulerControl1.ActiveView.AddAppointmentSelection(apt)


                End If

            Next apt

        End Sub

        Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
            Me.DateTimePicker2.Text = Me.DateTimePicker1.Value.AddDays(365)
        End Sub

        Private Sub ToolTipController1_BeforeShow(ByVal sender As System.Object, ByVal e As DevExpress.Utils.ToolTipControllerShowEventArgs) Handles ToolTipController1.BeforeShow

            On Error Resume Next

            If TypeOf ToolTipController1.ActiveObject Is AppointmentViewInfo Then

                Dim apt As Appointment = (CType(ToolTipController1.ActiveObject, AppointmentViewInfo)).Appointment

                e.ToolTipType = ToolTipType.SuperTip

                Dim stt As New SuperToolTip()
                Dim ttiTitle As New ToolTipTitleItem()
                Dim ttiBody As New ToolTipItem()
                Dim ttiFooter As New ToolTipItem()
                Dim OrderId As Integer = apt.GetValue(SchedulerStorage1, "OrderId")
                Dim StyleId As Integer = ReadIntegerData("Select StyleId From [Order] Where OrderId=" & OrderId, cnn)
                Dim StyleType As String = ReadStringData("Select StyleType From Style Where StyleId=" & StyleId, cnn)
                ttiTitle.Text = "Details Information : "

                Dim TNAString As String = String.Empty
                'Reading TNA Data
                Using connection As New SqlConnection(cnn)
                    connection.Open()
                    Using Command = New SqlCommand("Select * From ActivitiesPivotStartEnd Where OrderId=@OrderId", connection)
                        Command.Parameters.AddWithValue("@OrderId", apt.CustomFields("OrderId"))

                        Dim reader As SqlDataReader = Command.ExecuteReader()
                        If reader.HasRows Then

                            While reader.Read()

                                Dim MinEx As String = ReadStringData("Select Format(Min(Ex),'dd-MMM-yy') From [OrderDetails] Where OrderId=" & OrderId, cnn)
                                Dim MaxEx As String = ReadStringData("Select Format(Max(Ex),'dd-MMM-yy') From [OrderDetails] Where OrderId=" & OrderId, cnn)

                                TNAString = "Minimum Ex:" & MinEx.ToString() & Constants.vbLf
                                TNAString = TNAString & "Maximum Ex:" & MaxEx.ToString() & Constants.vbLf
                                TNAString = TNAString & "Yarn Inhouse Start :" & reader("YarnInhouseStart").ToString() & Constants.vbLf
                                TNAString = TNAString & "Yarn Inhouse End :" & reader("YarnInhouseEnd").ToString() & Constants.vbLf
                                TNAString = TNAString & "Fabric Delivery Start :" & reader("FabricDeliveryStart").ToString() & Constants.vbLf
                                TNAString = TNAString & "Fabric Delivery End :" & reader("FabricDeliveryEnd").ToString() & Constants.vbLf
                                TNAString = TNAString & "Cutting Start :" & reader("CuttingStart").ToString() & Constants.vbLf
                                TNAString = TNAString & "Cutting End :" & reader("CuttingEnd").ToString() & Constants.vbLf
                                TNAString = TNAString & "Printing Start :" & reader("PrintingStart").ToString() & Constants.vbLf
                                TNAString = TNAString & "Printing End :" & reader("PrintingEnd").ToString() & Constants.vbLf
                                TNAString = TNAString & "Embroidery Start :" & reader("EmbroideryStart").ToString() & Constants.vbLf
                                TNAString = TNAString & "Embroidery End :" & reader("EmbroideryEnd").ToString() & Constants.vbLf
                                TNAString = TNAString & "Sewing Start :" & reader("SewingStart").ToString() & Constants.vbLf
                                TNAString = TNAString & "Sewing End :" & reader("SewingEnd").ToString() & Constants.vbLf
                                TNAString = TNAString & "Finishing Start :" & reader("FinishingStart").ToString() & Constants.vbLf
                                TNAString = TNAString & "Finishing End :" & reader("FinishingEnd").ToString() & Constants.vbLf
                                TNAString = TNAString & "Inspection Start :" & reader("InspectionStart").ToString() & Constants.vbLf
                                TNAString = TNAString & "Inspection End :" & reader("InspectionEnd").ToString() & Constants.vbLf
                                TNAString = TNAString & "Shipment Strat :" & reader("ShipmentStart").ToString() & Constants.vbLf
                                TNAString = TNAString & "Shipment End :" & reader("ShipmentEnd").ToString() & Constants.vbLf
                                TNAString = TNAString & "Accessories Start :" & reader("AccessoriesStart").ToString() & Constants.vbLf
                                TNAString = TNAString & "Accessories End :" & reader("AccessoriesEnd").ToString() & Constants.vbLf

                            End While
                        End If

                    End Using
                End Using

                Dim AptId As Integer = apt.GetValue(SchedulerStorage1, "AppointmentId")
                Debug.Print(AptId.ToString())
                Dim SewingQty As Integer = ReadIntData("Select SewingQuantity From Appointments Where AppointmentId=" & AptId, cnn)


                ttiBody.Text = String.Format("Description: {0} " &
                                             Constants.vbLf & "Planning Quantity: {1}" &
                                             Constants.vbLf & "Sewing Quantity: {2}" &
                                             Constants.vbLf & "Completed: {3}%" &
                                             Constants.vbLf & "StyleType: {4}" &
                                             Constants.vbLf & "TNA Details:" & Constants.vbLf & "{5}", apt.Subject, apt.CustomFields("PlanningQuantity"), SewingQty, apt.PercentComplete, StyleType, TNAString)

                ttiBody.Image = SystemIcons.Information.ToBitmap()

                ttiFooter.AllowHtmlText = DefaultBoolean.True
                ttiFooter.Text = ""
                ttiFooter.Appearance.BackColor = Color.Red
                ttiFooter.Appearance.ForeColor = Color.Blue
                ttiFooter.LeftIndent = 30

                stt.Items.Add(ttiTitle)
                stt.Items.AddSeparator()
                stt.Items.Add(ttiBody)
                stt.Items.AddSeparator()
                stt.Items.Add(ttiFooter)

                e.SuperTip = stt

            End If

            If TypeOf ToolTipController1.ActiveObject Is ResourceHeader Then

                Dim res As Resource = (CType(ToolTipController1.ActiveObject, ResourceHeader)).Resource

                e.ToolTipType = ToolTipType.Standard
                e.Rounded = True

                e.Title = "Resource"
                e.ToolTip = res.Caption & ":: MC Qty-" & ReadIntData("Select Machine From Line Where Line='" & res.Caption & "'", cnn)

            End If

            If TypeOf ToolTipController1.ActiveObject Is DayHeader OrElse TypeOf ToolTipController1.ActiveObject Is TimeScaleHeader Then
                On Error Resume Next
                Dim interval As TimeInterval = (CType(ToolTipController1.ActiveObject, SchedulerHeader)).Interval
                Dim Header As SchedulerHeader = CType(ToolTipController1.ActiveObject, SchedulerHeader)
                Dim hol As Holiday = FindHoliday(interval.Start)

                e.ToolTipType = ToolTipType.Standard
                e.IconType = ToolTipIconType.Exclamation
                e.ShowBeak = True

                Dim HLDCount As Int32 = ReadIntData("Select Count(HolidayDate) From Holiday Where IsWeekend=0 And HolidayDate='" & interval.Start.Date & "'", cnn)
                Dim WKCount As Int32 = ReadIntData("Select Count(HolidayDate) From Holiday Where IsWeekend=1 And HolidayDate='" & interval.Start.Date & "'", cnn)

                If HLDCount > 0 Then
                    e.Title = "Holiday"
                    e.ToolTip = Header.Caption
                ElseIf WKCount > 0 Then
                    e.Title = "Off day"
                    e.ToolTip = interval.Start
                Else HLDCount = 0 And WKCount = 0
                    e.Title = "Work Day"
                    e.ToolTip = interval.Start
                End If

            End If

        End Sub

        Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
            RefreshPlanningBoard()
            MessageBox.Show("Refresh Successfully")
        End Sub

        Private Sub RefreshPlanningBoard()

            ShowAppointmentDetails(0)
            RefreshStatus()
            Me.PlanningBalanceBySIDTableAdapter.Fill(Me.PlanningBalanceDataSet.PlanningBalanceBySID)
            Me.ApmntLookupTableAdapter.Fill(Me.PlanningBoardNewDataSet.ApmntLookup)
            Me.AppointmentsLogTableAdapter.Fill(Me.AppointmentsLogDataSet.AppointmentsLog)

        End Sub
        Private Sub UpdateSewingCompletePercentage()


            Using Connection As New SqlConnection(cnn)

                Connection.Open()

                Dim cmd As SqlCommand = New SqlCommand("UpdateSewingComletePercentage", Connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.ExecuteNonQuery()

            End Using

        End Sub
        Private Sub SchedulerControl1_AppointmentResized(sender As Object, e As AppointmentResizeEventArgs) Handles SchedulerControl1.AppointmentResized


            UpdateSelectedAppointment(0)


        End Sub

        Private Sub SchedulerControl1_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles SchedulerControl1.PopupMenuShowing

            If SplitCheckBox.Checked Then

                If e.Menu.Id = DevExpress.XtraScheduler.SchedulerMenuItemId.AppointmentMenu Then
                    Dim command As New SplitAppointmentOperationCommand(SchedulerControl1)
                    Dim menuItemCommandAdapter As New SchedulerMenuItemCommandWinAdapter(command)
                    Dim menuItem As DXMenuItem = CType(menuItemCommandAdapter.CreateMenuItem(DXMenuItemPriority.Normal), DXMenuItem)
                    menuItem.BeginGroup = True
                    e.Menu.Items.Add(menuItem)
                End If

            End If

        End Sub



        Private Sub SchedulerControl1_CustomDrawAppointmentBackground(sender As Object, e As CustomDrawObjectEventArgs) Handles SchedulerControl1.CustomDrawAppointmentBackground
            ''SchedulerControl1.ActiveView.SelectAppointment()
            If CheckBox1.Checked Then


                Dim viewInfo As AppointmentViewInfo = TryCast(e.ObjectInfo, AppointmentViewInfo)
                ' Specify the ratio of a completed task to the entire task.
                Dim completenessRatio As Double = 0
                If CInt(viewInfo.Appointment.PercentComplete) > 100 Then
                    completenessRatio = 1
                Else
                    completenessRatio = CInt(viewInfo.Appointment.PercentComplete) / 100
                End If

                '0.25 * (CInt((viewInfo.Appointment.ResourceId)) Mod 4)
                ' Draw an appointment as usual.
                e.DrawDefault()
                ' Draw a background rectangle.
                Dim bounds As Rectangle = CalculateEntireAppointmentBounds(viewInfo)
                DrawBackGroundCore(e.Cache, bounds, completenessRatio)
                ' Indicate that no default drawing is required.
                e.Handled = True

            End If

        End Sub
        Private Shared Function CalculateEntireAppointmentBounds(ByVal viewInfo As AppointmentViewInfo) As Rectangle
            Dim leftOffset As Integer = 0
            Dim rightOffset As Integer = 0
            Dim scale As Double = viewInfo.Bounds.Width / viewInfo.Interval.Duration.TotalMilliseconds
            If Not viewInfo.HasLeftBorder Then
                Dim hidden As Double = (viewInfo.Interval.Start - viewInfo.AppointmentInterval.Start).TotalMilliseconds
                leftOffset = CInt((hidden * scale))
            End If
            If Not viewInfo.HasRightBorder Then
                Dim hidden As Double = (viewInfo.AppointmentInterval.End - viewInfo.Interval.End).TotalMilliseconds
                rightOffset = CInt((hidden * scale))
            End If
            Dim bounds As Rectangle = viewInfo.InnerBounds
            Return Rectangle.FromLTRB(bounds.Left - leftOffset, bounds.Y, bounds.Right + rightOffset, bounds.Bottom)
        End Function

        Private Shared Sub DrawBackGroundCore(ByVal cache As DevExpress.Utils.Drawing.GraphicsCache, ByVal bounds As Rectangle, ByVal completenessRatio As Double)
            Dim brush1 As Brush = New SolidBrush(Color.Green)
            cache.FillRectangle(brush1, New Rectangle(bounds.X, bounds.Y, CInt((bounds.Width * completenessRatio)), bounds.Height))
        End Sub

        Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
            My.Settings.ResourcePerPage = NumericUpDown1.Value
            My.Settings.Save()
            SchedulerControl1.Views.TimelineView.ResourcesPerPage = My.Settings.ResourcePerPage
        End Sub

        Private Sub SchedulerStorage1_AppointmentDeleting(sender As Object, e As PersistentObjectCancelEventArgs) Handles SchedulerStorage1.AppointmentDeleting

            Dim apt As Appointment = SchedulerControl1.SelectedAppointments(0)

            Dim aptid As Integer = 0

            If DBNull.Value.Equals(apt.GetValue(SchedulerStorage1, "AppointmentId")) = False Then
                aptid = apt.GetValue(SchedulerStorage1, "AppointmentId")

                Using Connection As New SqlConnection(cnn)

                    Connection.Open()

                    Dim cmd As SqlCommand = New SqlCommand("CopytoTempAppointmentNew", Connection)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@AptId", aptid)
                    cmd.Parameters.AddWithValue("@ActionType", "Deleted")
                    cmd.ExecuteNonQuery()

                End Using

                ExecuteQuery("Delete AppointmentDetails Where AppointmentId=" & aptid, cnn)

            End If

        End Sub

        Private Sub SchedulerStorage1_AppointmentsInserted(sender As Object, e As PersistentObjectsEventArgs) Handles SchedulerStorage1.AppointmentsInserted
            If SplitCheckBox.Checked Then
                SchedulerControl1.SelectedAppointments.Add(CType(e.Objects(0), DevExpress.XtraScheduler.Appointment))
                UpdateSelectedAppointment(1)
            End If
        End Sub

        Private Sub SelectSplitedAppointments(ByVal SDate As Date, ByVal FDate As Date)

            Dim aptColl As AppointmentBaseCollection = SchedulerStorage1.GetAppointments(SDate, FDate)

            For Each apt As Appointment In aptColl

                If apt.ResourceId = SchedulerControl1.SelectedResource.Id Then

                    SchedulerControl1.ActiveView.AddAppointmentSelection(apt)

                End If

            Next apt

        End Sub

        Private Sub PBalTextBox_TextChanged(sender As Object, e As EventArgs) Handles PBalTextBox.TextChanged, PIDTextBox.TextChanged
            If Val(PBalTextBox.Text) < 0 Then
                PBalTextBox.BackColor = Color.Red
                PBalTextBox.ForeColor = Color.Yellow
            ElseIf Val(PBalTextBox.Text) = 0 Then
                PBalTextBox.BackColor = Color.Green
                PBalTextBox.ForeColor = Color.White
            Else
                PBalTextBox.BackColor = Color.Yellow
                PBalTextBox.ForeColor = Color.Black
            End If
        End Sub


        Private Sub AddToPlanning(ByVal OID As Integer, ByVal SDate As Date, ByVal FDate As Date, ByVal SMV As Decimal, ByVal SMC As Integer, ByVal SID As Integer)


            'Dim row1 As OrderDataSet.OrderDetailsRow
            'row1 = CType(CType(Me.OrderDetailsBindingSource.Current, DataRowView).Row, OrderDataSet.OrderDetailsRow)



            Dim LID As Integer = 0
            Dim LText As String = String.Empty

            Dim OrQty As Integer = ReadIntData("Select Sum(OrderQuantity) From OrderQuantitySummeryBySID Where OrderId=" & OID & "And StyleId=" & SID, cnn)
            Dim PQty As Integer = ReadData("Select Sum(PlanningQuantity) From Appointments Where OrderId=" & OID & "And StyleId=" & SID, cnn)
            Dim PBQty As Integer = (PQtyTextBox.Text) 'Val(PBalTextBox.Text) 'OrQty - PQty

            Do While PBQty > 0
                If SMC > 0 Then
                    If LText = String.Empty Then
                        LID = ReadIntegerData("SELECT TOP 1 LineId FROM Line WHERE Planning=1 And Machine IS NOT NULL ORDER BY ABS(Machine - " & SMC & ")", cnn)
                        LText = LID
                        GoTo Line1
                    Else
                        LID = ReadIntegerData("SELECT TOP 1 LineId FROM Line WHERE Planning=1 And LineId not in (" & LText & ") And Machine IS NOT NULL ORDER BY ABS(Machine - " & SMC & ")", cnn)
                        LText = LText & "," & LID
                    End If

                End If
Line1:
                If LID > 0 Then

                    AddToPlanningWithLC(PBQty, LID, OID, SMV, SMC, SDate, FDate, Val(WHDTextBox.Text), SID, Val(LCSDTextBox.Text), Val(LCATextBox.Text), SCLGridLookUpEdit.EditValue)
                    PQty = ReadData("Select Sum(PlanningQuantity) From Appointments Where OrderId=" & OID & "And StyleId=" & SID, cnn)
                    PBQty = PBQty - PQty


                End If

            Loop




        End Sub
        Private Sub AddToPlanningBySelectedLine(ByVal OID As Integer, ByVal SDate As Date, ByVal FDate As Date, ByVal SMV As Decimal, ByVal SMC As Integer, ByVal SID As Integer)


            'Dim row1 As OrderDataSet.OrderDetailsRow
            'row1 = CType(CType(Me.OrderDetailsBindingSource.Current, DataRowView).Row, OrderDataSet.OrderDetailsRow)



            Dim LID As Integer = LineGridLookupEdit.EditValue
            Dim LText As String = String.Empty

            Dim OrQty As Integer = ReadIntData("Select Sum(OrderQuantity) From OrderQuantitySummeryBySID Where OrderId=" & OID & "And StyleId=" & SID, cnn)
            Dim PQty As Integer = ReadData("Select Sum(PlanningQuantity) From Appointments Where OrderId=" & OID & "And StyleId=" & SID, cnn)
            Dim PBQty As Integer = (PQtyTextBox.Text) 'Val(PBalTextBox.Text) 'OrQty - PQty


            '            Do While PBQty > 0
            '                If SMC > 0 Then
            '                    If LText = String.Empty Then
            '                        LID = ReadIntegerData("SELECT TOP 1 LineId FROM Line WHERE Planning=1 And Machine IS NOT NULL ORDER BY ABS(Machine - " & SMC & ")", cnn)
            '                        LText = LID
            '                        GoTo Line1
            '                    Else
            '                        LID = ReadIntegerData("SELECT TOP 1 LineId FROM Line WHERE Planning=1 And LineId not in (" & LText & ") And Machine IS NOT NULL ORDER BY ABS(Machine - " & SMC & ")", cnn)
            '                        LText = LText & "," & LID
            '                    End If

            '                End If
            'Line1:


            If LID > 0 Then

                AddToPlanningWithLC(PBQty, LID, OID, SMV, SMC, SDate, FDate, Val(WHDTextBox.Text), SID, Val(LCSDTextBox.Text), Val(LCATextBox.Text), SCLGridLookUpEdit.EditValue)
                PQty = ReadData("Select Sum(PlanningQuantity) From Appointments Where OrderId=" & OID & "And StyleId=" & SID, cnn)
                PBQty = PBQty - PQty


            End If

            'Loop




        End Sub




        Private Sub AddToPlanningWithLC(ByVal PlanningBalance As Integer, ByVal LID As Integer, ByVal OID As Integer, ByVal SSMV As Decimal, ByVal SMC As Integer, ByVal SDate As Date, ByVal FDate As Date, ByVal WHD As Integer, ByVal SID As Integer, ByVal LCSD As Integer, ByVal LCA As Integer, ByVal LC As String)

            'Dim row As OrderDataSet.OrderRow
            'row = CType(CType(Me.OrderBindingSource.Current, DataRowView).Row, OrderDataSet.OrderRow)


            Dim i As Integer = 1
            Dim CumNormalQuantity As Integer = 0
            Dim CumBonusQuantity As Integer = 0
            Dim Target As Integer = 0
            Dim MinEx As Date = ExDateEdit.DateTime.Date
            Dim Efficiency As Decimal
            Dim ProdEff As Integer = 0
            Dim WH As Int16 = 0
            Dim DayRequire As Integer = 0
            Dim HourRequire As Integer = 0
            Dim SDate2 As DateTime
            Dim FDate2 As DateTime

            ' Create new DataTable instance.
            Dim ADTable As New DataTable
            ' Create four typed columns in the DataTable.
            ADTable.Columns.Add("AppointmentId", GetType(Integer))
            ADTable.Columns.Add("DaySerial", GetType(Integer))
            ADTable.Columns.Add("PlanningDate", GetType(Date))
            ADTable.Columns.Add("Efficiency", GetType(Integer))
            ADTable.Columns.Add("PlanningQuantity", GetType(Integer))
            ADTable.Columns.Add("WH", GetType(Integer))



            If SSMV > 0 Then
                ProdEff = FormatNumber(SMC * 60 / SSMV * Val(WHD), 0)
            Else
                MessageBox.Show("SMV Missing in Style")
            End If

            Dim CumBal As Integer = 0


            Dim connection As New SqlConnection(cnn)
            connection.Open()

            Dim cmd As SqlCommand = New SqlCommand("Select dt From all_dates Where dt not in (Select HolidayDate From Holiday) And (dt between '" & SDate & "' and '" & FDate & "') Order By dt ", connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()

                If reader.IsDBNull(0) = False Then

                    If CumNormalQuantity <= PlanningBalance Then

                        If i < 10 Then
                            Efficiency = ReadData("Select Min(LC_Value) From SewingCustomLearningCurve Where StyleType='" & SCLGridLookUpEdit.EditValue & "' And MinSMV<=" & SSMV & " and DaySerial=" & i + LCSD - 1, cnn)
                            Efficiency = Efficiency * (1 - LCA / 100)
                        Else
                            Efficiency = ReadData("Select Min(LC_Value) From SewingCustomLearningCurve Where StyleType='" & SCLGridLookUpEdit.EditValue & "' And MinSMV<=" & SSMV & " and DaySerial=10", cnn) * (1 - LCA / 100)
                            Efficiency = Efficiency * (1 - LCA / 100)
                        End If
                        Dim PQty As Integer = 0


                        If CumNormalQuantity + ProdEff * Efficiency <= PlanningBalance Then

                            PQty = ProdEff * Efficiency
                            CumNormalQuantity = CumNormalQuantity + PQty
                            WH = WHD



                        ElseIf CumNormalQuantity + ProdEff * Efficiency > PlanningBalance Then

                            PQty = PlanningBalance - CumNormalQuantity
                            CumNormalQuantity = CumNormalQuantity + PQty

                            WH = roundUp(PQty / ProdEff * WHD)
                        End If

                        If i = 1 Then
                            SDate2 = reader("dt")
                        End If

                        If PQty > 0 Then
                            FDate2 = DateAdd("d", 1, reader("dt"))

                            Dim dr As DataRow = ADTable.NewRow()
                            dr("DaySerial") = i
                            dr("PlanningDate") = reader("dt")
                            dr("Efficiency") = Efficiency * 100
                            dr("PlanningQuantity") = PQty
                            dr("WH") = WH

                            ADTable.Rows.Add(dr)
                        Else
                            GoTo Line1
                        End If

                        i += 1

                    End If

                End If

            End While
Line1:
            Target = (CumNormalQuantity / i / WHD)
            DayRequire = DateDiff("d", SDate2, FDate2)
            HourRequire = DateDiff("d", SDate2, FDate2) * WHD

            reader.Close()
            connection.Close()
            Dim Line As String = ReadStringData("Select Line From Line Where LineId=" & LID, cnn)
            Dim aptSubject As String = ReadStringData("Select Details From OrderLookup Where OrderId=" & OID, cnn)
            'Dim aptlog As String = aptSubject & "::" & Line & "::" & SDate2 & "::" & FDate2
            'ExecuteQuery("Insert into AppointmentsLog(AppointmentsLog)values('" & aptlog & "')", cnn)
            'LogListBox.Items.Add(aptSubject & "::" & Line & "::" & SDate2 & "::" & FDate2)

            CRUDAppointment(0, SDate2, FDate2, 1, aptSubject, "Inserted", "Description", 0, LID, OID, CumNormalQuantity, Target, WHD, DayRequire, HourRequire, MinEx, 2, SSMV, SMC, SID, LCSD, LCA, LC)

            Dim APTId As Integer = ReadIntegerData("Select AppointmentId From Appointments Where Location='Inserted'", cnn)

            For Each drv As DataRow In ADTable.Rows
                CRUDAppointmentDetails(APTId, drv("DaySerial"), drv("PlanningDate"), drv("Efficiency"), drv("PlanningQuantity"), drv("WH"))
            Next drv

            ExecuteQuery("Update Appointments Set Location='' Where Location is not null", cnn)

        End Sub

        Private Sub AddToPlannningLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)



        End Sub


        Private Sub ShowStatusButton_Click(sender As Object, e As EventArgs) Handles ShowStatusButton.Click
            RefreshStatus()

        End Sub

        Private Sub RefreshStatus()
            If StatusByComboBox.Text = "Planning" Then
                OrangeLabel.Text = "Conflicted"
                YellowLabel.Text = ""
                BlueLabel.Text = ""
                GreenLabel.Text = "Perfect"
                ExecuteQuery("Exec UpdateSewingPlanningNew 'Planning'", cnn)
            ElseIf StatusByComboBox.Text = "Style Type" Then
                OrangeLabel.Text = "Paint : Rompper : Jump Suit"
                YellowLabel.Text = "T-Shirt : Tank top : Round Neck Sweat"
                BlueLabel.Text = "Polo : Serafino : Sweat Hoodie"
                GreenLabel.Text = "Jacket : Band Collar Polo"
                ExecuteQuery("Exec UpdateSewingPlanningNew 'Style Type'", cnn)
            ElseIf StatusByComboBox.Text = "Production" Then
                OrangeLabel.Text = "Not Cutting"
                YellowLabel.Text = "Cutting Start"
                BlueLabel.Text = "Sewing Start"
                GreenLabel.Text = "Sewing Complete"
                ExecuteQuery("Exec UpdateSewingPlanningNew 'Production'", cnn)
            End If

            Me.AppointmentsTableAdapter.FillByAll(Me.PlanningBoardNewDataSet.Appointments)
        End Sub

        Private Sub InlineCheckBox_CheckedChanged(sender As Object, e As EventArgs)

            If InlineCheckBox.Checked Then
                SchedulerControl1.OptionsCustomization.AllowInplaceEditor = UsedAppointmentType.All
            Else
                SchedulerControl1.OptionsCustomization.AllowInplaceEditor = UsedAppointmentType.None
            End If

        End Sub

        Private Sub ProgramNoLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ProgramNoLinkLabel.LinkClicked
            If Me.ProgNoTextBox.Text <> String.Empty Then

                Dim OID As Integer = ReadIntegerData("Select OrderId from [Order] Where ProgramNo='" & Me.ProgNoTextBox.Text & "'", cnn)

                frmOrderPrint.OrderId = OID
                ShowForm(frmOrderPrint)

            End If
        End Sub


        Private Sub PlanningBalanceBySIDBindingSource_PositionChanged_1(sender As Object, e As EventArgs) Handles PlanningBalanceBySIDBindingSource.PositionChanged
            If Me.PlanningBalanceBySIDBindingSource.Position > -1 Then

                Dim row As PlanningBalanceDataSet.PlanningBalanceBySIDRow
                row = CType(CType(Me.PlanningBalanceBySIDBindingSource.Current, DataRowView).Row, PlanningBalanceDataSet.PlanningBalanceBySIDRow)


                Dim SID As Integer = ReadIntegerData("Select StyleId From [Order] Where OrderId=" & row.OrderId, cnn)
                Dim TNAStart As Date = ReadDateData("Select ES From OrderActivities Where ActivitiesListId=22 And OrderId=" & row.OrderId, cnn)
                Dim TNAEnd As Date = ReadDateData("Select EF From OrderActivities Where ActivitiesListId=22 And OrderId=" & row.OrderId, cnn)
                TNAStartLabel.Text = TNAStart
                TNAEndLabel.Text = TNAEnd
                dtStart.EditValue = TNAStart
                dtEnd.EditValue = TNAEnd
                StyleTextBox.Text = ReadStringData("Select StyleName From [Style] Where StyleId=" & SID, cnn)
                ProgNoTextBox.Text = row.ProgramNo
                WHDTextBox.Text = 10


                OrdQtyTextBox.Text = row.OrderQuantity
                PBalTextBox.Text = row.PlanningBalance
                PQtyTextBox.Text = row.PlanningBalance
                SMVTextBox.Text = ReadData("Select SMV From Style Where StyleId=" & SID, cnn)
                MCTextBox.Text = ReadIntData("Select MCQty From Style Where StyleId=" & SID, cnn)

                Me.StyleTableAdapter.FillByStyleId(Me.StyleDataSet.Style, SID)


            End If
        End Sub
        Private Sub UndoLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles UndoLinkLabel.LinkClicked

            'On Error Resume Next
            Try
                Dim apt As Appointment = SchedulerControl1.SelectedAppointments(0)

                'If SelAptIndex = 0 Then
                '    SchedulerControl1.Refresh()
                'End If

                Dim AptId As Integer = apt.GetValue(SchedulerStorage1, "AppointmentId")



                Using Connection As New SqlConnection(cnn)

                    Connection.Open()

                    Dim cmd As SqlCommand = New SqlCommand("UndoAppointment", Connection)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@AptId", AptId)
                    cmd.ExecuteNonQuery()

                End Using


                Me.AppointmentsTableAdapter.FillByAll(Me.PlanningBoardNewDataSet.Appointments)


            Catch ex As Exception

                Using Connection As New SqlConnection(cnn)

                    Connection.Open()

                    Dim cmd As SqlCommand = New SqlCommand("UndoAppointmentNew", Connection)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.ExecuteNonQuery()

                End Using


                Me.AppointmentsTableAdapter.FillByAll(Me.PlanningBoardNewDataSet.Appointments)

            End Try


        End Sub

        Private Sub RedoLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RedoLinkLabel.LinkClicked

            On Error Resume Next
            Dim apt As Appointment = SchedulerControl1.SelectedAppointments(0)

            'If SelAptIndex = 0 Then
            '    SchedulerControl1.Refresh()
            'End If

            Dim AptId As Integer = apt.GetValue(SchedulerStorage1, "AppointmentId")

            Using Connection As New SqlConnection(cnn)

                Connection.Open()

                Dim cmd As SqlCommand = New SqlCommand("RedoAppointment", Connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@AptId", AptId)
                cmd.ExecuteNonQuery()

            End Using


            Me.AppointmentsTableAdapter.FillByAll(Me.PlanningBoardNewDataSet.Appointments)

        End Sub

        Private Sub PQtyLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PQtyLinkLabel.LinkClicked
            frmOrderQuantitySummery.OID = ReadIntegerData("Select OrderId From [Order] Where ProgramNo='" & ProgNoTextBox.Text & "'", cnn)
            frmOrderQuantitySummery.SID = ReadIntegerData("Select StyleId From [Style] Where StyleName='" & StyleTextBox.Text & "'", cnn)
            ShowMaster(frmOrderQuantitySummery)


            If frmOrderQuantitySummery.DialogResult = DialogResult.OK Then
                PQtyTextBox.Text = frmOrderQuantitySummery.OrdQty
            End If

        End Sub





        Private Sub AddToPQtyLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AddToPQtyLinkLabel.LinkClicked
            PQtyTextBox.Text = Val(PQtyTextBox.Text) + (PBalTextBox.Text)
            PBalTextBox.Text = 0
        End Sub

        Private Function GetAppointmentByRowHandle(ByVal storage As DevExpress.XtraScheduler.SchedulerStorage, ByVal row As DataRow) As DevExpress.XtraScheduler.Appointment
            Dim result As DevExpress.XtraScheduler.Appointment = Nothing
            Dim objectRow As Object = Nothing

            For i As Integer = 0 To storage.Appointments.Count - 1
                objectRow = storage.Appointments.DataManager.GetObjectRow(storage.Appointments(i))

                'If (CType(objectRow, DataRowView)).Row = row Then
                result = storage.Appointments(i)
                'End If

            Next

            Return result
        End Function

        Private Sub GridView5_FocusedRowChanged(sender As Object, e As XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView5.FocusedRowChanged
            Dim rowHandle As Integer = e.FocusedRowHandle
            Dim row As DataRow = GridView5.GetDataRow(rowHandle)
            Dim apt As DevExpress.XtraScheduler.Appointment = GetAppointmentByRowHandle(SchedulerStorage1, row)

            If apt IsNot Nothing Then
                SchedulerControl1.SelectedAppointments.Clear()
                SchedulerControl1.SelectedAppointments.Add(apt)
            End If

        End Sub

        Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

        End Sub

        Private Sub MaxExDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles MaxExDateTimePicker.ValueChanged

        End Sub

        Private Sub SplitCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SplitCheckBox.CheckedChanged, CheckBox1.CheckedChanged

            If Me.SplitCheckBox.Checked Then
                DateRadioButton.Checked = True
            Else
                QuantityRadioButton.Checked = True
            End If

        End Sub

        Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

            SplitCheckBox.Checked = False


            If Val(Me.SMVTextBox.Text) = 0 AndAlso Val(Me.MCTextBox.Text = 0) Then
                MessageBox.Show("Check SMV and MC")
                Exit Sub
            End If

            If PlanningBalanceBySIDBindingSource.Position > -1 Then
                'WHDTextBox.Text = 10
                Dim row As PlanningBalanceDataSet.PlanningBalanceBySIDRow
                row = CType(CType(Me.PlanningBalanceBySIDBindingSource.Current, DataRowView).Row, PlanningBalanceDataSet.PlanningBalanceBySIDRow)
                'If row.IsStartDateNull = False AndAlso row.IsEndDateNull = False AndAlso Val(SMVTextBox.Text) > 0 AndAlso Val(MCTextBox.Text) > 0 AndAlso Val(WHDTextBox.Text) > 0 AndAlso Val(LCSDTextBox.Text) > 0 AndAlso SCLGridLookUpEdit.EditValue <> String.Empty Then
                If Val(SMVTextBox.Text) > 0 AndAlso Val(MCTextBox.Text) > 0 AndAlso Val(WHDTextBox.Text) > 0 AndAlso Val(LCSDTextBox.Text) > 0 AndAlso SCLGridLookUpEdit.EditValue <> String.Empty Then
                    ExecuteQuery("Update [Order] Set SewingStartDate='" & dtStart.EditValue & "',SewingEndDate='" & dtEnd.EditValue & "' Where OrderId=" & row.OrderId, cnn)
                    ExecuteQuery("Update Style Set SMV=" & CType(SMVTextBox.Text, Decimal) & ",MCQty=" & Val(MCTextBox.Text) & " Where StyleId=(Select StyleId From [Order] Where OrderId=" & row.OrderId & ")", cnn)
                    'AddToPlanning(row.OrderId, row.StartDate, row.EndDate, SMVTextBox.Text, MCTextBox.Text, row.StyleId)
                    If QuantityRadioButton.Checked = True Then
                        dtEnd.EditValue = DateAdd("d", 90, dtStart.DateTime.Date)
                    End If
                    AddToPlanningBySelectedLine(row.OrderId, dtStart.EditValue, dtEnd.EditValue, SMVTextBox.Text, MCTextBox.Text, row.StyleId)
                    MessageBox.Show("Added Successfully")

                Else
                    MessageBox.Show("Please check following Parameter :" & vbNewLine & "Start And End Date , SMV , MCQty. WHD")
                    Exit Sub
                End If

                RefreshPlanningBoard()

            End If

        End Sub

        Private Sub DateRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DateRadioButton.CheckedChanged
            If DateRadioButton.Checked Then
                SchedulerControl1.OptionsCustomization.AllowAppointmentResize = UsedAppointmentType.All
            Else
                SchedulerControl1.OptionsCustomization.AllowAppointmentResize = UsedAppointmentType.None
            End If
        End Sub
        Private Sub AsyncInvoke()
            SchedulerStorage1.RefreshData()
        End Sub
        Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

            Try

                Dim ProdEff As Integer = 0
                Dim PQty As Decimal = 0


                ' Create new DataTable instance.
                Dim ADTable As New DataTable
                ' Create four typed columns in the DataTable.
                ADTable.Columns.Add("AppointmentId", GetType(Integer))
                ADTable.Columns.Add("DaySerial", GetType(Integer))
                ADTable.Columns.Add("PlanningDate", GetType(Date))
                ADTable.Columns.Add("Efficiency", GetType(Integer))
                ADTable.Columns.Add("PlanningQuantity", GetType(Integer))
                ADTable.Columns.Add("WH", GetType(Integer))


                For Each drv As DataRowView In Me.AppointmentDetailsBindingSource.List

                    ProdEff = FormatNumber(Val(MCTextBox.Text) * 60 / Val(SMVTextBox.Text) * Val(drv!WH), 0)

                    If drv!DaySerial < 10 Then

                        Efficiency = ReadData("Select Min(LC_Value) From SewingCustomLearningCurve Where MinSMV<=" & Val(SMVTextBox.Text) & " and DaySerial=" & drv!DaySerial, cnn)
                        Efficiency = FormatNumber(Efficiency * (1 - Val(LCATextBox.Text) / 100) * 100, 0)

                    Else

                        Efficiency = ReadData("Select Min(LC_Value) From SewingCustomLearningCurve Where MinSMV<=" & Val(SMVTextBox.Text) & " and DaySerial=10", cnn)
                        Efficiency = FormatNumber(Efficiency * (1 - Val(LCATextBox.Text) / 100) * 100, 0)

                    End If

                    drv!WH = drv!WH
                    drv!Efficiency = Efficiency
                    drv!PlanningQuantity = FormatNumber(ProdEff * (drv!Efficiency / 100), 0)
                    PQty = PQty + drv!PlanningQuantity


                    Dim dr As DataRow = ADTable.NewRow()
                    dr("DaySerial") = drv!DaySerial
                    dr("PlanningDate") = drv!PlanningDate
                    dr("Efficiency") = Efficiency
                    dr("PlanningQuantity") = drv!PlanningQuantity
                    dr("WH") = drv!WH
                    ADTable.Rows.Add(dr)

                Next



                RCal = True
                Dim apt As Appointment = SchedulerControl1.SelectedAppointments(0)
                Dim aptid As Integer = apt.GetValue(SchedulerStorage1, "AppointmentId")
                apt.CustomFields("PlanningQuantity") = PQty
                apt.CustomFields("LC") = SCLGridLookUpEdit.EditValue
                apt.CustomFields("LCA") = Val(LCATextBox.Text)
                PQtyTextBox.Text = PQty

                If DBNull.Value.Equals(aptid) = False Then
                    ExecuteQuery("Delete AppointmentDetails Where AppointmentId=" & aptid, cnn)
                    'ExecuteQuery("Update Appointments Set PlanningQuantity=0  Where AppointmentId=" & aptId, cnn)
                End If

                For Each drv As DataRow In ADTable.Rows
                    CRUDAppointmentDetails(aptId, drv("DaySerial"), drv("PlanningDate"), drv("Efficiency"), drv("PlanningQuantity"), drv("WH"))
                Next drv

                'Me.AppointmentDetailsBindingSource.ResetBindings(True)
                'Me.Validate()

                'Me.AppointmentsBindingSource.EndEdit()
                'Me.AppointmentDetailsBindingSource.EndEdit()
                'Me.AppointmentsTableAdapter.Update(Me.PlanningBoardNewDataSet)
                Me.AppointmentDetailsTableAdapter.FillByAptId(PlanningBoardNewDataSet.AppointmentDetails, apt.Id)

                MessageBox.Show("Update Successfully", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


        End Sub

        Private Sub CopyLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CopyLinkLabel.LinkClicked

            Dim apt As Appointment = SchedulerControl1.SelectedAppointments(0)
            PubAptId = apt.GetValue(SchedulerStorage1, "AppointmentId")


        End Sub

        Private Sub PasteLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PasteLabel.LinkClicked

            Using Connection As New SqlConnection(cnn)

                Connection.Open()

                Dim cmd As SqlCommand = New SqlCommand("PasteAppointment", Connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@AptId", PubAptId)
                cmd.Parameters.AddWithValue("@LID", RID)
                cmd.Parameters.AddWithValue("@StDate", MyStDate)
                cmd.ExecuteNonQuery()

            End Using

            Me.AppointmentsTableAdapter.FillByAll(Me.PlanningBoardNewDataSet.Appointments)

        End Sub

        Private Sub SchedulerControl1_MouseClick(sender As Object, e As MouseEventArgs) Handles SchedulerControl1.MouseClick

            Dim hInfo As SchedulerHitInfo = SchedulerControl1.ActiveView.ViewInfo.CalcHitInfo(New Point(e.X, e.Y), True)

            If hInfo.ViewInfo.HitTestType = SchedulerHitTest.Cell Then
                RID = CInt(hInfo.ViewInfo.Resource.Id)
                MyStDate = CDate(hInfo.ViewInfo.Interval.Start.Date)
                'MessageBox.Show(myDate.ToString())
            End If

        End Sub

        Private Sub SchedulerControl1_AppointmentViewInfoCustomizing(sender As Object, e As AppointmentViewInfoCustomizingEventArgs) Handles SchedulerControl1.AppointmentViewInfoCustomizing
            If e.ViewInfo.DisplayText = String.Empty Then
                e.ViewInfo.ToolTipText = String.Format("Started at {0:g}", e.ViewInfo.Appointment.Start)
            End If
        End Sub

        Private Sub UCPLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles UCPLinkLabel.LinkClicked
            UpdateSewingCompletePercentage()
            Me.AppointmentsTableAdapter.FillByAll(Me.PlanningBoardNewDataSet.Appointments)
        End Sub



        Private Sub ShowPOLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ShowPOLinkLabel.LinkClicked

            If Me.PlanningBalanceBySIDBindingSource.Position > -1 Then
                Dim row As PlanningBalanceDataSet.PlanningBalanceBySIDRow
                row = CType(CType(Me.PlanningBalanceBySIDBindingSource.Current, DataRowView).Row, PlanningBalanceDataSet.PlanningBalanceBySIDRow)
                Me.SewingOutputBalance_POwiseTableAdapter.FillByOID(Me.SewingOutputBalance_POwiseDataSet.SewingOutputBalance_POwise, row.OrderId)
            End If

        End Sub

        Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
            Me.AppointmentsTableAdapter.FillByAll(Me.PlanningBoardNewDataSet.Appointments)
        End Sub
        Private Sub GridView6_CellValueChanged(sender As Object, e As XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView6.CellValueChanged

            If e.Column.Caption = "Select" Then

                Dim TTLSewingBalance As Integer = 0

                For Each drv As DataRowView In Me.SewingOutputBalancePOwiseBindingSource.List

                    If drv!Select = True Then
                        If drv!SewingBalance > 0 Then
                            TTLSewingBalance = TTLSewingBalance + drv!SewingRequireQuantity
                        End If

                    End If

                Next

                PQtyTextBox.Text = TTLSewingBalance

            End If
        End Sub

        Private Sub ShowByPNButton_Click(sender As Object, e As EventArgs) Handles ShowByPNButton.Click
            Me.AppointmentsTableAdapter.FillByApmntId(Me.PlanningBoardNewDataSet.Appointments, GridLookUpEdit1.EditValue)
        End Sub

        Private Sub ShowByPrgButton_Click(sender As Object, e As EventArgs) Handles ShowByPrgButton.Click

            Dim OID As Integer = ReadIntegerData("Select OrderId From Appointments Where AppointmentId=" & GridLookUpEdit1.EditValue, cnn)

            If OID > 0 Then
                Me.AppointmentsTableAdapter.FillByOID(Me.PlanningBoardNewDataSet.Appointments, OID)
            End If

        End Sub

        Private Sub GridControl5_Click(sender As Object, e As EventArgs) Handles GridControl5.Click

        End Sub

        Private Sub SCLGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles SCLGridLookUpEdit.EditValueChanged

        End Sub
    End Class
    Public Class MyMouseHandlerService
        Inherits MouseHandlerServiceWrapper
        Private provider As IServiceProvider

        Public Sub New(ByVal provider As IServiceProvider, ByVal service As IMouseHandlerService)
            MyBase.New(service)
            Me.provider = provider
        End Sub

        Public Overrides Sub OnMouseWheel(ByVal e As MouseEventArgs)
            If TypeOf provider Is SchedulerControl Then
                Dim scheduler As SchedulerControl = CType(provider, SchedulerControl)
                If scheduler.ActiveViewType = SchedulerViewType.Timeline Then
                    If scheduler.Services.ResourceNavigation Is Nothing Then
                        MyBase.OnMouseWheel(e)
                        Return
                    End If

                    If e.Delta > 0 Then
                        scheduler.Services.ResourceNavigation.NavigateBackward()
                    Else
                        scheduler.Services.ResourceNavigation.NavigateForward()
                    End If
                Else
                    If System.Windows.Forms.Control.ModifierKeys <> Keys.Control Then
                        MyBase.OnMouseWheel(e)
                    End If
                End If
            End If
        End Sub
        ' MyBase.OnMouseWheel(e)
    End Class

End Namespace



