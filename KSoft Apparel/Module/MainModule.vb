Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.OleDb
Imports System
Imports System.Net
Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop
Imports DevExpress.XtraSplashScreen
Imports System.Configuration
Imports System.Globalization
Imports System.Security.Cryptography.X509Certificates
Imports System.Net.Security

Module MainModule

    Public blnIssue As Boolean
    Public UserName As String
    Public Password As String
    Public UserActive As Boolean
    Public UserLevel As Integer
    Public UserId As Integer
    Public ItemId As Integer
    Public DepartmentId As Integer
    Public cnn As String = My.Settings.KSoft_ApparelConnectionString
    Public blnPrintColor As Boolean = False
    Public BuyerName As String = ""
    Public OrderId As Integer
    Public blnOrder As Boolean = True
    Public blnMIS As Boolean = True
    Public FabricColorIdvar As Integer
    Public StyleIdvar As Integer
    Public PrintOrderId As Integer
    Public PrintColorId As Integer
    Public YarnStoreId As Integer = 8
    Public PrintStoreId As Integer = 13
    Public DyeingChemicalStoreId As Integer = 7
    Public YarnStore As Integer = 8
    Public PrintBranchId As Integer = 10
    Public ExportDepartmentId As Integer = 39

    Public GarmentsStoreId As Integer = 10
    Public YDStoreId As Integer = 0
    Public DCStore As Integer = ReadIntegerData("Select DepartmentId From Department Where DepartmentName='Dyes Chemical Store'", cnn)
    Public GreyFabricStoreId As Integer = 12
    Public FinishFabricStoreId As Integer = 11
    Public KnittingDeliveryId As Integer = 5
    Public CuttingDepartmentId As Integer = 40
    Public PrintingDepartmentId As Integer = 24
    Public EmbroideryDepartmentId As Integer = 28
    Public YarnDyeingDepartmentId As Integer = 19
    Public MiscDepartmentId As Integer = 41
    Public SewingDepartmentId As Integer = 52
    Public SCode As String = "nERP"
    Public SName As String = "nERP Apparel Solutions"
    Public SCName As String = "nERP Solutions"
    Public PoweredBy As String = "Norban Group of Companies"

    'Public DepartmentName As String = String.Empty

    Sub Main()
        'Write your execution code here ....
        'frmSplash.Show()
    End Sub

    Public Sub ClearText(ByVal container As Control) 'Clear Text
        Dim ctrl As Control
        For Each ctrl In container.Controls
            If TypeOf (ctrl) Is TextBox Then
                ctrl.Text = ""
            End If
            If ctrl.HasChildren Then
                ClearText(ctrl)
            End If
        Next
    End Sub

    Public Sub EnableControl(ByVal container As Control) 'Enable control
        Dim ctrl As Control
        For Each ctrl In container.Controls

            If TypeOf (ctrl) Is TextBox And ctrl.Tag <> "NR" Then
                ctrl.Enabled = True
            End If

            If TypeOf (ctrl) Is ComboBox And ctrl.Tag <> "NR" Then
                ctrl.Enabled = True
            End If

            If ctrl.Tag = "XTRAEDITOR" Then
                ctrl.Enabled = True
            End If


            If TypeOf (ctrl) Is DateTimePicker Then
                ctrl.Enabled = True
            End If

            If TypeOf (ctrl) Is LinkLabel And ctrl.Tag = "btn" Then
                ctrl.Enabled = True

            End If

            If ctrl.HasChildren Then
                EnableControl(ctrl)
            End If
        Next
    End Sub

    Public Sub DisableControl(ByVal container As Control) 'Disable Control
        Dim ctrl As Control
        For Each ctrl In container.Controls
            If TypeOf (ctrl) Is TextBox And ctrl.Tag <> "NR" Then
                ctrl.Enabled = False
            End If

            If TypeOf (ctrl) Is ComboBox And ctrl.Tag <> "NR" Then
                ctrl.Enabled = False
            End If

            If ctrl.Tag = "XTRAEDITOR" Then
                ctrl.Enabled = False
            End If

            If TypeOf (ctrl) Is DateTimePicker Then
                ctrl.Enabled = False
            End If
            If TypeOf (ctrl) Is LinkLabel And ctrl.Tag = "btn" Then
                ctrl.Enabled = False

            End If
            If ctrl.HasChildren Then
                DisableControl(ctrl)
            End If
        Next
    End Sub

    Public Sub FuncKeysModule(ByVal value As Keys)
        'Check what function key is in a pressed state, and then perform the corresponding action.
        Select Case value
            Case Keys.F1
                'Add the code for the function key F1 here.
                MessageBox.Show("F1 pressed")
            Case Keys.F2
                'Add the code for the function key F2 here.
                MessageBox.Show("F2 pressed")
            Case Keys.F3
                'Add the code for the function key F3 here.
                MessageBox.Show("F3 pressed")
            Case Keys.F4
                'Add the code for the function key F4 here.
                MessageBox.Show("F4 pressed")
            Case Keys.F5
                'Add the code for the function key F5 here.
                MessageBox.Show("F5 pressed")
            Case Keys.F6
                'Add the code for the function key F6 here.
                MessageBox.Show("F6 pressed")
            Case Keys.F7
                'Add the code for the function key F7 here.
                MessageBox.Show("F7 pressed")
            Case Keys.F8
                'Add the code for the function key F8 here.
                MessageBox.Show("F8 pressed")
            Case Keys.F9
                'Add the code for the function key F9 here.
                MessageBox.Show("F9 pressed")
            Case Keys.F10
                'Add the code for the function key F10 here.
                MessageBox.Show("F10 pressed")
            Case Keys.F11
                'Add the code for the function key F11 here.
                MessageBox.Show("F11 pressed")
            Case Keys.F12
                'Add the code for the key F12 here
                MessageBox.Show("F12 pressed")
        End Select
    End Sub


    'Public Sub ClearMenu(ByVal myform As Form) 'Clear Text
    '    'Dim mnuItem As Control
    '    'For Each mnuItem In myform.Controls
    '    '    If TypeOf (mnuItem) Is Menu Then

    '    '        mnuItem.Visible = False

    '    '    End If

    '    'Next
    '    '////////////////////////////////////
    '    'Private Sub Form_Load()
    '    '    Dim mnuItem As Control
    '    '    Dim rs As New Recordset
    '    '    rs.Open("select blah blah blah", cnn)
    '    '    Do While Not rs.EOF
    '    '        For Each mnuItem In Me.Controls
    '    '            If TypeOf mnuItem Is Menu Then
    '    '                If mnuItem.Name = rs!MenuName Then
    '    '                    mnuItem.Enabled = True
    '    '                    Exit For
    '    '                End If
    '    '            End If
    '    '        Next
    '    '        rs.movenext()
    '    '    Loop
    '    'End Sub
    '    '//////////////////////////////////////////////////////////////////
    '    '//////////////////////////////////////////////////////////////////
    '    'Private Sub Form_Load()
    '    '    Dim mnuItem As Control
    '    '    Dim rs As New Recordset
    '    '    rs.Open("select blah blah blah", cnn) ' field(0) is menu item names of the items this user can have
    '    '    Do While Not rs.EOF
    '    '        Me.Controls(rs.Fields(0).Value).Enabled = True 'I think this will work
    '    '        rs.movenext()
    '    '    Loop
    '    'End Sub
    '    '//////////////////////////////////////////////////////////////////

    'End Sub

    Function ReadValue(ByVal queryString As String, ByVal connectionString As String) As String
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(queryString, connection)
            Dim QueryValue As String = String.Empty
            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                reader.Read()

                If reader.IsDBNull(0) Then
                    QueryValue = String.Empty
                Else
                    QueryValue = reader.GetString(0)
                End If

                'Else
                '    PreviousReceived = 0

                '    MessageBox.Show("No rows found.")
            End If

            reader.Close()

            Return QueryValue

        End Using

    End Function

    Function ReadProgramNo() As Integer
        Using connection As New SqlConnection(cnn)
            Dim querystring As String = "Select ProgramNo From [Order]"
            Dim command As New SqlCommand(querystring, connection)
            Dim QueryValue As Decimal
            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                reader.Read()

                If reader.IsDBNull(0) Then
                    QueryValue = 0
                Else
                    QueryValue = reader.GetDecimal(0)
                End If

                'Else
                '    PreviousReceived = 0

                '    MessageBox.Show("No rows found.")
            End If

            reader.Close()

            Return QueryValue

        End Using

    End Function

    Function GetData(ByVal selectCommand As String, ByVal connectionString As String) As DataTable

        'Dim connectionString As String = _
        '    "Integrated Security=SSPI;Persist Security Info=False;" + _
        '    "Initial Catalog=Northwind;Data Source=localhost;Packet Size=4096"

        ' Connect to the database and fill a data table.
        Dim adapter As New SqlDataAdapter(selectCommand, connectionString)
        Dim data As New DataTable()
        data.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(data)

        Return data

    End Function
    Public Sub DisableFromControl(ByVal container As Form) 'Disable Control
        Dim ctrl As Control
        For Each ctrl In container.Controls
            If TypeOf (ctrl) Is TextBox And ctrl.Tag <> "NR" Then
                ctrl.Enabled = False
            End If

            If TypeOf (ctrl) Is DevExpress.XtraEditors.TextEdit And ctrl.Tag <> "NR" Then
                ctrl.Enabled = False
            End If

            If TypeOf (ctrl) Is ComboBox And ctrl.Tag <> "NR" Then
                ctrl.Enabled = False
            End If

            If TypeOf (ctrl) Is DataGridView And ctrl.Tag <> "NR" Then
                ctrl.Enabled = False
            End If

            If ctrl.Tag = "XTRAEDITOR" Then
                ctrl.Enabled = False
            End If

            If TypeOf (ctrl) Is DateTimePicker Then
                ctrl.Enabled = False
            End If
            If TypeOf (ctrl) Is LinkLabel And ctrl.Tag = "btn" Then
                ctrl.Enabled = False

            End If
            If TypeOf (ctrl) Is FlowLayoutPanel And ctrl.Tag <> "NR" Then
                ctrl.Enabled = False
            End If

            If TypeOf (ctrl) Is SplitContainer And ctrl.Tag <> "NR" Then
                ctrl.Enabled = False
            End If

            'If ctrl.HasChildren Then
            '    DisableControl(ctrl)
            'End If
        Next
    End Sub
    Public Sub EnableFormControl(ByVal container As Form) 'Enable control
        Dim ctrl As Control
        For Each ctrl In container.Controls
            If TypeOf (ctrl) Is TextBox And ctrl.Tag <> "NR" Then
                ctrl.Enabled = True
            End If

            If TypeOf (ctrl) Is DevExpress.XtraEditors.TextEdit And ctrl.Tag <> "NR" Then
                ctrl.Enabled = True
            End If

            If TypeOf (ctrl) Is ComboBox And ctrl.Tag <> "NR" Then
                ctrl.Enabled = True
            End If
            If TypeOf (ctrl) Is DateTimePicker Then
                ctrl.Enabled = True

            End If

            If TypeOf (ctrl) Is DataGridView And ctrl.Tag <> "NR" Then
                ctrl.Enabled = True
            End If

            If ctrl.Tag = "XTRAEDITOR" Then
                ctrl.Enabled = True
            End If

            If TypeOf (ctrl) Is LinkLabel And ctrl.Tag = "btn" Then
                ctrl.Enabled = True

            End If

            If TypeOf (ctrl) Is FlowLayoutPanel And ctrl.Tag <> "NR" Then
                ctrl.Enabled = True
            End If

            If TypeOf (ctrl) Is SplitContainer And ctrl.Tag <> "NR" Then
                ctrl.Enabled = True
            End If

            'If ctrl.HasChildren Then
            '    EnableControl(ctrl)
            'End If
        Next
    End Sub

    Public Function FormOpen(ByRef thisForm As Form) As Boolean
        Return thisForm.Visible
    End Function

    Public Sub ExecuteQuery(ByVal queryString As String, ByVal connectionString As String)

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(queryString, connection)
            command.Connection.Open()
            command.CommandTimeout = 60000
            command.ExecuteNonQuery()
        End Using

    End Sub

    Function ReadData(ByVal queryString As String, ByVal connectionString As String) As Decimal
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(queryString, connection)
            Dim DataValue As Decimal
            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                reader.Read()

                'Do While reader.Read()
                '    Console.WriteLine(reader.GetInt32(0) _
                '      & vbTab & reader.GetString(1))
                'Loop

                If reader.IsDBNull(0) Then
                    DataValue = 0

                Else
                    DataValue = reader.GetDecimal(0)
                End If

                'Else
                '    PreviousReceived = 0

                '    MessageBox.Show("No rows found.")
            End If

            reader.Close()

            Return DataValue

        End Using

    End Function

    Function ReadIntegerData(ByVal queryString As String, ByVal connectionString As String) As Integer

        Using connection As New SqlConnection(connectionString)

            Dim command As New SqlCommand(queryString, connection)
            Dim DataValue As Integer

            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                reader.Read()

                'Do While reader.Read()
                '    Console.WriteLine(reader.GetInt32(0) _
                '      & vbTab & reader.GetString(1))
                'Loop

                If reader.IsDBNull(0) Then
                    DataValue = 0
                Else
                    DataValue = reader.GetInt64(0)
                End If

                'Else
                '    PreviousReceived = 0

                '    MessageBox.Show("No rows found.")
            End If

            reader.Close()

            Return DataValue

        End Using

    End Function

    Function ReadBooleanData(ByVal queryString As String, ByVal connectionString As String) As Boolean
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(queryString, connection)
            Dim DataValue As Boolean
            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                reader.Read()

                'Do While reader.Read()
                '    Console.WriteLine(reader.GetInt32(0) _
                '      & vbTab & reader.GetString(1))
                'Loop

                If reader.IsDBNull(0) Then
                    DataValue = 0

                Else
                    DataValue = reader.GetBoolean(0)
                End If



                'Else
                '    PreviousReceived = 0

                '    MessageBox.Show("No rows found.")
            End If

            reader.Close()

            Return DataValue

        End Using

    End Function

    Public Sub ShowMaster(ByVal frm As Form)

        frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        frm.MinimizeBox = False
        frm.MaximizeBox = False
        frm.StartPosition = FormStartPosition.CenterParent
        frm.ShowDialog()

    End Sub

    Function ReadIntData(ByVal queryString As String, ByVal connectionString As String) As Integer
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(queryString, connection)
            Dim DataValue As Integer
            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                reader.Read()

                'Do While reader.Read()
                '    Console.WriteLine(reader.GetInt32(0) _
                '      & vbTab & reader.GetString(1))
                'Loop

                If reader.IsDBNull(0) Then
                    DataValue = 0

                Else
                    DataValue = reader.GetInt32(0)
                End If



                'Else
                '    PreviousReceived = 0

                '    MessageBox.Show("No rows found.")
            End If

            reader.Close()

            Return DataValue

        End Using

    End Function
    Function ReadTinyIntData(ByVal queryString As String, ByVal connectionString As String) As Integer
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(queryString, connection)
            Dim DataValue As Integer
            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                reader.Read()

                'Do While reader.Read()
                '    Console.WriteLine(reader.GetInt32(0) _
                '      & vbTab & reader.GetString(1))
                'Loop

                If reader.IsDBNull(0) Then
                    DataValue = 0

                Else
                    DataValue = reader.GetInt16(0)
                End If



                'Else
                '    PreviousReceived = 0

                '    MessageBox.Show("No rows found.")
            End If

            reader.Close()

            Return DataValue

        End Using

    End Function

    Function ReadDateData(ByVal queryString As String, ByVal connectionString As String) As Date
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(queryString, connection)
            Dim DataValue As Date
            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                reader.Read()

                'Do While reader.Read()
                '    Console.WriteLine(reader.GetInt32(0) _
                '      & vbTab & reader.GetString(1))
                'Loop

                If reader.IsDBNull(0) Then
                    DataValue = Nothing

                Else
                    DataValue = reader.GetDateTime(0)
                End If



                'Else
                '    PreviousReceived = 0

                '    MessageBox.Show("No rows found.")
            End If

            reader.Close()

            Return DataValue

        End Using

    End Function
    Function ReadStringData(ByVal queryString As String, ByVal connectionString As String) As String
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(queryString, connection)
            Dim DataValue As String = ""
            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                reader.Read()

                'Do While reader.Read()
                '    Console.WriteLine(reader.GetInt32(0) _
                '      & vbTab & reader.GetString(1))
                'Loop

                If reader.IsDBNull(0) Then
                    DataValue = ""
                Else
                    DataValue = reader.GetString(0)
                End If



                'Else
                '    PreviousReceived = 0

                '    MessageBox.Show("No rows found.")
            End If

            reader.Close()

            Return DataValue

        End Using

    End Function




    Public Function roundDown(ByVal dblValue As Double) As Double
        On Error GoTo PROC_ERR
        Dim myDec As Long

        myDec = InStr(1, CStr(dblValue), ".", vbTextCompare)
        If myDec > 0 Then
            roundDown = CDbl(Left(CStr(dblValue), myDec))
        Else
            roundDown = dblValue
        End If

