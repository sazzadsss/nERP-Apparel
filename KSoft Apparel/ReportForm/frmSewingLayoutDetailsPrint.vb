Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient

Public Class frmSewingLayoutDetailsPrint
    Private _SewingLayoutId As Integer
    Public Property SewingLayoutId() As Integer
        Get
            Return _SewingLayoutId
        End Get
        Set(ByVal value As Integer)
            _SewingLayoutId = value
        End Set
    End Property
    Dim filterstring As String = ""

    Private Sub SewingLayoutDetails()

        Dim MyReport As New SewingLayoutDetails

        'MyReport.Load(Application.StartupPath & "\Report\" & ReportName & ".rpt", OpenReportMethod.OpenReportByTempCopy)

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



        CrystalReportViewer1.ReportSource = MyReport
        CrystalReportViewer1.SelectionFormula = "{SewingLayout.LayoutId} = " & Me.SewingLayoutId
        CrystalReportViewer1.Refresh()


    End Sub

    Private Sub FrmSewingLayoutDetailsPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterstring = "{SewingLayout.LayoutId} = " & Me.SewingLayoutId
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SewingLayoutDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class