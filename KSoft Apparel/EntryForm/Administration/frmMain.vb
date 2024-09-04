Imports System.Windows.Forms
Imports KSoft_Apparel.TimelineTimeScales
Imports System.Globalization
Imports System.Deployment.Application
'Imports mycodelib.myform

Public Class frmMain
    Inherits Form
    Public Sub New()
        Try
            ' initialize added component on form1, which is menu strip;
            'note: if you have added any second component alongside menu
            'strip, such as context menu strip just add additional code 
            'line under InitializeComponent(), and it will work;
            InitializeComponent()
            'MenuStrip.Renderer = New MyRenderer()
        Catch ex As Exception

        End Try
    End Sub
    'Public Class MyRenderer
    '    Inherits ToolStripProfessionalRenderer
    '    Protected Overloads Overrides Sub OnRenderMenuItemBackground(ByVal e As ToolStripItemRenderEventArgs)
    '        Try
    '            Dim rc As New Rectangle(Point.Empty, e.Item.Size)
    '            Dim c As Color = IIf(e.Item.Selected, Color.Yellow, Color.White)
    '            Using brush As New SolidBrush(c)
    '                e.Graphics.FillRectangle(brush, rc)
    '            End Using
    '        Catch ex As Exception

    '        End Try

    '    End Sub
    'End Class

    Dim QueryString As String = String.Empty




    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    'Protected Overrides Sub OnFormClosed(ByVal e As System.Windows.Forms.FormClosedEventArgs)
    '    Timer1.Stop()
    '    RemoveHandler Application.Idle, AddressOf Application_Idle
    '    MyBase.OnFormClosed(e)
    'End Sub


    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'Protect Accidental Closing 
        If MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim sessionManager As New SessionManager

            sessionManager.DeleteSession(My.Settings.UserId)

            e.Cancel = False
        Else
            e.Cancel = True
        End If

    End Sub

    'Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)

    '    'Timer1.Interval = My.Settings.LockOutTime
    '    'Timer1.Stop()
    '    'Timer1.Start()

    'End Sub

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    '    Dim i As Integer = 1
    '    i += 1

    '    Do While i = 10

    '        With frmAnimation
    '            .MdiParent = Me
    '            .WindowState = FormWindowState.Maximized
    '            .Show()
    '        End With

    '        Timer1.Stop()

    '    Loop

    'End Sub


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim sessionManager As New SessionManager()
        Dim userId As Integer = My.Settings.UserId

        If sessionManager.IsUserLoggedIn(userId) = False Then
            'MessageBox.Show("User is already logged in.")
            MenuStrip.Visible = False
            Dim loginForm As New LoginForm()

            loginForm.ShowDialog()

            ' Proceed to the login form or other actions
        End If
        ''AddHandler System.Windows.Forms.Application.Idle, AddressOf Application_Idle
        'Dim CC As String = ReadStringData("Select CompanyCode From Company Where CompanyId=1", cnn)

        'If CC <> "NCL" Then
        '    Me.BackgroundImage = Global.KSoft_Apparel.My.Resources.Resources.CompanyName256
        '    Me.BackgroundImageLayout = ImageLayout.Center
        '    Me.Text = "KSoft Apparel Solutions"
        '    PictureBox1.BackgroundImage = Global.KSoft_Apparel.My.Resources.Resources.CompanyNameVert
        'End If


        MenuStrip.Visible = True

        QueryString = "SELECT DepartmentName FROM DEPARTMENT WHERE (DepartmentId=" & DepartmentId & ")"
        Dim DepartmentName As String = ReadStringData(QueryString, cnn)
        Dim UserName As String = ReadStringData("Select User_Name from [User] where User_Id=" & UserId, cnn)

        'ShowForm(frmApproveSheet)
        Me.UserNameToolStripStatusLabel.Text = UserName.ToUpper()
        Me.DepartmentToolStripStatusLabel.Text = DepartmentName.ToUpper()
        Me.IPAddressToolStripStatusLabel.Text = GetIPAddress()

        Dim culture = New CultureInfo("en-IN")
        ''Console.WriteLine(String.Format(culture, "{0:##,##,##,###.####}", 12345678))

        Dim COrderCount As Integer = ReadIntData("Select Count(ProgramNo) From [Order] Where IsRunning=1 And IsAdvance=0", cnn)
        Dim COrderQty As Integer = ReadIntegerData("Select Sum(OrderQuantity) From vOrder Where IsPOHold=0 And PODiscontinue=0 And IsRunning=1 And PODiscontinue=0 And IsAdvance=0", cnn)
        Dim ShipmentQty As Integer = ReadData("Select SUM(ShippmentQuantity) from FinishingProduction Where OrderDetailsId in (Select OrderDetailsId From OrderDetails Where OrderId in (Select OrderId From [Order] Where IsRunning=1))", cnn)
        Dim ShipmentBalance As Integer = COrderQty - ShipmentQty


        NoOfOrderToolStripTextBox.Text = String.Format(culture, "{0:##,##,##,###.####}", COrderCount)
        OrderQuantityToolStripTextBox.Text = String.Format(culture, "{0:##,##,##,###.####}", COrderQty)
        ShipmentQtyToolStripTextBox.Text = String.Format(culture, "{0:##,##,##,###.####}", ShipmentQty)
        ShipmentBalanceToolStripTextBox.Text = String.Format(culture, "{0:##,##,##,###.####}", ShipmentBalance)

        If UserName = "Security" Then

            MenuStrip.Visible = False
            ToolStrip2.Visible = False

            ShowForm(frmChallanVerificationSystem)

        End If




    End Sub



    Private Sub BrandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrandToolStripMenuItem.Click
        'frmBrand.ShowDialog()
        ShowMasterWithUserRights(frmBrand, "Brand")

    End Sub



    Private Sub MediaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediaToolStripMenuItem.Click
        'frmPrintingMedia.ShowDialog()
        ShowMasterWithUserRights(frmPrintingMedia, "Printing Media")
    End Sub



    Private Sub CategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmCategory.ShowDialog()
        ShowMasterWithUserRights(frmCategory, "Category")
    End Sub



    Private Sub BranchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub UnitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitToolStripMenuItem.Click
        'frmUnit.ShowDialog()
        ShowMasterWithUserRights(frmUnit, "Unit")
    End Sub

    'Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
    '    With frmConsumption
    '        .MdiParent = Me
    '        .WindowState = FormWindowState.Maximized
    '        .Show()
    '    End With
    'End Sub

    Private Sub OriginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OriginToolStripMenuItem.Click
        ShowFormWithUserRights(frmOrigin, "Origin")

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        If MessageBox.Show("Are you sure you want to exit?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub UserRightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserRightToolStripMenuItem.Click

        If UserId = 1 Then
            ShowForm(frmUserRights)
        Else
            ShowMasterWithUserRights(frmUserRights, "User Rights")
        End If

    End Sub








    Private Sub PrintTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmPrintType.ShowDialog()

    End Sub



    Private Sub BuyerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub SignOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignOutToolStripMenuItem.Click

        Dim sessionManager As New SessionManager

        sessionManager.DeleteSession(My.Settings.UserId)
        MenuStrip.Visible = False
        Dim loginForm As New LoginForm()
        loginForm.ShowDialog()

    End Sub
    'Checking user right for ToolStripMenuItem
    Private Sub SetMenu(ByVal MyMenuName As String, ByVal MyToolStrip As ToolStripMenuItem, Optional ByVal MyToolbarButton As ToolStripItem = Nothing)

        On Error Resume Next
        Dim MenuId As Integer = -1
        Dim Menurow As MenuDataSet.MenuRow = Nothing
        Dim UserRightsrow As UserRightsDataSet.UserRightsRow = Nothing

        '-----------------Start : Check User Right For Entry------------------------

        Me.MenuTableAdapter.FillByMenuName(MenuDataSet.Menu, MyMenuName)
        Menurow = CType(CType(MenuBindingSource.Current, DataRowView).Row, MenuDataSet.MenuRow)
        MenuId = CInt(Menurow.MENU_ID)

        UserRightsTableAdapter.FillByUserRights(UserRightsDataSet.UserRights, UserId, MenuId)
        UserRightsrow = CType(CType(UserRightsBindingSource.Current, DataRowView).Row, UserRightsDataSet.UserRightsRow)

        If UserRightsrow.CAN_VIEW = False Then

            MyToolStrip.Visible = False
            MyToolbarButton.Visible = False

        Else

            MyToolStrip.Visible = True
            MyToolbarButton.Visible = True

        End If

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        With frmRecipe

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub





    Private Sub PrintColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub



    Private Sub OrderEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderEntryToolStripMenuItem.Click

        'With frmOrderReceived

        '    .MdiParent = Me
        '    .WindowState = FormWindowState.Maximized
        '    .Show()

        'End With
        frmOrderReceived.ByUserFlag = False
        ShowFormWithUserRights(frmOrderReceived, "Buyer Order")

    End Sub

    Private Sub CompanyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub YarnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GSMToolStripMenuItem.Click

        ShowMasterWithUserRights(frmGSM, "GSM")

    End Sub

    Private Sub KnittingTypeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KnittingTypeToolStripMenuItem1.Click
        ShowMasterWithUserRights(frmKnittingType, "Knitting Type")

    End Sub

    '

    Private Sub GarmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GarmentToolStripMenuItem.Click
        'frmGarments.ShowDialog()
        ShowMasterWithUserRights(frmGarments, "Garments Name")

    End Sub

    Private Sub DivisionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DivisionToolStripMenuItem.Click

        ShowMasterWithUserRights(frmDivision, "Division")
    End Sub



    Private Sub SeasonToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeasonToolStripMenuItem.Click

        ShowMasterWithUserRights(frmSeason, "Season")

    End Sub

    Private Sub SizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SizeToolStripMenuItem.Click

        ShowMasterWithUserRights(frmSize, "Size")

    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentToolStripMenuItem.Click
        ShowMasterWithUserRights(frmDepartment, "Department")
    End Sub



    Private Sub FabricColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricColorToolStripMenuItem.Click
        'frmFabricColor.ShowDialog()
        ShowMasterWithUserRights(frmFabricColor, "Fabric Color")
    End Sub

    Private Sub StyleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleToolStripMenuItem.Click
        ShowMasterWithUserRights(frmStyle, "Style")
    End Sub


    Private Sub DyeingTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DyeingTypeToolStripMenuItem.Click
        ShowMasterWithUserRights(frmDyeingType, "Dyeing Type")
    End Sub

    Private Sub FabricConsumptionBookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricConsumptionBookingToolStripMenuItem.Click
        'With frmFabricBooking_Bulk
        '    .MdiParent = Me
        '    .WindowState = FormWindowState.Maximized
        '    .Show()
        'End With
        ShowFormWithUserRights(frmFabricBooking_Bulk, "Fabric Booking BULK")
    End Sub

    Private Sub DestinationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DestinationToolStripMenuItem.Click
        ShowMasterWithUserRights(frmDestination, "Destination")
    End Sub



    Private Sub BookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem.Click

        ShowFormWithUserRights(frmAccessoriesBookingNew, "Accessories Booking")

    End Sub


    Private Sub LineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub OrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub


    Private Sub ShippmentStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub




    Private Sub ConveyanceBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConveyanceBillToolStripMenuItem.Click
        With frmBillReport

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Private Sub ItemStyleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowMasterWithUserRights(frmItemStyle, "Item Style")
    End Sub




    Private Sub SewingProductionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub


    Private Sub BillToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillToolStripMenuItem1.Click

        ShowMasterWithUserRights(frmBill, "Bill")

    End Sub


    Private Sub DaywiseProductionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaywiseProductionToolStripMenuItem.Click
        With frmDayWiseProduction
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .MIS = True
            .Show()

        End With
    End Sub

    Private Sub PrintingProductionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintingProductionToolStripMenuItem.Click


        ShowFormWithUserRights(frmPrintProduction, "Print Production")

    End Sub



    Private Sub TestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestToolStripMenuItem.Click

        With frmPlanningBoard

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With

    End Sub

    Private Sub SewingProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SewingCategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub SewingLearningCurveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SewingMachineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub PlanningBoardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlanningBoardToolStripMenuItem.Click

        With frmPlanningBoardNew

            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Private Sub HourlyPrintProductionGraphToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HourlyPrintProductionGraphToolStripMenuItem.Click
        With frmPrintHourlyProductionGraph
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Private Sub PrintProductionStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintProductionStatusToolStripMenuItem.Click

        With frmDailyPrintProductionReport
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Private Sub InputBalanceReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub StyleWiseCMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub OrderBookingMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ShowForm(frmOrderBookingMasterReport)

    End Sub

    Private Sub SewingAttendanceReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MISReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MISReportToolStripMenuItem.Click

        ShowForm(frmEfficiencyReport)

    End Sub

    Private Sub MachineReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MachineReportToolStripMenuItem.Click
        ShowForm(frmMachineReport)
    End Sub


    Private Sub LineChiefListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub MonthlyEfficiencyReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthlyEfficiencyReportToolStripMenuItem.Click
        ShowForm(frmMonthlyEfficiencyReport)
    End Sub




    Private Sub ProductionBonusTopSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub OrderCPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ShowFormWithUserRights(frmOrderCP, "Order Time And Action")

    End Sub




    Private Sub OrderDeliveryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowForm(frmDelivery)

    End Sub

    Private Sub OrderAsignToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'ShowMasterWithUserRights(frmOrderAsign, "Order Asign")

    End Sub

    Private Sub GarmentsPartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GarmentsPartToolStripMenuItem.Click

        ShowMasterWithUserRights(frmGarmentsPart, "Garments Part")

    End Sub

    Private Sub MonthlyChemicalProductionCostToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthlyChemicalProductionCostToolStripMenuItem.Click
        ShowForm(frmMonthlyPrintProductionCostPrint)

    End Sub

    Private Sub SewingProductionLineAndDateRangeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub SewingLayoutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingLayoutToolStripMenuItem1.Click

        With frmSewingLayoutTopSheet

            .MdiParent = Me
            .MIS = True
            .WindowState = FormWindowState.Maximized
            .Show()

        End With

    End Sub

    Private Sub ActiveMonthToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub



    Private Sub CompositionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompositionToolStripMenuItem.Click
        ShowMasterWithUserRights(frmComposition, "Composition")
    End Sub

    Private Sub FabricConsumptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub





    Private Sub ShipmentStatusProductionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub


    Private Sub ShipmentCommentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub MonthlyRejectionReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthlyRejectionReportToolStripMenuItem.Click
        With frmMonthlyRejectionReport
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Private Sub QCCheckListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub SewingTableQCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub ShipmentFromSubContractToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub SewingTableQCReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)





    End Sub

    Private Sub FinishingDefectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub PrintingHourlyProductionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintingHourlyProductionToolStripMenuItem.Click

        ShowMasterWithUserRights(frmPrintProductionHour, "Print Production Hourly")

    End Sub

    Private Sub DaywiseProductionSummeryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaywiseProductionSummeryToolStripMenuItem1.Click

        With frmDaywiseProductionSummery

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With

    End Sub

    Private Sub CuttingProductionJobCardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub





    Private Sub CuttingJobCardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


    Private Sub ShipmentBalanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub SewingTargetListStylewiseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingTargetListStylewiseToolStripMenuItem.Click
        ShowMasterWithUserRights(frmSewingTargetList, "Sewing Target List")
    End Sub

    Private Sub SupplierToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierToolStripMenuItem1.Click
        ShowFormWithUserRights(frmGeneral, "General")
    End Sub

    Private Sub CustomerListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowMasterWithUserRights(frmCustomer, "Customer")
    End Sub


    Private Sub SampleOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub PreCostingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub SampleFabricBookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub OrderDetailsPrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowForm(frmOrderBookingMaster_Export)
    End Sub

    Private Sub OrderColorUpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderColorUpdateToolStripMenuItem.Click

        ShowMasterWithUserRights(frmOrderColorUpdate, "Order Color Update")

    End Sub



    Private Sub ProgramFullAndFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramFullAndFinalToolStripMenuItem.Click
        frmProgramFullAndFinal.ByUserFlag = True
        ShowFormWithUserRights(frmProgramFullAndFinal, "Program Full And Final")
    End Sub

    Private Sub StyleCaptureToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ShowFormWithUserRights(frmStyleCapture_Accessories, "Style Capture Accessories")

    End Sub


    Private Sub StyleCaptureFabricToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub UnitConversionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitConversionToolStripMenuItem.Click
        ShowMasterWithUserRights(frmUnitConversion, "Unit Conversion")
    End Sub



    Private Sub AccessoriesTemplateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub OrderStatusNavBarItem_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
        ShowForm(frmOrderStatusReport)
    End Sub



    Private Sub CuttingNavBarItem_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
        ShowForm(frmDailyCuttingReport)

    End Sub

    Private Sub SewingNavBarItem_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
        With frmDailySewingReport

            .MIS = True
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Private Sub FinishingNavBarItem_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
        With frmDailyFinishingReport
            .MIS = True
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub Test2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmDatagridViewCellHighlight.Show()
    End Sub



    'Private Sub PrintOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintOrderToolStripMenuItem.Click
    '    ShowMasterWithUserRights(frmPrintOrder)
    'End Sub

    Private Sub RecipeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecipeToolStripMenuItem.Click

        ShowFormWithUserRights(frmRecipe, "Print Recipe")

    End Sub





    Private Sub SewingEarningReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingEarningReportToolStripMenuItem.Click
        ShowForm(frmSewingEarnedReport)
    End Sub



    Private Sub FabricCostingMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub YarnPriceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FinishingInputToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub StyleNameMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleNameMasterToolStripMenuItem.Click
        ShowMasterWithUserRights(frmStyleName, "Style Name")
    End Sub

    Private Sub SampleOrderStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'With frmSampleFabricBookingStatus
        '    .MIS = True
        '    .MdiParent = Me
        '    .WindowState = FormWindowState.Maximized
        '    .Show()

        'End With

    End Sub

    Private Sub SampleRequestUpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub



    'Private Sub GarmentsDepartmnetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GarmentsDepartmnetToolStripMenuItem.Click
    '    ShowMasterWithUserRights(frmGMDepartment, "GM Department")
    'End Sub

    Private Sub WashTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WashTypeToolStripMenuItem.Click
        ShowMasterWithUserRights(frmWashType, "Wash Type")
    End Sub

    Private Sub DevelopmentTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevelopmentTypeToolStripMenuItem.Click
        ShowMasterWithUserRights(frmDevelopmentType, "Development Type")
    End Sub

    Private Sub PrintPartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub




    Private Sub DyeingShadeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DyeingShadeToolStripMenuItem.Click
        ShowMasterWithUserRights(frmDyeingShade, "Dyeing Shade")
    End Sub

    Private Sub SampleDeliveryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ActivitiesListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ActivitiesTemplateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ProgramActivitiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ShowFormWithUserRights(frmOrderActivities, "Activities")

    End Sub

    Private Sub ActivitiesViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        ShowFormWithUserRights(frmActivitieView, "Activities View")

    End Sub

    Private Sub CriticalPathPrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub SewingCapacityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub CutPanelRejectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowFormWithUserRights(frmCutPanelRejection, "Cut Panel Rejection")
    End Sub

    Private Sub LeftOverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SwProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub SwOperationCapacityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SewingOperationAnalyzeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub FinishingAttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FinishingTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishingTypeToolStripMenuItem.Click

        ShowMasterWithUserRights(frmfinishingTypeMst, "Finishing Type")

    End Sub



    Private Sub SewingTransferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub FinishingReportProgramwiseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



        ''ShowMdiform(frmFinishingReportProgramWise, frmMain)

    End Sub

    Private Sub SizewiseFinishingProductionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PrintOrderNewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintOrderNewToolStripMenuItem.Click

        With frmPrintOrderNew
            .IsGMT = False
        End With

        ShowFormWithUserRights(frmPrintOrderNew, "Print Order Printing")

    End Sub

    Private Sub PrintOrderNewGMTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintOrderNewGMTToolStripMenuItem.Click

        With frmPrintOrderNew
            .IsGMT = True

        End With
        ShowFormWithUserRights(frmPrintOrderNew, "Print Order Garments")

    End Sub

    Private Sub PrintOrderNewToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintOrderNewToolStripMenuItem1.Click

        With frmPrintOrderPrint
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With

    End Sub

    Private Sub WIBReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WIBReportToolStripMenuItem.Click

        With frmWIPReport
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With

    End Sub

    Private Sub ToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        frmAWSNew.IsMerchandising = True

        ShowFormWithUserRights(frmAWSNew, "Accessories Work Order [Merchandising]")
    End Sub

    'Private Sub BuyerOrderNewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'With frmBuyerOrderNew

    '    '    .MdiParent = Me
    '    '    .WindowState = FormWindowState.Maximized
    '    '    .Show()

    '    'End With
    'End Sub



    Private Sub MenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuToolStripMenuItem.Click
        If UserId = 1 Then
            ShowMaster(frmMenuList)
        Else
            ShowMasterWithUserRights(frmMenuList, "Menu List")
        End If

    End Sub

    Private Sub ParameterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParameterToolStripMenuItem1.Click
        ShowMasterWithUserRights(frmParameter, "Parameter")
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        ShowMasterWithUserRights(frmCustomer, "Customer")
    End Sub

    Private Sub FRProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FRProcessToolStripMenuItem.Click
        ShowMasterWithUserRights(frmFRProcess, "FRProcess")
    End Sub

    Private Sub OrderFabricConsumptionCADToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderFabricConsumptionCADToolStripMenuItem.Click
        ShowFormWithUserRights(frmFabricConsumptionNew, "CAD Information")
    End Sub

    Private Sub FabricAndAccessoriesBOMStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        ShowForm(frmDashboard)
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        ShowMasterWithUserRights(frmChangePassword, "Change Password")
    End Sub

    Private Sub SewingProductionByUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub AccessoriesListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowFormWithUserRights(frmAccessoriesList, "Accessories List")
    End Sub

    Private Sub YarnAllocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowFormWithUserRights(frmYarnAllocation, "Yarn Allocation GMT")
    End Sub

    Private Sub ShipmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ActivitiesTemplateListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CommercialInvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommercialInvoiceToolStripMenuItem.Click
        ShowFormWithUserRights(frmCommercialInvoice, "Commercial Invoice")
    End Sub

    Private Sub OrderPrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderPrintToolStripMenuItem.Click
        blnMIS = True

        With frmOrderPrint

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Private Sub OrderBookingMasterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderBookingMasterToolStripMenuItem1.Click
        With frmOrderBookingMasterReport

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Private Sub FabricBookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricBookingToolStripMenuItem.Click
        ShowForm(frmFabricConsumptionPrint)

    End Sub

    Private Sub OrderStatusToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderStatusToolStripMenuItem1.Click

        With frmOrderStatusReport

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With

    End Sub

    Private Sub OrderDetailsPrintToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderDetailsPrintToolStripMenuItem1.Click
        With frmOrderBookingMaster_Export
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ActivitiesPrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivitiesPrintToolStripMenuItem.Click
        With frmOrderActivities
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Private Sub ShipmentStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShipmentStatusToolStripMenuItem.Click
        With frmOrderShippmentStatus

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Private Sub ShipmentStatusWiithProductionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShipmentStatusWiithProductionToolStripMenuItem.Click
        With frmDelayShipmentStatusComments

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Private Sub ShipmentBalanceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShipmentBalanceToolStripMenuItem1.Click
        With frmShipmentBalanceReport

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DashboardToolStripMenuItem.Click
        ShowForm(frmDashboard)
    End Sub

    Private Sub SampleFabricBookingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampleFabricBookingToolStripMenuItem1.Click
        'With frmSampleFabricBooking
        '    .MIS = True
        '    .MdiParent = Me
        '    .WindowState = FormWindowState.Maximized
        '    .Show()

        'End With

        ShowForm(frmSampleFabricBookingPrint)
    End Sub

    Private Sub SampleFabricStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowForm(frmSampleRequestStatus)
    End Sub

    Private Sub SampleFabricRequestUpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("Under Build", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CuttingClosingReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuttingClosingReportToolStripMenuItem.Click
        With frmCuttingClosingReport

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Private Sub DailyCuttingReportToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyCuttingReportToolStripMenuItem1.Click

        With frmDailyCuttingReport

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .MIS = True
            .Show()

        End With

    End Sub

    Private Sub JobCartListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JobCartListToolStripMenuItem.Click
        With frmJobCardListDetails

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Private Sub DailyFinishingReportToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyFinishingReportToolStripMenuItem1.Click
        With frmDailyFinishingReport
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .MIS = True
            .Show()

        End With
    End Sub

    Private Sub FinishingReportProgramwiseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishingReportProgramwiseToolStripMenuItem1.Click
        With frmFinishingReportProgramWise
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub SizewiseFinishingProductionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SizewiseFinishingProductionToolStripMenuItem1.Click
        With frmSizewiseFinishingProduction
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub DailySewingProductionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailySewingProductionToolStripMenuItem.Click
        With frmDailySewingReport
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .MIS = True
            .Show()
        End With
    End Sub

    Private Sub DailySewingAttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailySewingAttendanceToolStripMenuItem.Click
        With frmDailyAttendanceReport
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub SewingProductionByLineAndDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingProductionByLineAndDateToolStripMenuItem.Click
        With frmSewingProduction_LineAndDateRange

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Private Sub SewingTableQCReportToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingTableQCReportToolStripMenuItem1.Click
        With frmSewingTableQCReport

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Private Sub SewingInputBalanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingInputBalanceToolStripMenuItem.Click
        With frmInputBalanceReport

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub



    Private Sub YarnPriceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YarnPriceToolStripMenuItem1.Click
        ShowMasterWithUserRights(frmYarnPrice, "Yarn Price")
    End Sub

    Private Sub FabricCostingMasterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricCostingMasterToolStripMenuItem1.Click
        ShowFormWithUserRights(frmFabricCostingMaster, "Fabric Costing Master")
    End Sub

    Private Sub PreCosingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreCosingToolStripMenuItem.Click
        ShowFormWithUserRights(frmPreCosting, "Pre Costing")
    End Sub

    Private Sub StyleCaptureFabricToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleCaptureFabricToolStripMenuItem.Click


        ShowFormWithUserRights(frmStyleCapture_Fabric, "Style Capture Fabric")

    End Sub

    Private Sub StyleCaptureAccessoriesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleCaptureAccessoriesToolStripMenuItem1.Click

        ShowFormWithUserRights(frmStyleCapture_Fabric, "Style Capture Fabric")

    End Sub

    Private Sub AccessoriesTemplateToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccessoriesTemplateToolStripMenuItem1.Click
        ShowMasterWithUserRights(frmAccessoriesTemplate, "Accessories Template")
    End Sub

    Private Sub ActivitiesListToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivitiesListToolStripMenuItem1.Click
        ShowMasterWithUserRights(ActivitiesList, "Activities List")
    End Sub


    Private Sub ActivitesTemplateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivitesTemplateToolStripMenuItem.Click
        ShowFormWithUserRights(frmActivitiesTemplate, "Activities Template")
    End Sub

    Private Sub ActivitiesGroupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivitiesGroupToolStripMenuItem.Click
        ShowMasterWithUserRights(frmActivitiesGroup, "Activities Group")
    End Sub

    Private Sub SampleOrderToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampleOrderToolStripMenuItem1.Click
        ShowFormWithUserRights(frmSampleOrder, "Sample Order")
    End Sub

    Private Sub SampleFabricBookingToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampleFabricBookingToolStripMenuItem2.Click
        ShowFormWithUserRights(frmFabricBooking_Sample, "Fabric Booking Sample")
    End Sub

    Private Sub SampleDeliveryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampleDeliveryToolStripMenuItem1.Click
        ShowFormWithUserRights(frmGatepass, "Sample Delivery")
    End Sub

    Private Sub ShipmentToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShipmentToolStripMenuItem2.Click
        ShowFormWithUserRights(frmShipment, "Shipment")
    End Sub

    Private Sub BuyerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuyerToolStripMenuItem1.Click
        'frmBuyer.ShowDialog()
        ShowMasterWithUserRights(frmBuyer, "Buyer")
    End Sub

    Private Sub BranchToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BranchToolStripMenuItem1.Click
        'frmBranch.ShowDialog()
        ShowMasterWithUserRights(frmBranch, "Branch")
    End Sub

    Private Sub ShipmentFromSubContractToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With frmShipmentFromSubContract

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Private Sub CompanyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanyToolStripMenuItem1.Click
        ShowMasterWithUserRights(frmCompany, "Company")
    End Sub

    Private Sub PrintColorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintColorToolStripMenuItem1.Click
        ShowMasterWithUserRights(frmPrintColor, "Print Color")
    End Sub

    Private Sub PrintTypeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintTypeToolStripMenuItem1.Click
        ShowMasterWithUserRights(frmPrintType, "Print Type")
    End Sub

    Private Sub PrintPartToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPartToolStripMenuItem1.Click
        ShowMasterWithUserRights(frmPrintPart, "Print Part")
    End Sub

    Private Sub PMListToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PMListToolStripMenuItem1.Click
        ShowMasterWithUserRights(frmPMList, "PM List")
    End Sub

    Private Sub APOListToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AOPListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AOPListToolStripMenuItem.Click
        ShowMasterWithUserRights(FrmAPOList, "APO List")
    End Sub

    Private Sub LineCheifListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LineCheifListToolStripMenuItem.Click
        ShowMasterWithUserRights(frmLineChiefList, "Line Chief List")
    End Sub

    Private Sub FloorInchargeListToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FloorInchargeListToolStripMenuItem1.Click
        ShowMasterWithUserRights(frmFloorIncharge, "Floor Incharge")
    End Sub

    Private Sub SewingMachineListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingMachineListToolStripMenuItem.Click
        ShowMasterWithUserRights(frmSewingMachine, "Sewing Machine")
    End Sub

    Private Sub QCCheckListToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QCCheckListToolStripMenuItem1.Click
        ShowMasterWithUserRights(frmQCCheckList, "QC Check List")
    End Sub

    Private Sub ActiveMonthToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActiveMonthToolStripMenuItem1.Click
        ShowMasterWithUserRights(frmActiveMonth, "Active Month")
    End Sub

    Private Sub SewingLearningCurveToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingLearningCurveToolStripMenuItem1.Click
        ShowMasterWithUserRights(frmLearningCurve, "Learning Curve")
    End Sub

    Private Sub SewingProcessToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingProcessToolStripMenuItem1.Click
        ShowMasterWithUserRights(frmSewingProcess, "Sewing Process")
    End Sub

    Private Sub SewingCategoryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingCategoryToolStripMenuItem1.Click
        ShowMasterWithUserRights(SewingCategory, "Sewing Category")
    End Sub

    Private Sub LineToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LineToolStripMenuItem1.Click
        ShowFormWithUserRights(frmLine, "Line")
    End Sub

    Private Sub SewingLayoutToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingLayoutToolStripMenuItem2.Click
        ShowFormWithUserRights(frmSewingLayout, "Sewing Layout")
    End Sub

    Private Sub StylewiseCMToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StylewiseCMToolStripMenuItem1.Click

        ShowMasterWithUserRights(frmCuttingMaking, "Stylewise CM")

    End Sub

    Private Sub ProductionBonusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductionBonusToolStripMenuItem.Click
        ShowFormWithUserRights(frmBonusTopSheetGenerator, "Production Bonus Top Sheet")
        PictureBox1.Visible = False
    End Sub

    Private Sub SewingCapacityToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingCapacityToolStripMenuItem1.Click
        ShowMasterWithUserRights(frmSewingCapacity, "Sewing Catacity")
    End Sub

    Private Sub SwProcessToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SwProcessToolStripMenuItem1.Click
        ShowMasterWithUserRights(frmswProcess, "Sewing Process")
    End Sub

    Private Sub SwOperationCapacityToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SwOperationCapacityToolStripMenuItem1.Click
        ShowMasterWithUserRights(frmswOperationCapacity, "Sewing Operation Capacity")
    End Sub

    Private Sub IEToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IEToolStripMenuItem2.Click

        'With frmSewingProcessDetails

        '    .MdiParent = Me
        '    .WindowState = FormWindowState.Maximized
        '    .Show()

        'End With

    End Sub

    Private Sub WorkingHourToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkingHourToolStripMenuItem1.Click
        ShowMasterWithUserRights(frmWorkingHour, "Working Hour")
    End Sub

    Private Sub CuttingProductionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuttingProductionToolStripMenuItem.Click
        ShowFormWithUserRights(frmCuttingProduction, "Cutting Production")
    End Sub

    Private Sub CuttingProductionJobCardToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuttingProductionJobCardToolStripMenuItem1.Click
        ShowFormWithUserRights(frmCuttingProductionNew, "Cutting Production From Job Card")
    End Sub

    Private Sub SewingAttendanceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingAttendanceToolStripMenuItem1.Click
        ShowFormWithUserRights(frmSewingAttendance, "Sewing Attendance")
    End Sub

    Private Sub SewingProductionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingProductionToolStripMenuItem.Click

        With frmSewingProduction
            .ByUserFlag = False
        End With
        ShowFormWithUserRights(frmSewingProduction, "Sewing Production")

    End Sub

    Private Sub SewingProductionByUserToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingProductionByUserToolStripMenuItem1.Click
        frmSewingProduction.ByUserFlag = True
        ShowFormWithUserRights(frmSewingProduction, "Sewing Production Userwise")
    End Sub

    Private Sub SewingTableQCToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingTableQCToolStripMenuItem1.Click
        ShowFormWithUserRights(frmSewingTableQC, "Sewing Table QC")
    End Sub

    Private Sub ShipmentCommentsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShipmentCommentsToolStripMenuItem1.Click
        ShowMasterWithUserRights(frmShipmentComents, "Shipment Comments")
    End Sub

    Private Sub SewingTransferToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingTransferToolStripMenuItem1.Click
        ShowMasterWithUserRights(frmSewingTransfer, "Sewing Transfer")
    End Sub

    Private Sub DaywiseProductionSummeryToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaywiseProductionSummeryToolStripMenuItem2.Click
        ShowFormWithUserRights(frmDailyProductionSummery, "Daily Production Summery")
    End Sub

    Private Sub LeftOverToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftOverToolStripMenuItem2.Click
        ShowFormWithUserRights(frmLeftOver, "Left Over")
    End Sub

    Private Sub FinishingProductionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishingProductionToolStripMenuItem1.Click
        ShowFormWithUserRights(frmFinishingProduction, "Finishing Production")
    End Sub

    Private Sub FinishingInputToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FinishingInputToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishingInputToolStripMenuItem1.Click
        ShowMasterWithUserRights(frmFinishingInput, "Finishing Input")
    End Sub

    Private Sub FinishingRejectionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishingRejectionToolStripMenuItem1.Click
        ShowFormWithUserRights(frmFinishingRejection, "Finishing Rejection")
    End Sub

    Private Sub FinishingDefectToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishingDefectToolStripMenuItem1.Click
        ShowFormWithUserRights(frmFinishingDefect, "Finishing Defect")
    End Sub

    Private Sub FinishingAttendanceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishingAttendanceToolStripMenuItem1.Click
        ShowFormWithUserRights(frmFinishingAttendance, "Finishing Attendance")
    End Sub

    Private Sub OrderActivitiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderActivitiesToolStripMenuItem.Click
        ShowFormWithUserRights(frmOrderActivities, "Order Activities")
    End Sub

    Private Sub EntryFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryFormToolStripMenuItem.Click

    End Sub

    Private Sub BuyerMerchandiserwiseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuyerMerchandiserwiseToolStripMenuItem.Click

        frmOrderReceived.ByUserFlag = True
        ShowFormWithUserRights(frmOrderReceived, "Buyer Order [Merchandiserwise]")

    End Sub

    Private Sub AccessoriesBookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccessoriesBookingToolStripMenuItem.Click
        ShowForm(frmAccessoriesBookingPrint)
    End Sub

    Private Sub AccessoriesWorkOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccessoriesWorkOrderToolStripMenuItem.Click
        ShowForm(frmAccessoriesWorkOrderSheetPrint)
    End Sub

    Private Sub PostCostingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PostCostingToolStripMenuItem.Click
        ShowForm(frmPostCosting)
    End Sub

    Private Sub SewingOperationAnalyzeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingOperationAnalyzeToolStripMenuItem1.Click
        MessageBox.Show("Under Build", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CutPanelRejectionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutPanelRejectionToolStripMenuItem1.Click
        ShowFormWithUserRights(frmCutPanelRejection, "Cut Panel Rejection")
    End Sub

    Private Sub SampleRequestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampleRequestToolStripMenuItem.Click
        ShowForm(frmSampleRequestStatus)
    End Sub

    Private Sub FabricReceivedReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricReceivedReportToolStripMenuItem.Click
        ShowForm(frmFabricReceivedReport)
    End Sub

    Private Sub CuttingNoWiseReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuttingNoWiseReportToolStripMenuItem.Click
        ShowForm(frmCuttingNumberwiseReport)
    End Sub

    Private Sub CuttingBundleInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuttingBundleInformationToolStripMenuItem.Click
        ShowFormWithUserRights(frmCuttingBundleTracking, "Cutting Bundle Information")
    End Sub

    Private Sub CuttingBundleAndStickerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuttingBundleAndStickerToolStripMenuItem.Click
        ShowForm(frmBundleSheet)
    End Sub

    Private Sub LinewiseInputReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinewiseInputReportToolStripMenuItem.Click
        ShowForm(frmLinewiseCuttingInputReport)
    End Sub

    Private Sub EmbroideryWorkOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmbroideryWorkOrderToolStripMenuItem.Click
        frmEmbroideryOrder.IsOutSide = False
        ShowFormWithUserRights(frmEmbroideryOrder, "Embroidery Work Order[In-house]")
    End Sub

    Private Sub EmbroideryOrderSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmbroideryOrderSheetToolStripMenuItem.Click
        ShowForm(frmEmbOrderPrint)
    End Sub

    Private Sub EmbroideryProductionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmbroideryProductionToolStripMenuItem.Click
        ShowFormWithUserRights(frmEmbroideryProduction, "Embroidery Production")
    End Sub

    Private Sub EmbroideryProductionReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmbroideryProductionReportToolStripMenuItem.Click
        ShowForm(frmEmbroideryProductionPrint)
    End Sub

    Private Sub EmbroideryMachineListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmbroideryMachineListToolStripMenuItem.Click
        ShowFormWithUserRights(frmEmbMachineList, "Embroidery Machine List")
    End Sub

    Private Sub PrintStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintStatusToolStripMenuItem.Click
        ShowFormWithUserRights(frmPrintStatus, "Printing Status")
    End Sub

    Private Sub ShipmentReportWithInvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShipmentReportWithInvoiceToolStripMenuItem.Click
        ShowForm(frmShipmentReport)
    End Sub

    Private Sub PreCostingToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreCostingToolStripMenuItem.Click
        ShowForm(frmPreCostingNewUser)
    End Sub

    Private Sub FloorRequisitionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FloorRequisitionToolStripMenuItem.Click
        ShowFormWithUserRights(frmFloorRequisition, "Floor Requisition")
    End Sub

    Private Sub ApproveSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApproveSheetToolStripMenuItem.Click
        ShowFormWithUserRights(frmApproveSheet, "Approve Sheet")
    End Sub

    Private Sub SignatureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignatureToolStripMenuItem.Click
        ShowMasterWithUserRights(frmSignature, "Signature")
    End Sub

    Private Sub SewingPlanningToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingPlanningToolStripMenuItem.Click
        frmPlanningBoardNew.MIS = False
        ShowFormWithUserRights(frmPlanningBoardNew, "Sewing Planning")
    End Sub

    Private Sub SewingPlanningToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingPlanningToolStripMenuItem1.Click

        ShowForm(frmSewingPlanningReport)

    End Sub

    Private Sub HolidayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HolidayToolStripMenuItem.Click
        ShowFormWithUserRights(frmHoliday, "Holiday")
    End Sub

    Private Sub MasterOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterOrderToolStripMenuItem.Click
        frmMasterOrder.ByMerchanFlag = False
        ShowFormWithUserRights(frmMasterOrder, "Master Order")
        'ShowForm(frmMasterOrder)
    End Sub



    Private Sub DocumentLibraryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocumentLibraryToolStripMenuItem.Click
        ShowFormWithUserRights(frmDocumentLibrary, "Document Library")
    End Sub

    Private Sub MasterOrderReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub OrderDeliveryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderDeliveryToolStripMenuItem1.Click
        ShowFormWithUserRights(frmDelivery, "Shipment Delivery Challan")
    End Sub

    Private Sub MasterLCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterLCToolStripMenuItem.Click
        ShowFormWithUserRights(frmMasterLC, "Master LC")
    End Sub


    Private Sub AWSApprovalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AWSApprovalToolStripMenuItem.Click
        ShowFormWithUserRights(frmAWSApproval, "AWS Approval")
    End Sub

    Private Sub StyleTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleTypeToolStripMenuItem.Click
        ShowMasterWithUserRights(frmStyleType, "Style Type")
    End Sub

    Private Sub GarmentsBrandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GarmentsBrandToolStripMenuItem.Click
        ShowMasterWithUserRights(frmGMTBrand, "Garments Brand")
    End Sub

    Private Sub MasterOrderMerchandiserWiseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterOrderMerchandiserWiseToolStripMenuItem.Click

        frmMasterOrder.ByMerchanFlag = True
        ShowFormWithUserRights(frmMasterOrder, "Master Order [Merchandiser Wise]")

    End Sub

    Private Sub AccessoriesBOMApprovalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccessoriesBOMApprovalToolStripMenuItem.Click

        ShowFormWithUserRights(frmAccBOMApproval, "Accessories BOM Approval")

    End Sub

    Private Sub AccessoriesWorkOrderProcurementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccessoriesWorkOrderProcurementToolStripMenuItem.Click
        ShowFormWithUserRights(frmAWSNew, "Accessories Work Order [Procurement]")
    End Sub

    Private Sub SampleCompleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampleCompleteToolStripMenuItem.Click
        ShowMasterWithUserRights(frmSampleComplete, "Sample Complete")
    End Sub

    Private Sub Buyer2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buyer2ToolStripMenuItem.Click
        ShowMasterWithUserRights(frmBuyer2, "Buyer2")
    End Sub

    Private Sub BankAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BankAccountToolStripMenuItem.Click
        ShowMasterWithUserRights(frmBankAccount, "Bank Account")
    End Sub

    Private Sub FloorRequsitionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FloorRequsitionToolStripMenuItem.Click
        ShowForm(frmRequisitionFloorPrint)
    End Sub

    Private Sub ProductionMonthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductionMonthToolStripMenuItem.Click
        ShowMasterWithUserRights(frmProductionMonth, "Production Month")
    End Sub

    Private Sub SewingLineStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SewingLineStatusToolStripMenuItem.Click
        'ShowForm(frmSewingLineStatusReport)
        With frmSewingLineStatusReport

            '.MdiParent = frmMain
            .WindowState = FormWindowState.Maximized
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()

        End With

    End Sub

    Private Sub OrderAndProductionStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderAndProductionStatusToolStripMenuItem.Click
        frmOrderAndProductionStatus.MIS = True
        ShowForm(frmOrderAndProductionStatus)
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click

    End Sub

    Private Sub GeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralToolStripMenuItem.Click

    End Sub

    Private Sub CareLabelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CareLabelToolStripMenuItem.Click
        ShowMasterWithUserRights(frmCareLabel, "Care Label")
    End Sub

    Private Sub ShipmentClosingReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShipmentClosingReportToolStripMenuItem.Click
        ShowForm(frmShipmentCompleteReport)
    End Sub

    Private Sub ProgramFullAndFinalAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramFullAndFinalAllToolStripMenuItem.Click
        frmProgramFullAndFinal.ByUserFlag = False
        ShowFormWithUserRights(frmProgramFullAndFinal, "Program Full And Final [All]")
    End Sub

    Private Sub SamplreStatusUpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SamplreStatusUpdateToolStripMenuItem.Click
        ShowFormWithUserRights(frmSampleStatusUpdate, "Sample Status Update")
    End Sub

    Private Sub SampleSummeryReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SampleSummeryReportToolStripMenuItem.Click
        ShowForm(frmSampleSummeryReport)
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        frmOrderAndProductionStatus.MIS = False
        ShowForm(frmOrderAndProductionStatus)
    End Sub

    Private Sub SampleDeliveryGatePassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SampleDeliveryGatePassToolStripMenuItem.Click
        ShowForm(frmGatePassPrint)
    End Sub

    Private Sub ShipmentDeliveryChallanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShipmentDeliveryChallanToolStripMenuItem.Click
        ShowForm(frmShipmentDeliveryChallanPrint)
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        InstallUpdateSyncWithInfo()
    End Sub
    Private Sub InstallUpdateSyncWithInfo()
        Dim info As UpdateCheckInfo = Nothing

        If (ApplicationDeployment.IsNetworkDeployed) Then
            Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment

            Try
                info = AD.CheckForDetailedUpdate()
            Catch dde As DeploymentDownloadException
                MessageBox.Show("The new version of the application cannot be downloaded at this time. " + ControlChars.Lf & ControlChars.Lf & "Please check your network connection, or try again later. Error: " + dde.Message)
                Return
            Catch ioe As InvalidOperationException
                MessageBox.Show("This application cannot be updated. It is likely not a ClickOnce application. Error: " & ioe.Message)
                Return
            End Try

            If (info.UpdateAvailable) Then
                Dim doUpdate As Boolean = True

                If (Not info.IsUpdateRequired) Then
                    Dim dr As DialogResult = MessageBox.Show("An update is available. Would you like to update the application now?", "Update Available", MessageBoxButtons.OKCancel)
                    If (Not System.Windows.Forms.DialogResult.OK = dr) Then
                        doUpdate = False
                    End If
                Else
                    ' Display a message that the app MUST reboot. Display the minimum required version.
                    MessageBox.Show("This application has detected a mandatory update from your current " &
                        "version to version " & info.MinimumRequiredVersion.ToString() &
                        ". The application will now install the update and restart.",
                        "Update Available", MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
                End If

                If (doUpdate) Then
                    Try
                        AD.Update()
                        MessageBox.Show("The application has been upgraded, and will now restart.")
                        Application.Restart()
                    Catch dde As DeploymentDownloadException
                        MessageBox.Show("Cannot install the latest version of the application. " & ControlChars.Lf & ControlChars.Lf & "Please check your network connection, or try again later.")
                        Return
                    End Try
                End If
            End If
        End If
    End Sub


    Private Sub SizewiseSewingOutputReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SizewiseSewingOutputReportToolStripMenuItem.Click
        ShowForm(frmSizewiseSewingOutputReport)

    End Sub

    Private Sub GeneralGatePassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralGatePassToolStripMenuItem.Click

        ShowFormWithUserRights(frmGeneralGatePass, "General Gate Pass")

    End Sub

    Private Sub ActivitiesTemplateDiagramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivitiesTemplateDiagramToolStripMenuItem.Click

        ShowForm(frmActivitiesDiagram)

    End Sub

    Private Sub SendMailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendMailToolStripMenuItem.Click

        ShowMasterWithUserRights(frmMailingAddress, "Mailing Address")

    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click

        With frmOrderBookingMasterReport

            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With

    End Sub

    Private Sub SewingPlanningBoardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SewingPlanningBoardToolStripMenuItem.Click

        frmPlanningBoardNew.MIS = True
        ShowForm(frmPlanningBoardNew)

    End Sub

    Private Sub ProductionTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductionTypeToolStripMenuItem.Click
        ShowMasterWithUserRights(frmProductionType, "Production Type")
    End Sub

    Private Sub ProductionTargetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductionTargetToolStripMenuItem.Click
        ShowMasterWithUserRights(frmProductionTarget, "Production Target")
    End Sub

    Private Sub RunningOrderProductionStatusToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MasterOrderStatusToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MasterOrderStatusToolStripMenuItem1.Click
        ShowForm(frmMasterOrderStatus)
    End Sub

    Private Sub PrintRecipeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintRecipeToolStripMenuItem.Click
        ShowForm(frmPrintRecipeReport)
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        ShowForm(frmOrderActivities)
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        ShowForm(frmSewingPlanningReport)
    End Sub

    Private Sub SewingInputToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SewingInputToolStripMenuItem.Click
        ShowMasterWithUserRights(SewingInput, "Sewing Input")
    End Sub

    Private Sub CuttingDeliveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuttingDeliveryToolStripMenuItem.Click
        ShowFormWithUserRights(frmCuttingDelivery, "Cutting Delivery")
    End Sub

    Private Sub CuttingDeliveryChallanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuttingDeliveryChallanToolStripMenuItem.Click
        ShowForm(frmCuttingDeliveryChallanPrint)
    End Sub

    Private Sub EmbroideryWorkOrderOutsideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmbroideryWorkOrderOutsideToolStripMenuItem.Click
        frmEmbroideryOrder.IsOutSide = True
        ShowFormWithUserRights(frmEmbroideryOrder, "Embroidery Work Order[Out-Side]")
    End Sub

    Private Sub SizewiseProductionReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SizewiseProductionReportToolStripMenuItem.Click
        ShowForm(frmSizewiseProductionReport)
    End Sub

    Private Sub CostingApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CostingApprovalToolStripMenuItem.Click
        ShowFormWithUserRights(frmPreCostingApproval, "Costing Approval")
    End Sub

    Private Sub BuyerOrderReceiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuyerOrderReceiveToolStripMenuItem.Click
        ShowForm(frmBuyerOrderReceive)
    End Sub

    Private Sub AccessoriesInventoryStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccessoriesInventoryStatusToolStripMenuItem.Click
        ShowForm(frmAccessoriesBookingStatusReport)
    End Sub

    Private Sub SewingSizewiseInputOutputReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SewingSizewiseInputOutputReportToolStripMenuItem.Click
        ShowForm(frmSewingSizewiseInputOutputReport)
    End Sub

    Private Sub CustomLearningCurveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomLearningCurveToolStripMenuItem.Click
        ShowMasterWithUserRights(frmCustomLearningCurve, "Custom Learning Curve")
    End Sub

    Private Sub SewingStatusMonthYearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SewingStatusMonthYearToolStripMenuItem.Click
        ShowForm(frmSewingOutputStatusMonthYear)
    End Sub

    Private Sub ShipmentSummeryReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShipmentSummeryReportToolStripMenuItem.Click
        ShowForm(frmShipmentSummeryRepot1)
    End Sub

    Private Sub ProgramStyleClosingReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramStyleClosingReportToolStripMenuItem.Click
        ShowForm(frmShipmentCompleteReport)
    End Sub

    Private Sub ProgramStyleAllRunningProductionStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramStyleAllRunningProductionStatusToolStripMenuItem.Click
        ShowForm(frmRunningOrderProductionStatus)
    End Sub


    Private Sub SupplierListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierListToolStripMenuItem.Click
        ShowForm(frmSupplierListReport)
    End Sub

    Private Sub FabricMaterialTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FabricMaterialTypeToolStripMenuItem.Click
        ShowMasterWithUserRights(frmFabricMatrialType, "Fabric Material Type")
    End Sub

    Private Sub SustanibilityStandardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SustanibilityStandardToolStripMenuItem.Click
        ShowMasterWithUserRights(frmSusStandard, "Sustanibility Standard")
    End Sub

    Private Sub SizewiseInputOutputReportCuttingSewingFinishingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SizewiseInputOutputReportCuttingSewingFinishingToolStripMenuItem.Click
        ShowForm(frmSizewiseInputOutputReport)
    End Sub

    Private Sub POSizewiseCuttingInputReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles POSizewiseCuttingInputReportToolStripMenuItem.Click
        ShowForm(frmCuttingPOSizeWiseInputReport)
    End Sub

    Private Sub SewingDeliveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SewingDeliveryToolStripMenuItem.Click
        ShowFormWithUserRights(frmSewingDelivery, "Sewing Delivery")
    End Sub

    Private Sub SewingDeliveryChallanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SewingDeliveryChallanToolStripMenuItem.Click
        ShowForm(frmSewingDeliveryChallanPrint)
    End Sub

    Private Sub EmbroideryDeliveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmbroideryDeliveryToolStripMenuItem.Click
        ShowFormWithUserRights(frmEmbroideryDelivery, "Embroidery Delivery")
    End Sub

    Private Sub PrintingDeliveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintingDeliveryToolStripMenuItem.Click
        ShowFormWithUserRights(frmPrintDelivery, "Printing Delivery")
    End Sub

    Private Sub PrintingDeliveryChallanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintingDeliveryChallanToolStripMenuItem.Click
        ShowForm(frmPrintingDeliveryChallanPrint)
    End Sub

    Private Sub EmbroideryDeliveryChallanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmbroideryDeliveryChallanToolStripMenuItem.Click
        ShowForm(frmEmbroideryDeliveryChallanPrint)
    End Sub

    Private Sub SewingLayoutListPendingCompleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SewingLayoutListPendingCompleteToolStripMenuItem.Click
        ShowForm(frmSewingLayoutList)
    End Sub

    Private Sub BudgetSheetManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BudgetSheetManagementToolStripMenuItem.Click
        ShowFormWithUserRights(frmPreCostingPrint, "Pre Costing Print")
    End Sub

    Private Sub PostCostingBudgetManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PostCostingBudgetManagementToolStripMenuItem.Click
        ShowFormWithUserRights(frmBudgetVSActualCost, "Post Costing Print")
    End Sub

    Private Sub PostCostingBudgetManagementToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PostCostingBudgetManagementToolStripMenuItem1.Click
        ShowFormWithUserRights(frmPostCosting, "Post Costing")
    End Sub

    Private Sub MonthWiseOrderStatusToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChallanCheckedListSecurityGateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChallanCheckedListSecurityGateToolStripMenuItem.Click
        ShowForm(frmChallanCheckedList)
    End Sub

    Private Sub PreCostingBudgetOpenValue5ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreCostingBudgetOpenValue5ListToolStripMenuItem.Click
        ShowFormWithUserRights(frmPreCostingOpenValueless5, "Pre Costing Open Valeu Less 5")
    End Sub

    Private Sub ProductionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductionToolStripMenuItem1.Click

    End Sub

    Private Sub CuttingProductionPOWiseReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuttingProductionPOWiseReportToolStripMenuItem.Click
        ShowForm(frmCuttingReportPOWise)
    End Sub

    Private Sub MachineRequireBySewingPlanningReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MachineRequireBySewingPlanningReportToolStripMenuItem.Click
        ShowForm(frmMachineRequireBySewingPlanning)
    End Sub

    Private Sub SewingPlanningBalanceReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SewingPlanningBalanceReportToolStripMenuItem.Click
        ShowForm(frmSewingPlanningBalanceReport)
    End Sub

    Private Sub TNAReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TNAReportToolStripMenuItem.Click
        ShowForm(TNAReport)
    End Sub

    Private Sub ProgramStyleCancelledEXDateWiseReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramStyleCancelledEXDateWiseReportToolStripMenuItem.Click
        ShowForm(frmProgramStyleCancel)
    End Sub

    Private Sub MasterOrderPrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterOrderPrintToolStripMenuItem.Click
        ShowForm(frmMasterOrderPrint)
    End Sub

    Private Sub OrderBookingMothWiseReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderBookingMothWiseReportToolStripMenuItem.Click
        ShowForm(frmMonthwiseOrderStatus)
    End Sub

    Private Sub ActuralMiscCostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActuralMiscCostToolStripMenuItem.Click
        ShowFormWithUserRights(frmMiscCost, "Actual Misc Cost")
    End Sub

    Private Sub SampleStatusUpdateNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SampleStatusUpdateNewToolStripMenuItem.Click

        frmSampleRequestStatusUpdateNew.MISFlag = False
        ShowFormWithUserRights(frmSampleRequestStatusUpdateNew, "Sample Request Status Update New")

    End Sub

    Private Sub DailyDatewiseProductionTargetListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyDatewiseProductionTargetListToolStripMenuItem.Click
        ShowForm(frmDailyProductionTargetList)
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        frmSampleRequestStatusUpdateNew.MISFlag = True
        ShowForm(frmSampleRequestStatusUpdateNew)
    End Sub

    Private Sub WashingToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles WashingToolStripMenuItem1.Click

    End Sub

    Private Sub WashingWorkSheetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WashingWorkSheetToolStripMenuItem.Click
        ShowFormWithUserRights(frmWashingWorkSheet, "Washing Work Sheet")
    End Sub

    Private Sub WashingBatchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WashingBatchToolStripMenuItem.Click
        ShowFormWithUserRights(frmWashingBatch, "Washing Batch")
    End Sub

    Private Sub WashingProducitonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WashingProducitonToolStripMenuItem.Click
        ShowFormWithUserRights(frmWashingProduction, "Washing Production")
    End Sub

    Private Sub DailyWashingProductionReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyWashingProductionReportToolStripMenuItem.Click
        ShowForm(frmWashingProductionReport)
    End Sub

    Private Sub WashingWorkSheetToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles WashingWorkSheetToolStripMenuItem1.Click
        ShowForm(frmWashingWorkSheetReport)
    End Sub

    Private Sub NERPDyeingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NERPDyeingToolStripMenuItem.Click
        'C:\Program Files (x86)\Microsoft SQL Server Management Studio 20\Common7\IDE

        Try
            ' Specify the path to the .exe file
            Dim exePath As String = "http://localhost:8082/nERP-Dyeing.application"
            Dim sessionManager As New SessionManager()


            If sessionManager.IsUserLoggedIn(UserId) Then
                'MessageBox.Show("User is already logged in.")
                Process.Start(exePath)
                ' Redirect to the main form or perform other actions
            Else
                MessageBox.Show("User is not logged in.")
                ' Proceed to the login form or other actions
            End If
            ' Start the process

        Catch ex As Exception
            ' Handle any exceptions that might occur
            Console.WriteLine("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub NERPInventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NERPInventoryToolStripMenuItem.Click
        Dim fbr As New FabricBookingReport
        fbr.CreateFabricBookingReport()
    End Sub
End Class
