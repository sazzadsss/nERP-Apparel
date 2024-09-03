Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient

Public Class frmOrderShippmentStatus
    Dim filterstring As String = ""
    Dim builder As New SqlConnectionStringBuilder(cnn)
    Dim user As String = builder.UserID
    Dim pass As String = builder.Password
    Dim server As String = builder.DataSource
    Dim db As String = builder.InitialCatalog

    Private _OID As Integer

    Public Property OID() As Integer
        Get
            Return _OID
        End Get
        Set(ByVal value As Integer)
            _OID = value
        End Set
    End Property

    Private Sub ShowShipmentInformation()

        Dim MyReport As New ShipmentInformation

        

        Dim myLogonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Dim myTable As Table

        For Each myTable In MyReport.Database.Tables 'If error check import..

            myLogonInfo = myTable.LogOnInfo
            'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
            myLogonInfo.ConnectionInfo.ServerName = server
            myLogonInfo.ConnectionInfo.DatabaseName = db
            myLogonInfo.ConnectionInfo.UserID = user
            myLogonInfo.ConnectionInfo.Password = pass
            myTable.ApplyLogOnInfo(myLogonInfo)

        Next myTable


        If MyReport.Subreports.Count > 0 Then
            For Each rpt As ReportDocument In MyReport.Subreports
                For Each myTable In rpt.Database.Tables
                    myLogonInfo = myTable.LogOnInfo
                    'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
                    myLogonInfo.ConnectionInfo.ServerName = server
                    myLogonInfo.ConnectionInfo.DatabaseName = db
                    myLogonInfo.ConnectionInfo.UserID = user
                    myLogonInfo.ConnectionInfo.Password = pass
                    myTable.ApplyLogOnInfo(myLogonInfo)
                Next myTable
            Next
        End If



        CrystalReportViewer1.ReportSource = MyReport



        Dim myParameterFields As ParameterFields = CrystalReportViewer1.ParameterFieldInfo

        Dim FromDateCurrentParameterValues As ParameterValues = New ParameterValues()
        Dim ToDateCurrentParameterValues As ParameterValues = New ParameterValues()

        Dim FromDateDiscreteValue As ParameterDiscreteValue = New ParameterDiscreteValue()
        Dim ToDateDiscreteValue As ParameterDiscreteValue = New ParameterDiscreteValue()

        FromDateDiscreteValue.Value = FromDateTimePicker.Value
        ToDateDiscreteValue.Value = ToDateTimePicker.Value


        FromDateCurrentParameterValues.Add(FromDateDiscreteValue)
        ToDateCurrentParameterValues.Add(ToDateDiscreteValue)

        Dim FromDateField As ParameterField = myParameterFields("FromDate")
        Dim ToDateField As ParameterField = myParameterFields("ToDate")

        FromDateField.CurrentValues = FromDateCurrentParameterValues
        ToDateField.CurrentValues = ToDateCurrentParameterValues

        CrystalReportViewer1.SelectionFormula = filterstring '"{Order.ProgramNo} = " & frmOrder.ProgramNoTextBox.Text & ""
        CrystalReportViewer1.Refresh()


    End Sub

    Private Sub ShowShipmentInformationByBuyer(Optional ByVal rptfilterstring As String = "")

        'Dim MyReport As ReportDocument
        'MyReport.Load(Application.StartupPath & "\Report\" & ReportName & ".rpt", OpenReportMethod.OpenReportByTempCopy)

        Dim MyReport As New ShipmentInformationbyBuyer


        Dim myLogonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Dim myTable As Table


        For Each myTable In MyReport.Database.Tables 'If error check import..

            myLogonInfo = myTable.LogOnInfo
            'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
            myLogonInfo.ConnectionInfo.ServerName = server
            myLogonInfo.ConnectionInfo.DatabaseName = db
            myLogonInfo.ConnectionInfo.UserID = user
            myLogonInfo.ConnectionInfo.Password = pass
            myTable.ApplyLogOnInfo(myLogonInfo)

        Next myTable

        If MyReport.Subreports.Count > 0 Then
            For Each rpt As ReportDocument In MyReport.Subreports
                For Each myTable In rpt.Database.Tables
                    myLogonInfo = myTable.LogOnInfo
                    'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
                    myLogonInfo.ConnectionInfo.ServerName = server
                    myLogonInfo.ConnectionInfo.DatabaseName = db
                    myLogonInfo.ConnectionInfo.UserID = user
                    myLogonInfo.ConnectionInfo.Password = pass
                    myTable.ApplyLogOnInfo(myLogonInfo)
                Next myTable
            Next
        End If



        CrystalReportViewer1.ReportSource = MyReport
        CrystalReportViewer1.SelectionFormula = rptfilterstring '"{Order.ProgramNo} = " & frmOrder.ProgramNoTextBox.Text & ""


        Dim myParameterFields As ParameterFields = CrystalReportViewer1.ParameterFieldInfo

        Dim FromDateCurrentParameterValues As ParameterValues = New ParameterValues()
        Dim ToDateCurrentParameterValues As ParameterValues = New ParameterValues()
        Dim BuyerCurrentParameterValues As ParameterValues = New ParameterValues()



        Dim FromDateDiscreteValue As ParameterDiscreteValue = New ParameterDiscreteValue()
        Dim ToDateDiscreteValue As ParameterDiscreteValue = New ParameterDiscreteValue()
        Dim BuyerDiscreteValue As ParameterDiscreteValue = New ParameterDiscreteValue()



        FromDateDiscreteValue.Value = FromDateTimePicker.Value
        ToDateDiscreteValue.Value = ToDateTimePicker.Value
        BuyerDiscreteValue.Value = BuyerComboBox.Text


        FromDateCurrentParameterValues.Add(FromDateDiscreteValue)
        ToDateCurrentParameterValues.Add(ToDateDiscreteValue)
        BuyerCurrentParameterValues.Add(BuyerDiscreteValue)

        Dim FromDateField As ParameterField = myParameterFields("FromDate")
        Dim ToDateField As ParameterField = myParameterFields("ToDate")
        Dim BuyerField As ParameterField = myParameterFields("BuyerCode")

        FromDateField.CurrentValues = FromDateCurrentParameterValues
        ToDateField.CurrentValues = ToDateCurrentParameterValues
        BuyerField.CurrentValues = BuyerCurrentParameterValues


        CrystalReportViewer1.Refresh()


    End Sub

    Private Sub ShowShipmentInformationByProgram(Optional ByVal rptfilterstring As String = "")

        'Dim MyReport As ReportDocument
        'MyReport.Load(Application.StartupPath & "\Report\" & ReportName & ".rpt", OpenReportMethod.OpenReportByTempCopy)

        Dim MyReport As New ShipmentInformationbyProgram

        Dim myLogonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Dim myTable As Table

        For Each myTable In MyReport.Database.Tables 'If error check import..

            myLogonInfo = myTable.LogOnInfo
            'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
            myLogonInfo.ConnectionInfo.ServerName = server
            myLogonInfo.ConnectionInfo.DatabaseName = db
            myLogonInfo.ConnectionInfo.UserID = user
            myLogonInfo.ConnectionInfo.Password = pass
            myTable.ApplyLogOnInfo(myLogonInfo)

        Next myTable

        If MyReport.Subreports.Count > 0 Then
            For Each rpt As ReportDocument In MyReport.Subreports
                For Each myTable In rpt.Database.Tables
                    myLogonInfo = myTable.LogOnInfo
                    'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
                    myLogonInfo.ConnectionInfo.ServerName = server
                    myLogonInfo.ConnectionInfo.DatabaseName = db
                    myLogonInfo.ConnectionInfo.UserID = user
                    myLogonInfo.ConnectionInfo.Password = pass
                    myTable.ApplyLogOnInfo(myLogonInfo)
                Next myTable
            Next
        End If




        CrystalReportViewer1.ReportSource = MyReport
        CrystalReportViewer1.SelectionFormula = rptfilterstring '"{Order.ProgramNo} = " & frmOrder.ProgramNoTextBox.Text & ""


        Dim myParameterFields As ParameterFields = CrystalReportViewer1.ParameterFieldInfo

        Dim FromDateCurrentParameterValues As ParameterValues = New ParameterValues()
        Dim ToDateCurrentParameterValues As ParameterValues = New ParameterValues()
        Dim BuyerCurrentParameterValues As ParameterValues = New ParameterValues()



        Dim FromDateDiscreteValue As ParameterDiscreteValue = New ParameterDiscreteValue()
        Dim ToDateDiscreteValue As ParameterDiscreteValue = New ParameterDiscreteValue()
        Dim BuyerDiscreteValue As ParameterDiscreteValue = New ParameterDiscreteValue()



        FromDateDiscreteValue.Value = FromDateTimePicker.Value
        ToDateDiscreteValue.Value = ToDateTimePicker.Value
        BuyerDiscreteValue.Value = BuyerComboBox.Text


        FromDateCurrentParameterValues.Add(FromDateDiscreteValue)
        ToDateCurrentParameterValues.Add(ToDateDiscreteValue)
        BuyerCurrentParameterValues.Add(BuyerDiscreteValue)

        Dim FromDateField As ParameterField = myParameterFields("FromDate")
        Dim ToDateField As ParameterField = myParameterFields("ToDate")
        Dim BuyerField As ParameterField = myParameterFields("BuyerCode")

        FromDateField.CurrentValues = FromDateCurrentParameterValues
        ToDateField.CurrentValues = ToDateCurrentParameterValues
        BuyerField.CurrentValues = BuyerCurrentParameterValues


        CrystalReportViewer1.Refresh()


    End Sub

    Private Sub frmOrderShippmentStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)

        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

        Dim StartMonth As Date = DateSerial(Year(Today), Month(Today), 1)
        Dim EndMonth As Date = DateSerial(Year(Today), Month(Today) + 1, 0)

        FromDateTimePicker.Value = StartMonth
        ToDateTimePicker.Value = EndMonth


        Dim FDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text

        'filterstring = "{ShipmentStatusSummerywithBranch.FinishingDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)AND {Branch.BranchId} = " & Me.BranchComboBox.SelectedValue & " AND {ShipmentStatusSummerywithBranch.TTLShippment} > 0.00 "

        'ShowShipmentInformation()
        If Me.OID > 0 Then

            If ShipmentRadioButton.Checked = True Then

                filterstring = "{vOrder.OrderId} = " & Me.OID

                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentInformation_ProgramWise
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            Else

                filterstring = "{vOrder.OrderId} = " & Me.OID

                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShippmentBalanceWithSewingOutput
                ShowReport(MyReport, filterstring, CrystalReportViewer1)


            End If
        End If

    End Sub



    Private Sub ShowButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton2.Click



        Dim FDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text


        'If ShipmentRadioButton.Checked = True Then


        '    'If SPRadioButton.Checked = True Then

        If BuyerCheckBox.Checked = True Then

            filterstring = "{ShipmentStatusSummerywithBranch.FinishingDate} in {?FromDate} to {?ToDate} and " &
                            "{ShipmentStatusSummerywithBranch.TTLShippment} > 0.00 and " &
                            "{vOrder.BuyerCode} ='" & BuyerComboBox.Text & "'And Not {vOrder.Discontinue}"


            If WithoutBranchCheckBox.Checked Then
                ' ShowShipmentInformationByProgram(filterstring)

                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentInformation
                MyReport.SetParameterValue("FromDate", FDate.Date)
                MyReport.SetParameterValue("ToDate", TDate.Date)
                'MyReport.SetParameterValue("BuyerCode", BuyerComboBox.Text)
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            Else
                ' ShowShipmentInformationByBuyer(filterstring)

                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentInformation
                MyReport.SetParameterValue("FromDate", FDate.Date)
                MyReport.SetParameterValue("ToDate", TDate.Date)
                'MyReport.SetParameterValue("BuyerCode", BuyerComboBox.Text)
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            End If


        Else


            'ShowShipmentInformation()
            Dim SFDate As Date = Me.FromDateTimePicker.Text
            Dim STDate As Date = Me.ToDateTimePicker.Text

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentInformation

            MyReport.SetParameterValue("FromDate", SFDate.Date)
            MyReport.SetParameterValue("ToDate", STDate.Date)

            filterstring = "{ShipmentStatusSummerywithBranch.FinishingDate} In {?FromDate} To {?ToDate} And {ShipmentStatusSummerywithBranch.TTLShippment} > 0.00 And Not {vOrder.Discontinue}"         '" {ShipmentStatusSummerywithBranch.FinishingDate} In DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) To DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)And {Branch.BranchId} = " & Me.BranchComboBox.SelectedValue & " And {ShipmentStatusSummerywithBranch.TTLShippment} > 0.00 "
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If



        'Else

        '    MessageBox.Show("Under Build", "Under Construction", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'End If


        'Else

        '    If SPRadioButton.Checked = True Then

        '        'MessageBox.Show("Under Build", "Under Construction", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '        filterstring = "{@Balance2} And {vOrder.EX} In DateTime (" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ", 00, 00, 00) To DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)"

        '        If CompactCheckBox.Checked Then

        '            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderStatusDetails_Compact
        '            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        '            'ElseIf OnlyOrderCheckBox.Checked Then

        '            '    Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderStatusDetails_Compact
        '            '    ShowReport(MyReport, filterstring, CrystalReportViewer1)

        '        Else
        '            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderStatusDetails
        '            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        '        End If



        '    Else

        '        filterstring = "{SewingProdSum_OrderBalance.TTLSewingOutput} > 0.00 And {vOrder.EX} In DateTime (" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ", 00, 00, 00) To DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ",00 ,00, 00 )"

        '        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShippmentBalanceWithSewingOutput2
        '        ShowReport(MyReport, filterstring, CrystalReportViewer1)

        '    End If


        'End If






    End Sub

    Private Sub ShowButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton3.Click


        If ShipmentRadioButton.Checked = True Then



            filterstring = "{vOrder.OrderId} = " & GridLookUpEdit1.EditValue

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentInformation_ProgramWise
            ShowReport(MyReport, filterstring, CrystalReportViewer1)


        Else


            filterstring = "{vOrder.OrderId} = " & GridLookUpEdit1.EditValue

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShippmentBalanceWithSewingOutput
            ShowReport(MyReport, filterstring, CrystalReportViewer1)


        End If


    End Sub



    Private Sub BuyerCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuyerCheckBox.CheckedChanged
        If BuyerCheckBox.Checked Then
            SummeryButton.Enabled = False
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
        Else
            SummeryButton.Enabled = True
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True

        End If
    End Sub



    Private Sub ShowShipmentInformationSummery()

        Dim MyReport As New ShipmentInformation_BranchAndBuyer

        Dim myLogonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Dim myTable As Table

        For Each myTable In MyReport.Database.Tables 'If error check import..

            myLogonInfo = myTable.LogOnInfo
            'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
            myLogonInfo.ConnectionInfo.ServerName = server
            myLogonInfo.ConnectionInfo.DatabaseName = db
            myLogonInfo.ConnectionInfo.UserID = user
            myLogonInfo.ConnectionInfo.Password = pass
            myTable.ApplyLogOnInfo(myLogonInfo)

        Next myTable


        'For Subreport

        If MyReport.Subreports.Count > 0 Then
            For Each rpt As ReportDocument In MyReport.Subreports
                For Each myTable In rpt.Database.Tables
                    myLogonInfo = myTable.LogOnInfo
                    'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
                    myLogonInfo.ConnectionInfo.ServerName = server
                    myLogonInfo.ConnectionInfo.DatabaseName = db
                    myLogonInfo.ConnectionInfo.UserID = user
                    myLogonInfo.ConnectionInfo.Password = pass
                    myTable.ApplyLogOnInfo(myLogonInfo)
                Next myTable
            Next
        End If



        CrystalReportViewer1.ReportSource = MyReport



        Dim myParameterFields As ParameterFields = CrystalReportViewer1.ParameterFieldInfo

        Dim FromDateCurrentParameterValues As ParameterValues = New ParameterValues()
        Dim ToDateCurrentParameterValues As ParameterValues = New ParameterValues()

        Dim FromDateDiscreteValue As ParameterDiscreteValue = New ParameterDiscreteValue()
        Dim ToDateDiscreteValue As ParameterDiscreteValue = New ParameterDiscreteValue()

        FromDateDiscreteValue.Value = FromDateTimePicker.Value
        ToDateDiscreteValue.Value = ToDateTimePicker.Value


        FromDateCurrentParameterValues.Add(FromDateDiscreteValue)
        ToDateCurrentParameterValues.Add(ToDateDiscreteValue)

        Dim FromDateField As ParameterField = myParameterFields("FromDate")
        Dim ToDateField As ParameterField = myParameterFields("ToDate")

        FromDateField.CurrentValues = FromDateCurrentParameterValues
        ToDateField.CurrentValues = ToDateCurrentParameterValues

        CrystalReportViewer1.SelectionFormula = filterstring '"{Order.ProgramNo} = " & frmOrder.ProgramNoTextBox.Text & ""
        CrystalReportViewer1.Refresh()


    End Sub

    Private Sub SummeryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummeryButton.Click

        Dim FDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text


        filterstring = "{ShipmentStatusSummerywithBranch.FinishingDate} In {?FromDate} To {?ToDate} And {ShipmentStatusSummerywithBranch.TTLShippment} > 0.00 And Not {vOrder.Discontinue}"         '" {ShipmentStatusSummerywithBranch.FinishingDate} In DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) To DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)And {Branch.BranchId} = " & Me.BranchComboBox.SelectedValue & " And {ShipmentStatusSummerywithBranch.TTLShippment} > 0.00 "
        ShowShipmentInformationSummery()


    End Sub


    Private Sub ShowYearlyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowYearlyButton.Click

        If BuyerCheckBox.Checked Then
            filterstring = "{MonthWiseShipment.BuyerCode} = '" & BuyerComboBox.Text & "'"
        Else
            filterstring = "{MonthWiseShipment.Yr} in " & ComboBox1.Text & " to " & ComboBox2.Text
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MonthwiseShipmentSummeryReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub SewingButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingButton.Click

        filterstring = "{SewingSummeryByOrderId.Yr} in " & ComboBox1.Text & " to " & ComboBox2.Text

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MonthwiseSewingOutput
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub CencelShowButton_Click(sender As Object, e As EventArgs) Handles CencelShowButton.Click
        Dim SFDate As Date = Me.FromDateTimePicker.Text
        Dim STDate As Date = Me.ToDateTimePicker.Text

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentInformation

        MyReport.SetParameterValue("FromDate", SFDate.Date)
        MyReport.SetParameterValue("ToDate", STDate.Date)

        filterstring = "{ShipmentStatusSummerywithBranch.FinishingDate} in {?FromDate} to {?ToDate} and {ShipmentStatusSummerywithBranch.TTLShippment} > 0.00 AND {vOrder.Discontinue}"         '" {ShipmentStatusSummerywithBranch.FinishingDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)AND {Branch.BranchId} = " & Me.BranchComboBox.SelectedValue & " AND {ShipmentStatusSummerywithBranch.TTLShippment} > 0.00 "
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) 

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text


        'If ShipmentRadioButton.Checked = True Then


        '    'If SPRadioButton.Checked = True Then

        If BuyerCheckBox.Checked = True Then

            filterstring = "{ShipmentStatusSummerywithBranch.FinishingDate} in {?FromDate} to {?ToDate} and " &
                            "{ShipmentStatusSummerywithBranch.TTLShippment} > 0.00 and " &
                            "{vOrder.BuyerCode} ='" & BuyerComboBox.Text & "'And Not {vOrder.Discontinue}"


            If WithoutBranchCheckBox.Checked Then
                ' ShowShipmentInformationByProgram(filterstring)

                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentInformationD
                MyReport.SetParameterValue("FromDate", FDate.Date)
                MyReport.SetParameterValue("ToDate", TDate.Date)
                'MyReport.SetParameterValue("BuyerCode", BuyerComboBox.Text)
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            Else
                ' ShowShipmentInformationByBuyer(filterstring)

                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentInformationD
                MyReport.SetParameterValue("FromDate", FDate.Date)
                MyReport.SetParameterValue("ToDate", TDate.Date)
                'MyReport.SetParameterValue("BuyerCode", BuyerComboBox.Text)
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            End If


        Else


            'ShowShipmentInformation()
            Dim SFDate As Date = Me.FromDateTimePicker.Text
            Dim STDate As Date = Me.ToDateTimePicker.Text

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentInformationD

            MyReport.SetParameterValue("FromDate", SFDate.Date)
            MyReport.SetParameterValue("ToDate", STDate.Date)

            filterstring = "{ShipmentStatusSummerywithBranch.FinishingDate} In {?FromDate} To {?ToDate} And {ShipmentStatusSummerywithBranch.TTLShippment} > 0.00 And Not {vOrder.Discontinue}"         '" {ShipmentStatusSummerywithBranch.FinishingDate} In DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) To DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)And {Branch.BranchId} = " & Me.BranchComboBox.SelectedValue & " And {ShipmentStatusSummerywithBranch.TTLShippment} > 0.00 "
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If



        'Else

        '    MessageBox.Show("Under Build", "Under Construction", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'End If


        'Else

        '    If SPRadioButton.Checked = True Then

        '        'MessageBox.Show("Under Build", "Under Construction", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '        filterstring = "{@Balance2} And {vOrder.EX} In DateTime (" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ", 00, 00, 00) To DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)"

        '        If CompactCheckBox.Checked Then

        '            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderStatusDetails_Compact
        '            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        '            'ElseIf OnlyOrderCheckBox.Checked Then

        '            '    Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderStatusDetails_Compact
        '            '    ShowReport(MyReport, filterstring, CrystalReportViewer1)

        '        Else
        '            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderStatusDetails
        '            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        '        End If



        '    Else

        '        filterstring = "{SewingProdSum_OrderBalance.TTLSewingOutput} > 0.00 And {vOrder.EX} In DateTime (" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ", 00, 00, 00) To DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ",00 ,00, 00 )"

        '        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShippmentBalanceWithSewingOutput2
        '        ShowReport(MyReport, filterstring, CrystalReportViewer1)

        '    End If


        'End If




    End Sub
End Class