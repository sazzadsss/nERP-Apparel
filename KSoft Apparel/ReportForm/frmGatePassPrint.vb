Imports System.Data.SqlClient
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmGatePassPrint
    Dim SDate As Date
    Dim SDate2 As Date
    Private _GatePassId As Integer

    Public Property GatePassId() As Integer
        Get
            Return _GatePassId
        End Get
        Set(ByVal value As Integer)
            _GatePassId = value
        End Set
    End Property
    Dim filterstring As String = ""



    Public Sub ShowReportWithCopy(ByVal MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal filterstring As String, ByVal CrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer, ByVal PrintCopy As String)

        '' Set Parmeter Value
        'Dim CompanyName As String = ReadStringData("Select Top 1 CompanyName From Company", cnn)
        MyReport.SetParameterValue("Copy", PrintCopy)

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


        CrystalReportViewer.ReportSource = MyReport
        CrystalReportViewer.SelectionFormula = filterstring
        'CrystalReportViewer.ShowRefreshButton = False
        CrystalReportViewer.Refresh()




    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        Me.GatePassId = Me.GridLookUpEdit1.EditValue
        filterstring = "{GatePass.GatePassId} = " & Me.GatePassId

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New GatePass
        MyReport.SetParameterValue("PType", "Report")
        MyReport.SetParameterValue("PrintCount", PrintCount(Me.GridLookUpEdit1.Text, True))
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub


    Private Sub frmGatePassPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SampleRequestNoLookupTableAdapter.Fill(Me.SampleRequestLookupDataSet.SampleRequestNoLookup)
        Me.GatePassLookupTableAdapter.Fill(Me.GatePassDataSet.GatePassLookup)
        Me.GridLookUpEdit1.EditValue = Me.GatePassId

        filterstring = "{GatePass.GatePassId} = " & Me.GatePassId

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New GatePass
        MyReport.SetParameterValue("PType", "Report")
        MyReport.SetParameterValue("PrintCount", PrintCount(Me.GridLookUpEdit1.Text, True))

        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub ShowByChallanDateButton_Click(sender As Object, e As EventArgs) Handles ShowByChallanDateButton.Click

        SDate = Me.FromDateTimePicker.Text
        SDate2 = Me.ToDateTimePicker.Text

        Dim filterstring As String = "{GatePass.GatepassDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New GatePass_SampleDateRange
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click

        If PrintCount(Me.GridLookUpEdit1.Text, True) > 0 Then
            Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id = " & UserId, cnn)
            If UL <> 1 Then
                MessageBox.Show("Not allowed to print a already printed Sample Gate Pass")
                Exit Sub
            Else
                GoTo Line1
            End If
        End If

Line1:
        Dim ChallanDate As Date = ReadDateData("Select GatePassDate from GatePass Where GatePassNo ='" & GridLookUpEdit1.Text & "'", cnn)


        Dim i As Integer = 0

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New GatePass
        Dim filterstring As String = "{Gatepass.GatePassId}=" & Me.GridLookUpEdit1.EditValue

        If MessageBox.Show("Are you sure you want to print this gate pass ?.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then

            Dim PrintCountNo As Integer = PrintCount(Me.GridLookUpEdit1.Text, False)

            Do While i <= 2

                If i = 0 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Receiver", PrintCountNo, PrintDialog1)

                ElseIf i = 1 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Gate", PrintCountNo, PrintDialog1)

                ElseIf i = 2 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Office", PrintCountNo, PrintDialog1)

                End If

                i = i + 1

            Loop

            MessageBox.Show("Gate Pass Print has been done.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SDate = Me.FromDateTimePicker.Text
        SDate2 = Me.ToDateTimePicker.Text

        Dim filterstring As String = "{GatePass.GatepassDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New GatePass_SampleDateRangeSummery
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SDate = Me.FromDateTimePicker.Text
        SDate2 = Me.ToDateTimePicker.Text

        Dim filterstring As String = "{GatePass.GatepassDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59) And {GatePass.GatePassType} = " & Me.GatePassTypeComboBoxEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New GatePass_SampleDateRangeSummery
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        filterstring = "{SampleRequestFinal.SampleRequestId}=" & RequestGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New GatePass_SampleDateRange
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class