PROC_EXIT:
        Exit Function
PROC_ERR:
        MsgBox(Err.Description, vbInformation, "Round Down")
    End Function

    Public Function roundUp(ByVal dblValue As Double) As Double

        On Error GoTo PROC_ERR
        Dim myDec As Long

        myDec = InStr(1, CStr(dblValue), ".", vbTextCompare)
        If myDec > 0 Then
            roundUp = CDbl(Left(CStr(dblValue), myDec)) + 1
        Else
            roundUp = dblValue
        End If

PROC_EXIT:
        Exit Function
PROC_ERR:
        MsgBox(Err.Description, vbInformation, "Round Up")

    End Function


    Public Function RoundToValue(ByVal nValue As Decimal, ByVal nCeiling As Double, Optional ByVal RoundUp As Boolean = True) As Double

        Dim tmp As Integer
        Dim tmpVal
        If Not IsNumeric(nValue) Then Exit Function
        nValue = CDbl(nValue)

        'Round up to a whole integer -
        'Any decimal value will force a round to the next integer.
        'i.e. 0.01 = 1 or 0.8 = 1

        tmpVal = ((nValue / nCeiling) + (-0.5 + (RoundUp And 1)))
        tmp = Fix(tmpVal)
        tmpVal = CInt((tmpVal - tmp) * 10 ^ 0)
        nValue = tmp + tmpVal / 10 ^ 0

        'Multiply by ceiling value to set RoundtoValue
        RoundToValue = nValue * nCeiling

    End Function
    Public Sub ShowReport(ByVal MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal filterstring As String, ByVal CrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer)

        '' Set Parmeter Value
        On Error Resume Next
        Dim CompanyName As String = ReadStringData("Select CompanyName From Company Where CompanyId=1", cnn)
        Dim CompanyAddress As String = ReadStringData("Select Address1+ ','+ Address2 +','+City From CompanyAddress Where CompanyId = 1 And CorporateOffice=0", cnn)
        Dim UserName As String = ReadStringData("Select User_Name From [User] Where User_Id = " & UserId, cnn)
        Dim rptFooter As String = "This report has been generated by " & SName & ", Powered by : Norban Group of Companies."

        MyReport.SetParameterValue("CompanyName", CompanyName)
        MyReport.SetParameterValue("CompanyAddress", CompanyAddress)
        MyReport.SetParameterValue("IPAddress", GetIPAddress)
        MyReport.SetParameterValue("UserName", UserName)
        MyReport.SetParameterValue("Footer", rptFooter)
        MyReport.SetParameterValue("Filter", filterstring)


        ''Reading Data from Connection String
        Dim builder As New SqlConnectionStringBuilder(cnn)
        Dim user As String = builder.UserID
        Dim pass As String = builder.Password
        Dim server As String = builder.DataSource
        Dim db As String = builder.InitialCatalog


        Dim myLogonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Dim myTable As Table

        ''For MasterReport

        For Each myTable In MyReport.Database.Tables
            myLogonInfo = myTable.LogOnInfo
            myLogonInfo.ConnectionInfo.ServerName = server
            myLogonInfo.ConnectionInfo.DatabaseName = db
            myLogonInfo.ConnectionInfo.UserID = user
            myLogonInfo.ConnectionInfo.Password = pass
            myTable.ApplyLogOnInfo(myLogonInfo)
        Next myTable

        ''For Subreport

        If MyReport.Subreports.Count > 0 Then
            For Each rpt As ReportDocument In MyReport.Subreports
                For Each myTable In rpt.Database.Tables
                    myLogonInfo = myTable.LogOnInfo
                    myLogonInfo.ConnectionInfo.ServerName = server
                    myLogonInfo.ConnectionInfo.DatabaseName = db
                    myLogonInfo.ConnectionInfo.UserID = user
                    myLogonInfo.ConnectionInfo.Password = pass
                    myTable.ApplyLogOnInfo(myLogonInfo)
                Next myTable
            Next
        End If

        Dim formats As Integer
        formats = (CrystalDecisions.Shared.ViewerExportFormats.PdfFormat Or CrystalDecisions.Shared.ViewerExportFormats.XLSXFormat)

        CrystalReportViewer.AllowedExportFormats = formats
        CrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None


        CrystalReportViewer.ReportSource = MyReport
        CrystalReportViewer.SelectionFormula = filterstring
        'CrystalReportViewer.ShowRefreshButton = False
        CrystalReportViewer.Refresh()


    End Sub
    Public Sub ShowReportExport(ByVal MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal filterstring As String, ByVal FName As String)

        '' Set Parmeter Value
        'Dim CompanyName As String = ReadStringData("Select Top 1 CompanyName From Company", cnn)
        'MyReport.SetParameterValue("CompanyName", CompanyName.ToString())

        ''Reading Data from Connection String
        Dim builder As New SqlConnectionStringBuilder(cnn)
        Dim user As String = builder.UserID
        Dim pass As String = builder.Password
        Dim server As String = builder.DataSource
        Dim db As String = builder.InitialCatalog

        MyReport.RecordSelectionFormula = filterstring

        Dim myLogonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Dim myTable As Table

        ''For MasterReport

        For Each myTable In MyReport.Database.Tables
            myLogonInfo = myTable.LogOnInfo
            myLogonInfo.ConnectionInfo.ServerName = server
            myLogonInfo.ConnectionInfo.DatabaseName = db
            myLogonInfo.ConnectionInfo.UserID = user
            myLogonInfo.ConnectionInfo.Password = pass
            myTable.ApplyLogOnInfo(myLogonInfo)
        Next myTable

        ''For Subreport

        If MyReport.Subreports.Count > 0 Then
            For Each rpt As ReportDocument In MyReport.Subreports
                For Each myTable In rpt.Database.Tables
                    myLogonInfo = myTable.LogOnInfo
                    myLogonInfo.ConnectionInfo.ServerName = server
                    myLogonInfo.ConnectionInfo.DatabaseName = db
                    myLogonInfo.ConnectionInfo.UserID = user
                    myLogonInfo.ConnectionInfo.Password = pass
                    myTable.ApplyLogOnInfo(myLogonInfo)
                Next myTable
            Next
        End If




        'CrystalReportViewer.ReportSource = MyReport
        'CrystalReportViewer.SelectionFormula = filterstring
        ''CrystalReportViewer.ShowRefreshButton = False
        'CrystalReportViewer.Refresh()

        'Exporting ..


        Try
            Dim CrExportOptions As ExportOptions
            Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
            Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
            CrDiskFileDestinationOptions.DiskFileName = "E:\" & FName & ".pdf"
            CrExportOptions = MyReport.ExportOptions

            With CrExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = CrDiskFileDestinationOptions
                .FormatOptions = CrFormatTypeOptions
            End With

            MyReport.Export()


            'Attaching Mail

            'Dim prss As String = "mailto:mahmud@skynetbangladesh.com?subject=an email&body=see attachment&attachment=" & "E:\crystalExport.pdf"
            'System.Diagnostics.Process.Start(prss)



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub
    Private Sub OpenSubreport(ByVal reportObjectName As String)
        'Dim subreportName As String
        'Dim subreportObject As SubreportObject
        'Dim subreport As New ReportDocument()

        '' Get the ReportObject by name and cast it as a 
        '' SubreportObject.
        'If TypeOf (Report.ReportDefinition.ReportObjects. _
        'Item(reportObjectName)) Is SubreportObject Then
        '    subreportObject = Report.ReportDefinition.ReportObjects. _
        '    Item(reportObjectName)
        '    ' Get the subreport name.
        '    subreportName = subreportObject.SubreportName
        '    ' Open the subreport as a ReportDocument.
        '    subreport = Report.OpenSubreport(subreportName)
        '    ' Preview the subreport.
        '    crystalReportViewer1.ReportSource = subreport
        'End If
    End Sub




    '============================================
    '============================================

    'make a call to your application or file by giving Process.Start
    'the full path to your file including name and extension.

    '    'will open a Word document called myfile.doc with MS Word
    'Process.Start("c:\myTestFolder\myfile.doc")

    '    'will run an executable file called myfile.exe
    'Process.Start("c:\myTestFolder\myfile.exe")

    '    'will open a blank notepad
    'Process.Start("Notepad.exe")

    '    'I'm sure you get the idea

    Public Sub SendSMTP(ByVal strFromAddress As String, ByVal strFromName As String, ByVal strToAddress As String, ByVal strToName As String, ByVal strReplyToAddrr As String, ByVal strReplyToName As String, ByVal strSubject As String, ByVal strBody As String, ByVal strCC As String, ByVal strAttachments As String)

        Dim insMail As New MailMessage(New MailAddress(strFromAddress, strFromName), New MailAddress(strToAddress, strToName))

        With insMail
            .Subject = strSubject
            .Body = strBody
            '.ReplyTo = New MailAddress(strReplyToAddrr, strReplyToName)
            .IsBodyHtml = False
            If Not strAttachments.Equals(String.Empty) Then
                Dim strFile As String
                Dim strAttach() As String = strAttachments.Split(";")
                For Each strFile In strAttach
                    .Attachments.Add(New Attachment(strFile.Trim()))
                Next
            End If
        End With

        'Mail Configuration
        Dim smtp As New System.Net.Mail.SmtpClient
        smtp.UseDefaultCredentials = True
        smtp.Credentials = New System.Net.NetworkCredential("sazzad@norbangroup.com", "norban123")
        smtp.Host = "mail.norbangroup.com"
        smtp.Port = 25
        smtp.Send(insMail)

    End Sub

    Public Sub SendUserMail(ByVal BodyMessage As String, ByVal SubjectMessage As String, ByVal MId As Integer)

        Dim MailBody As String = String.Empty
        Dim SMSBody As String = String.Empty
        Dim culture As CultureInfo = New CultureInfo("en-IN")

        Dim i As Integer = 0
        Dim md As Integer = 1
        Dim email As String = String.Empty
        Dim mobile As String = String.Empty

        Dim MailTo As String = ReadStringData("Select EmailAddress from [User] Where Active=1 And User_Id=" & MId, cnn)

        Dim fromMail As String = My.Settings.FromMail
        Dim from As MailAddress = New MailAddress(fromMail)
        Dim smtp As SmtpClient = New SmtpClient()
        smtp.Host = My.Settings.Host
        smtp.Port = My.Settings.Port
        smtp.Credentials = New NetworkCredential(fromMail, My.Settings.MailPass)
        smtp.EnableSsl = My.Settings.SSL


        Dim [to] As MailAddress = New MailAddress(MailTo)
        Dim mail As MailMessage = New MailMessage(from, [to])

        mail.Subject = SubjectMessage
        mail.Body = BodyMessage

        ServicePointManager.ServerCertificateValidationCallback = Function(ByVal s As Object, ByVal certificate As X509Certificate, ByVal chain As X509Chain, ByVal sslPolicyErrors As SslPolicyErrors) True
        mail.IsBodyHtml = True
        smtp.Send(mail)


    End Sub

    '================
    'following code resizes picture to fit

    '    Dim bm As New Bitmap(PictureBox1.Image)
    '    Dim x As Int32 'variable for new width size
    '    Dim y As Int32 'variable for new height size

    '    Dim width As Integer = Val(x) 'image width. 

    '    Dim height As Integer = Val(y) 'image height

    '    Dim thumb As New Bitmap(width, height)

    '    Dim g As Graphics = Graphics.FromImage(thumb)

    '        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic

    '        g.DrawImage(bm, New Rectangle(0, 0, width, height), New Rectangle(0, 0, bm.Width, _
    'bm.Height), GraphicsUnit.Pixel)

    '        g.Dispose()


    '    'image path. better to make this dynamic. I am hardcoding a path just for example sake
    '        thumb.Save("C:\newimage.bmp", _
    'System.Drawing.Imaging.ImageFormat.Bmp) 'can use any image format 

    '        bm.Dispose()

    '        thumb.Dispose()

    '        Me.Close()  'exit app
    '================

    Public Function RemoveWhitespace(ByVal in_string As String) As String
        Dim reg As New Regex("\s*")
        Dim out_string As String = reg.Replace(in_string, "")
        Return out_string
    End Function

    Function DecToTime(ByVal Time As Decimal) As String

        'Use Decimal Hour.

        Dim MyTime As String = ""
        Dim minutes As Decimal = 60 * Time

        Dim hours As Integer = 0

        While (minutes - 60) >= 0

            minutes -= 60

            hours += 1

        End While

        minutes = Math.Round(minutes)

        MyTime = hours.ToString() + ":" + Format(minutes, "00").ToString

        Return MyTime

    End Function

    Public Sub LoadAutoCompleteList(ByVal sqlstring As String, ByVal MyControl As TextBox)

        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand(sqlstring, connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim list As New AutoCompleteStringCollection

        While reader.Read
            If reader.IsDBNull(0) = False Then
                list.Add(reader.GetString(0))
            End If
        End While
        reader.Close()
        MyControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        MyControl.AutoCompleteSource = AutoCompleteSource.CustomSource
        MyControl.AutoCompleteCustomSource = list
        connection.Close()


    End Sub

    Private Function getMaxDataGridViewValue(ByVal columnNumber As Integer, ByVal aDataGridView As DataGridView) As String


        Dim maxValue As Double = 0

        Dim count As Integer = 0

        count = aDataGridView.RowCount

        For row = 1 To count

            If aDataGridView.Item(columnNumber, row).Value > maxValue Then

                maxValue = aDataGridView(columnNumber, row).Value

            End If

        Next

        Return maxValue.ToString


    End Function


    Public Sub SetUserRightsByLinkLabel(ByVal mnuname As String, ByVal usr As Integer, ByVal nbtn As LinkLabel, ByVal ebtn As LinkLabel, ByVal dbtn As LinkLabel)

        Dim CANEDIT As Boolean
        Dim CANDELETE As Boolean

        Dim MENUID As Integer = ReadIntegerData("Select Distinct Menu_Id From [Menu] Where Menu_Name='" & mnuname & "'", cnn)
        CANEDIT = ReadBooleanData("Select CAN_EDIT From UserRights Where User_Id=" & UserId & " and Menu_Id=" & MENUID, cnn)
        CANDELETE = ReadBooleanData("Select CAN_DELETE From UserRights Where User_Id=" & UserId & " and Menu_Id=" & MENUID, cnn)

        If CANEDIT = False Then
            nbtn.Enabled = False
            ebtn.Enabled = False
            dbtn.Enabled = False
        End If

        If CANDELETE = False Then
            dbtn.Enabled = False
        Else
            dbtn.Enabled = True
        End If

    End Sub

    Public Sub ShowReportNew(ByVal ReportName As String, ByVal filterstring As String, ByVal CrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer)



        Dim myLogonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Dim myTable As Table
        Dim MyReport As New ReportDocument


        Try
            MyReport.Load(Application.StartupPath & "\Report\" & ReportName & ".rpt", OpenReportMethod.OpenReportByTempCopy)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try


        Dim builder As New SqlConnectionStringBuilder(cnn)
        Dim server As String = builder.DataSource
        Dim user As String = builder.UserID
        Dim pass As String = builder.Password
        Dim db As String = builder.InitialCatalog


        For Each myTable In MyReport.Database.Tables
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




        CrystalReportViewer.ReportSource = MyReport
        CrystalReportViewer.SelectionFormula = filterstring '"{ItemList.ItemId}=" & ItemListComboBox.SelectedValue
        CrystalReportViewer.Refresh()


        'Dim cr As New ReportDocument
        'cr.Load(strReportPath)
        'cr.SetDataSource(DS.Tables("Customers"))
        'cr.SetParameterValue("StartDate", strMyParmValue)
        'CrystalReportViewer.ReportSource = cr

    End Sub

    Function IsAlreadyUsed(ByVal ColName As String, ByVal ColValue As Integer, ByVal extblname As String) As Boolean 'excluded table name

        Dim cnt As Integer = 0 'count
        Dim bln As Boolean = False 'boolean

        Using connection As New SqlConnection(cnn)

            Dim querystring As String = "SELECT name FROM sysobjects WHERE id IN ( SELECT id FROM syscolumns WHERE name = '" & ColName & "' ) And xtype='U'"

            Dim command As New SqlCommand(querystring, connection)
            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()


            While reader.Read()

                If reader(0).ToString <> extblname Then

                    Dim i As Integer

                    If reader(0).ToString = "Order" Then
                        i = ReadIntData("Select Count(*) As cnt From [" & reader(0).ToString & "] Where " & ColName & " = " & ColValue, cnn)
                    ElseIf reader(0).ToString = "User" Then
                        i = ReadIntData("Select Count(*) As cnt From [" & reader(0).ToString & "] Where " & ColName & " = " & ColValue, cnn)
                    Else
                        i = ReadIntData("Select Count(*) As cnt From " & reader(0).ToString & " Where " & ColName & " = " & ColValue, cnn)
                    End If

                    cnt = cnt + i

                End If

            End While

            reader.Close()
            connection.Close()

        End Using

        If cnt > 0 Then
            bln = True
        End If

        Return bln

    End Function

    'Check User Rights Function

    Public Structure GetUserRights

        Public CanView As Boolean
        Public CanEdit As Boolean
        Public CanDelete As Boolean

    End Structure

    Public Function CheckUserRights(ByVal MenuName As String) As GetUserRights

        Dim GURights As GetUserRights

        Dim connection As New SqlConnection(cnn)
        connection.Open()

        Dim sqlstring As String = "Select Can_View,Can_Edit,Can_Delete From UserRights Where User_Id=" & UserId & "And Menu_Id=(Select Top 1 Menu_Id From Menu Where Menu_Name='" & MenuName.ToString() & "')"
        Dim cmd As SqlCommand = New SqlCommand(sqlstring, connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()


        reader.Read()

        If reader.HasRows Then
            GURights.CanView = reader("Can_View")
            GURights.CanEdit = reader("Can_Edit")
            GURights.CanDelete = reader("Can_Delete")
        Else
            GURights.CanView = False
            GURights.CanEdit = False
            GURights.CanDelete = False

        End If



        reader.Close()
        connection.Close()

        Return GURights

    End Function


    Public Sub ShowFormWithUserRights(ByVal frmName As System.Windows.Forms.Form, ByVal MenuName As String)

        If CheckUserRights(MenuName).CanView = True Then
            SplashScreenManager.ShowForm(frmName, GetType(WaitForm), True, True, False)
            With frmName

                .MdiParent = frmMain
                .WindowState = FormWindowState.Maximized
                .Show()

            End With
            SplashScreenManager.CloseForm(False)
        Else

            MessageBox.Show("You have no permission in : " & vbNewLine & "[" & MenuName & "]", "Permission Denied..", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub


    Public Sub ShowMasterWithUserRights(ByVal frmName As System.Windows.Forms.Form, ByVal MenuName As String)

        If CheckUserRights(MenuName).CanView = True Then
            SplashScreenManager.ShowForm(frmName, GetType(WaitForm), True, True, False)
            With frmName

                '.MdiParent = frmMain
                '.WindowState = FormWindowState.Normal
                .StartPosition = FormStartPosition.CenterParent
                .ShowDialog()

            End With
            SplashScreenManager.CloseForm(False)
        Else

            MessageBox.Show("You have no permission in : " & vbNewLine & "[" & MenuName & "]", "Permission Denied..", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Public Sub ShowForm(ByVal frmName As System.Windows.Forms.Form)
        SplashScreenManager.ShowForm(frmName, GetType(WaitForm), True, True, False)
        With frmName
            .MdiParent = frmMain
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
        SplashScreenManager.CloseForm(False)
    End Sub
    Public Function GetIPAddress()

        Dim strHostName As String
        Dim strIPAddress As String
        Dim FullPCName As String

        strHostName = System.Net.Dns.GetHostName()
        strIPAddress = System.Net.Dns.GetHostEntry(strHostName).AddressList(0).ToString()
        FullPCName = strHostName + " / " + strIPAddress

        Return FullPCName
    End Function
    Public Function PrintCount(ByVal ChallanNo As String, ByVal DemoReport As Boolean) As Integer

        If DemoReport = False Then
            Using connection As New SqlConnection(cnn)
                connection.Open()
                Using sqlWrite = New SqlCommand("Insert into PrintCount(ChallanNo,PrintDate,UserId,IPAddress) Values ('" & ChallanNo & "',@PrintDate," & UserId & ",'" & GetIPAddress() & "')", connection)
                    sqlWrite.Parameters.Add("@PrintDate", SqlDbType.DateTime).Value = Now()
                    sqlWrite.ExecuteNonQuery()
                End Using
            End Using

        End If

        Dim PrintCountNo As Int32 = ReadIntData("Select Count(ChallanNo) From PrintCount Where ChallanNo = '" & ChallanNo & "'", cnn)
        Return PrintCountNo

    End Function
    Public Sub PrintChallan(ByVal MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal filterstring As String, ByVal CrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer, ByVal PType As String, ByVal PrintCount As Int32, ByVal PD As PrintDialog)

        'Dim MyReport As New rpt 'HourlyPrintProduction_Graph
        ''Reading Data from Connection String
        On Error Resume Next
        Dim CompanyName As String = ReadStringData("Select CompanyName From Company Where CompanyId = 1", cnn)
        Dim CompanyAddress As String = ReadStringData("Select CompanyAddress From Company Where CompanyId = 1", cnn)
        Dim UserName As String = ReadStringData("Select User_Name From [User] Where User_Id = " & UserId, cnn)
        Dim rptFooter As String = "This report has been generated by " & SName & ", Powered by : " & PoweredBy.ToString

        MyReport.SetParameterValue("CompanyName", CompanyName)
        MyReport.SetParameterValue("CompanyAddress", CompanyAddress)
        MyReport.SetParameterValue("IPAddress", GetIPAddress)
        MyReport.SetParameterValue("UserName", UserName)
        MyReport.SetParameterValue("PType", PType)
        MyReport.SetParameterValue("PrintCount", PrintCount)
        MyReport.SetParameterValue("Footer", "This report has been generated by " & SName & " , " & PoweredBy.ToString())

        Dim builder As New SqlConnectionStringBuilder(cnn)
        Dim user As String = builder.UserID
        Dim pass As String = builder.Password
        Dim server As String = builder.DataSource
        Dim db As String = builder.InitialCatalog


        Dim myLogonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Dim myTable As Table

        For Each myTable In MyReport.Database.Tables
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

        'CrystalReportViewer.ReportSource = MyReport
        MyReport.RecordSelectionFormula = filterstring

        PD.PrinterSettings.Copies = 1
        PD.PrintToFile = False


        'If PD.ShowDialog = DialogResult.OK Then
        MyReport.PrintOptions.PrinterName = PD.PrinterSettings.PrinterName
        MyReport.PrintToPrinter(PD.PrinterSettings.Copies, PD.PrinterSettings.Collate, PD.PrinterSettings.FromPage, PD.PrinterSettings.ToPage)
        'End If


    End Sub
    Public Sub SendProductiondMail()
        Dim cnn As String = ConfigurationManager.ConnectionStrings("KSoftConnectionString").ConnectionString
        Dim MailBody As String = String.Empty
        Dim SMSBody As String = String.Empty
        Dim culture As CultureInfo = New CultureInfo("en-IN")
        Dim list_emails As ArrayList = New ArrayList()
        Dim list_mobile As ArrayList = New ArrayList()
        Dim i As Integer = 0
        Dim md As Integer = 1
        Dim email As String = String.Empty
        Dim mobile As String = String.Empty
        Using conn1 As SqlConnection = New SqlConnection()
            conn1.ConnectionString = cnn
            conn1.Open()
            Dim cmd_Email As SqlCommand = New SqlCommand("Select MailAddress,MobileNo from MailAddress Where IsActive=1", conn1)
            Dim read_Email As SqlDataReader = cmd_Email.ExecuteReader()
            While read_Email.Read()
                email = read_Email.GetValue(0).ToString()
                mobile = read_Email.GetValue(1).ToString()
                list_emails.Add(email)
                list_mobile.Add(mobile)
                i = i + 1 - 1
            End While

            read_Email.Close()
        End Using

        Using conn As SqlConnection = New SqlConnection()
            conn.ConnectionString = cnn
            conn.Open()
            Dim command As SqlCommand = New SqlCommand("Execute LastDayProductionStatus @0", conn)
            Dim datetime As DateTime = DateTime.Now
            command.Parameters.Add(New SqlParameter("0", DateTime.Today.AddDays(-md)))
            Using reader As SqlDataReader = command.ExecuteReader()
                Dim HeaderString As String = "<!DOCTYPE html>" & "<html>" & "<head>" & "<style>" & "table, th, td {" & "border: 1px solid black;" & "border-collapse:collapse;" & "}" & "th, td {" & "padding: 5px;" & "text-align: left;" & "}" & "</style>" & "</head>" & "<body>"
                MailBody = MailBody + HeaderString
                SMSBody = "Last NCL Production:" & "\0x0A"
                MailBody = MailBody & "<table Style=" & "border: 1px solid blackborder - collapse: collapse;" & ">" & vbLf
                MailBody = MailBody & "<tr><td colspan="" 4 "" style=""background-color:Gray;color:White;"" > <b>NCL Production Date on  " + DateTime.Today.AddDays(-md).ToShortDateString() & "</b></td></tr>" & vbLf
                MailBody = MailBody & "<tr style=""background-color:Gray;color:White;text-align: center;"" ><td> <b>Production Type</b></td><td> <b>Target</b></td><td style=""text-align:center;""> <b>Actual</b></td><td style=""text-align:center;""><b>%</b></td></tr>" & vbLf
                While reader.Read()
                    Dim ap As Decimal = 0
                    If reader.GetDecimal(2) > 0 AndAlso reader.GetDecimal(3) > 0 AndAlso Not reader.GetDecimal(3).Equals(Nothing) Then
                        ap = reader.GetDecimal(3) / reader.GetDecimal(2) * 100
                    End If

                    If Convert.ToInt32(ap) = 0 Then
                        MailBody = MailBody & "<tr style=""background-color:LightGrey;""><td> " + String.Format("{0,-20}", reader(4).ToString()) & "</td><td style=""text-align:right;""><b>" + String.Format(culture, "{0:##,##,##,###.####}", reader(2)) & "</b></td><td style=""text-align:right;background-color:AliceBlue;""><b>" + String.Format(culture, "{0:##,##,##,###.####}", reader(3)) & "</b></td><td></td></tr>" & vbLf
                    Else
                        MailBody = MailBody & "<tr style=""background-color:LightGrey;""><td> " + String.Format("{0,-20}", reader(4).ToString()) & "</td><td style=""text-align:right;""><b>" + String.Format(culture, "{0:##,##,##,###.####}", reader(2)) & "</b></td><td style=""text-align:right;background-color:AliceBlue;""><b>" + String.Format(culture, "{0:##,##,##,###.####}", reader(3)) & "</b></td><td style=""text-align:right;""><b>" + Convert.ToInt32(ap).ToString() & "%</b></td></tr>" & vbLf
                    End If

                    SMSBody = SMSBody + String.Format("{0,-20}", reader(4).ToString()) & ":" + String.Format(culture, "{0:##,##,##,###.####}", reader(3)) & "\0x0A"
                End While

                MailBody = MailBody & "<tr><td colspan="" 4 "" style=""background-color:Gray;color:White;""><b>This is genereted by " & SCName & ".</b></td></tr>" & vbLf
                MailBody = MailBody & "</table></body>" & vbLf
            End Using
        End Using

        Dim from As MailAddress = New MailAddress("nerpsolutions@norbangroup.com")
        Dim smtp As SmtpClient = New SmtpClient()
        smtp.Host = "mail.norbangroup.com"
        smtp.Port = 25
        smtp.Credentials = New NetworkCredential("nerpsolutions@norbangroup.com", "norban123")
        smtp.EnableSsl = True
        For Each email_to As String In list_emails
            Console.WriteLine("Mail To")
            Dim [to] As MailAddress = New MailAddress(email_to)
            Console.WriteLine([to])
            Dim mail As MailMessage = New MailMessage(from, [to])
            mail.Subject = "NCL Production Status on " & DateTime.Today.AddDays(-1).ToShortDateString()
            mail.Body = MailBody
            Console.WriteLine("Sending email...")
            ServicePointManager.ServerCertificateValidationCallback = Function(ByVal s As Object, ByVal certificate As X509Certificate, ByVal chain As X509Chain, ByVal sslPolicyErrors As SslPolicyErrors) True
            mail.IsBodyHtml = True
            smtp.Send(mail)
            Console.WriteLine("Send Succesfully")
        Next

        'For Each mobile_no As String In list_mobile
        '    sendsms(SMSBody, mobile_no)
        'Next
    End Sub

    Public Sub CRUDAppointment(ByVal Type As Integer, ByVal StartDate As Date, ByVal EndDate As DateTime, ByVal AllDay As Boolean, ByVal Subject As String, ByVal Location As String, ByVal Description As String, ByVal Label As Integer, ByVal LineId As Integer, ByVal OrderId As Integer, ByVal PlanningQuantity As Integer, ByVal Target As Integer, ByVal WH As Integer, ByVal RD As Integer, ByVal RH As Integer, ByVal ExDate As DateTime, ByVal ExcessSewingPercentage As Integer, ByVal SMV As Decimal, ByVal MC As Integer, ByVal SID As Integer, ByVal LCSD As Integer, ByVal LCA As Integer, ByVal LC As String)

        ' GetConnection is a method that creates and return the '
        ' SqlConnection used here according to your connection string'
        Using Connection As New SqlConnection(cnn)

            Connection.Open()

            ' Create the command with the sproc name and add the parameter required'
            Dim cmd As SqlCommand = New SqlCommand("CRUDAppointment", Connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Type", Type)
            cmd.Parameters.AddWithValue("@StartDate", StartDate)
            cmd.Parameters.AddWithValue("@EndDate", EndDate)
            cmd.Parameters.AddWithValue("@AllDay", AllDay)
            cmd.Parameters.AddWithValue("@Subject", Subject)
            cmd.Parameters.AddWithValue("@Location", Location)
            cmd.Parameters.AddWithValue("@Description", Description)
            cmd.Parameters.AddWithValue("@Label", Label)
            cmd.Parameters.AddWithValue("@LineId", LineId)
            cmd.Parameters.AddWithValue("@OrderId", OrderId)
            cmd.Parameters.AddWithValue("@PlanningQuantity", PlanningQuantity)
            cmd.Parameters.AddWithValue("@Target", Target)
            cmd.Parameters.AddWithValue("@WH", WH)
            cmd.Parameters.AddWithValue("@RD", RD)
            cmd.Parameters.AddWithValue("@RH", RH)
            cmd.Parameters.AddWithValue("@ExDate", ExDate)
            cmd.Parameters.AddWithValue("@ExcessSewingPercentage", ExcessSewingPercentage)
            cmd.Parameters.AddWithValue("@SMV", SMV)
            cmd.Parameters.AddWithValue("@MC", MC)
            cmd.Parameters.AddWithValue("@StyleId", SID)
            cmd.Parameters.AddWithValue("@LCSD", LCSD)
            cmd.Parameters.AddWithValue("@LCA", LCA)
            cmd.Parameters.AddWithValue("@LC", LC)
            cmd.Parameters.AddWithValue("@StatementType", "Insert")
            cmd.ExecuteNonQuery()



        End Using

    End Sub
    Public Sub CRUDAppointmentDetails(ByVal AptId As Integer, ByVal DaySerial As Integer, ByVal PlanningDate As DateTime, ByVal Eff As Integer, ByVal PlanningQuantity As Integer, ByVal WHD As Integer)

        ' GetConnection is a method that creates and return the '
        ' SqlConnection used here according to your connection string'

        Using Connection As New SqlConnection(cnn)

            Connection.Open()

            ' Create the command with the sproc name and add the parameter required'
            Dim cmd As SqlCommand = New SqlCommand("CRUDAppointmentDetails", Connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@AppointmentId", AptId)
            cmd.Parameters.AddWithValue("@Remarks", "-")
            cmd.Parameters.AddWithValue("@DaySerial", DaySerial)
            cmd.Parameters.AddWithValue("@PlanningDate", PlanningDate)
            cmd.Parameters.AddWithValue("@Efficiency", Eff)
            cmd.Parameters.AddWithValue("@PlanningQuantity", PlanningQuantity)
            cmd.Parameters.AddWithValue("@WH", WHD)
            cmd.Parameters.AddWithValue("@StatementType", "Insert")
            cmd.ExecuteNonQuery()

        End Using

    End Sub

    Public Function AppoitmentDetailsTable() As DataTable

        ' Create new DataTable instance.
        Dim table As New DataTable
        ' Create four typed columns in the DataTable.
        table.Columns.Add("AppointmentId", GetType(Integer))
        table.Columns.Add("DaySerial", GetType(Integer))
        table.Columns.Add("PlanningDate", GetType(Date))
        table.Columns.Add("Efficiency", GetType(Integer))
        table.Columns.Add("PlanningQuantity", GetType(Integer))

        Return table

    End Function

    Public Sub HideColumn(ByVal col As DevExpress.XtraGrid.Columns.GridColumn)
        col.Visible = False
        col.OptionsColumn.ShowInCustomizationForm = False
        col.OptionsColumn.ShowInExpressionEditor = False
    End Sub
    Public Sub HideBandedColumn(ByVal col As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn)
        col.Visible = False
        col.OptionsColumn.ShowInCustomizationForm = False
        col.OptionsColumn.ShowInExpressionEditor = False
    End Sub

End Module
