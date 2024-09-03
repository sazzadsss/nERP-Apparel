
Namespace TimelineTimeScales

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmPlanningBoardNew
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
            Dim DailyPrintStyle1 As DevExpress.XtraScheduler.Printing.DailyPrintStyle = New DevExpress.XtraScheduler.Printing.DailyPrintStyle()
            Dim WeeklyPrintStyle1 As DevExpress.XtraScheduler.Printing.WeeklyPrintStyle = New DevExpress.XtraScheduler.Printing.WeeklyPrintStyle()
            Dim MonthlyPrintStyle1 As DevExpress.XtraScheduler.Printing.MonthlyPrintStyle = New DevExpress.XtraScheduler.Printing.MonthlyPrintStyle()
            Dim TriFoldPrintStyle1 As DevExpress.XtraScheduler.Printing.TriFoldPrintStyle = New DevExpress.XtraScheduler.Printing.TriFoldPrintStyle()
            Dim CalendarDetailsPrintStyle1 As DevExpress.XtraScheduler.Printing.CalendarDetailsPrintStyle = New DevExpress.XtraScheduler.Printing.CalendarDetailsPrintStyle()
            Dim MemoPrintStyle1 As DevExpress.XtraScheduler.Printing.MemoPrintStyle = New DevExpress.XtraScheduler.Printing.MemoPrintStyle()
            Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim TimeScaleYear1 As DevExpress.XtraScheduler.TimeScaleYear = New DevExpress.XtraScheduler.TimeScaleYear()
            Dim TimeScaleQuarter1 As DevExpress.XtraScheduler.TimeScaleQuarter = New DevExpress.XtraScheduler.TimeScaleQuarter()
            Dim TimeScaleMonth1 As DevExpress.XtraScheduler.TimeScaleMonth = New DevExpress.XtraScheduler.TimeScaleMonth()
            Dim TimeScaleWeek1 As DevExpress.XtraScheduler.TimeScaleWeek = New DevExpress.XtraScheduler.TimeScaleWeek()
            Dim TimeScaleDay1 As DevExpress.XtraScheduler.TimeScaleDay = New DevExpress.XtraScheduler.TimeScaleDay()
            Dim TimeScaleHour1 As DevExpress.XtraScheduler.TimeScaleHour = New DevExpress.XtraScheduler.TimeScaleHour()
            Dim TimeScaleFixedInterval1 As DevExpress.XtraScheduler.TimeScaleFixedInterval = New DevExpress.XtraScheduler.TimeScaleFixedInterval()
            Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Me.SchedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.AppointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.PlanningBoardNewDataSet = New KSoft_Apparel.PlanningBoardNewDataSet()
            Me.LineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.AppointmentsTableAdapter = New KSoft_Apparel.PlanningBoardNewDataSetTableAdapters.AppointmentsTableAdapter()
            Me.LineTableAdapter = New KSoft_Apparel.PlanningBoardNewDataSetTableAdapters.LineTableAdapter()
            Me.ComboBox1 = New System.Windows.Forms.ComboBox()
            Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.BranchDataSet = New KSoft_Apparel.BranchDataSet()
            Me.BranchTableAdapter = New KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
            Me.ApmntLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLine = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEndDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStartDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ShowAllButton = New System.Windows.Forms.Button()
            Me.SaveButton = New System.Windows.Forms.Button()
            Me.RefreshButton = New System.Windows.Forms.Button()
            Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
            Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
            Me.SelectAllButton = New System.Windows.Forms.Button()
            Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.MaxExDateTimePicker = New System.Windows.Forms.DateTimePicker()
            Me.PrintButton = New System.Windows.Forms.Button()
            Me.SplitCheckBox = New System.Windows.Forms.CheckBox()
            Me.AllButton = New System.Windows.Forms.Button()
            Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
            Me.ResourcesCheckedListBoxControl1 = New DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl()
            Me.SchedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
            Me.colIsPrint = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.TableAdapterManager = New KSoft_Apparel.SewingOutputBalanceDataSetTableAdapters.TableAdapterManager()
            Me.AppointmentDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
            Me.ActivitiesPivotBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ActivitiesPivotDataSet = New KSoft_Apparel.ActivitiesPivotDataSet()
            Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colYarn = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFabric = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCutting = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrinting = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEmbroidery = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSewing = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFinishing = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInspection = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipment = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPlanning = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccessories = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
            Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
            Me.PlanningBalanceBySIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.PlanningBalanceDataSet = New KSoft_Apparel.PlanningBalanceDataSet()
            Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPlanningBalance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMinEX = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMaxEX = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrderReceiveDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStyleName1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProgramNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPlanningQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSewingBalance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipmentBalance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
            Me.ShowPOLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.GridControl5 = New DevExpress.XtraGrid.GridControl()
            Me.SewingOutputBalancePOwiseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.SewingOutputBalance_POwiseDataSet = New KSoft_Apparel.SewingOutputBalance_POwiseDataSet()
            Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colEx = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrderQuantity2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOutputQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSewingBalance1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPO = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSelect = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipmentBalance1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemHyperLinkEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
            Me.TabPage3 = New System.Windows.Forms.TabPage()
            Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
            Me.AppointmentsLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.AppointmentsLogDataSet = New KSoft_Apparel.AppointmentsLogDataSet()
            Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colProgramNo2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSubject1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCreatedOn = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLine1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStartDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEndDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrderQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPlanningQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMaxEX1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMinEX1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAppointmentId = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.InlineCheckBox = New System.Windows.Forms.CheckBox()
            Me.DateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.ShowByPrgButton = New System.Windows.Forms.Button()
            Me.ShowByPNButton = New System.Windows.Forms.Button()
            Me.TabPage4 = New System.Windows.Forms.TabPage()
            Me.ShowStatusButton = New System.Windows.Forms.Button()
            Me.StatusByComboBox = New System.Windows.Forms.ComboBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.OrangeLabel = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.GreenLabel = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.YellowLabel = New System.Windows.Forms.Label()
            Me.BlueLabel = New System.Windows.Forms.Label()
            Me.TabPage5 = New System.Windows.Forms.TabPage()
            Me.TabPage6 = New System.Windows.Forms.TabPage()
            Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldDaySerial1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldPlanningDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldEfficiency1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldPlanningQuantity1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.TabPage7 = New System.Windows.Forms.TabPage()
            Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDaySerial = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPlanningDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEfficiency = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPlanningQuantity2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTarget = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colWH = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.dtEnd = New DevExpress.XtraEditors.DateEdit()
            Me.dtStart = New DevExpress.XtraEditors.DateEdit()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.LineGridLookupEdit = New DevExpress.XtraEditors.LookUpEdit()
            Me.AddToPQtyLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.RedoLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.UndoLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.SCLGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
            Me.SCLStyleTypeLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.SewingCustomLearningCurveDataSet = New KSoft_Apparel.SewingCustomLearningCurveDataSet()
            Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.PQtyLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.ProgramNoLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.PicturePictureEdit = New DevExpress.XtraEditors.PictureEdit()
            Me.StyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.StyleDataSet = New KSoft_Apparel.StyleDataSet()
            Me.MCTextBox = New System.Windows.Forms.TextBox()
            Me.StyleTextBox = New System.Windows.Forms.TextBox()
            Me.ProgNoTextBox = New System.Windows.Forms.TextBox()
            Me.LCSDTextBox = New System.Windows.Forms.TextBox()
            Me.WHDTextBox = New System.Windows.Forms.TextBox()
            Me.SMVTextBox = New System.Windows.Forms.TextBox()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.PQtyTextBox = New System.Windows.Forms.TextBox()
            Me.OrdQtyTextBox = New System.Windows.Forms.TextBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.PIDTextBox = New System.Windows.Forms.TextBox()
            Me.PBalTextBox = New System.Windows.Forms.TextBox()
            Me.TNAEndLabel = New System.Windows.Forms.Label()
            Me.TNAStartLabel = New System.Windows.Forms.Label()
            Me.FabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.FabricColorDataSet = New KSoft_Apparel.FabricColorDataSet()
            Me.TableAdapterManager1 = New KSoft_Apparel.PlanningBoardNewDataSetTableAdapters.TableAdapterManager()
            Me.FabricColorTableAdapter = New KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter()
            Me.ApmntLookupTableAdapter = New KSoft_Apparel.PlanningBoardNewDataSetTableAdapters.ApmntLookupTableAdapter()
            Me.AppointmentDetailsTableAdapter = New KSoft_Apparel.PlanningBoardNewDataSetTableAdapters.AppointmentDetailsTableAdapter()
            Me.StyleTableAdapter = New KSoft_Apparel.StyleDataSetTableAdapters.StyleTableAdapter()
            Me.ActivitiesPivotTableAdapter = New KSoft_Apparel.ActivitiesPivotDataSetTableAdapters.ActivitiesPivotTableAdapter()
            Me.AppointmentsLogTableAdapter = New KSoft_Apparel.AppointmentsLogDataSetTableAdapters.AppointmentsLogTableAdapter()
            Me.SCLStyleTypeLookupTableAdapter = New KSoft_Apparel.SewingCustomLearningCurveDataSetTableAdapters.SCLStyleTypeLookupTableAdapter()
            Me.PlanningBalanceBySIDTableAdapter = New KSoft_Apparel.PlanningBalanceDataSetTableAdapters.PlanningBalanceBySIDTableAdapter()
            Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
            Me.LCATextBox = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.UCPLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.DateRadioButton = New System.Windows.Forms.RadioButton()
            Me.QuantityRadioButton = New System.Windows.Forms.RadioButton()
            Me.PasteLabel = New System.Windows.Forms.LinkLabel()
            Me.CopyLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.AddButton = New System.Windows.Forms.Button()
            Me.CheckBox1 = New System.Windows.Forms.CheckBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.ExDateEdit = New DevExpress.XtraEditors.DateEdit()
            Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.SewingOutputBalance_POwiseTableAdapter = New KSoft_Apparel.SewingOutputBalance_POwiseDataSetTableAdapters.SewingOutputBalance_POwiseTableAdapter()
            CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PlanningBoardNewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ApmntLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ResourcesCheckedListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AppointmentDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ActivitiesPivotBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ActivitiesPivotDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControl1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer2.Panel1.SuspendLayout()
            Me.SplitContainer2.Panel2.SuspendLayout()
            Me.SplitContainer2.SuspendLayout()
            CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PlanningBalanceBySIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PlanningBalanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SewingOutputBalancePOwiseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SewingOutputBalance_POwiseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage3.SuspendLayout()
            CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AppointmentsLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AppointmentsLogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage1.SuspendLayout()
            CType(Me.DateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateNavigator1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage4.SuspendLayout()
            Me.TabPage5.SuspendLayout()
            Me.TabPage6.SuspendLayout()
            CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage7.SuspendLayout()
            CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LineGridLookupEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SCLGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SCLStyleTypeLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SewingCustomLearningCurveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PicturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer6.Panel1.SuspendLayout()
            Me.SplitContainer6.Panel2.SuspendLayout()
            Me.SplitContainer6.SuspendLayout()
            CType(Me.ExDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ExDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer1.Panel1.SuspendLayout()
            Me.SplitContainer1.Panel2.SuspendLayout()
            Me.SplitContainer1.SuspendLayout()
            Me.SuspendLayout()
            '
            'SchedulerStorage1
            '
            Me.SchedulerStorage1.Appointments.AutoRetrieveId = True
            Me.SchedulerStorage1.Appointments.CommitIdToDataSource = True
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("FabricColorId", "FabricColorId"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("OrderId", "OrderId"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("PlanningQuantity", "PlanningQuantity"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Target", "Target"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("IsAdvanced", "IsAdvanced"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("OrderDetailsId", "OrderDetailsId"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("WH", "WH"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("RD", "RD"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("RH", "RH"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ExDate", "ExDate"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ExcessSewingPercentage", "ExcessSewingPercentage"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("MC", "MC"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("SMV", "SMV"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("StyleId", "StyleId"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("LCSD", "LCSD"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("LCA", "LCA"))
            Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("LC", "LC"))
            Me.SchedulerStorage1.Appointments.DataSource = Me.AppointmentsBindingSource
            Me.SchedulerStorage1.Appointments.Labels.Add(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)), "0", "&0")
            Me.SchedulerStorage1.Appointments.Labels.Add(System.Drawing.Color.Yellow, "1", "&1")
            Me.SchedulerStorage1.Appointments.Labels.Add(System.Drawing.Color.Blue, "2", "&2")
            Me.SchedulerStorage1.Appointments.Labels.Add(System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), "3", "&3")
            Me.SchedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
            Me.SchedulerStorage1.Appointments.Mappings.AppointmentId = "AppointmentId"
            Me.SchedulerStorage1.Appointments.Mappings.Description = "Description"
            Me.SchedulerStorage1.Appointments.Mappings.End = "EndDate"
            Me.SchedulerStorage1.Appointments.Mappings.Label = "Label"
            Me.SchedulerStorage1.Appointments.Mappings.Location = "Location"
            Me.SchedulerStorage1.Appointments.Mappings.PercentComplete = "PercentComplete"
            Me.SchedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
            Me.SchedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
            Me.SchedulerStorage1.Appointments.Mappings.ResourceId = "LineId"
            Me.SchedulerStorage1.Appointments.Mappings.Start = "StartDate"
            Me.SchedulerStorage1.Appointments.Mappings.Status = "Status"
            Me.SchedulerStorage1.Appointments.Mappings.Subject = "Subject"
            Me.SchedulerStorage1.Appointments.Mappings.Type = "Type"
            Me.SchedulerStorage1.Appointments.Statuses.Add(DevExpress.XtraScheduler.AppointmentStatusType.Free, "0", "&0", System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)))
            Me.SchedulerStorage1.Appointments.Statuses.Add(DevExpress.XtraScheduler.AppointmentStatusType.Tentative, "1", "&1", System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer)))
            Me.SchedulerStorage1.Appointments.Statuses.Add(DevExpress.XtraScheduler.AppointmentStatusType.Busy, "2", "&2", System.Drawing.Color.Blue)
            Me.SchedulerStorage1.Appointments.Statuses.Add(DevExpress.XtraScheduler.AppointmentStatusType.OutOfOffice, "3", "&3", System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)))
            Me.SchedulerStorage1.Resources.DataSource = Me.LineBindingSource
            Me.SchedulerStorage1.Resources.Mappings.Caption = "Details"
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
            Me.LineBindingSource.DataSource = Me.PlanningBoardNewDataSet
            '
            'AppointmentsTableAdapter
            '
            Me.AppointmentsTableAdapter.ClearBeforeFill = True
            '
            'LineTableAdapter
            '
            Me.LineTableAdapter.ClearBeforeFill = True
            '
            'ComboBox1
            '
            Me.ComboBox1.DataSource = Me.BranchBindingSource
            Me.ComboBox1.DisplayMember = "BranchCode"
            Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Location = New System.Drawing.Point(55, 5)
            Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(124, 21)
            Me.ComboBox1.TabIndex = 1
            Me.ComboBox1.ValueMember = "BranchId"
            '
            'BranchBindingSource
            '
            Me.BranchBindingSource.DataMember = "Branch"
            Me.BranchBindingSource.DataSource = Me.BranchDataSet
            '
            'BranchDataSet
            '
            Me.BranchDataSet.DataSetName = "BranchDataSet"
            Me.BranchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'BranchTableAdapter
            '
            Me.BranchTableAdapter.ClearBeforeFill = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Location = New System.Drawing.Point(8, 9)
            Me.Label1.Margin = New System.Windows.Forms.Padding(10, 9, 3, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(41, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Branch"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.Location = New System.Drawing.Point(309, 28)
            Me.Label6.Margin = New System.Windows.Forms.Padding(10, 10, 3, 0)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(91, 13)
            Me.Label6.TabIndex = 7
            Me.Label6.Text = "Search Planning :"
            '
            'GridLookUpEdit1
            '
            Me.GridLookUpEdit1.AllowDrop = True
            Me.GridLookUpEdit1.Location = New System.Drawing.Point(312, 46)
            Me.GridLookUpEdit1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
            Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
            Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.GridLookUpEdit1.Properties.DataSource = Me.ApmntLookupBindingSource
            Me.GridLookUpEdit1.Properties.DisplayMember = "Subject"
            Me.GridLookUpEdit1.Properties.ImmediatePopup = True
            Me.GridLookUpEdit1.Properties.NullText = "[Select Program]"
            Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
            Me.GridLookUpEdit1.Properties.PopupView = Me.GridView1
            Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            Me.GridLookUpEdit1.Properties.ValueMember = "AppointmentId"
            Me.GridLookUpEdit1.Size = New System.Drawing.Size(163, 20)
            Me.GridLookUpEdit1.TabIndex = 6
            '
            'ApmntLookupBindingSource
            '
            Me.ApmntLookupBindingSource.DataMember = "ApmntLookup"
            Me.ApmntLookupBindingSource.DataSource = Me.PlanningBoardNewDataSet
            '
            'GridView1
            '
            Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSubject, Me.colLine, Me.colEndDate1, Me.colStartDate1})
            Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.GridView1.Name = "GridView1"
            Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.GridView1.OptionsView.ShowGroupPanel = False
            '
            'colSubject
            '
            Me.colSubject.FieldName = "Subject"
            Me.colSubject.Name = "colSubject"
            Me.colSubject.Visible = True
            Me.colSubject.VisibleIndex = 0
            '
            'colLine
            '
            Me.colLine.FieldName = "Line"
            Me.colLine.Name = "colLine"
            Me.colLine.Visible = True
            Me.colLine.VisibleIndex = 1
            '
            'colEndDate1
            '
            Me.colEndDate1.FieldName = "EndDate"
            Me.colEndDate1.Name = "colEndDate1"
            Me.colEndDate1.Visible = True
            Me.colEndDate1.VisibleIndex = 2
            '
            'colStartDate1
            '
            Me.colStartDate1.FieldName = "StartDate"
            Me.colStartDate1.Name = "colStartDate1"
            Me.colStartDate1.Visible = True
            Me.colStartDate1.VisibleIndex = 3
            '
            'ShowAllButton
            '
            Me.ShowAllButton.Location = New System.Drawing.Point(661, 28)
            Me.ShowAllButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
            Me.ShowAllButton.Name = "ShowAllButton"
            Me.ShowAllButton.Size = New System.Drawing.Size(80, 39)
            Me.ShowAllButton.TabIndex = 8
            Me.ShowAllButton.Text = "Show Running (All)"
            Me.ShowAllButton.UseVisualStyleBackColor = True
            '
            'SaveButton
            '
            Me.SaveButton.Location = New System.Drawing.Point(1084, 10)
            Me.SaveButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
            Me.SaveButton.Name = "SaveButton"
            Me.SaveButton.Size = New System.Drawing.Size(64, 38)
            Me.SaveButton.TabIndex = 9
            Me.SaveButton.Text = "&Update"
            Me.SaveButton.UseVisualStyleBackColor = True
            '
            'RefreshButton
            '
            Me.RefreshButton.Location = New System.Drawing.Point(1149, 10)
            Me.RefreshButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
            Me.RefreshButton.Name = "RefreshButton"
            Me.RefreshButton.Size = New System.Drawing.Size(52, 38)
            Me.RefreshButton.TabIndex = 9
            Me.RefreshButton.Text = "&Refresh"
            Me.RefreshButton.UseVisualStyleBackColor = True
            '
            'DateTimePicker1
            '
            Me.DateTimePicker1.CustomFormat = "dd-MMM-yy"
            Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.DateTimePicker1.Location = New System.Drawing.Point(445, 89)
            Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
            Me.DateTimePicker1.Name = "DateTimePicker1"
            Me.DateTimePicker1.Size = New System.Drawing.Size(75, 20)
            Me.DateTimePicker1.TabIndex = 4
            '
            'DateTimePicker2
            '
            Me.DateTimePicker2.CustomFormat = "dd-MMM-yy"
            Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.DateTimePicker2.Location = New System.Drawing.Point(548, 89)
            Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
            Me.DateTimePicker2.Name = "DateTimePicker2"
            Me.DateTimePicker2.Size = New System.Drawing.Size(83, 20)
            Me.DateTimePicker2.TabIndex = 5
            '
            'SelectAllButton
            '
            Me.SelectAllButton.Location = New System.Drawing.Point(661, 88)
            Me.SelectAllButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
            Me.SelectAllButton.Name = "SelectAllButton"
            Me.SelectAllButton.Size = New System.Drawing.Size(80, 52)
            Me.SelectAllButton.TabIndex = 8
            Me.SelectAllButton.Text = "Select All"
            Me.SelectAllButton.UseVisualStyleBackColor = True
            '
            'NumericUpDown1
            '
            Me.NumericUpDown1.Location = New System.Drawing.Point(441, 131)
            Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
            Me.NumericUpDown1.Name = "NumericUpDown1"
            Me.NumericUpDown1.Size = New System.Drawing.Size(72, 20)
            Me.NumericUpDown1.TabIndex = 14
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.Location = New System.Drawing.Point(309, 162)
            Me.Label5.Margin = New System.Windows.Forms.Padding(10, 10, 3, 0)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(101, 13)
            Me.Label5.TabIndex = 12
            Me.Label5.Text = "Select Max Ex Date"
            Me.Label5.Visible = False
            '
            'MaxExDateTimePicker
            '
            Me.MaxExDateTimePicker.CustomFormat = "dd-MMM-yy"
            Me.MaxExDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.MaxExDateTimePicker.Location = New System.Drawing.Point(441, 156)
            Me.MaxExDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
            Me.MaxExDateTimePicker.Name = "MaxExDateTimePicker"
            Me.MaxExDateTimePicker.Size = New System.Drawing.Size(72, 20)
            Me.MaxExDateTimePicker.TabIndex = 11
            Me.MaxExDateTimePicker.Visible = False
            '
            'PrintButton
            '
            Me.PrintButton.Location = New System.Drawing.Point(747, 88)
            Me.PrintButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
            Me.PrintButton.Name = "PrintButton"
            Me.PrintButton.Size = New System.Drawing.Size(75, 52)
            Me.PrintButton.TabIndex = 10
            Me.PrintButton.Text = "&Print"
            Me.PrintButton.UseVisualStyleBackColor = True
            '
            'SplitCheckBox
            '
            Me.SplitCheckBox.BackColor = System.Drawing.Color.Transparent
            Me.SplitCheckBox.Location = New System.Drawing.Point(936, 54)
            Me.SplitCheckBox.Name = "SplitCheckBox"
            Me.SplitCheckBox.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
            Me.SplitCheckBox.Size = New System.Drawing.Size(91, 25)
            Me.SplitCheckBox.TabIndex = 13
            Me.SplitCheckBox.Text = "Allow to split"
            Me.SplitCheckBox.UseVisualStyleBackColor = False
            '
            'AllButton
            '
            Me.AllButton.Location = New System.Drawing.Point(185, 4)
            Me.AllButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
            Me.AllButton.Name = "AllButton"
            Me.AllButton.Size = New System.Drawing.Size(76, 23)
            Me.AllButton.TabIndex = 3
            Me.AllButton.Text = "Show All"
            Me.AllButton.UseVisualStyleBackColor = True
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
            'ResourcesCheckedListBoxControl1
            '
            Me.ResourcesCheckedListBoxControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.ResourcesCheckedListBoxControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.ResourcesCheckedListBoxControl1.Location = New System.Drawing.Point(3, 33)
            Me.ResourcesCheckedListBoxControl1.Name = "ResourcesCheckedListBoxControl1"
            Me.ResourcesCheckedListBoxControl1.SchedulerControl = Me.SchedulerControl1
            Me.ResourcesCheckedListBoxControl1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
            Me.ResourcesCheckedListBoxControl1.Size = New System.Drawing.Size(258, 181)
            Me.ResourcesCheckedListBoxControl1.TabIndex = 0
            '
            'SchedulerControl1
            '
            Me.SchedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline
            Me.SchedulerControl1.DataStorage = Me.SchedulerStorage1
            Me.SchedulerControl1.DateNavigationBar.Visible = False
            Me.SchedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SchedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            Me.SchedulerControl1.LimitInterval.Duration = System.TimeSpan.Parse("1979.23:59:00")
            Me.SchedulerControl1.LimitInterval.Start = New Date(2017, 1, 1, 0, 0, 0, 0)
            Me.SchedulerControl1.Location = New System.Drawing.Point(0, 0)
            Me.SchedulerControl1.LookAndFeel.UseDefaultLookAndFeel = False
            Me.SchedulerControl1.Name = "SchedulerControl1"
            Me.SchedulerControl1.OptionsCustomization.AllowAppointmentConflicts = DevExpress.XtraScheduler.AppointmentConflictsMode.Custom
            Me.SchedulerControl1.OptionsCustomization.AllowInplaceEditor = DevExpress.XtraScheduler.UsedAppointmentType.None
            Me.SchedulerControl1.OptionsView.FirstDayOfWeek = DevExpress.XtraScheduler.FirstDayOfWeek.Saturday
            Me.SchedulerControl1.OptionsView.NavigationButtons.NextCaption = "Next Program"
            Me.SchedulerControl1.OptionsView.NavigationButtons.PrevCaption = "Previous Program"
            Me.SchedulerControl1.OptionsView.ResourceHeaders.RotateCaption = False
            Me.SchedulerControl1.OptionsView.ShowOnlyResourceAppointments = True
            Me.SchedulerControl1.PaintStyleName = "Skin"
            MonthlyPrintStyle1.HeadingsFont = New System.Drawing.Font("Times New Roman", 10.0!)
            MonthlyPrintStyle1.ResourceOptions.ResourcesPerPage = 15
            Me.SchedulerControl1.PrintStyles.Add(DailyPrintStyle1)
            Me.SchedulerControl1.PrintStyles.Add(WeeklyPrintStyle1)
            Me.SchedulerControl1.PrintStyles.Add(MonthlyPrintStyle1)
            Me.SchedulerControl1.PrintStyles.Add(TriFoldPrintStyle1)
            Me.SchedulerControl1.PrintStyles.Add(CalendarDetailsPrintStyle1)
            Me.SchedulerControl1.PrintStyles.Add(MemoPrintStyle1)
            Me.SchedulerControl1.Size = New System.Drawing.Size(1310, 404)
            Me.SchedulerControl1.Start = New Date(2017, 1, 1, 0, 0, 0, 0)
            Me.SchedulerControl1.TabIndex = 3
            Me.SchedulerControl1.Text = "SchedulerControl1"
            Me.SchedulerControl1.ToolTipController = Me.ToolTipController1
            Me.SchedulerControl1.Views.AgendaView.Enabled = False
            Me.SchedulerControl1.Views.DayView.Appearance.HeaderCaption.Options.UseTextOptions = True
            Me.SchedulerControl1.Views.DayView.Appearance.HeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.SchedulerControl1.Views.DayView.Appearance.HeaderCaptionLine.Options.UseTextOptions = True
            Me.SchedulerControl1.Views.DayView.Appearance.HeaderCaptionLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.SchedulerControl1.Views.DayView.Enabled = False
            Me.SchedulerControl1.Views.DayView.ShowWorkTimeOnly = True
            Me.SchedulerControl1.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.SchedulerControl1.Views.DayView.TimeScale = System.TimeSpan.Parse("01:00:00")
            Me.SchedulerControl1.Views.DayView.WorkTime = New DevExpress.XtraScheduler.WorkTimeInterval(System.TimeSpan.Parse("08:00:00"), System.TimeSpan.Parse("18:00:00"))
            Me.SchedulerControl1.Views.GanttView.Enabled = False
            Me.SchedulerControl1.Views.MonthView.AppointmentDisplayOptions.AppointmentAutoHeight = True
            Me.SchedulerControl1.Views.MonthView.AppointmentDisplayOptions.ShowBordersForSameDayAppointments = True
            Me.SchedulerControl1.Views.MonthView.Enabled = False
            Me.SchedulerControl1.Views.MonthView.ResourcesPerPage = 1
            Me.SchedulerControl1.Views.TimelineView.Appearance.Appointment.Font = New System.Drawing.Font("Tahoma", 6.0!)
            Me.SchedulerControl1.Views.TimelineView.Appearance.Appointment.Options.UseFont = True
            Me.SchedulerControl1.Views.TimelineView.Appearance.Appointment.Options.UseTextOptions = True
            Me.SchedulerControl1.Views.TimelineView.Appearance.Appointment.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.SchedulerControl1.Views.TimelineView.AppointmentDisplayOptions.AppointmentAutoHeight = True
            Me.SchedulerControl1.Views.TimelineView.AppointmentDisplayOptions.StatusDisplayType = DevExpress.XtraScheduler.AppointmentStatusDisplayType.Time
            Me.SchedulerControl1.Views.TimelineView.CellsAutoHeightOptions.Enabled = True
            Me.SchedulerControl1.Views.TimelineView.CellsAutoHeightOptions.MinHeight = 100
            Me.SchedulerControl1.Views.TimelineView.ResourcesPerPage = 16
            TimeScaleQuarter1.Enabled = False
            TimeScaleWeek1.Visible = False
            TimeScaleDay1.DisplayFormat = "dd"
            TimeScaleDay1.Width = 35
            TimeScaleHour1.Enabled = False
            TimeScaleFixedInterval1.Enabled = False
            TimeScaleFixedInterval1.Visible = False
            Me.SchedulerControl1.Views.TimelineView.Scales.Add(TimeScaleYear1)
            Me.SchedulerControl1.Views.TimelineView.Scales.Add(TimeScaleQuarter1)
            Me.SchedulerControl1.Views.TimelineView.Scales.Add(TimeScaleMonth1)
            Me.SchedulerControl1.Views.TimelineView.Scales.Add(TimeScaleWeek1)
            Me.SchedulerControl1.Views.TimelineView.Scales.Add(TimeScaleDay1)
            Me.SchedulerControl1.Views.TimelineView.Scales.Add(TimeScaleHour1)
            Me.SchedulerControl1.Views.TimelineView.Scales.Add(TimeScaleFixedInterval1)
            Me.SchedulerControl1.Views.TimelineView.TimelineScrollBarVisible = True
            Me.SchedulerControl1.Views.WeekView.Enabled = False
            Me.SchedulerControl1.Views.WeekView.ResourcesPerPage = 1
            Me.SchedulerControl1.Views.WorkWeekView.Enabled = False
            Me.SchedulerControl1.Views.WorkWeekView.ShowWorkTimeOnly = True
            Me.SchedulerControl1.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            Me.SchedulerControl1.Views.WorkWeekView.WorkTime = New DevExpress.XtraScheduler.WorkTimeInterval(System.TimeSpan.Parse("08:00:00"), System.TimeSpan.Parse("18:00:00"))
            '
            'ToolTipController1
            '
            Me.ToolTipController1.AllowHtmlText = True
            Me.ToolTipController1.CloseOnClick = DevExpress.Utils.DefaultBoolean.[True]
            Me.ToolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
            '
            'OrderLookupTableAdapter
            '
            Me.OrderLookupTableAdapter.ClearBeforeFill = True
            '
            'colIsPrint
            '
            Me.colIsPrint.FieldName = "IsPrint"
            Me.colIsPrint.Name = "colIsPrint"
            Me.colIsPrint.Visible = True
            Me.colIsPrint.VisibleIndex = 0
            '
            'colOrderId
            '
            Me.colOrderId.FieldName = "OrderId"
            Me.colOrderId.Name = "colOrderId"
            '
            'colProgramNo
            '
            Me.colProgramNo.FieldName = "ProgramNo"
            Me.colProgramNo.Name = "colProgramNo"
            Me.colProgramNo.Visible = True
            Me.colProgramNo.VisibleIndex = 1
            '
            'TableAdapterManager
            '
            Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
            Me.TableAdapterManager.Connection = Nothing
            Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SewingOutputBalanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
            '
            'AppointmentDetailsBindingSource
            '
            Me.AppointmentDetailsBindingSource.DataMember = "AppointmentDetails"
            Me.AppointmentDetailsBindingSource.DataSource = Me.PlanningBoardNewDataSet
            '
            'GridControl3
            '
            Me.GridControl3.DataSource = Me.ActivitiesPivotBindingSource
            Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl3.Location = New System.Drawing.Point(3, 3)
            Me.GridControl3.MainView = Me.GridView4
            Me.GridControl3.Name = "GridControl3"
            Me.GridControl3.Size = New System.Drawing.Size(1296, 174)
            Me.GridControl3.TabIndex = 8
            Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
            '
            'ActivitiesPivotBindingSource
            '
            Me.ActivitiesPivotBindingSource.DataMember = "ActivitiesPivot"
            Me.ActivitiesPivotBindingSource.DataSource = Me.ActivitiesPivotDataSet
            '
            'ActivitiesPivotDataSet
            '
            Me.ActivitiesPivotDataSet.DataSetName = "ActivitiesPivotDataSet"
            Me.ActivitiesPivotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'GridView4
            '
            Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colYarn, Me.colFabric, Me.colCutting, Me.colPrinting, Me.colEmbroidery, Me.colSewing, Me.colFinishing, Me.colInspection, Me.colShipment, Me.colPlanning, Me.colAccessories})
            Me.GridView4.GridControl = Me.GridControl3
            Me.GridView4.Name = "GridView4"
            Me.GridView4.OptionsView.ShowGroupPanel = False
            Me.GridView4.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPlanning, DevExpress.Data.ColumnSortOrder.Descending)})
            '
            'colYarn
            '
            Me.colYarn.FieldName = "Yarn Inhouse"
            Me.colYarn.Name = "colYarn"
            Me.colYarn.Visible = True
            Me.colYarn.VisibleIndex = 1
            '
            'colFabric
            '
            Me.colFabric.FieldName = "Fabric Delivery"
            Me.colFabric.Name = "colFabric"
            Me.colFabric.Visible = True
            Me.colFabric.VisibleIndex = 2
            '
            'colCutting
            '
            Me.colCutting.FieldName = "Cutting"
            Me.colCutting.Name = "colCutting"
            Me.colCutting.Visible = True
            Me.colCutting.VisibleIndex = 3
            '
            'colPrinting
            '
            Me.colPrinting.FieldName = "Printing"
            Me.colPrinting.Name = "colPrinting"
            Me.colPrinting.Visible = True
            Me.colPrinting.VisibleIndex = 4
            '
            'colEmbroidery
            '
            Me.colEmbroidery.FieldName = "Embroidery"
            Me.colEmbroidery.Name = "colEmbroidery"
            Me.colEmbroidery.Visible = True
            Me.colEmbroidery.VisibleIndex = 5
            '
            'colSewing
            '
            Me.colSewing.FieldName = "Sewing"
            Me.colSewing.Name = "colSewing"
            Me.colSewing.Visible = True
            Me.colSewing.VisibleIndex = 7
            '
            'colFinishing
            '
            Me.colFinishing.FieldName = "Finishing"
            Me.colFinishing.Name = "colFinishing"
            Me.colFinishing.Visible = True
            Me.colFinishing.VisibleIndex = 8
            '
            'colInspection
            '
            Me.colInspection.FieldName = "Inspection"
            Me.colInspection.Name = "colInspection"
            Me.colInspection.Visible = True
            Me.colInspection.VisibleIndex = 9
            '
            'colShipment
            '
            Me.colShipment.FieldName = "Shipment"
            Me.colShipment.Name = "colShipment"
            Me.colShipment.Visible = True
            Me.colShipment.VisibleIndex = 10
            '
            'colPlanning
            '
            Me.colPlanning.FieldName = "Planning"
            Me.colPlanning.Name = "colPlanning"
            Me.colPlanning.Visible = True
            Me.colPlanning.VisibleIndex = 0
            '
            'colAccessories
            '
            Me.colAccessories.FieldName = "Accessories"
            Me.colAccessories.Name = "colAccessories"
            Me.colAccessories.Visible = True
            Me.colAccessories.VisibleIndex = 6
            '
            'TabControl1
            '
            Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Controls.Add(Me.TabPage3)
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage4)
            Me.TabControl1.Controls.Add(Me.TabPage5)
            Me.TabControl1.Controls.Add(Me.TabPage6)
            Me.TabControl1.Controls.Add(Me.TabPage7)
            Me.TabControl1.Location = New System.Drawing.Point(0, 0)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(1310, 209)
            Me.TabControl1.TabIndex = 0
            '
            'TabPage2
            '
            Me.TabPage2.BackColor = System.Drawing.Color.Transparent
            Me.TabPage2.Controls.Add(Me.SplitContainer2)
            Me.TabPage2.Location = New System.Drawing.Point(4, 25)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(1302, 180)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Planning Balance List"
            '
            'SplitContainer2
            '
            Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
            Me.SplitContainer2.Name = "SplitContainer2"
            '
            'SplitContainer2.Panel1
            '
            Me.SplitContainer2.Panel1.Controls.Add(Me.GridControl2)
            '
            'SplitContainer2.Panel2
            '
            Me.SplitContainer2.Panel2.Controls.Add(Me.ShowPOLinkLabel)
            Me.SplitContainer2.Panel2.Controls.Add(Me.GridControl5)
            Me.SplitContainer2.Size = New System.Drawing.Size(1296, 174)
            Me.SplitContainer2.SplitterDistance = 778
            Me.SplitContainer2.TabIndex = 2
            '
            'GridControl2
            '
            Me.GridControl2.DataSource = Me.PlanningBalanceBySIDBindingSource
            Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl2.Location = New System.Drawing.Point(0, 0)
            Me.GridControl2.MainView = Me.GridView3
            Me.GridControl2.Name = "GridControl2"
            Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit1})
            Me.GridControl2.Size = New System.Drawing.Size(778, 174)
            Me.GridControl2.TabIndex = 0
            Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
            '
            'PlanningBalanceBySIDBindingSource
            '
            Me.PlanningBalanceBySIDBindingSource.DataMember = "PlanningBalanceBySID"
            Me.PlanningBalanceBySIDBindingSource.DataSource = Me.PlanningBalanceDataSet
            '
            'PlanningBalanceDataSet
            '
            Me.PlanningBalanceDataSet.DataSetName = "PlanningBalanceDataSet"
            Me.PlanningBalanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'GridView3
            '
            Me.GridView3.Appearance.HeaderPanel.Options.UseTextOptions = True
            Me.GridView3.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.GridView3.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.GridView3.ColumnPanelRowHeight = 40
            Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderQuantity, Me.colPlanningBalance, Me.colMinEX, Me.colMaxEX, Me.colStartDate, Me.colEndDate, Me.colOrderReceiveDate, Me.colStyleName1, Me.colProgramNo1, Me.colPlanningQuantity1, Me.colSewingBalance, Me.colShipmentBalance})
            Me.GridView3.GridControl = Me.GridControl2
            Me.GridView3.Name = "GridView3"
            Me.GridView3.OptionsView.ColumnAutoWidth = False
            Me.GridView3.OptionsView.ShowAutoFilterRow = True
            Me.GridView3.OptionsView.ShowFooter = True
            Me.GridView3.OptionsView.ShowGroupPanel = False
            '
            'colOrderQuantity
            '
            Me.colOrderQuantity.Caption = "Order Qty with C%"
            Me.colOrderQuantity.FieldName = "OrderQuantity"
            Me.colOrderQuantity.Name = "colOrderQuantity"
            Me.colOrderQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OrderQuantity", "{0:0}")})
            Me.colOrderQuantity.Visible = True
            Me.colOrderQuantity.VisibleIndex = 7
            Me.colOrderQuantity.Width = 79
            '
            'colPlanningBalance
            '
            Me.colPlanningBalance.FieldName = "PlanningBalance"
            Me.colPlanningBalance.Name = "colPlanningBalance"
            Me.colPlanningBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanningBalance", "{0:0}")})
            Me.colPlanningBalance.Visible = True
            Me.colPlanningBalance.VisibleIndex = 11
            Me.colPlanningBalance.Width = 76
            '
            'colMinEX
            '
            Me.colMinEX.FieldName = "MinEX"
            Me.colMinEX.Name = "colMinEX"
            Me.colMinEX.Visible = True
            Me.colMinEX.VisibleIndex = 3
            Me.colMinEX.Width = 74
            '
            'colMaxEX
            '
            Me.colMaxEX.FieldName = "MaxEX"
            Me.colMaxEX.Name = "colMaxEX"
            Me.colMaxEX.Visible = True
            Me.colMaxEX.VisibleIndex = 4
            Me.colMaxEX.Width = 83
            '
            'colStartDate
            '
            Me.colStartDate.Caption = "Sewing TNA Start"
            Me.colStartDate.FieldName = "StartDate"
            Me.colStartDate.Name = "colStartDate"
            Me.colStartDate.Visible = True
            Me.colStartDate.VisibleIndex = 5
            Me.colStartDate.Width = 68
            '
            'colEndDate
            '
            Me.colEndDate.Caption = "Sewing TNA End"
            Me.colEndDate.FieldName = "EndDate"
            Me.colEndDate.Name = "colEndDate"
            Me.colEndDate.Visible = True
            Me.colEndDate.VisibleIndex = 6
            Me.colEndDate.Width = 59
            '
            'colOrderReceiveDate
            '
            Me.colOrderReceiveDate.FieldName = "OrderReceiveDate"
            Me.colOrderReceiveDate.Name = "colOrderReceiveDate"
            Me.colOrderReceiveDate.Visible = True
            Me.colOrderReceiveDate.VisibleIndex = 2
            Me.colOrderReceiveDate.Width = 94
            '
            'colStyleName1
            '
            Me.colStyleName1.FieldName = "StyleName"
            Me.colStyleName1.Name = "colStyleName1"
            Me.colStyleName1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Me.colStyleName1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "StyleName", "{0}")})
            Me.colStyleName1.Visible = True
            Me.colStyleName1.VisibleIndex = 1
            Me.colStyleName1.Width = 117
            '
            'colProgramNo1
            '
            Me.colProgramNo1.FieldName = "ProgramNo"
            Me.colProgramNo1.Name = "colProgramNo1"
            Me.colProgramNo1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Me.colProgramNo1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ProgramNo", "{0}")})
            Me.colProgramNo1.Visible = True
            Me.colProgramNo1.VisibleIndex = 0
            Me.colProgramNo1.Width = 104
            '
            'colPlanningQuantity1
            '
            Me.colPlanningQuantity1.FieldName = "PlanningQuantity"
            Me.colPlanningQuantity1.Name = "colPlanningQuantity1"
            Me.colPlanningQuantity1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanningQuantity", "{0:0}")})
            Me.colPlanningQuantity1.Visible = True
            Me.colPlanningQuantity1.VisibleIndex = 10
            '
            'colSewingBalance
            '
            Me.colSewingBalance.FieldName = "SewingBalance"
            Me.colSewingBalance.Name = "colSewingBalance"
            Me.colSewingBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SewingBalance", "{0:0}")})
            Me.colSewingBalance.Visible = True
            Me.colSewingBalance.VisibleIndex = 8
            '
            'colShipmentBalance
            '
            Me.colShipmentBalance.FieldName = "ShipmentBalance"
            Me.colShipmentBalance.Name = "colShipmentBalance"
            Me.colShipmentBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ShipmentBalance", "{0:0}")})
            Me.colShipmentBalance.Visible = True
            Me.colShipmentBalance.VisibleIndex = 9
            '
            'RepositoryItemHyperLinkEdit1
            '
            Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
            Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
            '
            'ShowPOLinkLabel
            '
            Me.ShowPOLinkLabel.AutoSize = True
            Me.ShowPOLinkLabel.Location = New System.Drawing.Point(12, 5)
            Me.ShowPOLinkLabel.Name = "ShowPOLinkLabel"
            Me.ShowPOLinkLabel.Size = New System.Drawing.Size(149, 13)
            Me.ShowPOLinkLabel.TabIndex = 66
            Me.ShowPOLinkLabel.TabStop = True
            Me.ShowPOLinkLabel.Text = "Show PO Break Down Details"
            '
            'GridControl5
            '
            Me.GridControl5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GridControl5.DataSource = Me.SewingOutputBalancePOwiseBindingSource
            Me.GridControl5.Location = New System.Drawing.Point(0, 21)
            Me.GridControl5.MainView = Me.GridView6
            Me.GridControl5.Name = "GridControl5"
            Me.GridControl5.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit2})
            Me.GridControl5.Size = New System.Drawing.Size(512, 154)
            Me.GridControl5.TabIndex = 1
            Me.GridControl5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6})
            '
            'SewingOutputBalancePOwiseBindingSource
            '
            Me.SewingOutputBalancePOwiseBindingSource.DataMember = "SewingOutputBalance_POwise"
            Me.SewingOutputBalancePOwiseBindingSource.DataSource = Me.SewingOutputBalance_POwiseDataSet
            '
            'SewingOutputBalance_POwiseDataSet
            '
            Me.SewingOutputBalance_POwiseDataSet.DataSetName = "SewingOutputBalance_POwiseDataSet"
            Me.SewingOutputBalance_POwiseDataSet.EnforceConstraints = False
            Me.SewingOutputBalance_POwiseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'GridView6
            '
            Me.GridView6.Appearance.HeaderPanel.Options.UseTextOptions = True
            Me.GridView6.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.GridView6.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.GridView6.ColumnPanelRowHeight = 40
            Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEx, Me.colOrderQuantity2, Me.colOutputQuantity, Me.colSewingBalance1, Me.colPO, Me.colFabricColorName, Me.colSelect, Me.colShipmentBalance1})
            Me.GridView6.GridControl = Me.GridControl5
            Me.GridView6.Name = "GridView6"
            Me.GridView6.OptionsView.ColumnAutoWidth = False
            Me.GridView6.OptionsView.ShowAutoFilterRow = True
            Me.GridView6.OptionsView.ShowFooter = True
            Me.GridView6.OptionsView.ShowGroupPanel = False
            '
            'colEx
            '
            Me.colEx.FieldName = "Ex"
            Me.colEx.Name = "colEx"
            Me.colEx.Visible = True
            Me.colEx.VisibleIndex = 3
            Me.colEx.Width = 103
            '
            'colOrderQuantity2
            '
            Me.colOrderQuantity2.Caption = "Order Qty C%"
            Me.colOrderQuantity2.FieldName = "SewingRequireQuantity"
            Me.colOrderQuantity2.Name = "colOrderQuantity2"
            Me.colOrderQuantity2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SewingRequireQuantity", "{0:0.##}")})
            Me.colOrderQuantity2.Visible = True
            Me.colOrderQuantity2.VisibleIndex = 4
            '
            'colOutputQuantity
            '
            Me.colOutputQuantity.FieldName = "OutputQuantity"
            Me.colOutputQuantity.Name = "colOutputQuantity"
            Me.colOutputQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OutputQuantity", "{0:0.##}")})
            Me.colOutputQuantity.Visible = True
            Me.colOutputQuantity.VisibleIndex = 5
            '
            'colSewingBalance1
            '
            Me.colSewingBalance1.FieldName = "SewingBalance"
            Me.colSewingBalance1.Name = "colSewingBalance1"
            Me.colSewingBalance1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SewingBalance", "{0:0.##}")})
            Me.colSewingBalance1.Visible = True
            Me.colSewingBalance1.VisibleIndex = 6
            '
            'colPO
            '
            Me.colPO.FieldName = "PO"
            Me.colPO.Name = "colPO"
            Me.colPO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PO", "{0}")})
            Me.colPO.Visible = True
            Me.colPO.VisibleIndex = 1
            Me.colPO.Width = 127
            '
            'colFabricColorName
            '
            Me.colFabricColorName.FieldName = "FabricColorName"
            Me.colFabricColorName.Name = "colFabricColorName"
            Me.colFabricColorName.Visible = True
            Me.colFabricColorName.VisibleIndex = 2
            Me.colFabricColorName.Width = 96
            '
            'colSelect
            '
            Me.colSelect.Caption = "Select"
            Me.colSelect.FieldName = "Select"
            Me.colSelect.Name = "colSelect"
            Me.colSelect.Visible = True
            Me.colSelect.VisibleIndex = 0
            Me.colSelect.Width = 41
            '
            'colShipmentBalance1
            '
            Me.colShipmentBalance1.FieldName = "ShipmentBalance"
            Me.colShipmentBalance1.Name = "colShipmentBalance1"
            Me.colShipmentBalance1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ShipmentBalance", "{0:0.##}")})
            Me.colShipmentBalance1.Visible = True
            Me.colShipmentBalance1.VisibleIndex = 7
            '
            'RepositoryItemHyperLinkEdit2
            '
            Me.RepositoryItemHyperLinkEdit2.AutoHeight = False
            Me.RepositoryItemHyperLinkEdit2.Name = "RepositoryItemHyperLinkEdit2"
            '
            'TabPage3
            '
            Me.TabPage3.Controls.Add(Me.GridControl4)
            Me.TabPage3.Location = New System.Drawing.Point(4, 25)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage3.Size = New System.Drawing.Size(1302, 180)
            Me.TabPage3.TabIndex = 2
            Me.TabPage3.Text = "Planning List"
            Me.TabPage3.UseVisualStyleBackColor = True
            '
            'GridControl4
            '
            Me.GridControl4.DataSource = Me.AppointmentsLogBindingSource
            Me.GridControl4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl4.Location = New System.Drawing.Point(3, 3)
            Me.GridControl4.MainView = Me.GridView5
            Me.GridControl4.Name = "GridControl4"
            Me.GridControl4.Size = New System.Drawing.Size(1296, 174)
            Me.GridControl4.TabIndex = 0
            Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
            '
            'AppointmentsLogBindingSource
            '
            Me.AppointmentsLogBindingSource.DataMember = "AppointmentsLog"
            Me.AppointmentsLogBindingSource.DataSource = Me.AppointmentsLogDataSet
            '
            'AppointmentsLogDataSet
            '
            Me.AppointmentsLogDataSet.DataSetName = "AppointmentsLogDataSet"
            Me.AppointmentsLogDataSet.EnforceConstraints = False
            Me.AppointmentsLogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'GridView5
            '
            Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgramNo2, Me.colSubject1, Me.colStyleName, Me.colCreatedOn, Me.colLine1, Me.colStartDate2, Me.colEndDate2, Me.colOrderQuantity1, Me.colPlanningQuantity, Me.colMaxEX1, Me.colMinEX1, Me.colAppointmentId})
            Me.GridView5.GridControl = Me.GridControl4
            Me.GridView5.Name = "GridView5"
            Me.GridView5.OptionsView.ShowAutoFilterRow = True
            Me.GridView5.OptionsView.ShowFooter = True
            Me.GridView5.OptionsView.ShowGroupPanel = False
            '
            'colProgramNo2
            '
            Me.colProgramNo2.FieldName = "ProgramNo"
            Me.colProgramNo2.Name = "colProgramNo2"
            Me.colProgramNo2.Visible = True
            Me.colProgramNo2.VisibleIndex = 2
            Me.colProgramNo2.Width = 116
            '
            'colSubject1
            '
            Me.colSubject1.FieldName = "Subject"
            Me.colSubject1.Name = "colSubject1"
            Me.colSubject1.Visible = True
            Me.colSubject1.VisibleIndex = 4
            Me.colSubject1.Width = 111
            '
            'colStyleName
            '
            Me.colStyleName.FieldName = "StyleName"
            Me.colStyleName.Name = "colStyleName"
            Me.colStyleName.Visible = True
            Me.colStyleName.VisibleIndex = 5
            Me.colStyleName.Width = 111
            '
            'colCreatedOn
            '
            Me.colCreatedOn.FieldName = "CreatedOn"
            Me.colCreatedOn.Name = "colCreatedOn"
            Me.colCreatedOn.Visible = True
            Me.colCreatedOn.VisibleIndex = 1
            Me.colCreatedOn.Width = 99
            '
            'colLine1
            '
            Me.colLine1.FieldName = "Line"
            Me.colLine1.Name = "colLine1"
            Me.colLine1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            Me.colLine1.Visible = True
            Me.colLine1.VisibleIndex = 3
            Me.colLine1.Width = 117
            '
            'colStartDate2
            '
            Me.colStartDate2.Caption = "Start"
            Me.colStartDate2.FieldName = "StartDate"
            Me.colStartDate2.Name = "colStartDate2"
            Me.colStartDate2.Visible = True
            Me.colStartDate2.VisibleIndex = 8
            Me.colStartDate2.Width = 91
            '
            'colEndDate2
            '
            Me.colEndDate2.Caption = "End"
            Me.colEndDate2.FieldName = "EndDate"
            Me.colEndDate2.Name = "colEndDate2"
            Me.colEndDate2.Visible = True
            Me.colEndDate2.VisibleIndex = 9
            Me.colEndDate2.Width = 91
            '
            'colOrderQuantity1
            '
            Me.colOrderQuantity1.FieldName = "OrderQuantity"
            Me.colOrderQuantity1.Name = "colOrderQuantity1"
            Me.colOrderQuantity1.Visible = True
            Me.colOrderQuantity1.VisibleIndex = 10
            Me.colOrderQuantity1.Width = 91
            '
            'colPlanningQuantity
            '
            Me.colPlanningQuantity.FieldName = "PlanningQuantity"
            Me.colPlanningQuantity.Name = "colPlanningQuantity"
            Me.colPlanningQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanningQuantity", "{0:0}")})
            Me.colPlanningQuantity.Visible = True
            Me.colPlanningQuantity.VisibleIndex = 11
            Me.colPlanningQuantity.Width = 134
            '
            'colMaxEX1
            '
            Me.colMaxEX1.FieldName = "MaxEX"
            Me.colMaxEX1.Name = "colMaxEX1"
            Me.colMaxEX1.Visible = True
            Me.colMaxEX1.VisibleIndex = 6
            Me.colMaxEX1.Width = 132
            '
            'colMinEX1
            '
            Me.colMinEX1.FieldName = "MinEX"
            Me.colMinEX1.Name = "colMinEX1"
            Me.colMinEX1.Visible = True
            Me.colMinEX1.VisibleIndex = 7
            Me.colMinEX1.Width = 132
            '
            'colAppointmentId
            '
            Me.colAppointmentId.Caption = "Planning No"
            Me.colAppointmentId.FieldName = "AppointmentId"
            Me.colAppointmentId.Name = "colAppointmentId"
            Me.colAppointmentId.Visible = True
            Me.colAppointmentId.VisibleIndex = 0
            Me.colAppointmentId.Width = 93
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.InlineCheckBox)
            Me.TabPage1.Controls.Add(Me.DateNavigator1)
            Me.TabPage1.Controls.Add(Me.Label3)
            Me.TabPage1.Controls.Add(Me.Label5)
            Me.TabPage1.Controls.Add(Me.Label16)
            Me.TabPage1.Controls.Add(Me.Label2)
            Me.TabPage1.Controls.Add(Me.Label6)
            Me.TabPage1.Controls.Add(Me.MaxExDateTimePicker)
            Me.TabPage1.Controls.Add(Me.Label1)
            Me.TabPage1.Controls.Add(Me.PrintButton)
            Me.TabPage1.Controls.Add(Me.GridLookUpEdit1)
            Me.TabPage1.Controls.Add(Me.ResourcesCheckedListBoxControl1)
            Me.TabPage1.Controls.Add(Me.Button1)
            Me.TabPage1.Controls.Add(Me.ShowByPrgButton)
            Me.TabPage1.Controls.Add(Me.ShowByPNButton)
            Me.TabPage1.Controls.Add(Me.ShowAllButton)
            Me.TabPage1.Controls.Add(Me.ComboBox1)
            Me.TabPage1.Controls.Add(Me.DateTimePicker1)
            Me.TabPage1.Controls.Add(Me.AllButton)
            Me.TabPage1.Controls.Add(Me.DateTimePicker2)
            Me.TabPage1.Controls.Add(Me.SelectAllButton)
            Me.TabPage1.Controls.Add(Me.NumericUpDown1)
            Me.TabPage1.Location = New System.Drawing.Point(4, 25)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(1302, 180)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Filter And Selection"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'InlineCheckBox
            '
            Me.InlineCheckBox.AutoSize = True
            Me.InlineCheckBox.Location = New System.Drawing.Point(548, 132)
            Me.InlineCheckBox.Name = "InlineCheckBox"
            Me.InlineCheckBox.Size = New System.Drawing.Size(70, 17)
            Me.InlineCheckBox.TabIndex = 20
            Me.InlineCheckBox.Text = "inline edit"
            Me.InlineCheckBox.UseVisualStyleBackColor = True
            '
            'DateNavigator1
            '
            Me.DateNavigator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.DateNavigator1.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold
            Me.DateNavigator1.CalendarAppearance.DayCellSpecial.Options.UseFont = True
            Me.DateNavigator1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.DateNavigator1.Cursor = System.Windows.Forms.Cursors.Default
            Me.DateNavigator1.DateTime = New Date(2018, 12, 14, 0, 0, 0, 0)
            Me.DateNavigator1.EditValue = New Date(2018, 12, 14, 0, 0, 0, 0)
            Me.DateNavigator1.FirstDayOfWeek = System.DayOfWeek.Saturday
            Me.DateNavigator1.Location = New System.Drawing.Point(836, 4)
            Me.DateNavigator1.Name = "DateNavigator1"
            Me.DateNavigator1.SchedulerControl = Me.SchedulerControl1
            Me.DateNavigator1.Size = New System.Drawing.Size(463, 172)
            Me.DateNavigator1.TabIndex = 15
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Location = New System.Drawing.Point(309, 133)
            Me.Label3.Margin = New System.Windows.Forms.Padding(10, 10, 3, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(126, 13)
            Me.Label3.TabIndex = 12
            Me.Label3.Text = "Set Planning Row Height"
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.BackColor = System.Drawing.Color.Transparent
            Me.Label16.Location = New System.Drawing.Point(522, 93)
            Me.Label16.Margin = New System.Windows.Forms.Padding(10, 10, 3, 0)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(25, 13)
            Me.Label16.TabIndex = 7
            Me.Label16.Text = "to  :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Location = New System.Drawing.Point(309, 93)
            Me.Label2.Margin = New System.Windows.Forms.Padding(10, 10, 3, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(109, 13)
            Me.Label2.TabIndex = 7
            Me.Label2.Text = "Planning Date From  :"
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(747, 28)
            Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(75, 39)
            Me.Button1.TabIndex = 8
            Me.Button1.Text = "Show All"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'ShowByPrgButton
            '
            Me.ShowByPrgButton.Location = New System.Drawing.Point(553, 28)
            Me.ShowByPrgButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
            Me.ShowByPrgButton.Name = "ShowByPrgButton"
            Me.ShowByPrgButton.Size = New System.Drawing.Size(78, 39)
            Me.ShowByPrgButton.TabIndex = 8
            Me.ShowByPrgButton.Text = "Show by Program No"
            Me.ShowByPrgButton.UseVisualStyleBackColor = True
            '
            'ShowByPNButton
            '
            Me.ShowByPNButton.Location = New System.Drawing.Point(481, 28)
            Me.ShowByPNButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
            Me.ShowByPNButton.Name = "ShowByPNButton"
            Me.ShowByPNButton.Size = New System.Drawing.Size(66, 39)
            Me.ShowByPNButton.TabIndex = 8
            Me.ShowByPNButton.Text = "Show by P. No"
            Me.ShowByPNButton.UseVisualStyleBackColor = True
            '
            'TabPage4
            '
            Me.TabPage4.Controls.Add(Me.ShowStatusButton)
            Me.TabPage4.Controls.Add(Me.StatusByComboBox)
            Me.TabPage4.Controls.Add(Me.Label14)
            Me.TabPage4.Controls.Add(Me.OrangeLabel)
            Me.TabPage4.Controls.Add(Me.Label9)
            Me.TabPage4.Controls.Add(Me.Label13)
            Me.TabPage4.Controls.Add(Me.Label11)
            Me.TabPage4.Controls.Add(Me.Label12)
            Me.TabPage4.Controls.Add(Me.GreenLabel)
            Me.TabPage4.Controls.Add(Me.Label10)
            Me.TabPage4.Controls.Add(Me.YellowLabel)
            Me.TabPage4.Controls.Add(Me.BlueLabel)
            Me.TabPage4.Location = New System.Drawing.Point(4, 25)
            Me.TabPage4.Name = "TabPage4"
            Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage4.Size = New System.Drawing.Size(1302, 180)
            Me.TabPage4.TabIndex = 3
            Me.TabPage4.Text = "Status"
            Me.TabPage4.UseVisualStyleBackColor = True
            '
            'ShowStatusButton
            '
            Me.ShowStatusButton.Location = New System.Drawing.Point(86, 45)
            Me.ShowStatusButton.Name = "ShowStatusButton"
            Me.ShowStatusButton.Size = New System.Drawing.Size(183, 23)
            Me.ShowStatusButton.TabIndex = 18
            Me.ShowStatusButton.Text = "Show"
            Me.ShowStatusButton.UseVisualStyleBackColor = True
            '
            'StatusByComboBox
            '
            Me.StatusByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.StatusByComboBox.FormattingEnabled = True
            Me.StatusByComboBox.Items.AddRange(New Object() {"Planning", "Style Type", "Production", ""})
            Me.StatusByComboBox.Location = New System.Drawing.Point(86, 20)
            Me.StatusByComboBox.Name = "StatusByComboBox"
            Me.StatusByComboBox.Size = New System.Drawing.Size(183, 21)
            Me.StatusByComboBox.TabIndex = 17
            '
            'Label14
            '
            Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Label14.ForeColor = System.Drawing.Color.White
            Me.Label14.Location = New System.Drawing.Point(335, 20)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(24, 21)
            Me.Label14.TabIndex = 16
            Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'OrangeLabel
            '
            Me.OrangeLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.OrangeLabel.BackColor = System.Drawing.Color.Transparent
            Me.OrangeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.OrangeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.OrangeLabel.Location = New System.Drawing.Point(382, 20)
            Me.OrangeLabel.Name = "OrangeLabel"
            Me.OrangeLabel.Size = New System.Drawing.Size(107, 21)
            Me.OrangeLabel.TabIndex = 16
            Me.OrangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(22, 23)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(58, 13)
            Me.Label9.TabIndex = 15
            Me.Label9.Text = "Status By :"
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Label13.ForeColor = System.Drawing.Color.White
            Me.Label13.Location = New System.Drawing.Point(336, 100)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(24, 21)
            Me.Label13.TabIndex = 16
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(283, 23)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(46, 13)
            Me.Label11.TabIndex = 15
            Me.Label11.Text = " Status :"
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.Yellow
            Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Label12.Location = New System.Drawing.Point(335, 46)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(24, 21)
            Me.Label12.TabIndex = 16
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'GreenLabel
            '
            Me.GreenLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GreenLabel.BackColor = System.Drawing.Color.Transparent
            Me.GreenLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.GreenLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.GreenLabel.Location = New System.Drawing.Point(382, 98)
            Me.GreenLabel.Name = "GreenLabel"
            Me.GreenLabel.Size = New System.Drawing.Size(107, 21)
            Me.GreenLabel.TabIndex = 16
            Me.GreenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.Blue
            Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Label10.Location = New System.Drawing.Point(336, 76)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(24, 21)
            Me.Label10.TabIndex = 16
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'YellowLabel
            '
            Me.YellowLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.YellowLabel.BackColor = System.Drawing.Color.Transparent
            Me.YellowLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.YellowLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.YellowLabel.Location = New System.Drawing.Point(382, 46)
            Me.YellowLabel.Name = "YellowLabel"
            Me.YellowLabel.Size = New System.Drawing.Size(107, 21)
            Me.YellowLabel.TabIndex = 16
            Me.YellowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'BlueLabel
            '
            Me.BlueLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BlueLabel.BackColor = System.Drawing.Color.Transparent
            Me.BlueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BlueLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.BlueLabel.Location = New System.Drawing.Point(382, 72)
            Me.BlueLabel.Name = "BlueLabel"
            Me.BlueLabel.Size = New System.Drawing.Size(107, 21)
            Me.BlueLabel.TabIndex = 16
            Me.BlueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'TabPage5
            '
            Me.TabPage5.Controls.Add(Me.GridControl3)
            Me.TabPage5.Location = New System.Drawing.Point(4, 25)
            Me.TabPage5.Name = "TabPage5"
            Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage5.Size = New System.Drawing.Size(1302, 180)
            Me.TabPage5.TabIndex = 4
            Me.TabPage5.Text = "Time And Action"
            Me.TabPage5.UseVisualStyleBackColor = True
            '
            'TabPage6
            '
            Me.TabPage6.Controls.Add(Me.PivotGridControl1)
            Me.TabPage6.Location = New System.Drawing.Point(4, 25)
            Me.TabPage6.Name = "TabPage6"
            Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage6.Size = New System.Drawing.Size(1302, 180)
            Me.TabPage6.TabIndex = 5
            Me.TabPage6.Text = "LC Breakdown"
            Me.TabPage6.UseVisualStyleBackColor = True
            '
            'PivotGridControl1
            '
            Me.PivotGridControl1.DataSource = Me.AppointmentDetailsBindingSource
            Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldDaySerial1, Me.fieldPlanningDate1, Me.fieldEfficiency1, Me.fieldPlanningQuantity1})
            Me.PivotGridControl1.Location = New System.Drawing.Point(3, 3)
            Me.PivotGridControl1.Name = "PivotGridControl1"
            Me.PivotGridControl1.OptionsView.ShowColumnHeaders = False
            Me.PivotGridControl1.OptionsView.ShowColumnTotals = False
            Me.PivotGridControl1.OptionsView.ShowDataHeaders = False
            Me.PivotGridControl1.OptionsView.ShowFilterHeaders = False
            Me.PivotGridControl1.OptionsView.ShowRowHeaders = False
            Me.PivotGridControl1.Size = New System.Drawing.Size(1296, 174)
            Me.PivotGridControl1.TabIndex = 1
            '
            'fieldDaySerial1
            '
            Me.fieldDaySerial1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldDaySerial1.AreaIndex = 0
            Me.fieldDaySerial1.CellFormat.FormatString = "n0"
            Me.fieldDaySerial1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldDaySerial1.FieldName = "DaySerial"
            Me.fieldDaySerial1.Name = "fieldDaySerial1"
            '
            'fieldPlanningDate1
            '
            Me.fieldPlanningDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldPlanningDate1.AreaIndex = 1
            Me.fieldPlanningDate1.CellFormat.FormatString = "dd-MMM-yy"
            Me.fieldPlanningDate1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.fieldPlanningDate1.FieldName = "PlanningDate"
            Me.fieldPlanningDate1.Name = "fieldPlanningDate1"
            Me.fieldPlanningDate1.ValueFormat.FormatString = "dd-MMM-yy"
            Me.fieldPlanningDate1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
            '
            'fieldEfficiency1
            '
            Me.fieldEfficiency1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldEfficiency1.AreaIndex = 0
            Me.fieldEfficiency1.Caption = "Eff%"
            Me.fieldEfficiency1.CellFormat.FormatString = "n0"
            Me.fieldEfficiency1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.fieldEfficiency1.FieldName = "Efficiency"
            Me.fieldEfficiency1.Name = "fieldEfficiency1"
            Me.fieldEfficiency1.Width = 50
            '
            'fieldPlanningQuantity1
            '
            Me.fieldPlanningQuantity1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldPlanningQuantity1.AreaIndex = 1
            Me.fieldPlanningQuantity1.Caption = "P. Qty"
            Me.fieldPlanningQuantity1.CellFormat.FormatString = "n0"
            Me.fieldPlanningQuantity1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.fieldPlanningQuantity1.FieldName = "PlanningQuantity"
            Me.fieldPlanningQuantity1.Name = "fieldPlanningQuantity1"
            Me.fieldPlanningQuantity1.Width = 50
            '
            'TabPage7
            '
            Me.TabPage7.Controls.Add(Me.GridControl1)
            Me.TabPage7.Location = New System.Drawing.Point(4, 25)
            Me.TabPage7.Name = "TabPage7"
            Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage7.Size = New System.Drawing.Size(1302, 180)
            Me.TabPage7.TabIndex = 6
            Me.TabPage7.Text = "WH Brackdown"
            Me.TabPage7.UseVisualStyleBackColor = True
            '
            'GridControl1
            '
            Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GridControl1.DataSource = Me.AppointmentDetailsBindingSource
            Me.GridControl1.Location = New System.Drawing.Point(3, 3)
            Me.GridControl1.MainView = Me.GridView2
            Me.GridControl1.Name = "GridControl1"
            Me.GridControl1.Size = New System.Drawing.Size(1298, 173)
            Me.GridControl1.TabIndex = 0
            Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
            '
            'GridView2
            '
            Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRemarks, Me.colDaySerial, Me.colPlanningDate, Me.colEfficiency, Me.colPlanningQuantity2, Me.colTarget, Me.colWH})
            Me.GridView2.GridControl = Me.GridControl1
            Me.GridView2.Name = "GridView2"
            Me.GridView2.OptionsView.ShowFooter = True
            Me.GridView2.OptionsView.ShowGroupPanel = False
            '
            'colRemarks
            '
            Me.colRemarks.FieldName = "Remarks"
            Me.colRemarks.Name = "colRemarks"
            Me.colRemarks.Visible = True
            Me.colRemarks.VisibleIndex = 6
            Me.colRemarks.Width = 860
            '
            'colDaySerial
            '
            Me.colDaySerial.FieldName = "DaySerial"
            Me.colDaySerial.Name = "colDaySerial"
            Me.colDaySerial.OptionsColumn.FixedWidth = True
            Me.colDaySerial.Visible = True
            Me.colDaySerial.VisibleIndex = 0
            Me.colDaySerial.Width = 83
            '
            'colPlanningDate
            '
            Me.colPlanningDate.FieldName = "PlanningDate"
            Me.colPlanningDate.Name = "colPlanningDate"
            Me.colPlanningDate.OptionsColumn.FixedWidth = True
            Me.colPlanningDate.Visible = True
            Me.colPlanningDate.VisibleIndex = 1
            Me.colPlanningDate.Width = 94
            '
            'colEfficiency
            '
            Me.colEfficiency.FieldName = "Efficiency"
            Me.colEfficiency.Name = "colEfficiency"
            Me.colEfficiency.OptionsColumn.FixedWidth = True
            Me.colEfficiency.Visible = True
            Me.colEfficiency.VisibleIndex = 2
            Me.colEfficiency.Width = 72
            '
            'colPlanningQuantity2
            '
            Me.colPlanningQuantity2.FieldName = "PlanningQuantity"
            Me.colPlanningQuantity2.Name = "colPlanningQuantity2"
            Me.colPlanningQuantity2.OptionsColumn.FixedWidth = True
            Me.colPlanningQuantity2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanningQuantity", "{0:0.##}")})
            Me.colPlanningQuantity2.Visible = True
            Me.colPlanningQuantity2.VisibleIndex = 3
            Me.colPlanningQuantity2.Width = 99
            '
            'colTarget
            '
            Me.colTarget.FieldName = "Target"
            Me.colTarget.Name = "colTarget"
            Me.colTarget.OptionsColumn.FixedWidth = True
            Me.colTarget.Visible = True
            Me.colTarget.VisibleIndex = 4
            Me.colTarget.Width = 60
            '
            'colWH
            '
            Me.colWH.FieldName = "WH"
            Me.colWH.Name = "colWH"
            Me.colWH.OptionsColumn.FixedWidth = True
            Me.colWH.Visible = True
            Me.colWH.VisibleIndex = 5
            Me.colWH.Width = 50
            '
            'dtEnd
            '
            Me.dtEnd.EditValue = New Date(2005, 11, 25, 0, 0, 0, 0)
            Me.dtEnd.Location = New System.Drawing.Point(367, 26)
            Me.dtEnd.Name = "dtEnd"
            Me.dtEnd.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.dtEnd.Properties.Appearance.Options.UseBackColor = True
            Me.dtEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dtEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dtEnd.Size = New System.Drawing.Size(78, 20)
            Me.dtEnd.TabIndex = 62
            '
            'dtStart
            '
            Me.dtStart.EditValue = New Date(2005, 11, 25, 0, 0, 0, 0)
            Me.dtStart.Location = New System.Drawing.Point(367, 4)
            Me.dtStart.Name = "dtStart"
            Me.dtStart.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.dtStart.Properties.Appearance.Options.UseBackColor = True
            Me.dtStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dtStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dtStart.Size = New System.Drawing.Size(77, 20)
            Me.dtStart.TabIndex = 61
            '
            'Label28
            '
            Me.Label28.Location = New System.Drawing.Point(330, 5)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(36, 19)
            Me.Label28.TabIndex = 60
            Me.Label28.Text = "Start : :"
            '
            'Label27
            '
            Me.Label27.Location = New System.Drawing.Point(331, 27)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(36, 19)
            Me.Label27.TabIndex = 60
            Me.Label27.Text = "End :"
            '
            'Label26
            '
            Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label26.Location = New System.Drawing.Point(447, 5)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(36, 19)
            Me.Label26.TabIndex = 60
            Me.Label26.Text = "Line :"
            '
            'LineGridLookupEdit
            '
            Me.LineGridLookupEdit.Location = New System.Drawing.Point(487, 4)
            Me.LineGridLookupEdit.Name = "LineGridLookupEdit"
            Me.LineGridLookupEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.LineGridLookupEdit.Properties.Appearance.Options.UseBackColor = True
            Me.LineGridLookupEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.LineGridLookupEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Line", "Line", 29, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
            Me.LineGridLookupEdit.Properties.DataSource = Me.LineBindingSource
            Me.LineGridLookupEdit.Properties.DisplayMember = "Line"
            Me.LineGridLookupEdit.Properties.NullText = ""
            Me.LineGridLookupEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
            Me.LineGridLookupEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            Me.LineGridLookupEdit.Properties.ValueMember = "LineId"
            Me.LineGridLookupEdit.Size = New System.Drawing.Size(60, 20)
            Me.LineGridLookupEdit.TabIndex = 59
            '
            'AddToPQtyLinkLabel
            '
            Me.AddToPQtyLinkLabel.AutoSize = True
            Me.AddToPQtyLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
            Me.AddToPQtyLinkLabel.Location = New System.Drawing.Point(915, 29)
            Me.AddToPQtyLinkLabel.Name = "AddToPQtyLinkLabel"
            Me.AddToPQtyLinkLabel.Size = New System.Drawing.Size(19, 13)
            Me.AddToPQtyLinkLabel.TabIndex = 1
            Me.AddToPQtyLinkLabel.TabStop = True
            Me.AddToPQtyLinkLabel.Text = ">>"
            '
            'RedoLinkLabel
            '
            Me.RedoLinkLabel.AutoSize = True
            Me.RedoLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
            Me.RedoLinkLabel.Location = New System.Drawing.Point(1203, 10)
            Me.RedoLinkLabel.Name = "RedoLinkLabel"
            Me.RedoLinkLabel.Size = New System.Drawing.Size(53, 13)
            Me.RedoLinkLabel.TabIndex = 1
            Me.RedoLinkLabel.TabStop = True
            Me.RedoLinkLabel.Text = "||  Redo  ||"
            '
            'UndoLinkLabel
            '
            Me.UndoLinkLabel.AutoSize = True
            Me.UndoLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
            Me.UndoLinkLabel.Location = New System.Drawing.Point(1203, 29)
            Me.UndoLinkLabel.Name = "UndoLinkLabel"
            Me.UndoLinkLabel.Size = New System.Drawing.Size(53, 13)
            Me.UndoLinkLabel.TabIndex = 1
            Me.UndoLinkLabel.TabStop = True
            Me.UndoLinkLabel.Text = "||  Undo  ||"
            '
            'SCLGridLookUpEdit
            '
            Me.SCLGridLookUpEdit.Location = New System.Drawing.Point(487, 26)
            Me.SCLGridLookUpEdit.Name = "SCLGridLookUpEdit"
            Me.SCLGridLookUpEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.SCLGridLookUpEdit.Properties.Appearance.Options.UseBackColor = True
            Me.SCLGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.SCLGridLookUpEdit.Properties.DataSource = Me.SCLStyleTypeLookupBindingSource
            Me.SCLGridLookUpEdit.Properties.DisplayMember = "StyleType"
            Me.SCLGridLookUpEdit.Properties.NullText = ""
            Me.SCLGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
            Me.SCLGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            Me.SCLGridLookUpEdit.Properties.ValueMember = "StyleType"
            Me.SCLGridLookUpEdit.Size = New System.Drawing.Size(61, 20)
            Me.SCLGridLookUpEdit.TabIndex = 38
            '
            'SCLStyleTypeLookupBindingSource
            '
            Me.SCLStyleTypeLookupBindingSource.DataMember = "SCLStyleTypeLookup"
            Me.SCLStyleTypeLookupBindingSource.DataSource = Me.SewingCustomLearningCurveDataSet
            '
            'SewingCustomLearningCurveDataSet
            '
            Me.SewingCustomLearningCurveDataSet.DataSetName = "SewingCustomLearningCurveDataSet"
            Me.SewingCustomLearningCurveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'GridLookUpEdit1View
            '
            Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
            Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
            '
            'PQtyLinkLabel
            '
            Me.PQtyLinkLabel.AutoSize = True
            Me.PQtyLinkLabel.Location = New System.Drawing.Point(933, 9)
            Me.PQtyLinkLabel.Name = "PQtyLinkLabel"
            Me.PQtyLinkLabel.Size = New System.Drawing.Size(42, 13)
            Me.PQtyLinkLabel.TabIndex = 37
            Me.PQtyLinkLabel.TabStop = True
            Me.PQtyLinkLabel.Text = "P. Qty :"
            '
            'ProgramNoLinkLabel
            '
            Me.ProgramNoLinkLabel.AutoSize = True
            Me.ProgramNoLinkLabel.Location = New System.Drawing.Point(113, 8)
            Me.ProgramNoLinkLabel.Name = "ProgramNoLinkLabel"
            Me.ProgramNoLinkLabel.Size = New System.Drawing.Size(66, 13)
            Me.ProgramNoLinkLabel.TabIndex = 37
            Me.ProgramNoLinkLabel.TabStop = True
            Me.ProgramNoLinkLabel.Text = "Program No:"
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.Location = New System.Drawing.Point(113, 63)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(42, 14)
            Me.Label25.TabIndex = 35
            Me.Label25.Text = "P. No : "
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.Location = New System.Drawing.Point(730, 30)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(44, 14)
            Me.Label19.TabIndex = 35
            Me.Label19.Text = "P. Bal. :"
            '
            'PicturePictureEdit
            '
            Me.PicturePictureEdit.Cursor = System.Windows.Forms.Cursors.Default
            Me.PicturePictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "Picture", True))
            Me.PicturePictureEdit.Location = New System.Drawing.Point(5, 1)
            Me.PicturePictureEdit.Name = "PicturePictureEdit"
            Me.PicturePictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
            Me.PicturePictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
            Me.PicturePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
            Me.PicturePictureEdit.Size = New System.Drawing.Size(102, 74)
            Me.PicturePictureEdit.TabIndex = 32
            '
            'StyleBindingSource
            '
            Me.StyleBindingSource.DataMember = "Style"
            Me.StyleBindingSource.DataSource = Me.StyleDataSet
            '
            'StyleDataSet
            '
            Me.StyleDataSet.DataSetName = "StyleDataSet"
            Me.StyleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'MCTextBox
            '
            Me.MCTextBox.BackColor = System.Drawing.Color.Yellow
            Me.MCTextBox.Location = New System.Drawing.Point(676, 26)
            Me.MCTextBox.Name = "MCTextBox"
            Me.MCTextBox.Size = New System.Drawing.Size(48, 20)
            Me.MCTextBox.TabIndex = 33
            '
            'StyleTextBox
            '
            Me.StyleTextBox.BackColor = System.Drawing.Color.White
            Me.StyleTextBox.Location = New System.Drawing.Point(176, 25)
            Me.StyleTextBox.Multiline = True
            Me.StyleTextBox.Name = "StyleTextBox"
            Me.StyleTextBox.ReadOnly = True
            Me.StyleTextBox.Size = New System.Drawing.Size(141, 27)
            Me.StyleTextBox.TabIndex = 33
            '
            'ProgNoTextBox
            '
            Me.ProgNoTextBox.BackColor = System.Drawing.Color.White
            Me.ProgNoTextBox.Location = New System.Drawing.Point(176, 3)
            Me.ProgNoTextBox.Name = "ProgNoTextBox"
            Me.ProgNoTextBox.ReadOnly = True
            Me.ProgNoTextBox.Size = New System.Drawing.Size(141, 20)
            Me.ProgNoTextBox.TabIndex = 33
            '
            'LCSDTextBox
            '
            Me.LCSDTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.LCSDTextBox.Location = New System.Drawing.Point(598, 26)
            Me.LCSDTextBox.Name = "LCSDTextBox"
            Me.LCSDTextBox.Size = New System.Drawing.Size(37, 20)
            Me.LCSDTextBox.TabIndex = 33
            Me.LCSDTextBox.Text = "1"
            '
            'WHDTextBox
            '
            Me.WHDTextBox.BackColor = System.Drawing.Color.Yellow
            Me.WHDTextBox.Location = New System.Drawing.Point(599, 4)
            Me.WHDTextBox.Name = "WHDTextBox"
            Me.WHDTextBox.Size = New System.Drawing.Size(36, 20)
            Me.WHDTextBox.TabIndex = 33
            '
            'SMVTextBox
            '
            Me.SMVTextBox.BackColor = System.Drawing.Color.Yellow
            Me.SMVTextBox.Location = New System.Drawing.Point(676, 4)
            Me.SMVTextBox.Name = "SMVTextBox"
            Me.SMVTextBox.Size = New System.Drawing.Size(48, 20)
            Me.SMVTextBox.TabIndex = 33
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.Location = New System.Drawing.Point(638, 29)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(31, 14)
            Me.Label22.TabIndex = 35
            Me.Label22.Text = "MC :"
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.Location = New System.Drawing.Point(730, 8)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(63, 14)
            Me.Label20.TabIndex = 35
            Me.Label20.Text = "Order Qty:"
            '
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.BackColor = System.Drawing.Color.Transparent
            Me.Label24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.Location = New System.Drawing.Point(553, 29)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(39, 14)
            Me.Label24.TabIndex = 35
            Me.Label24.Text = "LCSD:"
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label23.Location = New System.Drawing.Point(553, 7)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(37, 14)
            Me.Label23.TabIndex = 35
            Me.Label23.Text = "WHD :"
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label21.Location = New System.Drawing.Point(638, 7)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(38, 14)
            Me.Label21.TabIndex = 35
            Me.Label21.Text = "SMV :"
            '
            'PQtyTextBox
            '
            Me.PQtyTextBox.BackColor = System.Drawing.Color.Yellow
            Me.PQtyTextBox.Location = New System.Drawing.Point(936, 27)
            Me.PQtyTextBox.Name = "PQtyTextBox"
            Me.PQtyTextBox.Size = New System.Drawing.Size(80, 20)
            Me.PQtyTextBox.TabIndex = 33
            '
            'OrdQtyTextBox
            '
            Me.OrdQtyTextBox.BackColor = System.Drawing.Color.White
            Me.OrdQtyTextBox.Location = New System.Drawing.Point(801, 5)
            Me.OrdQtyTextBox.Name = "OrdQtyTextBox"
            Me.OrdQtyTextBox.ReadOnly = True
            Me.OrdQtyTextBox.Size = New System.Drawing.Size(110, 20)
            Me.OrdQtyTextBox.TabIndex = 33
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.BackColor = System.Drawing.Color.Transparent
            Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.Location = New System.Drawing.Point(448, 29)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(31, 14)
            Me.Label18.TabIndex = 35
            Me.Label18.Text = "LC  :"
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.Location = New System.Drawing.Point(112, 27)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(43, 14)
            Me.Label15.TabIndex = 35
            Me.Label15.Text = "Style  :"
            '
            'PIDTextBox
            '
            Me.PIDTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.PIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PIDTextBox.Location = New System.Drawing.Point(176, 58)
            Me.PIDTextBox.Name = "PIDTextBox"
            Me.PIDTextBox.Size = New System.Drawing.Size(141, 20)
            Me.PIDTextBox.TabIndex = 34
            '
            'PBalTextBox
            '
            Me.PBalTextBox.BackColor = System.Drawing.Color.White
            Me.PBalTextBox.Location = New System.Drawing.Point(801, 27)
            Me.PBalTextBox.Name = "PBalTextBox"
            Me.PBalTextBox.ReadOnly = True
            Me.PBalTextBox.Size = New System.Drawing.Size(110, 20)
            Me.PBalTextBox.TabIndex = 34
            '
            'TNAEndLabel
            '
            Me.TNAEndLabel.AutoSize = True
            Me.TNAEndLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TNAEndLabel.Location = New System.Drawing.Point(331, 63)
            Me.TNAEndLabel.Name = "TNAEndLabel"
            Me.TNAEndLabel.Size = New System.Drawing.Size(19, 14)
            Me.TNAEndLabel.TabIndex = 35
            Me.TNAEndLabel.Text = "... "
            '
            'TNAStartLabel
            '
            Me.TNAStartLabel.AutoSize = True
            Me.TNAStartLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TNAStartLabel.Location = New System.Drawing.Point(331, 46)
            Me.TNAStartLabel.Name = "TNAStartLabel"
            Me.TNAStartLabel.Size = New System.Drawing.Size(19, 14)
            Me.TNAStartLabel.TabIndex = 35
            Me.TNAStartLabel.Text = "... "
            '
            'FabricColorBindingSource
            '
            Me.FabricColorBindingSource.DataMember = "FabricColor"
            Me.FabricColorBindingSource.DataSource = Me.FabricColorDataSet
            '
            'FabricColorDataSet
            '
            Me.FabricColorDataSet.DataSetName = "FabricColorDataSet"
            Me.FabricColorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'TableAdapterManager1
            '
            Me.TableAdapterManager1.AppointmentDetailsTableAdapter = Nothing
            Me.TableAdapterManager1.AppointmentsTableAdapter = Me.AppointmentsTableAdapter
            Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
            Me.TableAdapterManager1.LineTableAdapter = Me.LineTableAdapter
            Me.TableAdapterManager1.UpdateOrder = KSoft_Apparel.PlanningBoardNewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
            '
            'FabricColorTableAdapter
            '
            Me.FabricColorTableAdapter.ClearBeforeFill = True
            '
            'ApmntLookupTableAdapter
            '
            Me.ApmntLookupTableAdapter.ClearBeforeFill = True
            '
            'AppointmentDetailsTableAdapter
            '
            Me.AppointmentDetailsTableAdapter.ClearBeforeFill = True
            '
            'StyleTableAdapter
            '
            Me.StyleTableAdapter.ClearBeforeFill = True
            '
            'ActivitiesPivotTableAdapter
            '
            Me.ActivitiesPivotTableAdapter.ClearBeforeFill = True
            '
            'AppointmentsLogTableAdapter
            '
            Me.AppointmentsLogTableAdapter.ClearBeforeFill = True
            '
            'SCLStyleTypeLookupTableAdapter
            '
            Me.SCLStyleTypeLookupTableAdapter.ClearBeforeFill = True
            '
            'PlanningBalanceBySIDTableAdapter
            '
            Me.PlanningBalanceBySIDTableAdapter.ClearBeforeFill = True
            '
            'SplitContainer6
            '
            Me.SplitContainer6.BackColor = System.Drawing.SystemColors.Control
            Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainer6.IsSplitterFixed = True
            Me.SplitContainer6.Location = New System.Drawing.Point(0, 0)
            Me.SplitContainer6.Name = "SplitContainer6"
            Me.SplitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal
            '
            'SplitContainer6.Panel1
            '
            Me.SplitContainer6.Panel1.Controls.Add(Me.TabControl1)
            '
            'SplitContainer6.Panel2
            '
            Me.SplitContainer6.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.SplitContainer6.Panel2.Controls.Add(Me.LCATextBox)
            Me.SplitContainer6.Panel2.Controls.Add(Me.Label8)
            Me.SplitContainer6.Panel2.Controls.Add(Me.UCPLinkLabel)
            Me.SplitContainer6.Panel2.Controls.Add(Me.LinkLabel1)
            Me.SplitContainer6.Panel2.Controls.Add(Me.Label4)
            Me.SplitContainer6.Panel2.Controls.Add(Me.DateRadioButton)
            Me.SplitContainer6.Panel2.Controls.Add(Me.QuantityRadioButton)
            Me.SplitContainer6.Panel2.Controls.Add(Me.RefreshButton)
            Me.SplitContainer6.Panel2.Controls.Add(Me.PicturePictureEdit)
            Me.SplitContainer6.Panel2.Controls.Add(Me.ProgNoTextBox)
            Me.SplitContainer6.Panel2.Controls.Add(Me.PasteLabel)
            Me.SplitContainer6.Panel2.Controls.Add(Me.CopyLinkLabel)
            Me.SplitContainer6.Panel2.Controls.Add(Me.RedoLinkLabel)
            Me.SplitContainer6.Panel2.Controls.Add(Me.AddButton)
            Me.SplitContainer6.Panel2.Controls.Add(Me.SaveButton)
            Me.SplitContainer6.Panel2.Controls.Add(Me.Label21)
            Me.SplitContainer6.Panel2.Controls.Add(Me.AddToPQtyLinkLabel)
            Me.SplitContainer6.Panel2.Controls.Add(Me.SMVTextBox)
            Me.SplitContainer6.Panel2.Controls.Add(Me.UndoLinkLabel)
            Me.SplitContainer6.Panel2.Controls.Add(Me.Label22)
            Me.SplitContainer6.Panel2.Controls.Add(Me.PQtyTextBox)
            Me.SplitContainer6.Panel2.Controls.Add(Me.Label23)
            Me.SplitContainer6.Panel2.Controls.Add(Me.WHDTextBox)
            Me.SplitContainer6.Panel2.Controls.Add(Me.Label26)
            Me.SplitContainer6.Panel2.Controls.Add(Me.MCTextBox)
            Me.SplitContainer6.Panel2.Controls.Add(Me.CheckBox1)
            Me.SplitContainer6.Panel2.Controls.Add(Me.SplitCheckBox)
            Me.SplitContainer6.Panel2.Controls.Add(Me.Label7)
            Me.SplitContainer6.Panel2.Controls.Add(Me.Label24)
            Me.SplitContainer6.Panel2.Controls.Add(Me.ExDateEdit)
            Me.SplitContainer6.Panel2.Controls.Add(Me.dtEnd)
            Me.SplitContainer6.Panel2.Controls.Add(Me.LCSDTextBox)
            Me.SplitContainer6.Panel2.Controls.Add(Me.LineGridLookupEdit)
            Me.SplitContainer6.Panel2.Controls.Add(Me.Label15)
            Me.SplitContainer6.Panel2.Controls.Add(Me.Label27)
            Me.SplitContainer6.Panel2.Controls.Add(Me.Label18)
            Me.SplitContainer6.Panel2.Controls.Add(Me.dtStart)
            Me.SplitContainer6.Panel2.Controls.Add(Me.TNAStartLabel)
            Me.SplitContainer6.Panel2.Controls.Add(Me.Label25)
            Me.SplitContainer6.Panel2.Controls.Add(Me.TNAEndLabel)
            Me.SplitContainer6.Panel2.Controls.Add(Me.ProgramNoLinkLabel)
            Me.SplitContainer6.Panel2.Controls.Add(Me.StyleTextBox)
            Me.SplitContainer6.Panel2.Controls.Add(Me.Label19)
            Me.SplitContainer6.Panel2.Controls.Add(Me.PBalTextBox)
            Me.SplitContainer6.Panel2.Controls.Add(Me.Label28)
            Me.SplitContainer6.Panel2.Controls.Add(Me.SCLGridLookUpEdit)
            Me.SplitContainer6.Panel2.Controls.Add(Me.Label20)
            Me.SplitContainer6.Panel2.Controls.Add(Me.PIDTextBox)
            Me.SplitContainer6.Panel2.Controls.Add(Me.PQtyLinkLabel)
            Me.SplitContainer6.Panel2.Controls.Add(Me.OrdQtyTextBox)
            Me.SplitContainer6.Panel2MinSize = 75
            Me.SplitContainer6.Size = New System.Drawing.Size(1310, 303)
            Me.SplitContainer6.SplitterDistance = 212
            Me.SplitContainer6.TabIndex = 63
            '
            'LCATextBox
            '
            Me.LCATextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.LCATextBox.Location = New System.Drawing.Point(487, 55)
            Me.LCATextBox.Name = "LCATextBox"
            Me.LCATextBox.Size = New System.Drawing.Size(61, 20)
            Me.LCATextBox.TabIndex = 68
            Me.LCATextBox.Text = "1"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(446, 60)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(42, 14)
            Me.Label8.TabIndex = 67
            Me.Label8.Text = "LC A  :"
            '
            'UCPLinkLabel
            '
            Me.UCPLinkLabel.AutoSize = True
            Me.UCPLinkLabel.Location = New System.Drawing.Point(1254, 49)
            Me.UCPLinkLabel.Name = "UCPLinkLabel"
            Me.UCPLinkLabel.Size = New System.Drawing.Size(58, 13)
            Me.UCPLinkLabel.TabIndex = 66
            Me.UCPLinkLabel.TabStop = True
            Me.UCPLinkLabel.Text = "||    UCP   ||"
            '
            'LinkLabel1
            '
            Me.LinkLabel1.AutoSize = True
            Me.LinkLabel1.Location = New System.Drawing.Point(1203, 49)
            Me.LinkLabel1.Name = "LinkLabel1"
            Me.LinkLabel1.Size = New System.Drawing.Size(52, 13)
            Me.LinkLabel1.TabIndex = 65
            Me.LinkLabel1.TabStop = True
            Me.LinkLabel1.Text = "|| Recal. ||"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(730, 60)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(63, 13)
            Me.Label4.TabIndex = 64
            Me.Label4.Text = "Based On  :"
            '
            'DateRadioButton
            '
            Me.DateRadioButton.AutoSize = True
            Me.DateRadioButton.Location = New System.Drawing.Point(869, 58)
            Me.DateRadioButton.Name = "DateRadioButton"
            Me.DateRadioButton.Size = New System.Drawing.Size(48, 17)
            Me.DateRadioButton.TabIndex = 63
            Me.DateRadioButton.Text = "Date"
            Me.DateRadioButton.UseVisualStyleBackColor = True
            '
            'QuantityRadioButton
            '
            Me.QuantityRadioButton.AutoSize = True
            Me.QuantityRadioButton.Checked = True
            Me.QuantityRadioButton.Location = New System.Drawing.Point(801, 58)
            Me.QuantityRadioButton.Name = "QuantityRadioButton"
            Me.QuantityRadioButton.Size = New System.Drawing.Size(64, 17)
            Me.QuantityRadioButton.TabIndex = 63
            Me.QuantityRadioButton.TabStop = True
            Me.QuantityRadioButton.Text = "Quantity"
            Me.QuantityRadioButton.UseVisualStyleBackColor = True
            '
            'PasteLabel
            '
            Me.PasteLabel.AutoSize = True
            Me.PasteLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
            Me.PasteLabel.Location = New System.Drawing.Point(1254, 29)
            Me.PasteLabel.Name = "PasteLabel"
            Me.PasteLabel.Size = New System.Drawing.Size(57, 13)
            Me.PasteLabel.TabIndex = 1
            Me.PasteLabel.TabStop = True
            Me.PasteLabel.Text = "||   Paste  ||"
            '
            'CopyLinkLabel
            '
            Me.CopyLinkLabel.AutoSize = True
            Me.CopyLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
            Me.CopyLinkLabel.Location = New System.Drawing.Point(1254, 10)
            Me.CopyLinkLabel.Name = "CopyLinkLabel"
            Me.CopyLinkLabel.Size = New System.Drawing.Size(57, 13)
            Me.CopyLinkLabel.TabIndex = 1
            Me.CopyLinkLabel.TabStop = True
            Me.CopyLinkLabel.Text = "||   Copy   ||"
            '
            'AddButton
            '
            Me.AddButton.Location = New System.Drawing.Point(1017, 10)
            Me.AddButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
            Me.AddButton.Name = "AddButton"
            Me.AddButton.Size = New System.Drawing.Size(66, 38)
            Me.AddButton.TabIndex = 9
            Me.AddButton.Text = "&Add"
            Me.AddButton.UseVisualStyleBackColor = True
            '
            'CheckBox1
            '
            Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
            Me.CheckBox1.Location = New System.Drawing.Point(1033, 54)
            Me.CheckBox1.Name = "CheckBox1"
            Me.CheckBox1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
            Me.CheckBox1.Size = New System.Drawing.Size(149, 25)
            Me.CheckBox1.TabIndex = 13
            Me.CheckBox1.Text = "Show Progress"
            Me.CheckBox1.UseVisualStyleBackColor = False
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.BackColor = System.Drawing.Color.Transparent
            Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(547, 60)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(49, 14)
            Me.Label7.TabIndex = 35
            Me.Label7.Text = "Ex Date:"
            '
            'ExDateEdit
            '
            Me.ExDateEdit.EditValue = New Date(2005, 11, 25, 0, 0, 0, 0)
            Me.ExDateEdit.Location = New System.Drawing.Point(599, 57)
            Me.ExDateEdit.Name = "ExDateEdit"
            Me.ExDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.ExDateEdit.Properties.Appearance.Options.UseBackColor = True
            Me.ExDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ExDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.ExDateEdit.Properties.DisplayFormat.FormatString = "dd-MMM-yy"
            Me.ExDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.ExDateEdit.Properties.EditFormat.FormatString = "dd-MMM-yy"
            Me.ExDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.ExDateEdit.Size = New System.Drawing.Size(125, 20)
            Me.ExDateEdit.TabIndex = 62
            '
            'SplitContainer1
            '
            Me.SplitContainer1.BackColor = System.Drawing.Color.Gray
            Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
            Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
            Me.SplitContainer1.Name = "SplitContainer1"
            Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
            '
            'SplitContainer1.Panel1
            '
            Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer6)
            '
            'SplitContainer1.Panel2
            '
            Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
            Me.SplitContainer1.Panel2.Controls.Add(Me.SchedulerControl1)
            Me.SplitContainer1.Size = New System.Drawing.Size(1310, 711)
            Me.SplitContainer1.SplitterDistance = 303
            Me.SplitContainer1.TabIndex = 64
            '
            'SewingOutputBalance_POwiseTableAdapter
            '
            Me.SewingOutputBalance_POwiseTableAdapter.ClearBeforeFill = True
            '
            'frmPlanningBoardNew
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1310, 711)
            Me.Controls.Add(Me.SplitContainer1)
            Me.KeyPreview = True
            Me.Name = "frmPlanningBoardNew"
            Me.Text = " "
            CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PlanningBoardNewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ApmntLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ResourcesCheckedListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AppointmentDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ActivitiesPivotBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ActivitiesPivotDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage2.ResumeLayout(False)
            Me.SplitContainer2.Panel1.ResumeLayout(False)
            Me.SplitContainer2.Panel2.ResumeLayout(False)
            Me.SplitContainer2.Panel2.PerformLayout()
            CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer2.ResumeLayout(False)
            CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PlanningBalanceBySIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PlanningBalanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SewingOutputBalancePOwiseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SewingOutputBalance_POwiseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage3.ResumeLayout(False)
            CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AppointmentsLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AppointmentsLogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            CType(Me.DateNavigator1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage4.ResumeLayout(False)
            Me.TabPage4.PerformLayout()
            Me.TabPage5.ResumeLayout(False)
            Me.TabPage6.ResumeLayout(False)
            CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage7.ResumeLayout(False)
            CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LineGridLookupEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SCLGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SCLStyleTypeLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SewingCustomLearningCurveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PicturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer6.Panel1.ResumeLayout(False)
            Me.SplitContainer6.Panel2.ResumeLayout(False)
            Me.SplitContainer6.Panel2.PerformLayout()
            CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer6.ResumeLayout(False)
            CType(Me.ExDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ExDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer1.Panel1.ResumeLayout(False)
            Me.SplitContainer1.Panel2.ResumeLayout(False)
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PlanningBoardNewDataSet As KSoft_Apparel.PlanningBoardNewDataSet
        Friend WithEvents AppointmentsBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents AppointmentsTableAdapter As KSoft_Apparel.PlanningBoardNewDataSetTableAdapters.AppointmentsTableAdapter
        Friend WithEvents LineBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents LineTableAdapter As KSoft_Apparel.PlanningBoardNewDataSetTableAdapters.LineTableAdapter
        Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
        Friend WithEvents BranchDataSet As KSoft_Apparel.BranchDataSet
        Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents BranchTableAdapter As KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents AllButton As System.Windows.Forms.Button
        Friend WithEvents ResourcesCheckedListBoxControl1 As DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl
        Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
        Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
        Friend WithEvents colIsPrint As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
        Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents ShowAllButton As System.Windows.Forms.Button
        Friend WithEvents TableAdapterManager As KSoft_Apparel.SewingOutputBalanceDataSetTableAdapters.TableAdapterManager
        Friend WithEvents TableAdapterManager1 As KSoft_Apparel.PlanningBoardNewDataSetTableAdapters.TableAdapterManager
        Friend WithEvents SaveButton As System.Windows.Forms.Button
        Friend WithEvents SchedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
        Friend WithEvents FabricColorDataSet As KSoft_Apparel.FabricColorDataSet
        Friend WithEvents FabricColorBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents FabricColorTableAdapter As KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
        Friend WithEvents PrintButton As System.Windows.Forms.Button
        Friend WithEvents MaxExDateTimePicker As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
        Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
        Friend WithEvents SelectAllButton As System.Windows.Forms.Button
        Friend WithEvents ApmntLookupBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents ApmntLookupTableAdapter As KSoft_Apparel.PlanningBoardNewDataSetTableAdapters.ApmntLookupTableAdapter
        Friend WithEvents colSubject As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
        Private WithEvents SchedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
        Friend WithEvents OrangeLabel As Label
        Friend WithEvents GreenLabel As Label
        Friend WithEvents YellowLabel As Label
        Friend WithEvents BlueLabel As Label
        Friend WithEvents Label11 As Label
        Friend WithEvents RefreshButton As Button
        Friend WithEvents NumericUpDown1 As NumericUpDown
        Friend WithEvents SplitCheckBox As CheckBox
        Friend WithEvents AppointmentDetailsBindingSource As BindingSource
        Friend WithEvents AppointmentDetailsTableAdapter As PlanningBoardNewDataSetTableAdapters.AppointmentDetailsTableAdapter
        Friend WithEvents PicturePictureEdit As DevExpress.XtraEditors.PictureEdit
        Friend WithEvents StyleDataSet As StyleDataSet
        Friend WithEvents StyleBindingSource As BindingSource
        Friend WithEvents StyleTableAdapter As StyleDataSetTableAdapters.StyleTableAdapter
        Friend WithEvents PBalTextBox As TextBox
        Friend WithEvents ProgNoTextBox As TextBox
        Friend WithEvents Label19 As Label
        Friend WithEvents Label20 As Label
        Friend WithEvents OrdQtyTextBox As TextBox
        Friend WithEvents TabControl1 As TabControl
        Friend WithEvents TabPage1 As TabPage
        Friend WithEvents TabPage2 As TabPage
        Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents PlanningBalanceDataSet As PlanningBalanceDataSet
        Friend WithEvents MCTextBox As TextBox
        Friend WithEvents SMVTextBox As TextBox
        Friend WithEvents Label22 As Label
        Friend WithEvents Label21 As Label
        Friend WithEvents colLine As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEndDate1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colStartDate1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents TabPage3 As TabPage
        Friend WithEvents TabPage4 As TabPage
        Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents ActivitiesPivotBindingSource As BindingSource
        Friend WithEvents ActivitiesPivotDataSet As ActivitiesPivotDataSet
        Friend WithEvents colYarn As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFabric As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCutting As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrinting As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEmbroidery As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSewing As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFinishing As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInspection As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colShipment As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents ActivitiesPivotTableAdapter As ActivitiesPivotDataSetTableAdapters.ActivitiesPivotTableAdapter
        Friend WithEvents colPlanning As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents StatusByComboBox As ComboBox
        Friend WithEvents Label9 As Label
        Friend WithEvents ShowStatusButton As Button
        Friend WithEvents Label14 As Label
        Friend WithEvents Label13 As Label
        Friend WithEvents Label12 As Label
        Friend WithEvents Label10 As Label
        Friend WithEvents StyleTextBox As TextBox
        Friend WithEvents Label15 As Label
        Friend WithEvents colAccessories As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents TNAEndLabel As Label
        Friend WithEvents TNAStartLabel As Label
        Friend WithEvents WHDTextBox As TextBox
        Friend WithEvents Label23 As Label
        Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents AppointmentsLogDataSet As AppointmentsLogDataSet
        Friend WithEvents AppointmentsLogBindingSource As BindingSource
        Friend WithEvents AppointmentsLogTableAdapter As AppointmentsLogDataSetTableAdapters.AppointmentsLogTableAdapter
        Friend WithEvents colProgramNo2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSubject1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCreatedOn As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLine1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colStartDate2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEndDate2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Friend WithEvents ProgramNoLinkLabel As LinkLabel
        Friend WithEvents SCLStyleTypeLookupBindingSource As BindingSource
        Friend WithEvents SewingCustomLearningCurveDataSet As SewingCustomLearningCurveDataSet
        Friend WithEvents SCLStyleTypeLookupTableAdapter As SewingCustomLearningCurveDataSetTableAdapters.SCLStyleTypeLookupTableAdapter
        Friend WithEvents SCLGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
        Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents Label18 As Label
        Friend WithEvents LCSDTextBox As TextBox
        Friend WithEvents Label24 As Label
        Friend WithEvents PlanningBalanceBySIDBindingSource As BindingSource
        Friend WithEvents PlanningBalanceBySIDTableAdapter As PlanningBalanceDataSetTableAdapters.PlanningBalanceBySIDTableAdapter
        Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPlanningBalance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMinEX As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMaxEX As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colStartDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEndDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOrderReceiveDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colStyleName1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colProgramNo1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPlanningQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents PQtyTextBox As TextBox
        Private WithEvents Label28 As Label
        Private WithEvents Label27 As Label
        Private WithEvents Label26 As Label
        Friend WithEvents LineGridLookupEdit As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents PQtyLinkLabel As LinkLabel
        Friend WithEvents UndoLinkLabel As LinkLabel
        Friend WithEvents RedoLinkLabel As LinkLabel
        Friend WithEvents Label25 As Label
        Friend WithEvents PIDTextBox As TextBox
        Friend WithEvents AddToPQtyLinkLabel As LinkLabel
        Private WithEvents dtEnd As DevExpress.XtraEditors.DateEdit
        Private WithEvents dtStart As DevExpress.XtraEditors.DateEdit
        Friend WithEvents SplitContainer6 As SplitContainer
        Friend WithEvents TabPage5 As TabPage
        Friend WithEvents TabPage6 As TabPage
        Friend WithEvents SplitContainer1 As SplitContainer
        Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
        Friend WithEvents fieldDaySerial1 As DevExpress.XtraPivotGrid.PivotGridField
        Friend WithEvents fieldPlanningDate1 As DevExpress.XtraPivotGrid.PivotGridField
        Friend WithEvents fieldEfficiency1 As DevExpress.XtraPivotGrid.PivotGridField
        Friend WithEvents fieldPlanningQuantity1 As DevExpress.XtraPivotGrid.PivotGridField
        Friend WithEvents Label2 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents colOrderQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPlanningQuantity As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMaxEX1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMinEX1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents DateNavigator1 As DevExpress.XtraScheduler.DateNavigator
        Friend WithEvents colAppointmentId As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents InlineCheckBox As CheckBox
        Friend WithEvents Label4 As Label
        Friend WithEvents DateRadioButton As RadioButton
        Friend WithEvents QuantityRadioButton As RadioButton
        Friend WithEvents AddButton As Button
        Friend WithEvents TabPage7 As TabPage
        Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDaySerial As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPlanningDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEfficiency As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPlanningQuantity2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTarget As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colWH As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents LinkLabel1 As LinkLabel
        Friend WithEvents PasteLabel As LinkLabel
        Friend WithEvents CopyLinkLabel As LinkLabel
        Friend WithEvents colSewingBalance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridControl5 As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents RepositoryItemHyperLinkEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Friend WithEvents SewingOutputBalance_POwiseDataSet As SewingOutputBalance_POwiseDataSet
        Friend WithEvents SewingOutputBalancePOwiseBindingSource As BindingSource
        Friend WithEvents SewingOutputBalance_POwiseTableAdapter As SewingOutputBalance_POwiseDataSetTableAdapters.SewingOutputBalance_POwiseTableAdapter
        Friend WithEvents colEx As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOrderQuantity2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOutputQuantity As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSewingBalance1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPO As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSelect As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents UCPLinkLabel As LinkLabel
        Friend WithEvents CheckBox1 As CheckBox
        Friend WithEvents Button1 As Button
        Friend WithEvents SplitContainer2 As SplitContainer
        Friend WithEvents ShowPOLinkLabel As LinkLabel
        Friend WithEvents Label7 As Label
        Private WithEvents ExDateEdit As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label8 As Label
        Friend WithEvents LCATextBox As TextBox
        Friend WithEvents colShipmentBalance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colShipmentBalance1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents ShowByPNButton As Button
        Friend WithEvents Label16 As Label
        Friend WithEvents ShowByPrgButton As Button
    End Class
End Namespace
